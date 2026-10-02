using System.ComponentModel.DataAnnotations;

namespace foodiestopia.DTOs.Account
{
    public class ChangeEmailDTO
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Must be a valid email address.")]
        public string Email { get; set; } = string.Empty;
    }
}
