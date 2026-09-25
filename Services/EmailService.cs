using System.Net;
using System.Net.Mail;
using foodiestopia.Interfaces;

namespace foodiestopia.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string recipientEmail, string subject, string htmlBody)
        {
            var senderEmail = Environment.GetEnvironmentVariable("GMAIL_EMAIL");
            var password = Environment.GetEnvironmentVariable("GMAIL_PASSWORD");
            if (string.IsNullOrWhiteSpace(senderEmail) || string.IsNullOrWhiteSpace(password))
            {
                throw new InvalidOperationException("GMAIL_EMAIL and GMAIL_PASSWORD must be set.");
            }

            var host = "smtp.gmail.com";
            var port = 587; // TLS port number

            using var smtpClient = new SmtpClient(host, port)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail, password)
            };

            var message = new MailMessage
            {
                From = new MailAddress(senderEmail, "Foodiestopia"),
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