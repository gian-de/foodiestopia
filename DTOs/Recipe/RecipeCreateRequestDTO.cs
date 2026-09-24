using System.ComponentModel.DataAnnotations;
using foodiestopia.DTOs.Ingredient;
using foodiestopia.DTOs.Instruction;

namespace foodiestopia.DTOs.Recipe
{
    public class RecipeCreateRequestDTO
    {
        public string Name { get; set; } = string.Empty;
        public Guid CountryId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        [Required(ErrorMessage = "Prep time is required.")]
        [Range(0, 1440, ErrorMessage = "Prep time must be between 0 and 1440 minutes.")]
        public int PrepTimeMinutes { get; set; }
        [Required(ErrorMessage = "Cook time is required.")]
        [Range(0, 1440, ErrorMessage = "Cook time must be between 0 and 1440 minutes.")]
        public int CookTimeMinutes { get; set; }
        public List<IngredientCreateDTO> Ingredients { get; set; } = new();
        public List<InstructionCreateDTO> Instructions { get; set; } = new();
        public DateTime PublishedAt { get; set; } = DateTime.UtcNow;
    }
}