using System.Net.Http.Json;
using System.Text.Json;
using foodiestopia.Interfaces;

namespace foodiestopia.Services
{
    public class EmailService : IEmailService
    {
        private static readonly HttpClient Http = new()
        {
            Timeout = TimeSpan.FromSeconds(20)
        };

        public async Task SendEmailAsync(string recipientEmail, string subject, string htmlBody)
        {
            var apiKey = Environment.GetEnvironmentVariable("BREVO_API_KEY");
            var from = Environment.GetEnvironmentVariable("SMTP_FROM");

            if (string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(from))
            {
                throw new InvalidOperationException("BREVO_API_KEY and SMTP_FROM must be set.");
            }

            using var request = new HttpRequestMessage(HttpMethod.Post, "https://api.brevo.com/v3/smtp/email");
            request.Headers.Add("api-key", apiKey);
            request.Headers.Add("accept", "application/json");
            request.Content = JsonContent.Create(new
            {
                sender = new { name = "Foodiestopia", email = from },
                to = new[] { new { email = recipientEmail } },
                subject,
                htmlContent = htmlBody
            });

            using var response = await Http.SendAsync(request);
            if (response.IsSuccessStatusCode) return;

            var body = await response.Content.ReadAsStringAsync();
            var detail = body;
            try
            {
                using var doc = JsonDocument.Parse(body);
                if (doc.RootElement.TryGetProperty("message", out var message))
                {
                    detail = message.GetString() ?? body;
                }
            }
            catch (JsonException)
            {
                // keep raw body
            }

            throw new InvalidOperationException($"Failure sending mail: {(int)response.StatusCode} {detail}");
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
