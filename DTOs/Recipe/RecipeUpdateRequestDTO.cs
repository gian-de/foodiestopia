using System.ComponentModel.DataAnnotations;
using foodiestopia.DTOs.Ingredient;
using foodiestopia.DTOs.Instruction;

namespace foodiestopia.DTOs.Recipe
{
    public class RecipeUpdateRequestDTO
    {
        public string? Name { get; set; }
        public Guid? CountryId { get; set; }
        public string? ImageUrl { get; set; }
        [Range(0, 1440, ErrorMessage = "Prep time must be between 0 and 1440 minutes.")]
        public int? PrepTimeMinutes { get; set; }
        [Range(0, 1440, ErrorMessage = "Cook time must be between 0 and 1440 minutes.")]
        public int? CookTimeMinutes { get; set; }
        public List<IngredientUpdateDTO>? Ingredients { get; set; }
        public List<InstructionUpdateDTO>? Instructions { get; set; }
    }
}