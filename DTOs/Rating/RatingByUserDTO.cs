using foodiestopia.DTOs.Country;

namespace foodiestopia.DTOs.Rating
{
    public record RatingByUserDTO
    (
        Guid RecipeId,
        string RecipeName,
        string ImageUrl,
        double TasteRating,
        double DifficultyRating,
        DateTime ReviewedAt,
        CountryDTO Country
    );
}