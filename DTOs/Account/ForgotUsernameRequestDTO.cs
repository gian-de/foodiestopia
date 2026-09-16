using System.ComponentModel.DataAnnotations;

namespace foodiestopia.DTOs.Account
{
    public class ForgotUsernameRequestDTO
    {
        [Required]
        [EmailAddress(ErrorMessage = "Must be a valid email address.")]
        public required string Email { get; set; }
    }
}