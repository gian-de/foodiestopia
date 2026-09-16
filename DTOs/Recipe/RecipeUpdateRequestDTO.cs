using foodiestopia.DTOs.Ingredient;
using foodiestopia.DTOs.Instruction;

namespace foodiestopia.DTOs.Recipe
{
    public class RecipeUpdateRequestDTO
    {
        public string? Name { get; set; }
        public Guid? CountryId { get; set; }
        public string? ImageUrl { get; set; }
        public List<IngredientUpdateDTO>? Ingredients { get; set; }
        public List<InstructionUpdateDTO>? Instructions { get; set; }
    }
}