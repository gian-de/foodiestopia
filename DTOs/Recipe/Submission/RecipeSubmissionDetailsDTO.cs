using foodiestopia.DTOs.Country;
using foodiestopia.DTOs.Ingredient;
using foodiestopia.DTOs.Instruction;

namespace foodiestopia.DTOs.Recipe.Submission
{
    public record RecipeSubmissionDetailsDTO
    (
        Guid RecipeId,
        string Name,
        string ImageUrl,
        string VisibilityStatus,
        int HeartCount,
        double? TasteAverage,
        double? DifficultyAverage,
        int? TasteReviewCount,
        int? DifficultyReviewCount,
        DateTime PublishedAt,
        DateTime? SubmittedAt,
        DateTime? ReviewedAt,
        string? ReviewedByUsername,
        Guid CountryId,
        CountryDTO Country,
        ICollection<IngredientDTO> Ingredients,
        ICollection<InstructionDTO> Instructions
    );
}