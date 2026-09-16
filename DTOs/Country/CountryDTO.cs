using foodiestopia.DTOs.Recipe;

namespace foodiestopia.DTOs.Country
{
    public record CountryDTO
    (
        Guid Id,
        string Name,
        string Slug,
        string ImagePath,
        ICollection<RecipeTldrDTO>? Recipes
    );
}