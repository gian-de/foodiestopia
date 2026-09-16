using foodiestopia.DTOs.Recipe;
using foodiestopia.Helpers;

namespace foodiestopia.Interfaces
{
    public interface IIngredientService
    {
        Task<PagedResult<RecipeSummaryDTO>> SearchRecipesByIngredientsAsync(string[] ingredients, int page, int pageSize);
    }
}