using foodiestopia.Models;
using Microsoft.EntityFrameworkCore;

namespace foodiestopia.Database.Seeds
{
    public static class CatalogSeed
    {
        private static readonly string[] Photos =
        {
            "https://images.unsplash.com/photo-1546069901-ba9599a7e63c?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1567620905732-2d1ec7ab7445?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1565299624946-b28f40a0ae38?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1540189549336-e6e99c3679fe?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1473093295043-cdd812d0e601?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1512621776951-a57141f2eefd?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1467003909585-2f8a72700288?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1504674900247-0877df9cc836?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1498837167922-ddd27525d352?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1432139555190-58524dae6a55?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1476224203421-9ac39bcb3327?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1414235077428-338989a2e8c0?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1482049016688-2d3e1b311543?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1484723091739-30a097e8f929?auto=format&fit=crop&w=1200&q=80",
            "https://images.unsplash.com/photo-1499028344343-cd173ffc68a9?auto=format&fit=crop&w=1200&q=80"
        };

        private static readonly Guid[] Countries =
        {
            CountrySeedUUID.USA, CountrySeedUUID.Mexico, CountrySeedUUID.Italy, CountrySeedUUID.Japan,
            CountrySeedUUID.France, CountrySeedUUID.India, CountrySeedUUID.Thailand, CountrySeedUUID.Greece,
            CountrySeedUUID.Vietnam, CountrySeedUUID.UK, CountrySeedUUID.Brazil, CountrySeedUUID.China,
            CountrySeedUUID.SouthKorea, CountrySeedUUID.Turkey, CountrySeedUUID.Peru, CountrySeedUUID.Poland,
            CountrySeedUUID.Egypt, CountrySeedUUID.SouthAfrica, CountrySeedUUID.Pakistan, CountrySeedUUID.Russia
        };

        // name, prep, cook, difficulty 1-5, taste 1-5
        private static readonly (string Name, int Prep, int Cook, double Difficulty, double Taste)[] Dishes =
        {
            ("Weeknight tomato soup", 10, 20, 1.5, 4.2),
            ("Garlic shrimp", 10, 8, 2.0, 4.6),
            ("Sheet pan chicken", 15, 35, 2.0, 4.1),
            ("Miso salmon", 15, 12, 2.8, 4.7),
            ("Sunday beef stew", 30, 180, 4.2, 4.5),
            ("Lemon pasta", 10, 15, 1.8, 4.3),
            ("Vegetable fried rice", 15, 10, 2.2, 4.0),
            ("Roast chicken", 20, 75, 3.2, 4.4),
            ("Black bean tacos", 15, 10, 1.6, 4.2),
            ("Mushroom risotto", 15, 35, 3.4, 4.6),
            ("Crispy fish tacos", 20, 10, 2.4, 4.3),
            ("Slow lamb curry", 25, 90, 4.0, 4.7),
            ("Caprese salad", 10, 0, 1.2, 4.1),
            ("Banana pancakes", 10, 15, 1.5, 4.4),
            ("Weeknight chili", 20, 60, 2.6, 4.3),
            ("Pesto gnocchi", 10, 12, 1.8, 4.5),
            ("Skillet pork chops", 15, 20, 2.9, 4.0),
            ("Soy ramen bowl", 20, 40, 3.1, 4.6),
            ("Greek salad", 15, 0, 1.3, 4.0),
            ("Baked ziti", 20, 40, 2.7, 4.4),
            ("Coconut vegetable curry", 15, 25, 2.5, 4.2),
            ("Steak frites", 15, 20, 3.8, 4.8),
            ("Avocado toast", 5, 5, 1.1, 3.9),
            ("Lentil soup", 15, 35, 1.7, 4.2),
            ("Chicken tikka", 20, 30, 3.0, 4.6),
            ("Herb omelette", 5, 8, 1.4, 4.0),
            ("Pulled pork", 30, 240, 4.5, 4.7),
            ("Margherita pizza", 25, 12, 3.3, 4.5),
            ("Quinoa grain bowl", 15, 20, 1.9, 3.8),
            ("Clam chowder", 20, 40, 3.2, 4.3),
            ("Teriyaki tofu", 15, 15, 2.1, 4.0),
            ("Beef street tacos", 15, 15, 2.3, 4.5),
            ("French onion soup", 20, 60, 3.6, 4.4),
            ("Poke bowl", 20, 0, 2.0, 4.6),
            ("Shepherd's pie", 30, 40, 3.1, 4.3),
            ("Thai basil chicken", 15, 12, 2.8, 4.5),
            ("Corn chowder", 15, 30, 2.2, 4.1),
            ("Eggplant parmesan", 25, 40, 3.4, 4.2),
            ("Breakfast burrito", 10, 15, 1.6, 4.3),
            ("Osso buco", 30, 150, 4.6, 4.8),
            ("Cucumber salad", 10, 0, 1.0, 3.7),
            ("Turkey meatballs", 20, 25, 2.6, 4.2),
            ("Stovetop mac and cheese", 10, 25, 1.7, 4.4),
            ("Shakshuka", 10, 25, 2.4, 4.5),
            ("Grilled cheese", 5, 8, 1.2, 4.1),
            ("Seafood paella", 30, 45, 4.3, 4.7),
            ("Caesar salad", 15, 0, 1.5, 4.0),
            ("Chicken noodle soup", 15, 40, 1.8, 4.3),
            ("Chocolate lava cake", 15, 12, 3.5, 4.8),
            ("Overnight oats", 10, 0, 1.0, 3.9)
        };

        public static async Task SeedAsync(AppDbContext db)
        {
            if (!await db.Countries.AnyAsync() || !await db.Users.AnyAsync(u => u.Id == AppUserSeedUUID.PeterParker))
                return;

            var recipes = new List<Recipe>();
            var ratings = new List<Rating>();
            var now = DateTime.UtcNow;

            for (var i = 0; i < Dishes.Length; i++)
            {
                var id = Guid.Parse($"c1000000-0000-4000-8000-{i + 1:000000000000}");
                if (await db.Recipes.AnyAsync(r => r.Id == id)) continue;

                var dish = Dishes[i];
                var count = (i % 5) + 1;
                var images = new List<string>();
                for (var n = 0; n < count; n++)
                    images.Add(Photos[(i + n) % Photos.Length]);

                recipes.Add(new Recipe
                {
                    Id = id,
                    Name = dish.Name,
                    UserId = AppUserSeedUUID.PeterParker,
                    CountryId = Countries[i % Countries.Length],
                    ImageUrl = images[0],
                    ImageUrls = images,
                    PrepTimeMinutes = dish.Prep,
                    CookTimeMinutes = dish.Cook,
                    VisibilityStatus = "public",
                    PublishedAt = now.AddDays(-i),
                    Ingredients = new List<Ingredient>
                    {
                        new() { Name = "Main ingredient", Quantity = 1, Measurement = "portion" },
                        new() { Name = "Olive oil", Quantity = 1, Measurement = "tbsp" }
                    },
                    Instructions = new List<Instruction>
                    {
                        new() { Order = 1, Text = $"Prep the ingredients for {dish.Name}." },
                        new() { Order = 2, Text = dish.Cook == 0 ? "Assemble and serve." : $"Cook for about {dish.Cook} minutes, then serve." }
                    }
                });

                ratings.Add(new Rating
                {
                    Id = Guid.Parse($"d1000000-0000-4000-8000-{i + 1:000000000000}"),
                    RecipeId = id,
                    UserId = AppUserSeedUUID.PeterParker,
                    DifficultyRating = dish.Difficulty,
                    TasteRating = dish.Taste,
                    ReviewedAt = now.AddDays(-i)
                });
            }

            if (recipes.Count == 0) return;
            db.Recipes.AddRange(recipes);
            db.Ratings.AddRange(ratings);
            await db.SaveChangesAsync();
        }
    }
}
