using foodiestopia.DTOs.Country;
using foodiestopia.DTOs.Ingredient;
using foodiestopia.DTOs.Instruction;
using foodiestopia.DTOs.Recipe;
using foodiestopia.DTOs.User;
using foodiestopia.Models;

namespace foodiestopia.Mappings.Recipes
{
    public static class RecipeExtension
    {
        public static RecipeSummaryDTO ToRecipeSummaryDTO(this Recipe recipeModel)
        {
            return new RecipeSummaryDTO(
                Id: recipeModel.Id,
                Name: recipeModel.Name,
                ImageUrl: recipeModel.ImageUrl,
                PrepTimeMinutes: recipeModel.PrepTimeMinutes,
                CookTimeMinutes: recipeModel.CookTimeMinutes,
                HeartCount: recipeModel.HeartedByUsers?.Count ?? 0,
                TasteAverage: recipeModel.Ratings?.Count > 0 ? Math.Round(recipeModel.Ratings.Average(r => r.TasteRating), 2) : null,
                DifficultyAverage: recipeModel.Ratings?.Count > 0 ? Math.Round(recipeModel.Ratings.Average(r => r.DifficultyRating), 2) : null,
                TasteReviewCount: recipeModel.Ratings?.Count(r => r.TasteRating > 0),
                DifficultyReviewCount: recipeModel.Ratings?.Count(r => r.DifficultyRating > 0),
                VisibilityStatus: recipeModel.VisibilityStatus,
                PublishedAt: recipeModel.PublishedAt,
                User: recipeModel.User != null
                    ? new UserTldrDTO(recipeModel.User.UserName)
                    : null,
                CountryId: recipeModel.CountryId,
                Country: new CountryDTO(
                    Id: recipeModel.Country!.Id,
                    Name: recipeModel.Country.Name,
                    Slug: recipeModel.Country.Slug,
                    ImagePath: recipeModel.Country.ImagePath,
                    Recipes: null
                ),
                Ingredients: recipeModel.Ingredients.Select(ing => new IngredientDTO(ing.Id, ing.Name, ing.Quantity, ing.Measurement)).ToList(),
                Instructions: recipeModel.Instructions.Select(inst => new InstructionDTO(inst.Id, inst.Order, inst.Text)).ToList()
            );
        }
    }
}