using System.Net;
using System.Net.Mail;
using foodiestopia.Interfaces;

namespace foodiestopia.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string recipientEmail, string subject, string htmlBody)
        {
            var host = Environment.GetEnvironmentVariable("SMTP_HOST") ?? "smtp-relay.brevo.com";
            var portText = Environment.GetEnvironmentVariable("SMTP_PORT") ?? "587";
            var user = Environment.GetEnvironmentVariable("SMTP_USER");
            var password = Environment.GetEnvironmentVariable("SMTP_PASSWORD");
            var from = Environment.GetEnvironmentVariable("SMTP_FROM") ?? user;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(from))
            {
                throw new InvalidOperationException("SMTP_USER, SMTP_PASSWORD, and SMTP_FROM must be set.");
            }

            if (!int.TryParse(portText, out var port))
            {
                throw new InvalidOperationException("SMTP_PORT must be a number.");
            }

            using var smtpClient = new SmtpClient(host, port)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(user, password)
            };

            var message = new MailMessage
            {
                From = new MailAddress(from, "Foodiestopia"),
                Subject = subject,
                Body = htmlBody,
                IsBodyHtml = true
            };

            message.To.Add(recipientEmail);
            try
            {
                await smtpClient.SendMailAsync(message);
            }
            catch (SmtpException ex)
            {
                var detail = ex.InnerException?.Message ?? ex.Message;
                throw new InvalidOperationException($"Failure sending mail: {detail}", ex);
            }
        }

        public Task SendEmailConfirmationAsync(string recipientEmail, string confirmationLink)
        {
            string subject = "FOODIESTOPIA - Confirm Your Email";
            string htmlBody = $"<h1>Please confirm your email by clicking <a href='{confirmationLink}'>here.</a></h1>";

            return SendEmailAsync(recipientEmail, subject, htmlBody);
        }

        public Task SendEmailPasswordResetAsync(string recipientEmail, string passwordResetLink)
        {
            string subject = "FOODIESTOPIA - Reset Password";
            string htmlBody = $"<h1>Reset your password by clicking <a href='{passwordResetLink}'>here.</a></h1>";

            return SendEmailAsync(recipientEmail, subject, htmlBody);
        }

        public Task SendEmailUsernameInfoAsync(string recipientEmail, string username)
        {
            string subject = "FOODIESTOPIA - Forgot Username";
            string htmlBody = $"<p>Your login username is: <strong>{username}<strong></p>";

            return SendEmailAsync(recipientEmail, subject, htmlBody);
        }
    }
}
