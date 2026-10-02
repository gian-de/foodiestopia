using System.ComponentModel.DataAnnotations;

namespace foodiestopia.DTOs.Account
{
    public class ChangeUsernameDTO
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters.")]
        public string Username { get; set; } = string.Empty;
    }
}
