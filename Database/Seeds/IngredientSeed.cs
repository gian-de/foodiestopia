using foodiestopia.Models;

namespace foodiestopia.Database.Seeds
{
    public static class IngredientSeed
    {
        public static IEnumerable<Ingredient> GetIngredients()
        {
            return new List<Ingredient>
            {
                // start Low Cal Pizza
                new Ingredient
                {
                    Id = Guid.Parse("697e9870-e247-411e-96f3-e56b8d21be1b"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Name = "Flour",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("be8b28cc-b3ba-4d35-866e-5d4ce096a788"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Name = "Egg",
                    Quantity = 2,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("f639974d-9bf6-4efd-954c-5abec793ac11"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Name = "Sauce",
                    Quantity = 1,
                    Measurement = "cup"
                },
                // end Low Cal Pizza

                // start Classic Cheeseburger
                new Ingredient
                {
                    Id = Guid.Parse("ffde08e9-ce76-4a6d-88c2-437205c0ad97"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Name = "Ground beef",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("61046199-47f5-4d3b-8834-1cb7b8464a82"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Name = "Burger buns",
                    Quantity = 4,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("045ff37e-63c4-413b-9553-b6082ef70c3d"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Name = "Cheddar cheese",
                    Quantity = 4,
                    Measurement = "slices"
                },
                new Ingredient
                {
                    Id = Guid.Parse("830d8300-a1d6-408a-8ab3-99541fb423e3"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Name = "Lettuce leaves",
                    Quantity = 4,
                    Measurement = "pcs"
                },
                // end Classic Cheeseburger

                // start Tacos al Pastor
                new Ingredient
                {
                    Id = Guid.Parse("0bce1bf7-1cea-43de-9cee-d85e1eeeb89f"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Name = "Pork shoulder",
                    Quantity = 2,
                    Measurement = "lbs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6f48049f-e9bb-489c-b98a-f57c3c0212ed"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Name = "Pineapple chunks",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("87f6815c-5992-4f7d-8a49-3f5183e556de"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Name = "Corn tortillas",
                    Quantity = 8,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a824a011-d517-43e2-8b80-9242324a0242"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Name = "Adobo marinade",
                    Quantity = 1,
                    Measurement = "cup"
                },
                // end Tacos al Pastor

                // start Chicken Biryani 
                new Ingredient
                {
                    Id = Guid.Parse("92fc04e6-7949-44ee-97ef-b795444a8e94"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Name = "Chicken thighs",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2f743557-4f5f-4783-b3fc-a36a41888940"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Name = "Basmati rice",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("37dec78e-9dac-4a98-99f2-03f0de13facd"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Name = "Yogurt",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("fe728b6c-4c0a-4908-9596-8ed49bdae068"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Name = "Biryani spices",
                    Quantity = 2,
                    Measurement = "tbsp"
                },
                // end Chicken Biryani

                // start Pecking Duck
                new Ingredient
                {
                    Id = Guid.Parse("8a7b5cd3-b432-4c96-8f4e-6d23b9cfe3d7"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Name = "Duck",
                    Quantity = 1,
                    Measurement = "whole"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1e85b82a-0dcd-4c37-a9c9-123e8c3280d5"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Name = "Hoisin sauce",
                    Quantity = 0.5M,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("843d5c82-3a4b-4f8e-b746-389fbf68d1d1"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Name = "Scallions",
                    Quantity = 6,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a1c8a4d5-22dc-4b8e-a452-573fc9159f65"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Name = "Pancakes",
                    Quantity = 12,
                    Measurement = "pcs"
                },
                // end Pecking Duck
                
                // start Beef Stroganoff
                new Ingredient
                {
                    Id = Guid.Parse("5b9a6f7e-4e3d-8a1f-7b2d-5a6e7f3b8f12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Name = "Beef tenderloin (cut into strips)",
                    Quantity = 1,
                    Measurement = "pound"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8b9c7e6b-3f4d-8a1f-7b2d-6f7a5c8e9f12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Name = "Onion (chopped)",
                    Quantity = 1,
                    Measurement = "medium"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7e5b9c6a-4e3d-8a1f-7b2d-5f7a6b8c9f12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Name = "Mushrooms (sliced)",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6a7b5c9e-3d4a-8f1e-7b2d-9e6b5a7c8f12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Name = "Sour cream",
                    Quantity = 1,
                    Measurement = "cup"
                },
                // end Beef Stroganoff

                // start Feijoada
                new Ingredient
                {
                    Id = Guid.Parse("0df2e923-4f5b-4203-925a-7d2e38c72d1c"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Name = "Black beans",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1cf5b843-7d93-4f3c-846e-3f9b726ae2d3"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Name = "Smoked sausage",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6b8f35a9-9247-4b5d-8574-2f8b39e7c4b3"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Name = "Pork ribs",
                    Quantity = 1.5M,
                    Measurement = "lbs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d8b26c49-5f7d-46c4-972b-7a5f8b3d26e5"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Name = "Bay leaves",
                    Quantity = 2,
                    Measurement = "pcs"
                },
                // end Feijoada

                // start Sushi
                new Ingredient
                {
                    Id = Guid.Parse("0fa36b10-e022-42aa-b4c1-73b81ce4e51d"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Name = "Sushi rice",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8a042d5b-5073-4f71-b823-ab102e3293ea"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Name = "Nori sheets",
                    Quantity = 4,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b6bef407-688f-4948-8c62-84af05c4c7a6"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Name = "Fresh salmon",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2b55982b-11e6-4642-afa8-6c727382753f"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Name = "Soy sauce",
                    Quantity = 0.25M,
                    Measurement = "cup"
                },
                // end Sushi

                // start Pad Thai
                new Ingredient
                {
                    Id = Guid.Parse("e1a9d4a8-6d34-41b8-bc70-1245a1e5f5a1"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Name = "Rice noodles",
                    Quantity = 8,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("17dbfc9b-cd68-4937-94b5-d23a36af1c13"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Name = "Shrimp",
                    Quantity = 12,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6ba75d76-24d6-404e-b437-4b8b44f97c74"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Name = "Bean sprouts",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("913a61c7-5f73-4900-a68b-637d6176f96e"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Name = "Pad Thai sauce",
                    Quantity = 0.5M,
                    Measurement = "cup"
                },
                // end Pad Thai

                // start Pho
                new Ingredient
                {
                    Id = Guid.Parse("a7c5d8f3-4b92-3f6a-96e7-5d2b7c39f4e6"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Name = "Rice noodles",
                    Quantity = 8,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7d4b6f82-5c93-2f8a-9e36-4b7c39e5d3f2"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Name = "Beef broth",
                    Quantity = 4,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8f5c3a7d-4b92-96e2-7f6b-3a49e2c5f8d7"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Name = "Thinly sliced beef",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9e2b6f7c-3a5d-4b92-83e7-5c39f4a6d8f2"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Name = "Bean sprouts",
                    Quantity = 1,
                    Measurement = "cup"
                },
                // end Pho

                // start Ceviche 
                new Ingredient
                {
                    Id = Guid.Parse("9d6f4b3a-7e8b-5c2f-3a9d-7b6a4e5f8c3f"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Name = "Fresh fish (cubed)",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7b9d6f3e-4a5c-8f2b-7d3a-9c6a4f5e8b7f"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Name = "Lime juice",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4e7a5c3f-9d6b-2f8b-7f3a-8b9c6a5d7f4e"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Name = "Red onion (thinly sliced)",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5f7c9d4e-3b6a-8f2f-7f5a-9c6b4a7d3e8b"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Name = "Cilantro (chopped)",
                    Quantity = 0.25M,
                    Measurement = "cup"
                },
                // end Ceviche 

                // start Kebab
                new Ingredient
                {
                    Id = Guid.Parse("b02357ad-7e58-448a-a65f-9c5d9e781f22"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Name = "Ground lamb",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6f2c49e4-81f7-4d83-9f89-7a3b2f2a79db"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Name = "Onion (grated)",
                    Quantity = 1,
                    Measurement = "small"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9c4761af-93b6-45f5-b2d5-7a29f4d78163"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Name = "Ground cumin",
                    Quantity = 1,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("f8b91c6a-3f2b-4217-b58d-9a38f6e0b277"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Name = "Salt",
                    Quantity = 0.5M,
                    Measurement = "tsp"
                },
                // end Kebab

                // start Butter Chicken
                new Ingredient
                {
                    Id = Guid.Parse("61d3f2a9-7b6e-48d5-8f9c-7a2e9b34d7fa"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Name = "Chicken thighs (cubed)",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2f97b6d4-5c8a-4a1f-9e7d-3b4f6a91c78e"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Name = "Tomato puree",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b47e1f6a-8f3c-4a2d-91b7-6a9c58f7e302"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Name = "Heavy cream",
                    Quantity = 0.5M,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7d9e6b2f-3a4c-8f1b-7a5f-6f9b4e0d7a38"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Name = "Butter",
                    Quantity = 2,
                    Measurement = "tbsp"
                },
                // end Butter Chicken

                // start Bobotie
                new Ingredient
                {
                    Id = Guid.Parse("b1c7e5f4-91a8-4b3d-7f2e-6d9a5f8c301b"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Name = "Ground beef",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7f6c3a9b-5e1d-4f9a-7b2c-9a8f4e7d6b13"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Name = "Chopped onion",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4e7b6a3c-9f8d-5b2a-7f1c-6d3e5f9a7b18"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Name = "Milk-soaked bread",
                    Quantity = 2,
                    Measurement = "slices"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9f5d3a7c-1e8b-6a4f-7b9d-3f2e6c9a5f8a"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Name = "Curry powder",
                    Quantity = 2,
                    Measurement = "tbsp"
                },
                // end Bobotie

                // start Kimchi
                new Ingredient
                {
                    Id = Guid.Parse("1f6c5e7a-4b8d-9a3f-7b2c-3f9e7a5d6b12"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Name = "Napa cabbage",
                    Quantity = 1,
                    Measurement = "large head"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6b9a7d4f-3e8c-5a1f-7b2d-9f5c7a4e3b18"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Name = "Korean chili flakes (gochugaru)",
                    Quantity = 3,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3f7b6d5a-9c4e-8a1f-7b2d-6a9e5f4c7b12"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Name = "Garlic cloves (minced)",
                    Quantity = 4,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9e3b7a5d-6a4f-1c8b-7f2d-3f6c5f7b9a18"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Name = "Salt",
                    Quantity = 1,
                    Measurement = "tbsp"
                },
                // end Kimchi

                // start Pierogi
                new Ingredient
                {
                    Id = Guid.Parse("4b6e9a3f-7d1c-5f2b-8a7d-3c5e7a9b6f18"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Name = "All-purpose flour",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6a7b9e5c-3f8d-4a1f-7c2d-9f5b7a6e3f12"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Name = "Potatoes (mashed)",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9f5c3e7a-4d1b-6a8f-7b2c-7b9a6e3f5a18"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Name = "Cheddar cheese (shredded)",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3c7b9e6f-5d4a-1a8f-7b2c-9f6a5b7e3f18"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Name = "Egg",
                    Quantity = 1,
                    Measurement = "large"
                },
                // end Pierogi

                // start Fish and Chips
                new Ingredient
                {
                    Id = Guid.Parse("8a7c5f3e-9b6d-4f1a-7b2c-6a9e7b5d3f18"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Name = "Cod fillets",
                    Quantity = 4,
                    Measurement = "pieces"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3f9b7e5a-6d4c-8a1f-7b2d-9f5c7a6e3b12"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Name = "All-purpose flour",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6f3b9a7e-5d4c-1a8f-7b2c-9e6a5f7b3c18"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Name = "Potatoes (cut into fries)",
                    Quantity = 4,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9e5a3f7b-6d4c-8a1f-7b2d-6a9e7f5c3b12"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Name = "Vegetable oil",
                    Quantity = 2,
                    Measurement = "cups"
                },
                // end Fish and Chips

                // start Moussaka
                new Ingredient
                {
                    Id = Guid.Parse("a1d3bbaf-1132-4111-b558-2e027fab8926"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Name = "Eggplants (sliced)",
                    Quantity = 2,
                    Measurement = "large"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b7c9a5e6-3d4f-8a1f-7b2d-6f5e7a9b3c12"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Name = "Ground lamb",
                    Quantity = 1,
                    Measurement = "pound"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9f6b7e5c-3a4d-8a1f-7b2c-5e7a6f9b3c12"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Name = "Tomatoes (diced)",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5a6e7f9c-3b4d-8a1f-7b2c-9e6a7f5c3b18"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Name = "Béchamel sauce",
                    Quantity = 1,
                    Measurement = "cup"
                },
                // end Moussaka

                // start Lasagna
                new Ingredient
                {
                    Id = Guid.Parse("6f9a5c7b-3e4d-8a1f-7b2d-9b6a5f7c3e12"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Name = "Lasagna noodles",
                    Quantity = 12,
                    Measurement = "pieces"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7b6f9c5e-3d4a-8a1f-7b2d-5e7c9a6f3b18"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Name = "Ground beef",
                    Quantity = 1,
                    Measurement = "pound"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3f7a6b9e-5c4d-8a1f-7b2d-9e6a5f9b7c18"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Name = "Ricotta cheese",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9e5b7c6a-3f4d-8a1f-7b2d-5f6e7a9c3b18"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Name = "Mozzarella cheese (shredded)",
                    Quantity = 2,
                    Measurement = "cups"
                },
                // end Lasagna

                // start Croissant
                new Ingredient
                {
                    Id = Guid.Parse("5f9a6e7b-3c4d-8a1f-7b2d-6b9e7f3a5c12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Name = "All-purpose flour",
                    Quantity = 3,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7a6b9e5f-3c4d-8a1f-7b2d-9f6e7c5b3a18"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Name = "Unsalted butter",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6f9c7b5a-3e4d-8a1f-7b2d-5a7e6f3b9c12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Name = "Yeast",
                    Quantity = 2,
                    Measurement = "teaspoons"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3a6f9e7b-5c4d-8a1f-7b2d-6e5f9b7c3a12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Name = "Milk (warm)",
                    Quantity = 1,
                    Measurement = "cup"
                },
                // end Croissant

                // start Shawarma
                new Ingredient
                {
                    Id = Guid.Parse("5c4e7b9f-2d4a-8f3b-7b2c-9a5f6a7b3e12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Name = "Chicken thighs (boneless)",
                    Quantity = 1,
                    Measurement = "pound"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7a5b9f6e-5c4d-8a1f-7b2c-9e7a5c9b6f18"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Name = "Garlic cloves (minced)",
                    Quantity = 3,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8a9f6b7e-5c4d-8a1f-7b2d-6e7a5f9c3e12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Name = "Ground cumin",
                    Quantity = 2,
                    Measurement = "teaspoons"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9f7e8c5b-3c4d-8a1f-7b2d-9e5f7a6c3b12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Name = "Yogurt (plain)",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d9076900-e132-4e4a-b88c-e56d664c9739"),
                    RecipeId = RecipeSeedUUID.TomYumGoong,
                    Name = "Chicken",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("ea0a0e1f-96e0-404c-898f-c23948db5528"),
                    RecipeId = RecipeSeedUUID.TomYumGoong,
                    Name = "Garlic",
                    Quantity = 3m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("0ae4c3d1-cd3c-41fe-a96d-fd8e32144f47"),
                    RecipeId = RecipeSeedUUID.TomYumGoong,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("d14be218-655a-4b1b-9930-1c4f7b5a86f8"),
                    RecipeId = RecipeSeedUUID.TomYumGoong,
                    Name = "Salt",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("933b39ed-819a-4463-b393-5f7cffa62f70"),
                    RecipeId = RecipeSeedUUID.GreenCurry,
                    Name = "Rice",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("ac93451c-b107-4d85-8373-9055a7369165"),
                    RecipeId = RecipeSeedUUID.GreenCurry,
                    Name = "Coconut milk",
                    Quantity = 1m,
                    Measurement = "can"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4b9510c7-e62d-4465-b40c-cb73e71cede6"),
                    RecipeId = RecipeSeedUUID.GreenCurry,
                    Name = "Lime",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("953c1ad8-491d-4e38-9e41-08750a3e8253"),
                    RecipeId = RecipeSeedUUID.GreenCurry,
                    Name = "Fish sauce",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a7e2ba84-a292-466c-98fc-59e99f45d808"),
                    RecipeId = RecipeSeedUUID.MassamanCurry,
                    Name = "Shrimp",
                    Quantity = 12m,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("319790fb-302f-4937-b0ae-25efb9688f8a"),
                    RecipeId = RecipeSeedUUID.MassamanCurry,
                    Name = "Lemongrass",
                    Quantity = 2m,
                    Measurement = "stalks"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5c300964-07b6-44c9-b0ac-5d5f85d6c1dd"),
                    RecipeId = RecipeSeedUUID.MassamanCurry,
                    Name = "Chili",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("2755746c-2b6d-415d-9482-23e640c9d2fc"),
                    RecipeId = RecipeSeedUUID.MassamanCurry,
                    Name = "Broth",
                    Quantity = 4m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("c6ce8fdc-2da1-45c6-9758-c5c8ef2ee622"),
                    RecipeId = RecipeSeedUUID.SomTam,
                    Name = "Tomato",
                    Quantity = 4m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("89fea048-ca01-4731-9c38-06e81b072d15"),
                    RecipeId = RecipeSeedUUID.SomTam,
                    Name = "Olive oil",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("c9dbde7c-730d-4bb0-b7bc-b28827f6501e"),
                    RecipeId = RecipeSeedUUID.SomTam,
                    Name = "Basil",
                    Quantity = 1m,
                    Measurement = "bunch"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1d0816b4-6e61-4d88-9911-08f88c907fd3"),
                    RecipeId = RecipeSeedUUID.SomTam,
                    Name = "Mozzarella",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b2ccbfd1-3575-46df-9bd6-c8c393d38749"),
                    RecipeId = RecipeSeedUUID.MangoStickyRice,
                    Name = "Flour",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6466e935-4df2-463c-bb3d-14004aac5878"),
                    RecipeId = RecipeSeedUUID.MangoStickyRice,
                    Name = "Egg",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("cee8029b-9d2b-4563-97c6-62a4da42f1aa"),
                    RecipeId = RecipeSeedUUID.MangoStickyRice,
                    Name = "Butter",
                    Quantity = 4m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3556c71d-0172-4d47-8bf8-8e09e696657b"),
                    RecipeId = RecipeSeedUUID.MangoStickyRice,
                    Name = "Milk",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("c7548bec-db1f-422b-b9f9-288ff74bbaef"),
                    RecipeId = RecipeSeedUUID.ThaiBasilChicken,
                    Name = "Beef",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("fc0f8ebc-3377-4782-80f3-0d93b946c289"),
                    RecipeId = RecipeSeedUUID.ThaiBasilChicken,
                    Name = "Potato",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("09f21641-ca54-49ba-8ec8-fc78ecb926ae"),
                    RecipeId = RecipeSeedUUID.ThaiBasilChicken,
                    Name = "Carrot",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("46e0cf93-cb5d-492d-9861-abcebd227a1d"),
                    RecipeId = RecipeSeedUUID.ThaiBasilChicken,
                    Name = "Stock",
                    Quantity = 3m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("cc7c41c5-d9c1-4530-b954-7cd0eefcea5b"),
                    RecipeId = RecipeSeedUUID.PanangCurry,
                    Name = "Tofu",
                    Quantity = 14m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2270efde-2ff4-4624-8b55-46f456fc44a4"),
                    RecipeId = RecipeSeedUUID.PanangCurry,
                    Name = "Soy sauce",
                    Quantity = 3m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("61101186-dc43-4459-b9cc-2ad6ca527165"),
                    RecipeId = RecipeSeedUUID.PanangCurry,
                    Name = "Ginger",
                    Quantity = 1m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4bd8a6f0-2182-4299-a232-1b6b8ae94a03"),
                    RecipeId = RecipeSeedUUID.PanangCurry,
                    Name = "Scallion",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("9a84c057-c38a-49a6-b83f-3aa9c6293ef7"),
                    RecipeId = RecipeSeedUUID.CoconutSoup,
                    Name = "Pork",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a055034f-6915-4d0f-8267-c9419048f45e"),
                    RecipeId = RecipeSeedUUID.CoconutSoup,
                    Name = "Cabbage",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("94cf8fe2-4ee9-4e34-8619-a3459f3d9c38"),
                    RecipeId = RecipeSeedUUID.CoconutSoup,
                    Name = "Garlic",
                    Quantity = 2m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("03629d96-0454-41d9-9198-f0577b209f30"),
                    RecipeId = RecipeSeedUUID.CoconutSoup,
                    Name = "Pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("448f6703-61a7-428c-a62f-a274e7e887d2"),
                    RecipeId = RecipeSeedUUID.BanhMi,
                    Name = "Chickpeas",
                    Quantity = 2m,
                    Measurement = "cans"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2dee7ab4-b0e7-4ded-b562-7ef44c0ce518"),
                    RecipeId = RecipeSeedUUID.BanhMi,
                    Name = "Cumin",
                    Quantity = 2m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7008f8f4-c083-4548-896f-983a173ccac8"),
                    RecipeId = RecipeSeedUUID.BanhMi,
                    Name = "Tomato",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("71e6fb14-f90b-4eb5-bdac-fe878635f6a4"),
                    RecipeId = RecipeSeedUUID.BanhMi,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("932b060e-6a6c-412c-a7df-b07047e338eb"),
                    RecipeId = RecipeSeedUUID.BunCha,
                    Name = "Pasta",
                    Quantity = 12m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("17454ee8-152b-45bc-b5be-63de4df262fa"),
                    RecipeId = RecipeSeedUUID.BunCha,
                    Name = "Parmesan",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b2cfc5a5-92c5-4d59-96c8-79496bb67d5c"),
                    RecipeId = RecipeSeedUUID.BunCha,
                    Name = "Egg",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("293e4224-f3ed-40e7-b72b-5edc5606c99f"),
                    RecipeId = RecipeSeedUUID.BunCha,
                    Name = "Black pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4f655dfc-e548-4a6f-9302-f4bebc72c85e"),
                    RecipeId = RecipeSeedUUID.GoiCuon,
                    Name = "Mango",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("21828d66-68b0-4da6-b205-1ae2d867b8dc"),
                    RecipeId = RecipeSeedUUID.GoiCuon,
                    Name = "Sticky rice",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("e0e8adce-a71f-40e1-9406-8d9e4b213a2a"),
                    RecipeId = RecipeSeedUUID.GoiCuon,
                    Name = "Sugar",
                    Quantity = 3m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("c8ec85a6-9bc9-44c7-822b-9e9f6bc92df6"),
                    RecipeId = RecipeSeedUUID.GoiCuon,
                    Name = "Coconut milk",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("98d5a84d-3da7-48e9-916e-71256c4be6ca"),
                    RecipeId = RecipeSeedUUID.ComTam,
                    Name = "Lentils",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3671a90c-2e0f-4a62-b0b9-b9704562de20"),
                    RecipeId = RecipeSeedUUID.ComTam,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("79c42bce-727d-4886-866d-78ba0651b02c"),
                    RecipeId = RecipeSeedUUID.ComTam,
                    Name = "Carrot",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("36cf2aff-d79c-443f-904f-0b1c91c68d7b"),
                    RecipeId = RecipeSeedUUID.ComTam,
                    Name = "Paprika",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("45041b46-628a-48b0-b51c-9a61be21a3dc"),
                    RecipeId = RecipeSeedUUID.Ramen,
                    Name = "Fish",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("57c1094e-4259-48d3-9179-a30745cca4d1"),
                    RecipeId = RecipeSeedUUID.Ramen,
                    Name = "Lime juice",
                    Quantity = 0.5m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6835438f-f6d3-4e99-920e-43cdbeccd306"),
                    RecipeId = RecipeSeedUUID.Ramen,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("dcbb18d9-4d53-4ad7-a8f8-f1031332b89a"),
                    RecipeId = RecipeSeedUUID.Ramen,
                    Name = "Cilantro",
                    Quantity = 0.5m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2c141e9f-93fe-45c7-a412-5f30fb91fbf3"),
                    RecipeId = RecipeSeedUUID.Tonkatsu,
                    Name = "Beans",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("966273eb-34d9-41a9-b4a2-86024b708e4a"),
                    RecipeId = RecipeSeedUUID.Tonkatsu,
                    Name = "Garlic",
                    Quantity = 4m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("c73f5dde-83be-4751-8a9b-8fe6341ebb95"),
                    RecipeId = RecipeSeedUUID.Tonkatsu,
                    Name = "Bay leaf",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("dbf195f2-40d6-49f8-952a-aab264da1c35"),
                    RecipeId = RecipeSeedUUID.Tonkatsu,
                    Name = "Sausage",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("e153f9dd-32a6-47b1-ad9a-e15bf910ff0e"),
                    RecipeId = RecipeSeedUUID.Okonomiyaki,
                    Name = "Noodles",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("92ea8eb6-4b1d-4788-9937-55d707e6f6e0"),
                    RecipeId = RecipeSeedUUID.Okonomiyaki,
                    Name = "Beef",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a531232b-d03c-4907-8d82-7ad678cfcc50"),
                    RecipeId = RecipeSeedUUID.Okonomiyaki,
                    Name = "Spinach",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("67e4cd2e-c4c6-4d24-b67b-01f1bf609c43"),
                    RecipeId = RecipeSeedUUID.Okonomiyaki,
                    Name = "Sesame oil",
                    Quantity = 1m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("c1824733-7b40-476b-9c47-e816f31b0d47"),
                    RecipeId = RecipeSeedUUID.MisoSoup,
                    Name = "Chicken",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("dcbff9cd-2397-4a15-97fe-cc269942ea93"),
                    RecipeId = RecipeSeedUUID.MisoSoup,
                    Name = "Garlic",
                    Quantity = 3m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("340ba530-26ea-4b6b-acea-ba19a5b3db72"),
                    RecipeId = RecipeSeedUUID.MisoSoup,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("d8671d5d-4cb4-4e48-ad3b-72b4d6e5fc80"),
                    RecipeId = RecipeSeedUUID.MisoSoup,
                    Name = "Salt",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4146d080-4fd6-4448-b8c6-5495bb50d9e5"),
                    RecipeId = RecipeSeedUUID.Udon,
                    Name = "Rice",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("825c1fd0-c558-4b34-a93f-c81ebdc2b538"),
                    RecipeId = RecipeSeedUUID.Udon,
                    Name = "Coconut milk",
                    Quantity = 1m,
                    Measurement = "can"
                },
                new Ingredient
                {
                    Id = Guid.Parse("19334a6e-d370-4aa2-a8b2-26e369d8dea3"),
                    RecipeId = RecipeSeedUUID.Udon,
                    Name = "Lime",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("2b2ac669-5413-4a69-9701-e924beed09fa"),
                    RecipeId = RecipeSeedUUID.Udon,
                    Name = "Fish sauce",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("64fc9462-d44d-4514-a693-53ddc4c0bbbc"),
                    RecipeId = RecipeSeedUUID.Tempura,
                    Name = "Shrimp",
                    Quantity = 12m,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4d8c9ce8-4638-4927-9ee2-2c03aa2145a5"),
                    RecipeId = RecipeSeedUUID.Tempura,
                    Name = "Lemongrass",
                    Quantity = 2m,
                    Measurement = "stalks"
                },
                new Ingredient
                {
                    Id = Guid.Parse("469a8270-1628-4b61-8774-0a82b1734d3e"),
                    RecipeId = RecipeSeedUUID.Tempura,
                    Name = "Chili",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("52c238e6-79cd-4b87-856e-553492602c92"),
                    RecipeId = RecipeSeedUUID.Tempura,
                    Name = "Broth",
                    Quantity = 4m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("bc5a1447-cee0-412e-ac6c-03da4e358c72"),
                    RecipeId = RecipeSeedUUID.Onigiri,
                    Name = "Tomato",
                    Quantity = 4m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("04d3db49-f505-40b0-877c-efd08f76cb07"),
                    RecipeId = RecipeSeedUUID.Onigiri,
                    Name = "Olive oil",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7091fd11-f24b-4ad5-a38b-d0b72e099ba4"),
                    RecipeId = RecipeSeedUUID.Onigiri,
                    Name = "Basil",
                    Quantity = 1m,
                    Measurement = "bunch"
                },
                new Ingredient
                {
                    Id = Guid.Parse("350c0d50-9a94-4112-ab9e-df40c41919d5"),
                    RecipeId = RecipeSeedUUID.Onigiri,
                    Name = "Mozzarella",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("17758708-8678-475e-894a-c249f5ee78cc"),
                    RecipeId = RecipeSeedUUID.Carbonara,
                    Name = "Flour",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("82351a31-bd30-49d6-8f96-e53a6f3dcb63"),
                    RecipeId = RecipeSeedUUID.Carbonara,
                    Name = "Egg",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("5f0b34e7-efc5-414a-ada8-cac80d64b0aa"),
                    RecipeId = RecipeSeedUUID.Carbonara,
                    Name = "Butter",
                    Quantity = 4m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("df269fcb-896c-4781-982c-20dd28e9f33f"),
                    RecipeId = RecipeSeedUUID.Carbonara,
                    Name = "Milk",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("23acebb1-bcb8-42fd-8444-dd15c37da09f"),
                    RecipeId = RecipeSeedUUID.MargheritaPizza,
                    Name = "Beef",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d6c5eee0-2ddb-4604-bedb-b08551c12809"),
                    RecipeId = RecipeSeedUUID.MargheritaPizza,
                    Name = "Potato",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("2cd00e24-c699-4f22-87cd-1138961f1b48"),
                    RecipeId = RecipeSeedUUID.MargheritaPizza,
                    Name = "Carrot",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("10284f7d-c9f5-4577-ae8e-de0b7738f44d"),
                    RecipeId = RecipeSeedUUID.MargheritaPizza,
                    Name = "Stock",
                    Quantity = 3m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5a9c74f1-390d-4f62-a585-04e61f338ffa"),
                    RecipeId = RecipeSeedUUID.MushroomRisotto,
                    Name = "Tofu",
                    Quantity = 14m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("fde8120a-a201-4de7-92e0-b41e2e8826b2"),
                    RecipeId = RecipeSeedUUID.MushroomRisotto,
                    Name = "Soy sauce",
                    Quantity = 3m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1dcbad5a-5a68-445f-a5c8-14c0fa4b0d9c"),
                    RecipeId = RecipeSeedUUID.MushroomRisotto,
                    Name = "Ginger",
                    Quantity = 1m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8f6af6d7-0b1e-4ebe-9005-d6378115f945"),
                    RecipeId = RecipeSeedUUID.MushroomRisotto,
                    Name = "Scallion",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("1499468f-8e56-431f-8a21-0ff486b10bd4"),
                    RecipeId = RecipeSeedUUID.Tiramisu,
                    Name = "Pork",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("07563ae4-977f-4676-b08a-606f1e1f4959"),
                    RecipeId = RecipeSeedUUID.Tiramisu,
                    Name = "Cabbage",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4431467b-917d-4758-8d3a-c576bbcd384f"),
                    RecipeId = RecipeSeedUUID.Tiramisu,
                    Name = "Garlic",
                    Quantity = 2m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("812c3e11-6a87-45a7-88d5-09b13807c78a"),
                    RecipeId = RecipeSeedUUID.Tiramisu,
                    Name = "Pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a8c8b61e-39bb-4db1-a92a-4b6cb8a9c3c0"),
                    RecipeId = RecipeSeedUUID.Gnocchi,
                    Name = "Chickpeas",
                    Quantity = 2m,
                    Measurement = "cans"
                },
                new Ingredient
                {
                    Id = Guid.Parse("c8488b48-2fa5-42cc-8b66-6de1decb5c44"),
                    RecipeId = RecipeSeedUUID.Gnocchi,
                    Name = "Cumin",
                    Quantity = 2m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("67db6d24-d363-4d36-bdb3-b45121b6750d"),
                    RecipeId = RecipeSeedUUID.Gnocchi,
                    Name = "Tomato",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("5c586463-2eae-4e96-80cb-ecfc77010dc8"),
                    RecipeId = RecipeSeedUUID.Gnocchi,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("ff2d564e-e6c6-44df-aed2-87bb8fd495e3"),
                    RecipeId = RecipeSeedUUID.PestoPasta,
                    Name = "Pasta",
                    Quantity = 12m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("171a5a91-cd70-47fd-91ac-560182c658fb"),
                    RecipeId = RecipeSeedUUID.PestoPasta,
                    Name = "Parmesan",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3ec649eb-0f07-420b-a202-7e5ce33d314e"),
                    RecipeId = RecipeSeedUUID.PestoPasta,
                    Name = "Egg",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("22d371cd-4cc5-44a0-91ad-140882d040b7"),
                    RecipeId = RecipeSeedUUID.PestoPasta,
                    Name = "Black pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2bd67db4-9ba9-4e08-9905-ad569b1a31b9"),
                    RecipeId = RecipeSeedUUID.Minestrone,
                    Name = "Mango",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("4a74536c-0481-4d46-95ed-0cb1d2684cd3"),
                    RecipeId = RecipeSeedUUID.Minestrone,
                    Name = "Sticky rice",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4d333349-2578-4f24-848b-b46fe33a1bf2"),
                    RecipeId = RecipeSeedUUID.Minestrone,
                    Name = "Sugar",
                    Quantity = 3m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d0f19fe6-fd50-4f0e-8ef3-cd9542c2ba66"),
                    RecipeId = RecipeSeedUUID.Minestrone,
                    Name = "Coconut milk",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5b603b9c-a386-4cd2-9f24-7b51409df71f"),
                    RecipeId = RecipeSeedUUID.ChickenEnchiladas,
                    Name = "Lentils",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9edb7410-fe50-46c9-ba41-4c19b3d343b8"),
                    RecipeId = RecipeSeedUUID.ChickenEnchiladas,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("6cb42754-50c7-4425-b49f-094bd09038b1"),
                    RecipeId = RecipeSeedUUID.ChickenEnchiladas,
                    Name = "Carrot",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("6198c7ab-fd27-4327-a3fa-90665af47138"),
                    RecipeId = RecipeSeedUUID.ChickenEnchiladas,
                    Name = "Paprika",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a232143c-b878-4926-8e3c-f23fb1c1d569"),
                    RecipeId = RecipeSeedUUID.Guacamole,
                    Name = "Fish",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a697872a-adc4-42c0-880f-deb5d42f5b55"),
                    RecipeId = RecipeSeedUUID.Guacamole,
                    Name = "Lime juice",
                    Quantity = 0.5m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7eb565f8-0855-4799-a26d-c31455c6dcf5"),
                    RecipeId = RecipeSeedUUID.Guacamole,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("d48de052-8857-4699-9e60-292a503f45a1"),
                    RecipeId = RecipeSeedUUID.Guacamole,
                    Name = "Cilantro",
                    Quantity = 0.5m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("32de550d-8239-4e79-a69d-f43114534ba8"),
                    RecipeId = RecipeSeedUUID.Pozole,
                    Name = "Beans",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("40aa0d7d-b5a3-4c9d-937d-1d90f1b849e2"),
                    RecipeId = RecipeSeedUUID.Pozole,
                    Name = "Garlic",
                    Quantity = 4m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7fad3f6c-f58e-498f-ac09-450a89090afe"),
                    RecipeId = RecipeSeedUUID.Pozole,
                    Name = "Bay leaf",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("a73c5411-28a2-4803-905e-e4aabc311234"),
                    RecipeId = RecipeSeedUUID.Pozole,
                    Name = "Sausage",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4baf69c5-02d4-4fe4-810a-7a64e86f086e"),
                    RecipeId = RecipeSeedUUID.Elote,
                    Name = "Noodles",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("34e1d623-75ed-4852-a2a2-4927cdbaca1a"),
                    RecipeId = RecipeSeedUUID.Elote,
                    Name = "Beef",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3ad18483-7faa-42a0-9952-a9c135201f6b"),
                    RecipeId = RecipeSeedUUID.Elote,
                    Name = "Spinach",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("74b49137-30ce-4082-b4e2-3cbfc6f2e5b9"),
                    RecipeId = RecipeSeedUUID.Elote,
                    Name = "Sesame oil",
                    Quantity = 1m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("352f4314-415e-4fc1-8029-c47030aff613"),
                    RecipeId = RecipeSeedUUID.CheeseQuesadilla,
                    Name = "Chicken",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("e25043a7-6abf-4404-89ef-a1c31824e6a7"),
                    RecipeId = RecipeSeedUUID.CheeseQuesadilla,
                    Name = "Garlic",
                    Quantity = 3m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4860b47f-af0c-4a1d-9491-8953440e043c"),
                    RecipeId = RecipeSeedUUID.CheeseQuesadilla,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("e1919796-eeea-4932-8583-14d91c8640bc"),
                    RecipeId = RecipeSeedUUID.CheeseQuesadilla,
                    Name = "Salt",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d2341cd6-34cd-44bf-b65b-d423a23b6474"),
                    RecipeId = RecipeSeedUUID.Tamales,
                    Name = "Rice",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("101781a2-fc70-4b2c-872c-26edaa2838d4"),
                    RecipeId = RecipeSeedUUID.Tamales,
                    Name = "Coconut milk",
                    Quantity = 1m,
                    Measurement = "can"
                },
                new Ingredient
                {
                    Id = Guid.Parse("232cc93a-16ce-4143-9811-f2d7ff530b72"),
                    RecipeId = RecipeSeedUUID.Tamales,
                    Name = "Lime",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("823ec768-719b-4c20-a328-641794f1323f"),
                    RecipeId = RecipeSeedUUID.Tamales,
                    Name = "Fish sauce",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4c6492f9-8e0b-4bde-a559-945d54f39043"),
                    RecipeId = RecipeSeedUUID.MacAndCheese,
                    Name = "Shrimp",
                    Quantity = 12m,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("704dcabb-9082-4a10-b034-37eb1b7ba145"),
                    RecipeId = RecipeSeedUUID.MacAndCheese,
                    Name = "Lemongrass",
                    Quantity = 2m,
                    Measurement = "stalks"
                },
                new Ingredient
                {
                    Id = Guid.Parse("cab4d812-94a5-4b2c-aacc-29a6bd800412"),
                    RecipeId = RecipeSeedUUID.MacAndCheese,
                    Name = "Chili",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("e7252fc7-1d29-4951-b56a-de661f615bbc"),
                    RecipeId = RecipeSeedUUID.MacAndCheese,
                    Name = "Broth",
                    Quantity = 4m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b2d121b7-aee5-44ac-a291-149eb3ce3db3"),
                    RecipeId = RecipeSeedUUID.FriedChicken,
                    Name = "Tomato",
                    Quantity = 4m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("66618c94-f846-480b-8505-882f6d969c42"),
                    RecipeId = RecipeSeedUUID.FriedChicken,
                    Name = "Olive oil",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("21bcb79a-ea85-48af-98e2-84e95c524c8d"),
                    RecipeId = RecipeSeedUUID.FriedChicken,
                    Name = "Basil",
                    Quantity = 1m,
                    Measurement = "bunch"
                },
                new Ingredient
                {
                    Id = Guid.Parse("090c3111-196e-46aa-b1b7-f81269c5b739"),
                    RecipeId = RecipeSeedUUID.FriedChicken,
                    Name = "Mozzarella",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("eeec9e4b-8dbc-4ad8-8a45-36b266c08748"),
                    RecipeId = RecipeSeedUUID.ClamChowder,
                    Name = "Flour",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("c9096093-32d4-474a-84c3-13aed18e0abd"),
                    RecipeId = RecipeSeedUUID.ClamChowder,
                    Name = "Egg",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("3c7cc245-d1ea-4ca3-84a2-2efee828ae9c"),
                    RecipeId = RecipeSeedUUID.ClamChowder,
                    Name = "Butter",
                    Quantity = 4m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("fe8f4cf2-d5ef-4372-beff-5b775621eaac"),
                    RecipeId = RecipeSeedUUID.ClamChowder,
                    Name = "Milk",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3057c8ca-6bd6-4f22-b670-6dd2fee536a2"),
                    RecipeId = RecipeSeedUUID.Pancakes,
                    Name = "Beef",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1136cdd4-e2c0-440f-8979-adcf877bba96"),
                    RecipeId = RecipeSeedUUID.Pancakes,
                    Name = "Potato",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("06c05198-3e39-4368-83f4-91acf060de92"),
                    RecipeId = RecipeSeedUUID.Pancakes,
                    Name = "Carrot",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("7593ba65-6a1f-4864-855a-b6f4a11e5d06"),
                    RecipeId = RecipeSeedUUID.Pancakes,
                    Name = "Stock",
                    Quantity = 3m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6aeba3b1-4165-4ada-8678-a05232d1bbc9"),
                    RecipeId = RecipeSeedUUID.BeefChili,
                    Name = "Tofu",
                    Quantity = 14m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("83c109f0-fabe-4695-9893-0f63b491d036"),
                    RecipeId = RecipeSeedUUID.BeefChili,
                    Name = "Soy sauce",
                    Quantity = 3m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("de735381-bf09-4f02-8560-b81a1836d8f5"),
                    RecipeId = RecipeSeedUUID.BeefChili,
                    Name = "Ginger",
                    Quantity = 1m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4a547467-69d7-47f2-8a26-59cf0689cb14"),
                    RecipeId = RecipeSeedUUID.BeefChili,
                    Name = "Scallion",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("a0db956f-d2a9-402d-a36f-2631e30310b7"),
                    RecipeId = RecipeSeedUUID.ApplePie,
                    Name = "Pork",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("be93d42e-c204-4a48-88ad-ce3137cf1613"),
                    RecipeId = RecipeSeedUUID.ApplePie,
                    Name = "Cabbage",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1651c13b-17ef-488d-9607-f252221162b3"),
                    RecipeId = RecipeSeedUUID.ApplePie,
                    Name = "Garlic",
                    Quantity = 2m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4c516d28-fcf5-4367-99a6-cd5b965c03f2"),
                    RecipeId = RecipeSeedUUID.ApplePie,
                    Name = "Pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("c314e8ba-471d-4d77-b8fd-bf1f57805110"),
                    RecipeId = RecipeSeedUUID.TikkaMasala,
                    Name = "Chickpeas",
                    Quantity = 2m,
                    Measurement = "cans"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7a6d3374-4bef-4313-ba58-acfe555fe96f"),
                    RecipeId = RecipeSeedUUID.TikkaMasala,
                    Name = "Cumin",
                    Quantity = 2m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("93615ac9-d5fd-47d4-9dc0-0dcf5047e1bc"),
                    RecipeId = RecipeSeedUUID.TikkaMasala,
                    Name = "Tomato",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("7ec551fd-9c78-4a97-aa18-06fd80a2f7c1"),
                    RecipeId = RecipeSeedUUID.TikkaMasala,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("d5c0415b-18ef-4ca8-ae78-5c11c0fe5159"),
                    RecipeId = RecipeSeedUUID.PalakPaneer,
                    Name = "Pasta",
                    Quantity = 12m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("21ae0002-f085-4e9e-b22e-4c2b0feb9de1"),
                    RecipeId = RecipeSeedUUID.PalakPaneer,
                    Name = "Parmesan",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("cd48c990-c278-419d-9f7c-dba8a8a8bc32"),
                    RecipeId = RecipeSeedUUID.PalakPaneer,
                    Name = "Egg",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("9b0bad4e-1dd7-4d60-b930-62b3a71e280f"),
                    RecipeId = RecipeSeedUUID.PalakPaneer,
                    Name = "Black pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("71b19248-9915-4605-b576-55b4c5ac2ee2"),
                    RecipeId = RecipeSeedUUID.Samosas,
                    Name = "Mango",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("9f479f39-3e1d-4c63-b95e-3bd2f230a360"),
                    RecipeId = RecipeSeedUUID.Samosas,
                    Name = "Sticky rice",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("cc740b06-9a85-4294-9d9f-6aa636169377"),
                    RecipeId = RecipeSeedUUID.Samosas,
                    Name = "Sugar",
                    Quantity = 3m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d3f626de-686e-4841-b460-16daabc6cd9d"),
                    RecipeId = RecipeSeedUUID.Samosas,
                    Name = "Coconut milk",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("18c17d64-fbee-4f4a-94e1-2732408ce078"),
                    RecipeId = RecipeSeedUUID.ChanaMasala,
                    Name = "Lentils",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d7b03ff0-8d16-4ac6-a648-7cec3945b97c"),
                    RecipeId = RecipeSeedUUID.ChanaMasala,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("c700f1a4-e24f-47c0-9ff6-7d41398b48b2"),
                    RecipeId = RecipeSeedUUID.ChanaMasala,
                    Name = "Carrot",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("376c825f-c096-42a5-80d0-b92b827fe032"),
                    RecipeId = RecipeSeedUUID.ChanaMasala,
                    Name = "Paprika",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("814d0b9b-6f59-4110-9f78-6c41c4c15117"),
                    RecipeId = RecipeSeedUUID.DalTadka,
                    Name = "Fish",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("07c5b696-951b-465b-9c65-5c10bd31b33e"),
                    RecipeId = RecipeSeedUUID.DalTadka,
                    Name = "Lime juice",
                    Quantity = 0.5m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("902eadf0-d685-4cbb-8eb5-fede70dfbec7"),
                    RecipeId = RecipeSeedUUID.DalTadka,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("b0aa3246-131e-4088-b179-8e2ffdc48830"),
                    RecipeId = RecipeSeedUUID.DalTadka,
                    Name = "Cilantro",
                    Quantity = 0.5m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4e86aa7f-fe92-4cd9-bf30-ea52942b641e"),
                    RecipeId = RecipeSeedUUID.MasalaDosa,
                    Name = "Beans",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("18d21859-4f5e-4d62-a03a-3e574b9e70d2"),
                    RecipeId = RecipeSeedUUID.MasalaDosa,
                    Name = "Garlic",
                    Quantity = 4m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("f84dc94c-c6e9-4b8e-a70a-e1ad3dc4e005"),
                    RecipeId = RecipeSeedUUID.MasalaDosa,
                    Name = "Bay leaf",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("06464d11-98d7-44b8-8d3a-76b699535848"),
                    RecipeId = RecipeSeedUUID.MasalaDosa,
                    Name = "Sausage",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("de223ba0-9080-4585-a6ce-fc0b3d3a4d0d"),
                    RecipeId = RecipeSeedUUID.MapoTofu,
                    Name = "Noodles",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("f03f18cc-b060-4afc-b035-22b1d73488de"),
                    RecipeId = RecipeSeedUUID.MapoTofu,
                    Name = "Beef",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("646a5f6f-6a0e-4f7a-9155-aa5900433c2f"),
                    RecipeId = RecipeSeedUUID.MapoTofu,
                    Name = "Spinach",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("78729aea-c29b-4c67-82e6-c7fd140296a0"),
                    RecipeId = RecipeSeedUUID.MapoTofu,
                    Name = "Sesame oil",
                    Quantity = 1m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("24fb2c9b-2007-4b53-be8d-ed26ba5f28ef"),
                    RecipeId = RecipeSeedUUID.PorkDumplings,
                    Name = "Chicken",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("0847378a-8619-4d76-b6fa-2f2bcf78ad85"),
                    RecipeId = RecipeSeedUUID.PorkDumplings,
                    Name = "Garlic",
                    Quantity = 3m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("04b71e70-ac85-4920-b133-7fc0b6c70463"),
                    RecipeId = RecipeSeedUUID.PorkDumplings,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("cfdbe4bf-75fd-4ce7-8959-d3376e81dd25"),
                    RecipeId = RecipeSeedUUID.PorkDumplings,
                    Name = "Salt",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("39dd6569-cebb-4333-b686-0d0d565e8a34"),
                    RecipeId = RecipeSeedUUID.KungPaoChicken,
                    Name = "Rice",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9de0bd6a-73be-4d2e-a7eb-054621005880"),
                    RecipeId = RecipeSeedUUID.KungPaoChicken,
                    Name = "Coconut milk",
                    Quantity = 1m,
                    Measurement = "can"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7f9d9584-644d-4dca-ad86-444e875ab2f5"),
                    RecipeId = RecipeSeedUUID.KungPaoChicken,
                    Name = "Lime",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("b2b80e77-c508-4cfc-a31b-64c2b21fa06d"),
                    RecipeId = RecipeSeedUUID.KungPaoChicken,
                    Name = "Fish sauce",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4aed6d10-a9b5-488f-a474-7fd969df11a8"),
                    RecipeId = RecipeSeedUUID.EggFriedRice,
                    Name = "Shrimp",
                    Quantity = 12m,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("40101031-2b86-4707-9b9e-f3dfcc84393c"),
                    RecipeId = RecipeSeedUUID.EggFriedRice,
                    Name = "Lemongrass",
                    Quantity = 2m,
                    Measurement = "stalks"
                },
                new Ingredient
                {
                    Id = Guid.Parse("cbbe9c2e-3ea8-4f06-8dd5-a957f5ee56bc"),
                    RecipeId = RecipeSeedUUID.EggFriedRice,
                    Name = "Chili",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("166140ec-4e88-4e03-b66d-814638f9a711"),
                    RecipeId = RecipeSeedUUID.EggFriedRice,
                    Name = "Broth",
                    Quantity = 4m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b9562a29-95d2-4c03-856b-cee0d5fca13b"),
                    RecipeId = RecipeSeedUUID.WontonSoup,
                    Name = "Tomato",
                    Quantity = 4m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("235c8223-2e93-44db-8f58-a82bdb589c8b"),
                    RecipeId = RecipeSeedUUID.WontonSoup,
                    Name = "Olive oil",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("84a4ee68-6a93-49e3-ae0a-5378ff0b0994"),
                    RecipeId = RecipeSeedUUID.WontonSoup,
                    Name = "Basil",
                    Quantity = 1m,
                    Measurement = "bunch"
                },
                new Ingredient
                {
                    Id = Guid.Parse("202b09f4-2d84-4f32-89cd-fae8329715f7"),
                    RecipeId = RecipeSeedUUID.WontonSoup,
                    Name = "Mozzarella",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("82b29414-846f-4cfc-9000-f63dc5354a88"),
                    RecipeId = RecipeSeedUUID.CharSiu,
                    Name = "Flour",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("23513fd2-223d-4c21-bc82-db52f3a9801f"),
                    RecipeId = RecipeSeedUUID.CharSiu,
                    Name = "Egg",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("d5222b8a-4a82-4363-b405-0f62d668223e"),
                    RecipeId = RecipeSeedUUID.CharSiu,
                    Name = "Butter",
                    Quantity = 4m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8775ca93-717c-4b00-99f1-19f3c6e07532"),
                    RecipeId = RecipeSeedUUID.CharSiu,
                    Name = "Milk",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7b51ce5c-e6be-47ea-a47c-102170707333"),
                    RecipeId = RecipeSeedUUID.FrenchOnionSoup,
                    Name = "Beef",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("80ed0b75-3393-4b75-8fb8-fc0f6b2b1d58"),
                    RecipeId = RecipeSeedUUID.FrenchOnionSoup,
                    Name = "Potato",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("16a01824-214c-4667-973e-1a759160d587"),
                    RecipeId = RecipeSeedUUID.FrenchOnionSoup,
                    Name = "Carrot",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("c4d5c573-79cd-4387-9ca7-5e4e1bb271ef"),
                    RecipeId = RecipeSeedUUID.FrenchOnionSoup,
                    Name = "Stock",
                    Quantity = 3m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("c17cfcc5-3a9d-482d-9909-6a363ba4b833"),
                    RecipeId = RecipeSeedUUID.Ratatouille,
                    Name = "Tofu",
                    Quantity = 14m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d00103d0-d651-4584-afd5-5962fb189ff9"),
                    RecipeId = RecipeSeedUUID.Ratatouille,
                    Name = "Soy sauce",
                    Quantity = 3m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("dc482fc6-e2c0-4c7e-b88a-f23c91386e10"),
                    RecipeId = RecipeSeedUUID.Ratatouille,
                    Name = "Ginger",
                    Quantity = 1m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("e37fe4d9-2e1e-4113-a993-310e81ea10cb"),
                    RecipeId = RecipeSeedUUID.Ratatouille,
                    Name = "Scallion",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("a05c1eec-6022-4107-81b6-0bba27f05b2c"),
                    RecipeId = RecipeSeedUUID.QuicheLorraine,
                    Name = "Pork",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("09f4506d-5eb1-4247-a86e-55d27778fbd4"),
                    RecipeId = RecipeSeedUUID.QuicheLorraine,
                    Name = "Cabbage",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("f414821b-7cef-46e3-8e87-57f1591a7022"),
                    RecipeId = RecipeSeedUUID.QuicheLorraine,
                    Name = "Garlic",
                    Quantity = 2m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("42be730f-5f60-4a9b-abbc-7fdbf3492a1a"),
                    RecipeId = RecipeSeedUUID.QuicheLorraine,
                    Name = "Pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1d05b58b-07a7-40f5-bf43-c77b21f15f00"),
                    RecipeId = RecipeSeedUUID.Crepes,
                    Name = "Chickpeas",
                    Quantity = 2m,
                    Measurement = "cans"
                },
                new Ingredient
                {
                    Id = Guid.Parse("0bc8526f-0bbe-48bc-9f59-45e9fb6f05b7"),
                    RecipeId = RecipeSeedUUID.Crepes,
                    Name = "Cumin",
                    Quantity = 2m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("e55f04cc-22f9-4dc4-8ce9-aa0cf556d6a6"),
                    RecipeId = RecipeSeedUUID.Crepes,
                    Name = "Tomato",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("5eb90cad-7e47-413f-b6e9-19b860a2fbc4"),
                    RecipeId = RecipeSeedUUID.Crepes,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("4328e41e-8a12-4a9f-ae37-e2cfb01b0f5d"),
                    RecipeId = RecipeSeedUUID.CoqAuVin,
                    Name = "Pasta",
                    Quantity = 12m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("df728461-f298-492e-9eac-0840a77eeb03"),
                    RecipeId = RecipeSeedUUID.CoqAuVin,
                    Name = "Parmesan",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("adb3652a-bcf9-429d-a625-55b8420f97e1"),
                    RecipeId = RecipeSeedUUID.CoqAuVin,
                    Name = "Egg",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("a242079a-66a5-4f8c-9cbc-56c5d5bfb62e"),
                    RecipeId = RecipeSeedUUID.CoqAuVin,
                    Name = "Black pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("300bad0e-0109-43a5-a7cb-56527c828970"),
                    RecipeId = RecipeSeedUUID.GreekSalad,
                    Name = "Mango",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("6a7f60eb-3e1c-454d-a6f9-2c761e1bcbb5"),
                    RecipeId = RecipeSeedUUID.GreekSalad,
                    Name = "Sticky rice",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("19f1391b-6328-41f4-8424-95c833975937"),
                    RecipeId = RecipeSeedUUID.GreekSalad,
                    Name = "Sugar",
                    Quantity = 3m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3ca0fe9f-238a-48e0-a60f-dcca30b5feab"),
                    RecipeId = RecipeSeedUUID.GreekSalad,
                    Name = "Coconut milk",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("75ed3391-bcf7-47bd-a98e-9d776eef93db"),
                    RecipeId = RecipeSeedUUID.Souvlaki,
                    Name = "Lentils",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("18f62ba5-cb62-4ae0-a483-79df88c1dadc"),
                    RecipeId = RecipeSeedUUID.Souvlaki,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("d8f00b59-f3cc-4cff-b999-00c70e6ec86f"),
                    RecipeId = RecipeSeedUUID.Souvlaki,
                    Name = "Carrot",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("a6254264-0fe2-497e-ab13-04c5a3065d98"),
                    RecipeId = RecipeSeedUUID.Souvlaki,
                    Name = "Paprika",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("fd6cc0b3-3bba-4c76-ae24-cb588092512d"),
                    RecipeId = RecipeSeedUUID.Spanakopita,
                    Name = "Fish",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5bafb5b0-f795-4840-944b-c2d40d8d71ab"),
                    RecipeId = RecipeSeedUUID.Spanakopita,
                    Name = "Lime juice",
                    Quantity = 0.5m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a5151250-8162-40c8-a2bf-a4e6e2b40165"),
                    RecipeId = RecipeSeedUUID.Spanakopita,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("ce154470-6889-48fb-8293-160bbd9e75f5"),
                    RecipeId = RecipeSeedUUID.Spanakopita,
                    Name = "Cilantro",
                    Quantity = 0.5m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d8d5516f-b8dd-4ea7-9176-d11b7549a8d3"),
                    RecipeId = RecipeSeedUUID.BaklavaGreek,
                    Name = "Beans",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3098e7e0-cb90-4e5c-93a8-ac4c5db90d56"),
                    RecipeId = RecipeSeedUUID.BaklavaGreek,
                    Name = "Garlic",
                    Quantity = 4m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("c4135e17-4875-4ed7-baa3-dc14ff3a118b"),
                    RecipeId = RecipeSeedUUID.BaklavaGreek,
                    Name = "Bay leaf",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("2bd88e93-ca55-4700-8fbf-bb95adf30a65"),
                    RecipeId = RecipeSeedUUID.BaklavaGreek,
                    Name = "Sausage",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("f369aeeb-81f2-46f0-adb9-30d406745553"),
                    RecipeId = RecipeSeedUUID.ShepherdsPie,
                    Name = "Noodles",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2fe8bb6f-14a5-40f7-8ec9-4e35e370062c"),
                    RecipeId = RecipeSeedUUID.ShepherdsPie,
                    Name = "Beef",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("39d74a1e-6045-41bb-9781-94dd946caaf5"),
                    RecipeId = RecipeSeedUUID.ShepherdsPie,
                    Name = "Spinach",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5b6b6e79-d6fe-45c3-bc16-3b635571b8af"),
                    RecipeId = RecipeSeedUUID.ShepherdsPie,
                    Name = "Sesame oil",
                    Quantity = 1m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("dd0fc91a-04f6-4ea9-b8e3-0a8a38772430"),
                    RecipeId = RecipeSeedUUID.Scones,
                    Name = "Chicken",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("85a09829-aedf-4f08-a1ea-7d81a2dea2b1"),
                    RecipeId = RecipeSeedUUID.Scones,
                    Name = "Garlic",
                    Quantity = 3m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b01532c4-ad4a-43fa-9c2d-380bb697483e"),
                    RecipeId = RecipeSeedUUID.Scones,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("9b1ea305-0387-4c54-a085-d7ef371dc902"),
                    RecipeId = RecipeSeedUUID.Scones,
                    Name = "Salt",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5a8d68ff-4225-4b62-9909-81f77f969821"),
                    RecipeId = RecipeSeedUUID.StickyToffee,
                    Name = "Rice",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("ac966add-796f-4cb0-9cd2-2090caea49a8"),
                    RecipeId = RecipeSeedUUID.StickyToffee,
                    Name = "Coconut milk",
                    Quantity = 1m,
                    Measurement = "can"
                },
                new Ingredient
                {
                    Id = Guid.Parse("396f1be7-f7e3-4b3b-8c2d-c374962f2d83"),
                    RecipeId = RecipeSeedUUID.StickyToffee,
                    Name = "Lime",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("7a7af897-8e13-4a25-95fa-90c3ae4bc1b7"),
                    RecipeId = RecipeSeedUUID.StickyToffee,
                    Name = "Fish sauce",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("68782676-5e4d-4085-abd9-24a78170c6e9"),
                    RecipeId = RecipeSeedUUID.Bibimbap,
                    Name = "Shrimp",
                    Quantity = 12m,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d1f6de7d-cfb7-4161-b8f6-4d3c4921ae8d"),
                    RecipeId = RecipeSeedUUID.Bibimbap,
                    Name = "Lemongrass",
                    Quantity = 2m,
                    Measurement = "stalks"
                },
                new Ingredient
                {
                    Id = Guid.Parse("84f44107-ead1-44a6-85e0-2175a813503b"),
                    RecipeId = RecipeSeedUUID.Bibimbap,
                    Name = "Chili",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("a90f42ad-c6bf-41c8-b8ff-aaf699f7a4fb"),
                    RecipeId = RecipeSeedUUID.Bibimbap,
                    Name = "Broth",
                    Quantity = 4m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6d5ec779-fba1-4bda-be0a-ae23b441f6f5"),
                    RecipeId = RecipeSeedUUID.Tteokbokki,
                    Name = "Tomato",
                    Quantity = 4m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("0ada04f0-717f-4b38-82e6-dc34b91111ed"),
                    RecipeId = RecipeSeedUUID.Tteokbokki,
                    Name = "Olive oil",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6a130297-17e1-4127-ba72-d8c323327775"),
                    RecipeId = RecipeSeedUUID.Tteokbokki,
                    Name = "Basil",
                    Quantity = 1m,
                    Measurement = "bunch"
                },
                new Ingredient
                {
                    Id = Guid.Parse("73f6428e-5197-4a2d-8c65-d2ab7d39cef0"),
                    RecipeId = RecipeSeedUUID.Tteokbokki,
                    Name = "Mozzarella",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7476c93e-cdcb-4e92-bf66-c7738a61c890"),
                    RecipeId = RecipeSeedUUID.Bulgogi,
                    Name = "Flour",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("cdacea4e-1a1c-4182-8b64-ae4c30e667f6"),
                    RecipeId = RecipeSeedUUID.Bulgogi,
                    Name = "Egg",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("b7834ff8-a6b9-4b2a-b83e-b21fa1f6509c"),
                    RecipeId = RecipeSeedUUID.Bulgogi,
                    Name = "Butter",
                    Quantity = 4m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("e43470c7-d4e5-4107-ae8a-7a4b97b39d86"),
                    RecipeId = RecipeSeedUUID.Bulgogi,
                    Name = "Milk",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d8b17bb2-1c89-462e-9737-c1d03f378b54"),
                    RecipeId = RecipeSeedUUID.Japchae,
                    Name = "Beef",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6d7cf730-0fe9-4158-9aff-2f2a4f3280b9"),
                    RecipeId = RecipeSeedUUID.Japchae,
                    Name = "Potato",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("d655d6d8-6874-4513-acd8-18cdfa2b3409"),
                    RecipeId = RecipeSeedUUID.Japchae,
                    Name = "Carrot",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("116901ec-64d6-4d44-8429-122b293a16a5"),
                    RecipeId = RecipeSeedUUID.Japchae,
                    Name = "Stock",
                    Quantity = 3m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4750d51b-2c12-43f3-bba1-87f832d7c4f2"),
                    RecipeId = RecipeSeedUUID.KoreanFriedChicken,
                    Name = "Tofu",
                    Quantity = 14m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1a22f75f-8011-458d-8c1e-9dced5278387"),
                    RecipeId = RecipeSeedUUID.KoreanFriedChicken,
                    Name = "Soy sauce",
                    Quantity = 3m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5bddf991-764e-4286-9ac2-f4e3b91dd729"),
                    RecipeId = RecipeSeedUUID.KoreanFriedChicken,
                    Name = "Ginger",
                    Quantity = 1m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1e19e4fc-772b-4896-85fb-8375f29d083b"),
                    RecipeId = RecipeSeedUUID.KoreanFriedChicken,
                    Name = "Scallion",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("f01a8085-1023-4f3b-b875-f54bf939cb90"),
                    RecipeId = RecipeSeedUUID.Menemen,
                    Name = "Pork",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("65b1308b-82bb-4b70-bdc5-12b80e6aa82e"),
                    RecipeId = RecipeSeedUUID.Menemen,
                    Name = "Cabbage",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("caefcc37-3539-4a61-8211-63bfc7d5300e"),
                    RecipeId = RecipeSeedUUID.Menemen,
                    Name = "Garlic",
                    Quantity = 2m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4f1ef72b-97c6-414e-9572-7629d60815cc"),
                    RecipeId = RecipeSeedUUID.Menemen,
                    Name = "Pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("77233f87-bdb1-4eb8-86c2-5088d9168f61"),
                    RecipeId = RecipeSeedUUID.LentilSoup,
                    Name = "Chickpeas",
                    Quantity = 2m,
                    Measurement = "cans"
                },
                new Ingredient
                {
                    Id = Guid.Parse("f47da9de-5b87-4ac9-8a56-2f20c4ce8000"),
                    RecipeId = RecipeSeedUUID.LentilSoup,
                    Name = "Cumin",
                    Quantity = 2m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("115ed6e4-67c7-4314-a562-51cb2bef4feb"),
                    RecipeId = RecipeSeedUUID.LentilSoup,
                    Name = "Tomato",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("7be8666c-c720-4c1a-a1fc-3f97484099f1"),
                    RecipeId = RecipeSeedUUID.LentilSoup,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("f0bbb15d-c3c1-4374-b20d-2473b7b84978"),
                    RecipeId = RecipeSeedUUID.Lahmacun,
                    Name = "Pasta",
                    Quantity = 12m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1a5afff3-5c2e-4b6c-b0a4-6158890f546b"),
                    RecipeId = RecipeSeedUUID.Lahmacun,
                    Name = "Parmesan",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2de803ff-9a0b-4fdd-943d-cfb024c53172"),
                    RecipeId = RecipeSeedUUID.Lahmacun,
                    Name = "Egg",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("d9a76579-7be8-493e-bb8e-2797655cfbb5"),
                    RecipeId = RecipeSeedUUID.Lahmacun,
                    Name = "Black pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b794fd13-ec6b-472c-8800-1cfca3fbd3b1"),
                    RecipeId = RecipeSeedUUID.Koshari,
                    Name = "Mango",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("c284deb9-ded9-4121-ad1c-2217a72f144d"),
                    RecipeId = RecipeSeedUUID.Koshari,
                    Name = "Sticky rice",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2587295f-dcec-414b-ae2f-b23a93f189f8"),
                    RecipeId = RecipeSeedUUID.Koshari,
                    Name = "Sugar",
                    Quantity = 3m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("ce85140c-f0d1-48d0-b2f3-2e4047b4bda9"),
                    RecipeId = RecipeSeedUUID.Koshari,
                    Name = "Coconut milk",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d67a123a-1b8e-4274-b197-097c4951dec8"),
                    RecipeId = RecipeSeedUUID.FulMedames,
                    Name = "Lentils",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("c3558198-e8ad-4c23-87f0-eb494e41ba37"),
                    RecipeId = RecipeSeedUUID.FulMedames,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("3cbe7b89-9826-4dd2-a2c7-4a910b02e1dd"),
                    RecipeId = RecipeSeedUUID.FulMedames,
                    Name = "Carrot",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("412eb874-a9b2-4fe2-93b6-d8f90ee36c74"),
                    RecipeId = RecipeSeedUUID.FulMedames,
                    Name = "Paprika",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5a5f6258-483b-4fa2-a7ae-9f9f048f2d3c"),
                    RecipeId = RecipeSeedUUID.Taameya,
                    Name = "Fish",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1c344dfd-aeda-419b-98a9-8d796c8d202c"),
                    RecipeId = RecipeSeedUUID.Taameya,
                    Name = "Lime juice",
                    Quantity = 0.5m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("0df40db9-10df-4a8d-b14a-ad1d84a771f5"),
                    RecipeId = RecipeSeedUUID.Taameya,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("0ad35bd3-6fe0-4e53-acee-5a8c4e64600e"),
                    RecipeId = RecipeSeedUUID.Taameya,
                    Name = "Cilantro",
                    Quantity = 0.5m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("f4c5104d-730a-4aa7-a040-79dedd6357af"),
                    RecipeId = RecipeSeedUUID.PaoDeQueijo,
                    Name = "Beans",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7062f949-33b6-4abe-8860-5a6eb78a4520"),
                    RecipeId = RecipeSeedUUID.PaoDeQueijo,
                    Name = "Garlic",
                    Quantity = 4m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3bd72e09-5ce6-4fa0-8503-8c5d4cf342df"),
                    RecipeId = RecipeSeedUUID.PaoDeQueijo,
                    Name = "Bay leaf",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("34daaa1b-ccc1-4e19-8910-38d958309711"),
                    RecipeId = RecipeSeedUUID.PaoDeQueijo,
                    Name = "Sausage",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("32b62e6e-2c33-4e56-af5d-921403418354"),
                    RecipeId = RecipeSeedUUID.Moqueca,
                    Name = "Noodles",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5c9e607f-ee0f-48ae-8e6c-ef244d164968"),
                    RecipeId = RecipeSeedUUID.Moqueca,
                    Name = "Beef",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("0a62f60f-0185-4d0e-9b33-f7b4a1305b7d"),
                    RecipeId = RecipeSeedUUID.Moqueca,
                    Name = "Spinach",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2a73b90a-2457-4791-a602-ca014da6b038"),
                    RecipeId = RecipeSeedUUID.Moqueca,
                    Name = "Sesame oil",
                    Quantity = 1m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4992fbaa-7e10-4d03-9bbe-47155bff962c"),
                    RecipeId = RecipeSeedUUID.Brigadeiro,
                    Name = "Chicken",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("342f2979-c5d1-4cea-bd50-752ce153e3d9"),
                    RecipeId = RecipeSeedUUID.Brigadeiro,
                    Name = "Garlic",
                    Quantity = 3m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("e70cf860-688a-4dd8-8270-1f232e877a56"),
                    RecipeId = RecipeSeedUUID.Brigadeiro,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("86d9da58-e9eb-49ca-9909-2b1960745b40"),
                    RecipeId = RecipeSeedUUID.Brigadeiro,
                    Name = "Salt",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("e437abf8-0621-468a-b372-f6e7a6aea33f"),
                    RecipeId = RecipeSeedUUID.LomoSaltado,
                    Name = "Rice",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("fdfbcc21-0372-4bd1-9822-879734d303a3"),
                    RecipeId = RecipeSeedUUID.LomoSaltado,
                    Name = "Coconut milk",
                    Quantity = 1m,
                    Measurement = "can"
                },
                new Ingredient
                {
                    Id = Guid.Parse("dc9d8270-215e-47de-9061-436dc601b025"),
                    RecipeId = RecipeSeedUUID.LomoSaltado,
                    Name = "Lime",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("3c873754-dcc1-47a4-80c2-1dd4ad1673c8"),
                    RecipeId = RecipeSeedUUID.LomoSaltado,
                    Name = "Fish sauce",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5290d46e-462b-4a19-b582-211920d7feff"),
                    RecipeId = RecipeSeedUUID.CausaLimeña,
                    Name = "Shrimp",
                    Quantity = 12m,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("95aed73a-702d-4c23-a416-cb23fbade7b5"),
                    RecipeId = RecipeSeedUUID.CausaLimeña,
                    Name = "Lemongrass",
                    Quantity = 2m,
                    Measurement = "stalks"
                },
                new Ingredient
                {
                    Id = Guid.Parse("60357375-26a1-4dd9-af59-d29d8e714c59"),
                    RecipeId = RecipeSeedUUID.CausaLimeña,
                    Name = "Chili",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("024fcdd0-6a12-4866-948d-b5e50c04dc8c"),
                    RecipeId = RecipeSeedUUID.CausaLimeña,
                    Name = "Broth",
                    Quantity = 4m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("45ead6d6-3817-4f27-866c-dd2620cfbcfd"),
                    RecipeId = RecipeSeedUUID.ChickenKarahi,
                    Name = "Tomato",
                    Quantity = 4m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("7d2c4903-6d07-40d3-a137-8597372b13d7"),
                    RecipeId = RecipeSeedUUID.ChickenKarahi,
                    Name = "Olive oil",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4ac740d0-bc74-43f2-8b15-d435225ed0d1"),
                    RecipeId = RecipeSeedUUID.ChickenKarahi,
                    Name = "Basil",
                    Quantity = 1m,
                    Measurement = "bunch"
                },
                new Ingredient
                {
                    Id = Guid.Parse("02a9c593-d643-4d4a-82c0-e76523e6b703"),
                    RecipeId = RecipeSeedUUID.ChickenKarahi,
                    Name = "Mozzarella",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7dd69c9a-6338-4a3b-b2c3-6e9bfe2d6a52"),
                    RecipeId = RecipeSeedUUID.Nihari,
                    Name = "Flour",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("ef7976ae-b2a3-47fe-aa82-35f6dde43fd4"),
                    RecipeId = RecipeSeedUUID.Nihari,
                    Name = "Egg",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("aef2109f-e0ec-4dd7-9cc3-c5fed5ab4d4a"),
                    RecipeId = RecipeSeedUUID.Nihari,
                    Name = "Butter",
                    Quantity = 4m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("fe1b5403-7e05-4001-b8a3-053efea16497"),
                    RecipeId = RecipeSeedUUID.Nihari,
                    Name = "Milk",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b486f1e5-c48d-4d23-b8bf-6330d65b283c"),
                    RecipeId = RecipeSeedUUID.MalvaPudding,
                    Name = "Beef",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("437f5ce4-2cfd-4b41-9536-a542d18a9f34"),
                    RecipeId = RecipeSeedUUID.MalvaPudding,
                    Name = "Potato",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("61ae4681-6457-440b-8f64-0dfaa23de509"),
                    RecipeId = RecipeSeedUUID.MalvaPudding,
                    Name = "Carrot",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("35d4e134-34e8-42c3-9644-e8f4cddd525e"),
                    RecipeId = RecipeSeedUUID.MalvaPudding,
                    Name = "Stock",
                    Quantity = 3m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a804c0aa-f31a-46f8-b478-f4a41f76514e"),
                    RecipeId = RecipeSeedUUID.Chakalaka,
                    Name = "Tofu",
                    Quantity = 14m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a80fd76e-f218-4c7b-92b0-d0dcaa0e3fa3"),
                    RecipeId = RecipeSeedUUID.Chakalaka,
                    Name = "Soy sauce",
                    Quantity = 3m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1f1719bf-c63b-454a-88e6-0be1962faa7d"),
                    RecipeId = RecipeSeedUUID.Chakalaka,
                    Name = "Ginger",
                    Quantity = 1m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("852857b7-3bcd-4ff3-8665-53776005536b"),
                    RecipeId = RecipeSeedUUID.Chakalaka,
                    Name = "Scallion",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("51bf7988-a9de-4210-a2dc-e63dda4c3d2d"),
                    RecipeId = RecipeSeedUUID.Bigos,
                    Name = "Pork",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2966f4dc-aa98-4ccf-bc10-c3b61672ae97"),
                    RecipeId = RecipeSeedUUID.Bigos,
                    Name = "Cabbage",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("f600452f-9d37-4128-8912-5a32129f7ae3"),
                    RecipeId = RecipeSeedUUID.Bigos,
                    Name = "Garlic",
                    Quantity = 2m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8b892c7b-aa56-4870-a3dd-b0bbafaaa483"),
                    RecipeId = RecipeSeedUUID.Bigos,
                    Name = "Pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6b028e98-b45f-44fa-aa2c-253bc5462df8"),
                    RecipeId = RecipeSeedUUID.Zurek,
                    Name = "Chickpeas",
                    Quantity = 2m,
                    Measurement = "cans"
                },
                new Ingredient
                {
                    Id = Guid.Parse("71a042fd-af78-43bf-a7de-4647977d0a32"),
                    RecipeId = RecipeSeedUUID.Zurek,
                    Name = "Cumin",
                    Quantity = 2m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("168503f2-c4b9-493b-80f5-d9b70a41eb06"),
                    RecipeId = RecipeSeedUUID.Zurek,
                    Name = "Tomato",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("f5a18c07-e5b7-464c-9564-2245b0c29b7b"),
                    RecipeId = RecipeSeedUUID.Zurek,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("aed52cbc-742a-48c5-954e-34bf41f119a1"),
                    RecipeId = RecipeSeedUUID.Borscht,
                    Name = "Pasta",
                    Quantity = 12m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("be12a304-3f0b-4e55-8dd2-a2cb11a295d4"),
                    RecipeId = RecipeSeedUUID.Borscht,
                    Name = "Parmesan",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6f900552-358a-4f77-8955-0debcedb48c5"),
                    RecipeId = RecipeSeedUUID.Borscht,
                    Name = "Egg",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("f03d540a-6c96-4590-884d-dbc9857fa51b"),
                    RecipeId = RecipeSeedUUID.Borscht,
                    Name = "Black pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8e5887b6-34b6-4e3a-864f-3f775038f6ac"),
                    RecipeId = RecipeSeedUUID.Pelmeni,
                    Name = "Mango",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("7646fae7-6c91-481f-8062-7cce8366b215"),
                    RecipeId = RecipeSeedUUID.Pelmeni,
                    Name = "Sticky rice",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1cb2c0ff-e196-4351-aa75-8094e3b9422a"),
                    RecipeId = RecipeSeedUUID.Pelmeni,
                    Name = "Sugar",
                    Quantity = 3m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("636ef644-3338-4b3d-836f-9df16e0772bc"),
                    RecipeId = RecipeSeedUUID.Pelmeni,
                    Name = "Coconut milk",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("effb4dc2-8ad3-480d-be3f-2c4756f45dba"),
                    RecipeId = RecipeSeedUUID.Paella,
                    Name = "Lentils",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3fba9d4b-7735-4120-982c-095937b3c2ec"),
                    RecipeId = RecipeSeedUUID.Paella,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("c6b60236-9f05-457f-aea5-38966a28c0be"),
                    RecipeId = RecipeSeedUUID.Paella,
                    Name = "Carrot",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("adb74375-b3c7-49dc-8015-3169876a1dd5"),
                    RecipeId = RecipeSeedUUID.Paella,
                    Name = "Paprika",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a5c3bc7b-c29a-4884-96e9-0dd9b8961687"),
                    RecipeId = RecipeSeedUUID.Gazpacho,
                    Name = "Fish",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("88c73541-4bfe-481a-ad2a-355b677083ba"),
                    RecipeId = RecipeSeedUUID.Gazpacho,
                    Name = "Lime juice",
                    Quantity = 0.5m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1c7025ab-df99-4a36-a483-004e9eddc841"),
                    RecipeId = RecipeSeedUUID.Gazpacho,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("948c8b83-5635-4deb-b72a-c98a19782991"),
                    RecipeId = RecipeSeedUUID.Gazpacho,
                    Name = "Cilantro",
                    Quantity = 0.5m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("776fad02-c969-4b63-a765-0f075cf62786"),
                    RecipeId = RecipeSeedUUID.Schnitzel,
                    Name = "Beans",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("0a24962a-a132-4f56-86de-e653f7755655"),
                    RecipeId = RecipeSeedUUID.Schnitzel,
                    Name = "Garlic",
                    Quantity = 4m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("10db0e01-77b9-4af5-87ee-f66b1cb77bb9"),
                    RecipeId = RecipeSeedUUID.Schnitzel,
                    Name = "Bay leaf",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("9b3ca8ed-505c-42f5-8525-aee46d11925e"),
                    RecipeId = RecipeSeedUUID.Schnitzel,
                    Name = "Sausage",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("e7ca21bd-5201-43f8-95bc-6a16840feada"),
                    RecipeId = RecipeSeedUUID.Pretzels,
                    Name = "Noodles",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1c7c4d97-c71d-4f38-ac78-b3a36dcf18f2"),
                    RecipeId = RecipeSeedUUID.Pretzels,
                    Name = "Beef",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("ff2d7f2b-852b-475d-a8ef-36dd067d1842"),
                    RecipeId = RecipeSeedUUID.Pretzels,
                    Name = "Spinach",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("fbe76f13-6c2f-4fc7-8a9a-6d2384087a6b"),
                    RecipeId = RecipeSeedUUID.Pretzels,
                    Name = "Sesame oil",
                    Quantity = 1m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4d22e59a-d29e-454f-aa37-9b0121609f86"),
                    RecipeId = RecipeSeedUUID.Tagine,
                    Name = "Chicken",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("aa331df7-ebe1-4934-bfe3-fd50a5996ccb"),
                    RecipeId = RecipeSeedUUID.Tagine,
                    Name = "Garlic",
                    Quantity = 3m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8e3b7512-6897-4e26-bf05-299529e961e0"),
                    RecipeId = RecipeSeedUUID.Tagine,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("a6484247-f401-4151-8d2e-2f1503f16532"),
                    RecipeId = RecipeSeedUUID.Tagine,
                    Name = "Salt",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9eeac921-5cce-403e-9eab-0086519d72d3"),
                    RecipeId = RecipeSeedUUID.JollofRice,
                    Name = "Rice",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8d82f0af-a3c5-4c27-b56d-8f5e7d610358"),
                    RecipeId = RecipeSeedUUID.JollofRice,
                    Name = "Coconut milk",
                    Quantity = 1m,
                    Measurement = "can"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8d92983c-7a52-4d20-8d6b-6b2d446f9e55"),
                    RecipeId = RecipeSeedUUID.JollofRice,
                    Name = "Lime",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("dbec1b60-fbec-4011-8087-db8de3b04bce"),
                    RecipeId = RecipeSeedUUID.JollofRice,
                    Name = "Fish sauce",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6f1e8d45-6b3f-4091-b5a5-49dc07c2bcc2"),
                    RecipeId = RecipeSeedUUID.JerkChicken,
                    Name = "Shrimp",
                    Quantity = 12m,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("bf8f00cb-01d0-4d74-af66-de4eebcc2b45"),
                    RecipeId = RecipeSeedUUID.JerkChicken,
                    Name = "Lemongrass",
                    Quantity = 2m,
                    Measurement = "stalks"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5d15ecc0-607a-4436-b7d8-628b9675d74d"),
                    RecipeId = RecipeSeedUUID.JerkChicken,
                    Name = "Chili",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("2c2a0b3b-a1d7-47a5-ae81-f0768fdc473c"),
                    RecipeId = RecipeSeedUUID.JerkChicken,
                    Name = "Broth",
                    Quantity = 4m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9b486720-8e10-493e-84e4-e28ce110e27f"),
                    RecipeId = RecipeSeedUUID.Empanadas,
                    Name = "Tomato",
                    Quantity = 4m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("d9697253-4a1e-41e2-bba1-0b9a21fb839a"),
                    RecipeId = RecipeSeedUUID.Empanadas,
                    Name = "Olive oil",
                    Quantity = 2m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("102e1220-f8e8-4e43-8d88-d1c5bafe4b1f"),
                    RecipeId = RecipeSeedUUID.Empanadas,
                    Name = "Basil",
                    Quantity = 1m,
                    Measurement = "bunch"
                },
                new Ingredient
                {
                    Id = Guid.Parse("0dba3364-1418-4ce9-b87e-f17b5be6a19c"),
                    RecipeId = RecipeSeedUUID.Empanadas,
                    Name = "Mozzarella",
                    Quantity = 8m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4a9806b3-ce15-4dc7-86fe-33e338546148"),
                    RecipeId = RecipeSeedUUID.Adobo,
                    Name = "Flour",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3f1c50f4-e8b0-41c0-8174-361d321f4197"),
                    RecipeId = RecipeSeedUUID.Adobo,
                    Name = "Egg",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("c7b72d88-2aaa-4cb3-a78e-382382c50045"),
                    RecipeId = RecipeSeedUUID.Adobo,
                    Name = "Butter",
                    Quantity = 4m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("98e65128-bf78-42ab-9532-3a17285cde4b"),
                    RecipeId = RecipeSeedUUID.Adobo,
                    Name = "Milk",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("f7e8c92f-c7cd-4e9e-a365-68ac32dd7118"),
                    RecipeId = RecipeSeedUUID.Bacalhau,
                    Name = "Beef",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("abfd34f5-8064-4f8d-ab6f-82c0d21d839d"),
                    RecipeId = RecipeSeedUUID.Bacalhau,
                    Name = "Potato",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("d39cd713-6874-4445-afc5-e901dae74577"),
                    RecipeId = RecipeSeedUUID.Bacalhau,
                    Name = "Carrot",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("86310f1f-e757-4362-bd8f-4e3c5542695a"),
                    RecipeId = RecipeSeedUUID.Bacalhau,
                    Name = "Stock",
                    Quantity = 3m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2cab8231-1c58-40f1-9dc0-86844f7dca72"),
                    RecipeId = RecipeSeedUUID.Poutine,
                    Name = "Tofu",
                    Quantity = 14m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("56fe9a5b-7e77-48a5-8317-1931193b6210"),
                    RecipeId = RecipeSeedUUID.Poutine,
                    Name = "Soy sauce",
                    Quantity = 3m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("99d65095-0032-4fbc-8cd1-34f3dfe14ab3"),
                    RecipeId = RecipeSeedUUID.Poutine,
                    Name = "Ginger",
                    Quantity = 1m,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1689149f-9ec5-4451-b5c8-8ef6ca373c77"),
                    RecipeId = RecipeSeedUUID.Poutine,
                    Name = "Scallion",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("c9ff9e78-706a-41fc-9837-dc180cf73911"),
                    RecipeId = RecipeSeedUUID.Pavlova,
                    Name = "Pork",
                    Quantity = 1m,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d1cc8c97-3496-49b3-a9b2-3963b0b6a1d4"),
                    RecipeId = RecipeSeedUUID.Pavlova,
                    Name = "Cabbage",
                    Quantity = 2m,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("59412b55-0f3f-4ce4-9a19-27337fb2e733"),
                    RecipeId = RecipeSeedUUID.Pavlova,
                    Name = "Garlic",
                    Quantity = 2m,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6cc39aac-abf6-4e29-a1ee-4d13b45619da"),
                    RecipeId = RecipeSeedUUID.Pavlova,
                    Name = "Pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4ee1a09b-43c8-4f65-a714-ae87682f376f"),
                    RecipeId = RecipeSeedUUID.Arepa,
                    Name = "Chickpeas",
                    Quantity = 2m,
                    Measurement = "cans"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8c737756-36b0-4824-b103-a6b37f90433f"),
                    RecipeId = RecipeSeedUUID.Arepa,
                    Name = "Cumin",
                    Quantity = 2m,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b356662b-8e01-479c-9211-e96d1856462a"),
                    RecipeId = RecipeSeedUUID.Arepa,
                    Name = "Tomato",
                    Quantity = 2m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("c4a96c00-7608-47f3-b6fe-cd951ffd6e1e"),
                    RecipeId = RecipeSeedUUID.Arepa,
                    Name = "Onion",
                    Quantity = 1m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("acda0171-44d1-42b1-9dcf-60d75a1a9a74"),
                    RecipeId = RecipeSeedUUID.IrishStew,
                    Name = "Pasta",
                    Quantity = 12m,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("e9a77142-2286-403d-bfdd-835ebe180918"),
                    RecipeId = RecipeSeedUUID.IrishStew,
                    Name = "Parmesan",
                    Quantity = 1m,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6356ea8c-bfed-4d77-9fbe-7c1df9a31d0a"),
                    RecipeId = RecipeSeedUUID.IrishStew,
                    Name = "Egg",
                    Quantity = 3m,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("4d893fe3-caeb-45fe-b9eb-6aec26b81b50"),
                    RecipeId = RecipeSeedUUID.IrishStew,
                    Name = "Black pepper",
                    Quantity = 1m,
                    Measurement = "tsp"
                }
            };
        }
    }
}