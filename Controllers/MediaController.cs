using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace foodiestopia.Controllers
{
    [Route("api/media")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        [Authorize]
        [HttpGet("imagekit-auth")]
        public IActionResult ImageKitAuth()
        {
            var privateKey = Environment.GetEnvironmentVariable("IMAGEKIT_PRIVATE_KEY");
            var publicKey = Environment.GetEnvironmentVariable("IMAGEKIT_PUBLIC_KEY");
            if (string.IsNullOrWhiteSpace(privateKey) || string.IsNullOrWhiteSpace(publicKey))
                return StatusCode(500, new { message = "Image upload is not configured." });

            var token = Guid.NewGuid().ToString();
            var expire = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + 10 * 60;
            using var hmac = new HMACSHA1(Encoding.UTF8.GetBytes(privateKey));
            var signature = Convert.ToHexString(hmac.ComputeHash(Encoding.UTF8.GetBytes(token + expire))).ToLowerInvariant();

            return Ok(new { token, expire, signature, publicKey });
        }
    }
}
