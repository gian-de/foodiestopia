using foodiestopia.DTOs.Country;

namespace foodiestopia.DTOs.Recipe
{
    public record RecipeTldrDTO
    (
        Guid Id,
        string UserName,
        string Name,
        Guid CountryId,
        CountryDTO Country,
        string ImageUrl,
        decimal TasteAverage,
        decimal DifficultyAverage,
        int HeartCount
    );
}