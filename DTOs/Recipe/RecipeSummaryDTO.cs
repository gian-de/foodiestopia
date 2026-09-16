using foodiestopia.DTOs.Country;
using foodiestopia.DTOs.Ingredient;
using foodiestopia.DTOs.Instruction;
using foodiestopia.DTOs.User;

namespace foodiestopia.DTOs.Recipe
{
    public record RecipeSummaryDTO
    (
        Guid Id,
        string Name,
        string ImageUrl,
        int HeartCount,
        double? TasteAverage,
        double? DifficultyAverage,
        int? TasteReviewCount,
        int? DifficultyReviewCount,
        string VisibilityStatus,
        DateTime PublishedAt,
        UserTldrDTO? User,
        Guid CountryId,
        CountryDTO Country,
        ICollection<IngredientDTO> Ingredients,
        ICollection<InstructionDTO> Instructions
    );
}