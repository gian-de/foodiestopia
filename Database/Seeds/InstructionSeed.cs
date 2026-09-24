using foodiestopia.Models;

namespace foodiestopia.Database.Seeds
{
    public static class InstructionSeed
    {
        public static IEnumerable<Instruction> GetInstructions()
        {
            return new List<Instruction>()
            {
                // start Low Cal Pizza
                new Instruction
                {
                    Id = Guid.Parse("a1d3bbaf-1132-4111-b558-2e027fab8926"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Text = "Crack eggs and add to mixing bowl.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7cc01c97-66e0-40e3-9e0b-67cb7e5bba8c"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Text = "Whisk until eggs form into a foam-like white texture.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("dbb31e0c-0758-40a2-a7fb-d7e2499befa0"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Text = "Add arrowroot starch to mixing bowl and other spices of your choosing.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("19e6a008-bc94-4bff-8fd7-8b633712f9b9"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Text = "Place inside the over that has been preheated to 350 degrees Fahrenheit for 8-10 minutes.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("e662eb34-f212-424e-a5c5-186954c01f4a"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Text = "Layer the sauce, then the cheese and lastly the toppings.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("bc6b146f-9f96-4e1f-8cc0-26b139d5ef1a"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Text = "Place back into the over for 12-15 minutes.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("53c53fa8-b7c7-47aa-8bd4-6880cee51f01"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Text = "Let the pizza cool for at least 5 minutes and enjoy!",
                    Order = 7
                },
                // end Low Cal Pizza

                // start Classic Cheeseburger
                new Instruction
                {
                    Id = Guid.Parse("a3a2d1d5-b8d2-4095-9dab-a6ece4e8a12b"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Text = "Shape ground beef into four patties.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("2470414b-0fb5-4714-807f-bd0e58961f2d"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Text = "Grill patties for 3-4 minutes per side.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("d0f47451-500b-45b5-bfdd-610c268e815b"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Text = "Place cheddar cheese slices on patties to melt.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("1333c52f-b6a9-499d-a34a-c9ca5b2da74e"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Text = "Toast burger buns lightly on the grill.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("53774383-64e6-4fc6-a307-3316e2f2527d"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Text = "Assemble burgers with lettuce, patties, and toppings of choice.",
                    Order = 5
                },
                // end Classic Cheeseburger

                // start Tacos al Pastor
                new Instruction
                {
                    Id = Guid.Parse("a8d91f07-ba9d-4bc2-a648-3e19e2863559"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Text = "Marinate pork in adobo sauce for 4 hours.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("5122c450-7627-47f4-a1cd-aa2fe8773ebf"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Text = "Grill pork until fully cooked and slightly charred.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("7d465672-a6a1-4981-af70-6f3d9754370a"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Text = "Chop grilled pork into bite-sized pieces.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("f7542ebf-4f93-4556-93ee-8a2184a7fddc"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Text = "Warm tortillas on a skillet or grill.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("03e9f8e6-539c-41e7-a041-8af500790ba7"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Text = "Assemble tacos with pork, pineapple, and toppings of choice.",
                    Order = 5
                },
                // end Tacos al Pastor

                // start Chicken Biryani
                new Instruction
                {
                    Id = Guid.Parse("ebc08345-ecbc-43cc-a371-ed082f332976"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Text = "Marinate chicken with yogurt and spices for 2 hours.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("4f6b3424-78dd-4b4d-af57-d001e42bc3c3"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Text = "Cook basmati rice until half-cooked and drain.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("b6790a8b-3c8a-4905-849b-d80ca468096f"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Text = "Layer chicken and rice in a pot, adding fried onions.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("43f35046-194d-414c-909c-ec7a0fad643c"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Text = "Seal the pot with a lid and cook on low heat for 30 minutes.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("7ab0a7aa-0a00-4cc0-90f8-e4c808962230"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Text = "Fluff rice and serve hot with raita.",
                    Order = 5
                },
                // end Chicken Biryani

                // start Pecking Duck
                new Instruction
                {
                    Id = Guid.Parse("e8f2d9d7-b6c7-4c9e-b79f-75d19a5f5f8b"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Text = "Clean and dry the duck thoroughly.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("db49a2e1-4f37-4b5d-b8a1-6a9cbf3e43c6"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Text = "Roast the duck in the oven at 375°F until crispy.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("5c8a2f37-dc8b-4c69-a8a1-6c35e8c7b4f3"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Text = "Slice the duck into thin pieces.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("d4b29f68-4e8b-4a5f-a2c8-7b34f9e6c3a5"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Text = "Spread hoisin sauce on the pancakes.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("6b8c3d74-5c4a-4b8d-b3a7-9f6e5c8a2d5b"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Text = "Assemble pancakes with duck, scallions, and serve.",
                    Order = 5
                },
                // end Pecking Duck

                // start Beef Stroganoff
                new Instruction
                {
                    Id = Guid.Parse("9f7a6e5b-3c4d-8a1f-7b2d-5a6e7c8b9e12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Text = "Cook beef in a pan until browned, then set aside.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7a9f5c6e-4e3d-8a1f-7b2d-9b6e7f5a7b12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Text = "Sauté onions and mushrooms in the same pan.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("8b7c9e5a-3c4d-8a1f-7b2d-9e6f7b5a3b12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Text = "Add beef back into the pan and stir in beef broth.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("6c9e7f3b-3c4d-8a1f-7b2d-5f7b9c6a3f12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Text = "Stir in sour cream and simmer for 5 minutes.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("5a6f9c8e-3c4d-8a1f-7b2d-9e7f6b7a5e12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Text = "Serve over egg noodles or rice.",
                    Order = 5
                },
                // end Beef Stroganoff
                
                // start Feijoada
                new Instruction
                {
                    Id = Guid.Parse("7b24c93f-4f3d-4c92-93a7-3b25d9e8f4a2"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Text = "Soak black beans in water overnight.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("1cf7d59b-3a6f-4c35-b8e2-9c7245b39f8c"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Text = "Cook black beans with bay leaves until tender.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("4e9b3d82-7f6c-4d5f-83a2-7c38b25f9b6d"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Text = "Sear sausage and pork ribs in a skillet.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("6c82d49f-3b6e-4c7f-93f5-8b25d39c7e48"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Text = "Combine meats with cooked beans and simmer.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("1f7b49c3-83e5-4c6b-b724-9d38c35a9f8d"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Text = "Serve hot with white rice and orange slices.",
                    Order = 5
                },
                // end Feijoada

                // start Sushi
                new Instruction
                {
                    Id = Guid.Parse("aa70a518-abf1-40d5-b54f-13863ef82212"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Text = "Cook sushi rice and season with rice vinegar.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("4980a006-6a16-4788-bc52-c1aab9215845"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Text = "Place a nori sheet on a bamboo mat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("bf1e4571-675f-44bf-9f3e-b8e572d0a7d1"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Text = "Spread rice evenly on the nori, leaving an edge.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("62f1b272-5cbf-4ba8-9ad6-2abdd4f1b865"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Text = "Add fresh salmon and roll tightly.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("2ada858b-3049-488e-891e-7c4eca8ea28f"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Text = "Slice roll into bite-sized pieces and serve with soy sauce.",
                    Order = 5
                },
                // end Sushi

                // start Pad Thai
                new Instruction
                {
                    Id = Guid.Parse("d9eac06b-58d7-41c2-b6db-6d14e98e3914"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Text = "Soak rice noodles in warm water until softened.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("a68d3b3f-2460-49ff-a469-15d5b0f8c03c"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Text = "Cook shrimp in a hot wok until pink, then set aside.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("e349c5be-9f1c-4fbf-8497-142e6c64e2cc"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Text = "Add soaked noodles to the wok with Pad Thai sauce.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("c915df33-f7c6-4f55-ae59-9b8d1e36d446"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Text = "Stir in shrimp and bean sprouts.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("96e0bcb2-49f6-4745-8125-5c63e136f5b7"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Text = "Serve hot with lime wedges and crushed peanuts.",
                    Order = 5
                },
                // end Pad Thai

                // start Pho
                new Instruction
                {
                    Id = Guid.Parse("2f5b7c4a-6e8d-3f92-83b9-7a39e2c5d8f6"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Text = "Cook rice noodles according to package instructions.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("5a39e7d6-4f92-3b8c-83f7-7d2e5b6f4a3c"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Text = "Heat beef broth and bring to a gentle boil.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("7c5b92e6-3f4a-96d7-2b8f-5a39e4f7c8d3"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Text = "Add thinly sliced beef to the hot broth.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("8d4b3f5a-7e96-2b8f-83c9-4a7d5c39f6e2"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Text = "Combine cooked noodles and broth in a bowl.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("3f6b7c92-5a9d-4b2e-96e7-4a39f5d8c7e3"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Text = "Garnish with bean sprouts, herbs, and lime wedges.",
                    Order = 5
                },
                // end Pho

                // start Ceviche
                new Instruction
                {
                    Id = Guid.Parse("8f5b9c4a-3d7e-6a2f-7f3b-4c9a7f5e8b6d"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Text = "In a bowl, combine fish and lime juice.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7d4c9b6f-3e8a-5f2f-7f3a-9c5e7b4a6f8d"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Text = "Let the fish marinate in the lime juice for 10 minutes.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("6a7c5f3d-9b4e-8f2f-7f9d-3b5e7a4c8f6d"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Text = "Add sliced red onion and cilantro to the marinated fish.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("5e9a7b6f-4c3a-8f2f-7f5d-3b9c7e6a4f8d"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Text = "Toss everything together gently.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("4b7a6f9e-3d5c-8f2f-7f3a-9c5e7b4a8f6d"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Text = "Serve immediately with tortilla chips or on its own.",
                    Order = 5
                },
                // end Ceviche

                // start Kebab
                new Instruction
                {
                    Id = Guid.Parse("d3a97b62-fab2-4e8a-96fc-1b8a49f7e283"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Text = "Combine ground lamb, grated onion, cumin, and salt in a bowl.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7a96b41d-e289-4cf8-b27a-6f91c3b7d0f4"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Text = "Shape the mixture into long, thin patties or onto skewers.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("f4d7293a-5b9f-4e91-8a2c-7b18d6e2f049"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Text = "Preheat grill or grill pan to medium-high heat.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("9b3c78fa-6d8e-4a1f-b2d7-3a9c47e6f0a8"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Text = "Cook kebabs for 3-4 minutes on each side until fully cooked.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("6f8c4a97-b5e3-4981-9d2a-7e0f9c3a621b"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Text = "Serve with flatbread, yogurt, and fresh vegetables.",
                    Order = 5
                },
                // end Kebab

                // start Butter Chicken
                new Instruction
                {
                    Id = Guid.Parse("5e9a7f6d-b34c-4f91-8a7d-9b6f2a0c7f18"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Text = "Melt butter in a skillet over medium heat.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("6f7c4b5d-a92e-8f31-7b9d-3a9c7e6f4d12"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Text = "Add chicken and cook until browned.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("7b8f9a3d-4e6f-1b2c-7a5f-6c9f4e7d3a18"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Text = "Stir in tomato puree and heavy cream.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("4a3d5e6b-9f8c-7a1f-3b7d-9e6f4a91c5b8"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Text = "Simmer on low heat for 10-15 minutes.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("6f5b7d9e-3a2c-8f1b-9d7a-4e6c9a5f8b12"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Text = "Serve with basmati rice or naan bread.",
                    Order = 5
                },
                // end Butter Chicken

                // start Bobotie
                new Instruction
                {
                    Id = Guid.Parse("7b6f9a4e-3a8c-5f1d-9e2b-6a7d4f3e5c9a"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Text = "Preheat the oven to 350°F (175°C).",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("5f3b7d4a-9e8c-6a1f-7b2d-3f6e5c9a7b18"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Text = "Sauté onions in a skillet until translucent.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("3e7f5b9a-1c4d-6a8b-9f2e-5a6d7b4c9f18"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Text = "Mix onions, ground beef, bread, and curry powder in a bowl.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("9e3f6b7a-4a1d-7c5b-9f8e-6a3d5f7b8c12"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Text = "Transfer the mixture to a greased baking dish.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("4f3b9d7a-6a8c-5e1f-7b2d-3f9a5c7e8b18"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Text = "Bake for 30-40 minutes until golden brown.",
                    Order = 5
                },
                // end Bobotie

                // start Kimchi
                new Instruction
                {
                    Id = Guid.Parse("6a7b9d3f-5e8c-4f1b-7a2d-9c6e3f5b7a18"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Text = "Chop cabbage and sprinkle with salt. Let it sit for 2 hours.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("3e5b7a4c-9f6d-7b1f-7a2d-6a8c9e5f3b12"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Text = "Rinse the cabbage thoroughly to remove excess salt.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("9f6c7b3a-4d5e-8a1f-7b2c-6e9a5f7b3c18"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Text = "Mix cabbage with chili flakes, garlic, and water to create a paste.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("4a7d5b6f-3c9e-7a1f-7b2d-6f9c5e7a3b18"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Text = "Pack the mixture tightly into a jar.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("7e3f5b9a-4a6c-8f1d-7b2d-3f9c5e7a6b12"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Text = "Ferment at room temperature for 3-5 days, then refrigerate.",
                    Order = 5
                },
                // end Kimchi

                // start Pierogi
                new Instruction
                {
                    Id = Guid.Parse("5e7b9c6a-3d4f-8a1b-7f2c-9a6f5b3e7a12"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Text = "Mix flour, egg, and water to form a dough. Knead until smooth.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("9f3b7e5a-6d4c-8a1f-7b2d-3f6a7b5c9e12"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Text = "Roll out dough and cut into circles using a cookie cutter.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("4f7c9a6e-5d3b-1a8f-7b2c-9e6a5f3b7a18"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Text = "Spoon mashed potato and cheese filling onto each circle.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("3e7b9f6c-5a4d-8a1f-7b2c-6a9e5f7c3b12"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Text = "Fold the dough over the filling and pinch edges to seal.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("7a6f5b9e-3c4d-8a1f-7b2d-6f9c5e3b7a18"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Text = "Boil in salted water for 5-7 minutes, then serve warm.",
                    Order = 5
                },
                // end Pierogi

                // start Fish and Chips
                new Instruction
                {
                    Id = Guid.Parse("7a9c6f5b-3e4d-8a1f-7b2d-9f6e5b3a7c12"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Text = "Heat oil in a deep fryer or heavy skillet.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("3e7f5b9a-6c4d-8a1f-7b2d-6f9a7b5c3e18"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Text = "Coat fish fillets with flour, then dip in batter.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("6a9b5f7c-3e4d-8a1f-7b2d-9f6e7c5a3b18"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Text = "Fry the fish in hot oil until golden brown.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("4b7a6f3e-5c9d-1a8f-7b2c-6e9a5f3b7a18"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Text = "Fry the potato fries until crispy and golden.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("9f6a5b7e-3c4d-8a1f-7b2d-6e9a5c3f7b12"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Text = "Serve fish and chips together with tartar sauce.",
                    Order = 5
                },
                // end Fish and Chips

                // start Moussaka
                new Instruction
                {
                    Id = Guid.Parse("8a9b7f6c-3e4d-1a8f-7b2d-6e9a5c7b3f12"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Text = "Preheat oven to 375°F (190°C).",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("3b6e7a5f-9c4d-8a1f-7b2d-5e7f9a6c3b12"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Text = "Cook eggplant slices in olive oil until soft and lightly browned.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("7e5a6f3b-9c4d-8a1f-7b2d-6a9f5c7e3b18"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Text = "Cook ground lamb with diced tomatoes and season to taste.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("9e7b5a6f-3c4d-8a1f-7b2d-5f9a6e7b3a12"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Text = "Layer eggplants and lamb mixture in a baking dish.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("5b9e7a6f-3c4d-8a1f-7b2d-6e7a5f3b9c18"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Text = "Top with béchamel sauce and bake for 30-40 minutes.",
                    Order = 5
                },
                // end Moussaka

                // start Lasagna
                new Instruction
                {
                    Id = Guid.Parse("7f5a6e9b-3c4d-8a1f-7b2d-9e6a5c7f3b12"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Text = "Preheat oven to 375°F (190°C).",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("9b5e7f6a-3c4d-8a1f-7b2d-6a7c9e5f3b18"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Text = "Cook lasagna noodles according to package instructions.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("3e9a6b7f-5c4d-8a1f-7b2d-5f7c9a6e3b12"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Text = "Cook ground beef and season with garlic and spices.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("6b5a9f7e-3c4d-8a1f-7b2d-9c7f6a5b3e12"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Text = "Layer noodles, ricotta, beef, and mozzarella in a baking dish.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("5f6b9e7a-3c4d-8a1f-7b2d-6e9a7b5c3f12"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Text = "Bake for 35-40 minutes, then let rest before serving.",
                    Order = 5
                },
                // end Lasagna

                // start Croissant
                new Instruction
                {
                    Id = Guid.Parse("5f7e9a6b-3c4d-8a1f-7b2d-6a9f7b5c3e12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Text = "Dissolve yeast in warm milk and let it activate.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7b6f5a9e-3c4d-8a1f-7b2d-9e6f3a5c7b12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Text = "Mix flour, sugar, salt, and milk mixture into a dough.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("9e7a6f3b-5c4d-8a1f-7b2d-5a6e9f7b3c12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Text = "Fold butter into the dough and roll out several times.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("6a5e9f7b-3c4d-8a1f-7b2d-7b5f9e6c3a12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Text = "Shape into croissants and let them proof until doubled.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("7f5b6a9e-3c4d-8a1f-7b2d-9e6a3f7b5c12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Text = "Bake at 400°F (200°C) until golden brown and flaky.",
                    Order = 5
                },
                // end Croissant

                // start Shawarma
                new Instruction
                {
                    Id = Guid.Parse("6a9f7e5b-3c4d-8a1f-7b2d-8f6b7c9f3e12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Text = "Mix yogurt, garlic, cumin, and olive oil to create marinade.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("8b9f7e5a-3c4d-8a1f-7b2d-5c7e6a5f3b12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Text = "Marinate chicken in the mixture for at least 2 hours.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("9c8a5b7f-3c4d-8a1f-7b2d-6f7a5c9b3a12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Text = "Grill chicken on medium-high heat for about 5-7 minutes per side.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("4f6e8c7b-3c4d-8a1f-7b2d-9e5a7f9b3c12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Text = "Rest chicken for a few minutes, then slice thinly.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("7b9f6c7e-3c4d-8a1f-7b2d-5a9e6b7c9f12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Text = "Serve with pita and your favorite toppings.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("2c5ed9c4-429e-4205-8061-beb0cd6efc8d"),
                    RecipeId = RecipeSeedUUID.TomYumGoong,
                    Text = "Prep ingredients for Tom Yum Goong.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("afedff87-0207-421e-8415-d76868988821"),
                    RecipeId = RecipeSeedUUID.TomYumGoong,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("9e8d3dff-14a5-4e43-b9f8-318c9e95b04e"),
                    RecipeId = RecipeSeedUUID.TomYumGoong,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("c8555053-1988-4743-b7ce-a22e2d95997b"),
                    RecipeId = RecipeSeedUUID.TomYumGoong,
                    Text = "Season and cook until Tom Yum Goong is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("88eb6f5c-6b0f-4b2d-9406-eea0a06e8fd1"),
                    RecipeId = RecipeSeedUUID.TomYumGoong,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("5cb50741-86b5-4fc6-99d4-ab04ab142586"),
                    RecipeId = RecipeSeedUUID.TomYumGoong,
                    Text = "Plate Tom Yum Goong and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("3bbb8efa-78c6-4126-9128-bdfe7ab9f756"),
                    RecipeId = RecipeSeedUUID.GreenCurry,
                    Text = "Prep ingredients for Thai Green Curry.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("0c8b9da5-8694-451d-9f70-f748c5655f54"),
                    RecipeId = RecipeSeedUUID.GreenCurry,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("c1323ecb-33ca-4be3-8249-1ec6fe656810"),
                    RecipeId = RecipeSeedUUID.GreenCurry,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("cf440453-4175-4068-8e61-b1878494a6ac"),
                    RecipeId = RecipeSeedUUID.GreenCurry,
                    Text = "Season and cook until Thai Green Curry is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("7903f72b-a79f-47f5-9a03-bec36c24e8a0"),
                    RecipeId = RecipeSeedUUID.GreenCurry,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("6e22575f-e0b2-44b8-8960-09431f61f03f"),
                    RecipeId = RecipeSeedUUID.GreenCurry,
                    Text = "Plate Thai Green Curry and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("5d06cb33-9cf9-4f65-a762-db5f35a16f9b"),
                    RecipeId = RecipeSeedUUID.MassamanCurry,
                    Text = "Prep ingredients for Massaman Curry.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("e352ae0e-25fd-4e19-93a2-dde2353f86b1"),
                    RecipeId = RecipeSeedUUID.MassamanCurry,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("52ce5ac6-0ed2-47c4-bdcc-b2ad767f7c41"),
                    RecipeId = RecipeSeedUUID.MassamanCurry,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("80efb4b8-0f9f-4404-a2df-18e02606cc86"),
                    RecipeId = RecipeSeedUUID.MassamanCurry,
                    Text = "Season and cook until Massaman Curry is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("04f11cbd-7b73-428b-be88-9993bded2efb"),
                    RecipeId = RecipeSeedUUID.MassamanCurry,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("c4ab1e2d-5e63-4f0e-810c-c3f61b5e058f"),
                    RecipeId = RecipeSeedUUID.MassamanCurry,
                    Text = "Plate Massaman Curry and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("a9c82257-17a7-46a8-8e34-87ca7c3f4e44"),
                    RecipeId = RecipeSeedUUID.SomTam,
                    Text = "Prep ingredients for Som Tam.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("040b9177-dbbb-4e9e-923b-754a01e0a1b1"),
                    RecipeId = RecipeSeedUUID.SomTam,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("51f6d5bc-6a43-41eb-a11b-c9f00374cea4"),
                    RecipeId = RecipeSeedUUID.SomTam,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("c01f5e78-0bc4-4617-be5c-6cb88fc4da89"),
                    RecipeId = RecipeSeedUUID.SomTam,
                    Text = "Season and cook until Som Tam is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("b3f7ad34-580d-4f12-895c-c527b9b93e0e"),
                    RecipeId = RecipeSeedUUID.SomTam,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("b2df399c-2111-4b96-aae0-8c364b7f37a0"),
                    RecipeId = RecipeSeedUUID.SomTam,
                    Text = "Plate Som Tam and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("e142adf6-f47d-4168-94e2-4c7e028e53ed"),
                    RecipeId = RecipeSeedUUID.MangoStickyRice,
                    Text = "Prep ingredients for Mango Sticky Rice.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("4ed42002-7689-4a68-96b8-b75024f5d27f"),
                    RecipeId = RecipeSeedUUID.MangoStickyRice,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("788fe5a9-0f65-4c0e-8cef-af2af2cfa4f7"),
                    RecipeId = RecipeSeedUUID.MangoStickyRice,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("8d71d1b7-c116-4576-83e1-2638f412da87"),
                    RecipeId = RecipeSeedUUID.MangoStickyRice,
                    Text = "Season and cook until Mango Sticky Rice is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("9c1fae8a-8ca5-4209-a935-0f7294bac670"),
                    RecipeId = RecipeSeedUUID.MangoStickyRice,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("d00ef058-61fc-46ff-ae9b-08db168b652b"),
                    RecipeId = RecipeSeedUUID.MangoStickyRice,
                    Text = "Plate Mango Sticky Rice and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("c219cb5e-6d60-4d72-86d7-db4e5a479684"),
                    RecipeId = RecipeSeedUUID.ThaiBasilChicken,
                    Text = "Prep ingredients for Thai Basil Chicken.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("66aa0e1e-366c-4841-9911-9853f082faf3"),
                    RecipeId = RecipeSeedUUID.ThaiBasilChicken,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("a3399a05-d416-45a4-afc3-0531fe83be23"),
                    RecipeId = RecipeSeedUUID.ThaiBasilChicken,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("f4a4b517-83ad-44ea-9472-d18fce66fa80"),
                    RecipeId = RecipeSeedUUID.ThaiBasilChicken,
                    Text = "Season and cook until Thai Basil Chicken is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("90204cef-dc47-4fb9-b691-b800e7e733f3"),
                    RecipeId = RecipeSeedUUID.ThaiBasilChicken,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("8c052e34-0bc7-4659-b374-99d928a02fd6"),
                    RecipeId = RecipeSeedUUID.ThaiBasilChicken,
                    Text = "Plate Thai Basil Chicken and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("6562f46e-5dd3-4e0e-a77b-1c6e163f4a6a"),
                    RecipeId = RecipeSeedUUID.PanangCurry,
                    Text = "Prep ingredients for Panang Curry.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("d7527475-4957-45fd-b7af-b98d73cea2af"),
                    RecipeId = RecipeSeedUUID.PanangCurry,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("d7696931-293a-4bc1-aeeb-cac8d1706a54"),
                    RecipeId = RecipeSeedUUID.PanangCurry,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("4e4e786f-d3f5-43e0-ad8a-28f6252707e4"),
                    RecipeId = RecipeSeedUUID.PanangCurry,
                    Text = "Season and cook until Panang Curry is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("0478dc77-8044-470f-b573-7cbdb71066ba"),
                    RecipeId = RecipeSeedUUID.PanangCurry,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("7f75dcb1-28b3-476f-b6c2-ef35c3145d8a"),
                    RecipeId = RecipeSeedUUID.PanangCurry,
                    Text = "Plate Panang Curry and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("3d8d3c98-6dba-46f4-bafe-d6af599fb33c"),
                    RecipeId = RecipeSeedUUID.CoconutSoup,
                    Text = "Prep ingredients for Tom Kha Gai.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("9e4c976e-de8d-494b-8808-fd927c4ad4be"),
                    RecipeId = RecipeSeedUUID.CoconutSoup,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("ce5d9063-7f98-4cfa-9bfe-80e3fad3a609"),
                    RecipeId = RecipeSeedUUID.CoconutSoup,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("825c4c2c-6bdc-406d-9977-9f3a07aa506b"),
                    RecipeId = RecipeSeedUUID.CoconutSoup,
                    Text = "Season and cook until Tom Kha Gai is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("29be4a1d-0a46-4fd5-9132-679cbee3f115"),
                    RecipeId = RecipeSeedUUID.CoconutSoup,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("4d12201d-8f1f-45e5-8856-df214f5f5fd3"),
                    RecipeId = RecipeSeedUUID.CoconutSoup,
                    Text = "Plate Tom Kha Gai and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("7e9e73db-f32f-4e76-baf2-edbbcb39b503"),
                    RecipeId = RecipeSeedUUID.BanhMi,
                    Text = "Prep ingredients for Banh Mi.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("9ecd3528-ffdf-4721-9ecf-d500d119956f"),
                    RecipeId = RecipeSeedUUID.BanhMi,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("c167944c-1ae6-405e-b7a8-3076b8c567ed"),
                    RecipeId = RecipeSeedUUID.BanhMi,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("c0d9f2bc-00a5-402f-a7fe-6b387ce979a9"),
                    RecipeId = RecipeSeedUUID.BanhMi,
                    Text = "Season and cook until Banh Mi is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("edbf2542-6bf4-4c02-8384-716e1b29a7eb"),
                    RecipeId = RecipeSeedUUID.BanhMi,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("878878eb-0d5f-4bd4-bc33-3d4383fa254d"),
                    RecipeId = RecipeSeedUUID.BanhMi,
                    Text = "Plate Banh Mi and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("2b13165a-08d2-4163-a7ca-62d726b1c801"),
                    RecipeId = RecipeSeedUUID.BunCha,
                    Text = "Prep ingredients for Bun Cha.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("c758e514-4667-4ae9-82b5-a260b08ffe41"),
                    RecipeId = RecipeSeedUUID.BunCha,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("e15b663a-26cf-4ec9-ac5b-08b0454bd367"),
                    RecipeId = RecipeSeedUUID.BunCha,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("7c2e1f76-37e2-457c-be7e-74e8e06126cd"),
                    RecipeId = RecipeSeedUUID.BunCha,
                    Text = "Season and cook until Bun Cha is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("1da867f3-32d2-4ccf-b741-0abe02eaaeec"),
                    RecipeId = RecipeSeedUUID.BunCha,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("d49c33fb-f1e8-434f-959d-2d81b743bca8"),
                    RecipeId = RecipeSeedUUID.BunCha,
                    Text = "Plate Bun Cha and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("3484746b-dc8e-43dd-a8fe-4702777e8a80"),
                    RecipeId = RecipeSeedUUID.GoiCuon,
                    Text = "Prep ingredients for Goi Cuon.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("4f8cd410-f37c-4d79-88b1-daebd241781e"),
                    RecipeId = RecipeSeedUUID.GoiCuon,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("6188a926-6e7f-40aa-b16c-7cb2ee3413d6"),
                    RecipeId = RecipeSeedUUID.GoiCuon,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("2c34f9b2-c6fe-41e8-990a-6f3e97b709ac"),
                    RecipeId = RecipeSeedUUID.GoiCuon,
                    Text = "Season and cook until Goi Cuon is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("f87afdba-9a3a-4755-99eb-257f1d59da8c"),
                    RecipeId = RecipeSeedUUID.GoiCuon,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("9148d003-f7c2-4daa-9de4-7872579c5371"),
                    RecipeId = RecipeSeedUUID.GoiCuon,
                    Text = "Plate Goi Cuon and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("87a6b22e-28c4-4eb3-a7bc-ce59c019e345"),
                    RecipeId = RecipeSeedUUID.ComTam,
                    Text = "Prep ingredients for Com Tam.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("73cd1a50-2df2-4669-b96b-37fa46a4c5ab"),
                    RecipeId = RecipeSeedUUID.ComTam,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("128d13c7-ea40-45dc-8574-04e0e5a3e543"),
                    RecipeId = RecipeSeedUUID.ComTam,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("6cabc981-f75d-4338-95e1-95bbd11ccebe"),
                    RecipeId = RecipeSeedUUID.ComTam,
                    Text = "Season and cook until Com Tam is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("43af8edc-293e-485b-994c-e822b299d699"),
                    RecipeId = RecipeSeedUUID.ComTam,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("e86033f0-66f3-46f5-9072-306b4e76e330"),
                    RecipeId = RecipeSeedUUID.ComTam,
                    Text = "Plate Com Tam and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("ca61433e-f3ee-4ebd-8111-f40321da3a1e"),
                    RecipeId = RecipeSeedUUID.Ramen,
                    Text = "Prep ingredients for Tonkotsu Ramen.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("ebde3752-01d5-497b-a620-f33f13657468"),
                    RecipeId = RecipeSeedUUID.Ramen,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("94249957-6e85-43a8-a9b8-b875922709a3"),
                    RecipeId = RecipeSeedUUID.Ramen,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("2e11e55c-c876-4dc2-add1-9a3cc3838970"),
                    RecipeId = RecipeSeedUUID.Ramen,
                    Text = "Season and cook until Tonkotsu Ramen is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("245db09d-8bcc-40c5-8308-219f89e2197b"),
                    RecipeId = RecipeSeedUUID.Ramen,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("79106b9d-b924-4a0a-aae6-a8266a83f0f5"),
                    RecipeId = RecipeSeedUUID.Ramen,
                    Text = "Plate Tonkotsu Ramen and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("85821fa6-5582-4fff-8eff-f7370dffd9f0"),
                    RecipeId = RecipeSeedUUID.Tonkatsu,
                    Text = "Prep ingredients for Tonkatsu.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("324c6e94-ce7a-4169-a5e3-a019a8bceff1"),
                    RecipeId = RecipeSeedUUID.Tonkatsu,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("630e1ad8-05e7-42fb-a911-cbb2f8414e8e"),
                    RecipeId = RecipeSeedUUID.Tonkatsu,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("4c32163a-dc35-48b8-b250-71cbc11956f2"),
                    RecipeId = RecipeSeedUUID.Tonkatsu,
                    Text = "Season and cook until Tonkatsu is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("03e76984-356d-4a19-8526-a65a26aede80"),
                    RecipeId = RecipeSeedUUID.Tonkatsu,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("9fde70bc-857e-4400-af5a-cf914f3a1de5"),
                    RecipeId = RecipeSeedUUID.Tonkatsu,
                    Text = "Plate Tonkatsu and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("42add2e5-98f7-4844-ac83-19e990659f48"),
                    RecipeId = RecipeSeedUUID.Okonomiyaki,
                    Text = "Prep ingredients for Okonomiyaki.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("1a75c7a1-b080-4397-aeb6-368301a5651c"),
                    RecipeId = RecipeSeedUUID.Okonomiyaki,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("9d13277a-6ead-4447-b571-4061d81a24f1"),
                    RecipeId = RecipeSeedUUID.Okonomiyaki,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("521207c3-578d-4a2d-b410-24d602222c13"),
                    RecipeId = RecipeSeedUUID.Okonomiyaki,
                    Text = "Season and cook until Okonomiyaki is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("c4e56008-c70d-481f-b75f-67b75d19bc95"),
                    RecipeId = RecipeSeedUUID.Okonomiyaki,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("ed75004c-2707-48af-b0e0-cbf8aa54e7ae"),
                    RecipeId = RecipeSeedUUID.Okonomiyaki,
                    Text = "Plate Okonomiyaki and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("440569fc-7072-42c6-aa28-a63a4a9646a2"),
                    RecipeId = RecipeSeedUUID.MisoSoup,
                    Text = "Prep ingredients for Miso Soup.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("3bc50c53-4df0-4915-8b61-e2ddc7a0d7ab"),
                    RecipeId = RecipeSeedUUID.MisoSoup,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("84da6fc8-c4cd-480f-a449-35125558650e"),
                    RecipeId = RecipeSeedUUID.MisoSoup,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("7946d545-b6ea-4f35-aa95-0dfd236f3833"),
                    RecipeId = RecipeSeedUUID.MisoSoup,
                    Text = "Season and cook until Miso Soup is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("dc5745a1-82a7-4ab8-bd74-43efa3fdbfff"),
                    RecipeId = RecipeSeedUUID.MisoSoup,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("7aede663-c2f8-4506-9db3-34bf486fbbae"),
                    RecipeId = RecipeSeedUUID.MisoSoup,
                    Text = "Plate Miso Soup and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("08cc0988-8daf-47c8-b669-e1533b4c0ab0"),
                    RecipeId = RecipeSeedUUID.Udon,
                    Text = "Prep ingredients for Kitsune Udon.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("f212cea6-2c9c-4b19-b130-6982b3d1819c"),
                    RecipeId = RecipeSeedUUID.Udon,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("2eba6910-6886-48bf-bb09-bf99705b85ab"),
                    RecipeId = RecipeSeedUUID.Udon,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("5bf55f3f-3000-44b4-bcbc-a257782c4df2"),
                    RecipeId = RecipeSeedUUID.Udon,
                    Text = "Season and cook until Kitsune Udon is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("6529efde-5c25-4e64-b7c3-c28459602ea2"),
                    RecipeId = RecipeSeedUUID.Udon,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("902adcb9-be35-4512-a0dc-d6b000bc2641"),
                    RecipeId = RecipeSeedUUID.Udon,
                    Text = "Plate Kitsune Udon and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("9dea574f-5fc0-4992-a146-495be26a1734"),
                    RecipeId = RecipeSeedUUID.Tempura,
                    Text = "Prep ingredients for Vegetable Tempura.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("024befd6-5990-4e78-a68c-36f7ee13e058"),
                    RecipeId = RecipeSeedUUID.Tempura,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("83b8d566-105a-4ad4-b741-1c9875d09b8a"),
                    RecipeId = RecipeSeedUUID.Tempura,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("91c98b46-f6d1-42e6-9357-9031157732b4"),
                    RecipeId = RecipeSeedUUID.Tempura,
                    Text = "Season and cook until Vegetable Tempura is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("09bbaabf-e9eb-406a-aab9-8dad8288bec4"),
                    RecipeId = RecipeSeedUUID.Tempura,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("a1b54d9b-524f-4770-8242-7497c1fe00d7"),
                    RecipeId = RecipeSeedUUID.Tempura,
                    Text = "Plate Vegetable Tempura and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("73d90ec7-7f1c-435f-a1bc-370011b8a94d"),
                    RecipeId = RecipeSeedUUID.Onigiri,
                    Text = "Prep ingredients for Onigiri.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("4b023874-3b5d-4a21-baea-a8f8d6d6dd17"),
                    RecipeId = RecipeSeedUUID.Onigiri,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("da0e2fd1-8a91-4641-b954-ad9907610959"),
                    RecipeId = RecipeSeedUUID.Onigiri,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("f2179377-e851-4646-ae75-6f8a9be26989"),
                    RecipeId = RecipeSeedUUID.Onigiri,
                    Text = "Season and cook until Onigiri is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("b0a31f90-bfa8-4c05-aa53-25371ef8d3e7"),
                    RecipeId = RecipeSeedUUID.Onigiri,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("917e8722-6d1f-406d-9db9-827fd4098ebe"),
                    RecipeId = RecipeSeedUUID.Onigiri,
                    Text = "Plate Onigiri and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("9752d545-9301-46ad-8edf-a1d7dfea5521"),
                    RecipeId = RecipeSeedUUID.Carbonara,
                    Text = "Prep ingredients for Spaghetti Carbonara.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("3a0c1d55-5607-4637-89be-b5dc17977f6c"),
                    RecipeId = RecipeSeedUUID.Carbonara,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("430e2a19-96cb-454c-be35-c3e419a6ae78"),
                    RecipeId = RecipeSeedUUID.Carbonara,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("c107bc19-2e2b-417a-929e-970038cae67e"),
                    RecipeId = RecipeSeedUUID.Carbonara,
                    Text = "Season and cook until Spaghetti Carbonara is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("52daad8a-3617-475f-a733-21e9c0d60aaa"),
                    RecipeId = RecipeSeedUUID.Carbonara,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("ecd14b33-240b-4e08-abfa-fda2be8af755"),
                    RecipeId = RecipeSeedUUID.Carbonara,
                    Text = "Plate Spaghetti Carbonara and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("20f11c7f-7751-478a-b87a-192aa3ad642f"),
                    RecipeId = RecipeSeedUUID.MargheritaPizza,
                    Text = "Prep ingredients for Margherita Pizza.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("1b74c192-5168-4f45-bcf7-128e99a83419"),
                    RecipeId = RecipeSeedUUID.MargheritaPizza,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("71c7fa6b-3707-4f63-aa2d-023df9bfa14f"),
                    RecipeId = RecipeSeedUUID.MargheritaPizza,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("e61cfe10-1e5f-4977-9330-fc318094b6ca"),
                    RecipeId = RecipeSeedUUID.MargheritaPizza,
                    Text = "Season and cook until Margherita Pizza is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("5eb83922-3a7c-4baf-8493-6874625e579c"),
                    RecipeId = RecipeSeedUUID.MargheritaPizza,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("1876339b-a6e7-4854-b253-45f68af7fef4"),
                    RecipeId = RecipeSeedUUID.MargheritaPizza,
                    Text = "Plate Margherita Pizza and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("8d5a78c6-8b47-43d0-b50e-a5eb5e703fe3"),
                    RecipeId = RecipeSeedUUID.MushroomRisotto,
                    Text = "Prep ingredients for Mushroom Risotto.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7ae36daa-9875-4f5a-bb2d-54b5eafae167"),
                    RecipeId = RecipeSeedUUID.MushroomRisotto,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("80d462a6-f2fb-402d-9929-2904b200a44f"),
                    RecipeId = RecipeSeedUUID.MushroomRisotto,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("2ccf97c3-1db6-4763-a22e-2ac733d4b8c7"),
                    RecipeId = RecipeSeedUUID.MushroomRisotto,
                    Text = "Season and cook until Mushroom Risotto is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("c723dca1-d0ef-404d-9803-78f44640771d"),
                    RecipeId = RecipeSeedUUID.MushroomRisotto,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("6f91a959-4eb3-4424-947f-3104165631ba"),
                    RecipeId = RecipeSeedUUID.MushroomRisotto,
                    Text = "Plate Mushroom Risotto and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("fd0dc99c-ba8e-451f-816c-d4438c0658cf"),
                    RecipeId = RecipeSeedUUID.Tiramisu,
                    Text = "Prep ingredients for Tiramisu.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("a15eb536-3561-413a-9824-56081db1c181"),
                    RecipeId = RecipeSeedUUID.Tiramisu,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("a64e0990-1e97-4587-8704-c67e734011c9"),
                    RecipeId = RecipeSeedUUID.Tiramisu,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("e631b7d0-3eef-40a6-91e3-2f27707bec6b"),
                    RecipeId = RecipeSeedUUID.Tiramisu,
                    Text = "Season and cook until Tiramisu is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("ccab991b-d4c0-4bcd-8303-ce94e36d8aee"),
                    RecipeId = RecipeSeedUUID.Tiramisu,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("7ead78a7-de06-4fb4-b0af-6657639b2cb7"),
                    RecipeId = RecipeSeedUUID.Tiramisu,
                    Text = "Plate Tiramisu and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("734b5058-ec0b-4133-abe3-8123fb58d231"),
                    RecipeId = RecipeSeedUUID.Gnocchi,
                    Text = "Prep ingredients for Potato Gnocchi.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("88bf4a20-c214-4729-b75b-6e6a3ad4c194"),
                    RecipeId = RecipeSeedUUID.Gnocchi,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("1051d8ab-f05c-42c5-bcc2-f521f405c02a"),
                    RecipeId = RecipeSeedUUID.Gnocchi,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("acc39a1d-924b-4adc-a77b-537ccd34afc2"),
                    RecipeId = RecipeSeedUUID.Gnocchi,
                    Text = "Season and cook until Potato Gnocchi is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("f7ae11a6-d138-45ce-b307-bfe65746ff78"),
                    RecipeId = RecipeSeedUUID.Gnocchi,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("25ee4741-d861-43bd-afc2-932645da0542"),
                    RecipeId = RecipeSeedUUID.Gnocchi,
                    Text = "Plate Potato Gnocchi and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("dea2d5a6-88da-43e3-ab2d-1429e8fe8ec7"),
                    RecipeId = RecipeSeedUUID.PestoPasta,
                    Text = "Prep ingredients for Pesto Linguine.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("d4791ed1-287f-469a-80b6-ba9177c59d58"),
                    RecipeId = RecipeSeedUUID.PestoPasta,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("cb0071d2-dcb9-4fa7-8339-c4a420c3496d"),
                    RecipeId = RecipeSeedUUID.PestoPasta,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("60c2f408-6e87-4421-8039-75512ef16d6e"),
                    RecipeId = RecipeSeedUUID.PestoPasta,
                    Text = "Season and cook until Pesto Linguine is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("31de15cb-3483-494a-9b8c-d3200463e8af"),
                    RecipeId = RecipeSeedUUID.PestoPasta,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("995db4f2-a18c-4aea-bf32-dfc93c1b7399"),
                    RecipeId = RecipeSeedUUID.PestoPasta,
                    Text = "Plate Pesto Linguine and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("8352e97f-d3c7-4497-96f9-884b562dcc64"),
                    RecipeId = RecipeSeedUUID.Minestrone,
                    Text = "Prep ingredients for Minestrone.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("02f4ee2b-76fd-4843-af7f-54f99752d13f"),
                    RecipeId = RecipeSeedUUID.Minestrone,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("4ea3ee3f-3c86-4604-ac4b-dea281f8f319"),
                    RecipeId = RecipeSeedUUID.Minestrone,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("695b517e-1d84-43b6-bc2c-765f58ed5332"),
                    RecipeId = RecipeSeedUUID.Minestrone,
                    Text = "Season and cook until Minestrone is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("f4a21c65-c89f-4b54-a06e-1e9c35022cee"),
                    RecipeId = RecipeSeedUUID.Minestrone,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("f5db38d3-e6c2-48d0-ac66-3ba6a04f4789"),
                    RecipeId = RecipeSeedUUID.Minestrone,
                    Text = "Plate Minestrone and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("f8cde565-2d6b-4039-bf9e-34370a4a45b5"),
                    RecipeId = RecipeSeedUUID.ChickenEnchiladas,
                    Text = "Prep ingredients for Chicken Enchiladas.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7d673799-9e2f-4b03-8836-79db787465ff"),
                    RecipeId = RecipeSeedUUID.ChickenEnchiladas,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("137271e3-e82c-4738-af8f-f8f89bce3ef8"),
                    RecipeId = RecipeSeedUUID.ChickenEnchiladas,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("ccfb2404-04c7-435d-ab2e-70b0dab33bdd"),
                    RecipeId = RecipeSeedUUID.ChickenEnchiladas,
                    Text = "Season and cook until Chicken Enchiladas is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("7b1c082c-d26c-4e94-8efc-c252ed6f6fdb"),
                    RecipeId = RecipeSeedUUID.ChickenEnchiladas,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("a95218d9-e76f-450e-af10-507c63c88381"),
                    RecipeId = RecipeSeedUUID.ChickenEnchiladas,
                    Text = "Plate Chicken Enchiladas and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("0a9d8964-4398-441d-9e76-bbe8c3570416"),
                    RecipeId = RecipeSeedUUID.Guacamole,
                    Text = "Prep ingredients for Guacamole.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("5e6be349-6bb0-484b-9d5c-2fb37623c325"),
                    RecipeId = RecipeSeedUUID.Guacamole,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("c6a4f66e-5500-40b5-8412-cc342d4bce70"),
                    RecipeId = RecipeSeedUUID.Guacamole,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("71c2712f-c5e6-435a-816b-b7521560cf0e"),
                    RecipeId = RecipeSeedUUID.Guacamole,
                    Text = "Season and cook until Guacamole is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("82ba588a-9ca0-4de2-ada8-02419cdba792"),
                    RecipeId = RecipeSeedUUID.Guacamole,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("bd6d0c8b-9aa9-45c3-81a2-37b4040d1728"),
                    RecipeId = RecipeSeedUUID.Guacamole,
                    Text = "Plate Guacamole and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("b1c34083-f528-44df-9560-9e20ec7322e5"),
                    RecipeId = RecipeSeedUUID.Pozole,
                    Text = "Prep ingredients for Pozole Rojo.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("781dd714-ad79-4873-94ef-bf16f6084da1"),
                    RecipeId = RecipeSeedUUID.Pozole,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("9da45ae7-0e0d-40fc-8919-3214be6f3a8a"),
                    RecipeId = RecipeSeedUUID.Pozole,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("7658d3c0-e365-462c-bae6-96601e70655c"),
                    RecipeId = RecipeSeedUUID.Pozole,
                    Text = "Season and cook until Pozole Rojo is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("7dd212cc-316d-439e-96f0-89ea813bddbf"),
                    RecipeId = RecipeSeedUUID.Pozole,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("5d843735-9774-4c87-9535-3b0f65a133bd"),
                    RecipeId = RecipeSeedUUID.Pozole,
                    Text = "Plate Pozole Rojo and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("689f7b46-3676-4e91-a335-57eef4561b1f"),
                    RecipeId = RecipeSeedUUID.Elote,
                    Text = "Prep ingredients for Elote.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("aee9e9fe-474d-40e4-9233-5df4f32812cd"),
                    RecipeId = RecipeSeedUUID.Elote,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("44966fef-394b-41a9-bceb-7388c13822d7"),
                    RecipeId = RecipeSeedUUID.Elote,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("3c087121-846e-4089-8aa6-8349249474a6"),
                    RecipeId = RecipeSeedUUID.Elote,
                    Text = "Season and cook until Elote is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("c4a01733-d720-4aea-b22c-929ff65c080b"),
                    RecipeId = RecipeSeedUUID.Elote,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("8dafe091-7e87-4016-9867-4243a971eb1c"),
                    RecipeId = RecipeSeedUUID.Elote,
                    Text = "Plate Elote and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("a86f573e-4e61-4cc8-930d-7bd80698b60b"),
                    RecipeId = RecipeSeedUUID.CheeseQuesadilla,
                    Text = "Prep ingredients for Cheese Quesadilla.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("b15ae9ab-5733-47bc-923f-02b0f4f556c6"),
                    RecipeId = RecipeSeedUUID.CheeseQuesadilla,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("acaaab18-54a0-4b8d-88e6-694825dfc2eb"),
                    RecipeId = RecipeSeedUUID.CheeseQuesadilla,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("e91b01c6-a06a-4807-8c72-1263a0f014ba"),
                    RecipeId = RecipeSeedUUID.CheeseQuesadilla,
                    Text = "Season and cook until Cheese Quesadilla is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("2e20e074-4ef2-4f94-a273-59b441e7e1e4"),
                    RecipeId = RecipeSeedUUID.CheeseQuesadilla,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("a06090aa-5d55-4a2f-b5b4-47b04dd31d22"),
                    RecipeId = RecipeSeedUUID.CheeseQuesadilla,
                    Text = "Plate Cheese Quesadilla and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("47df9e29-d08b-466a-b361-88d0c29ef1b7"),
                    RecipeId = RecipeSeedUUID.Tamales,
                    Text = "Prep ingredients for Pork Tamales.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("b187dca3-f97b-4d51-8849-60add92fabc6"),
                    RecipeId = RecipeSeedUUID.Tamales,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("ce621c89-b300-4099-bc53-ce65f187d8f4"),
                    RecipeId = RecipeSeedUUID.Tamales,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("b26ba01e-8c76-42b4-8b04-1739712ffac5"),
                    RecipeId = RecipeSeedUUID.Tamales,
                    Text = "Season and cook until Pork Tamales is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("d49ba63b-d113-47b4-941b-b20ea1eabe51"),
                    RecipeId = RecipeSeedUUID.Tamales,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("abdb6d6e-938c-47bb-9747-7edd84f4d43f"),
                    RecipeId = RecipeSeedUUID.Tamales,
                    Text = "Plate Pork Tamales and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("eb413ee1-cb0b-40bc-b902-618581756775"),
                    RecipeId = RecipeSeedUUID.MacAndCheese,
                    Text = "Prep ingredients for Stovetop Mac and Cheese.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("2623a7e8-9a10-4e8a-90b2-6f20578d26b8"),
                    RecipeId = RecipeSeedUUID.MacAndCheese,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("bd053aae-0ef4-45a1-8877-26629e4e1d0a"),
                    RecipeId = RecipeSeedUUID.MacAndCheese,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("63056596-8364-4788-9e27-75690afc9956"),
                    RecipeId = RecipeSeedUUID.MacAndCheese,
                    Text = "Season and cook until Stovetop Mac and Cheese is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("011da947-ad03-4ce7-95d7-407fca931af9"),
                    RecipeId = RecipeSeedUUID.MacAndCheese,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("2bea4385-987a-4ffd-a5c4-2f6c91ef38d8"),
                    RecipeId = RecipeSeedUUID.MacAndCheese,
                    Text = "Plate Stovetop Mac and Cheese and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("6f91b1b3-7dc6-4630-8aa1-7270d548068b"),
                    RecipeId = RecipeSeedUUID.FriedChicken,
                    Text = "Prep ingredients for Buttermilk Fried Chicken.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("911ab7ed-b307-4d4c-9e2a-c3116243accd"),
                    RecipeId = RecipeSeedUUID.FriedChicken,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("85d8721a-d4b5-4aef-a301-14c4c5a47988"),
                    RecipeId = RecipeSeedUUID.FriedChicken,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("10c62f5c-c157-4e8d-bc25-37939ce2b686"),
                    RecipeId = RecipeSeedUUID.FriedChicken,
                    Text = "Season and cook until Buttermilk Fried Chicken is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("248b7fe6-6c03-4aff-b203-1025fca25933"),
                    RecipeId = RecipeSeedUUID.FriedChicken,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("4fbba0ed-16e2-4286-8443-4014d52d1e2f"),
                    RecipeId = RecipeSeedUUID.FriedChicken,
                    Text = "Plate Buttermilk Fried Chicken and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("87bed3ea-0af1-45f5-9961-05c748c921bf"),
                    RecipeId = RecipeSeedUUID.ClamChowder,
                    Text = "Prep ingredients for New England Clam Chowder.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("88f93749-adc5-4a3d-8f97-1292b4e883de"),
                    RecipeId = RecipeSeedUUID.ClamChowder,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("a8944a5a-483b-490d-877a-6dec51dcff3a"),
                    RecipeId = RecipeSeedUUID.ClamChowder,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("0a322010-d865-4674-b4f2-673cead2ced8"),
                    RecipeId = RecipeSeedUUID.ClamChowder,
                    Text = "Season and cook until New England Clam Chowder is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("09687955-8588-486e-afac-0e98c9c11c54"),
                    RecipeId = RecipeSeedUUID.ClamChowder,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("20d1eb9b-7b21-4935-b023-a84c79067410"),
                    RecipeId = RecipeSeedUUID.ClamChowder,
                    Text = "Plate New England Clam Chowder and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("00428c8c-41f3-4d79-b0bf-db78111145e5"),
                    RecipeId = RecipeSeedUUID.Pancakes,
                    Text = "Prep ingredients for Buttermilk Pancakes.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("5e645641-4398-4c1e-a342-8e6064f6d016"),
                    RecipeId = RecipeSeedUUID.Pancakes,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("8c0a6ec3-84c3-469b-bca0-2ff2baf4b479"),
                    RecipeId = RecipeSeedUUID.Pancakes,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("28b7f5ff-5ca0-46c1-b6dc-27409b927612"),
                    RecipeId = RecipeSeedUUID.Pancakes,
                    Text = "Season and cook until Buttermilk Pancakes is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("4f5ad49c-41c3-42c0-858b-a2b46c6508f9"),
                    RecipeId = RecipeSeedUUID.Pancakes,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("fc4ba45f-d60e-46c7-afab-d38eef6a6c5b"),
                    RecipeId = RecipeSeedUUID.Pancakes,
                    Text = "Plate Buttermilk Pancakes and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("db93aa69-5237-49ed-a015-6daa5b69a8fd"),
                    RecipeId = RecipeSeedUUID.BeefChili,
                    Text = "Prep ingredients for Beef Chili.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("977efa8a-a984-449b-ac10-783e8c0ecb05"),
                    RecipeId = RecipeSeedUUID.BeefChili,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("288a3707-8b48-4dc0-9b93-8fbc9995ed65"),
                    RecipeId = RecipeSeedUUID.BeefChili,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("37362d93-1ab6-4086-91bf-b923871aeb8f"),
                    RecipeId = RecipeSeedUUID.BeefChili,
                    Text = "Season and cook until Beef Chili is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("20d68091-69f7-44a1-b590-63363ce82ce7"),
                    RecipeId = RecipeSeedUUID.BeefChili,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("a0f56338-10d1-43ad-bc52-7729cd44a79a"),
                    RecipeId = RecipeSeedUUID.BeefChili,
                    Text = "Plate Beef Chili and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("37e007fa-980e-4a73-92da-26d40e726bd7"),
                    RecipeId = RecipeSeedUUID.ApplePie,
                    Text = "Prep ingredients for Apple Pie.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("95c25201-c049-42c2-8dcb-fbd061c3c9c6"),
                    RecipeId = RecipeSeedUUID.ApplePie,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("b01abc8c-37fc-4e7a-9117-0fb31fbe19b3"),
                    RecipeId = RecipeSeedUUID.ApplePie,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("4f658553-5518-444f-8baa-aee167b99250"),
                    RecipeId = RecipeSeedUUID.ApplePie,
                    Text = "Season and cook until Apple Pie is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("e935d698-ea61-440c-9084-25030a7c1228"),
                    RecipeId = RecipeSeedUUID.ApplePie,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("198be7c1-6661-4a31-8ea9-f862c72d51e4"),
                    RecipeId = RecipeSeedUUID.ApplePie,
                    Text = "Plate Apple Pie and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("da026dd7-ed16-4423-948f-759d58352fe3"),
                    RecipeId = RecipeSeedUUID.TikkaMasala,
                    Text = "Prep ingredients for Chicken Tikka Masala.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("2ab57baf-8902-4388-a350-d3f39b3b7fc1"),
                    RecipeId = RecipeSeedUUID.TikkaMasala,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("e771c827-67cd-4d36-8803-7a3195c017e8"),
                    RecipeId = RecipeSeedUUID.TikkaMasala,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("c7a8f96b-5102-41ad-a8aa-7e06347ccc4e"),
                    RecipeId = RecipeSeedUUID.TikkaMasala,
                    Text = "Season and cook until Chicken Tikka Masala is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("c026630b-d091-48df-a479-52740e4979c3"),
                    RecipeId = RecipeSeedUUID.TikkaMasala,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("008f16a3-2e3a-4dae-a5cd-218102c5585f"),
                    RecipeId = RecipeSeedUUID.TikkaMasala,
                    Text = "Plate Chicken Tikka Masala and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("d9fb96f1-3da2-46e5-a9e5-eafd186f0763"),
                    RecipeId = RecipeSeedUUID.PalakPaneer,
                    Text = "Prep ingredients for Palak Paneer.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("6e602f0a-3ad1-44fe-940e-d9443fe4246d"),
                    RecipeId = RecipeSeedUUID.PalakPaneer,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("77ab3d75-514d-4dde-b073-1e921bad2fbd"),
                    RecipeId = RecipeSeedUUID.PalakPaneer,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("58665b2a-3793-4970-8949-7ad6548c53a5"),
                    RecipeId = RecipeSeedUUID.PalakPaneer,
                    Text = "Season and cook until Palak Paneer is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("551c4630-738b-4351-95d2-0a77072a520b"),
                    RecipeId = RecipeSeedUUID.PalakPaneer,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("9de6eab7-7696-497a-9ef7-879e78789bac"),
                    RecipeId = RecipeSeedUUID.PalakPaneer,
                    Text = "Plate Palak Paneer and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("cf908b6d-e821-4d3d-807e-b7654d41e1ea"),
                    RecipeId = RecipeSeedUUID.Samosas,
                    Text = "Prep ingredients for Vegetable Samosas.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("f558f93d-abe6-4c88-b7c6-c4c27e9f714f"),
                    RecipeId = RecipeSeedUUID.Samosas,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("09bffaa1-5def-4d03-b63c-9bd1201377a2"),
                    RecipeId = RecipeSeedUUID.Samosas,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("7d603461-7d70-4480-8c1a-547977dc87f7"),
                    RecipeId = RecipeSeedUUID.Samosas,
                    Text = "Season and cook until Vegetable Samosas is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("a2872d3b-d88d-4278-97fe-2db4f1eff357"),
                    RecipeId = RecipeSeedUUID.Samosas,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("9a93d63b-7399-4527-b458-b9f27c3ccdea"),
                    RecipeId = RecipeSeedUUID.Samosas,
                    Text = "Plate Vegetable Samosas and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("771b45d0-b0da-49ad-ad48-a945fbafd538"),
                    RecipeId = RecipeSeedUUID.ChanaMasala,
                    Text = "Prep ingredients for Chana Masala.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("9bd2ecc0-3572-4340-a859-15ea20e956c4"),
                    RecipeId = RecipeSeedUUID.ChanaMasala,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("21aca0e6-6b85-45be-ad25-d3645e9d974d"),
                    RecipeId = RecipeSeedUUID.ChanaMasala,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("137d52ff-6217-45e9-a857-7d4fb429b393"),
                    RecipeId = RecipeSeedUUID.ChanaMasala,
                    Text = "Season and cook until Chana Masala is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("5963f5ed-d791-4fb2-99b9-5d9f8cf266ce"),
                    RecipeId = RecipeSeedUUID.ChanaMasala,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("b9169747-50f5-4c8e-aed6-d8c641c2c2d3"),
                    RecipeId = RecipeSeedUUID.ChanaMasala,
                    Text = "Plate Chana Masala and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("cb345cce-e609-46cf-94e3-8106c5debc11"),
                    RecipeId = RecipeSeedUUID.DalTadka,
                    Text = "Prep ingredients for Dal Tadka.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("09ae3727-06af-4ea8-837d-7e59c3a89856"),
                    RecipeId = RecipeSeedUUID.DalTadka,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("fd4aadcc-8670-4c86-a45e-1c88ce2c8bef"),
                    RecipeId = RecipeSeedUUID.DalTadka,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("07142001-e070-4fc1-bf70-3672fa2876c2"),
                    RecipeId = RecipeSeedUUID.DalTadka,
                    Text = "Season and cook until Dal Tadka is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("ed3985d8-a292-4cb8-9392-d791249a702c"),
                    RecipeId = RecipeSeedUUID.DalTadka,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("cc221aab-32af-4e80-9b1c-58ee38c6e9ab"),
                    RecipeId = RecipeSeedUUID.DalTadka,
                    Text = "Plate Dal Tadka and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("67805ad4-7785-495e-8e53-d95868741988"),
                    RecipeId = RecipeSeedUUID.MasalaDosa,
                    Text = "Prep ingredients for Masala Dosa.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("92973ebf-ed74-4e88-89a7-744330a0aebf"),
                    RecipeId = RecipeSeedUUID.MasalaDosa,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("68845dc1-782d-42e3-ab70-f5bb622d6833"),
                    RecipeId = RecipeSeedUUID.MasalaDosa,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("f400648c-3d8a-4ced-922d-95f9ffd28a04"),
                    RecipeId = RecipeSeedUUID.MasalaDosa,
                    Text = "Season and cook until Masala Dosa is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("53175e6e-b5d5-440b-8890-d26b5ea361a7"),
                    RecipeId = RecipeSeedUUID.MasalaDosa,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("500ad4cc-75f1-49cf-b3da-05aedc80dd50"),
                    RecipeId = RecipeSeedUUID.MasalaDosa,
                    Text = "Plate Masala Dosa and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("0d492b9a-ff86-4d09-9c41-e5e89a3cf6d3"),
                    RecipeId = RecipeSeedUUID.MapoTofu,
                    Text = "Prep ingredients for Mapo Tofu.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("c5df163c-faa5-41d8-8e0f-c38dc2803201"),
                    RecipeId = RecipeSeedUUID.MapoTofu,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("01d1aaca-1874-4f8f-97ad-03670d5964f4"),
                    RecipeId = RecipeSeedUUID.MapoTofu,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("c6989092-90ba-4309-a85e-693144c0bd5d"),
                    RecipeId = RecipeSeedUUID.MapoTofu,
                    Text = "Season and cook until Mapo Tofu is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("d8d1eb29-24db-4508-8038-3fe3a8314597"),
                    RecipeId = RecipeSeedUUID.MapoTofu,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("d5d162f0-3074-4e71-8776-2c26df304045"),
                    RecipeId = RecipeSeedUUID.MapoTofu,
                    Text = "Plate Mapo Tofu and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("5d0375d2-9d0d-481c-ae07-93995857232c"),
                    RecipeId = RecipeSeedUUID.PorkDumplings,
                    Text = "Prep ingredients for Pork Dumplings.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("1bdb1c2b-6cfb-4a58-af0b-9c0a81650943"),
                    RecipeId = RecipeSeedUUID.PorkDumplings,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("ef9da3bd-4d1b-41eb-87d8-669b2e82a456"),
                    RecipeId = RecipeSeedUUID.PorkDumplings,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("461bd46e-87d2-4186-97c1-ba57df69b7dd"),
                    RecipeId = RecipeSeedUUID.PorkDumplings,
                    Text = "Season and cook until Pork Dumplings is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("eabe079e-5e80-4fa4-924b-de093ebcc6a7"),
                    RecipeId = RecipeSeedUUID.PorkDumplings,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("20ded626-de6a-49ad-87c9-998f0f5ecbc5"),
                    RecipeId = RecipeSeedUUID.PorkDumplings,
                    Text = "Plate Pork Dumplings and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("88a5a654-b9d7-4f58-b470-578f561c9109"),
                    RecipeId = RecipeSeedUUID.KungPaoChicken,
                    Text = "Prep ingredients for Kung Pao Chicken.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("a0e72a9a-4b84-4c2f-9435-8bb2757475ef"),
                    RecipeId = RecipeSeedUUID.KungPaoChicken,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("fb91f023-c010-4662-b0f3-c2eb2287f82e"),
                    RecipeId = RecipeSeedUUID.KungPaoChicken,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("0da5fdd5-6909-4d11-a3dc-7c887419f1d5"),
                    RecipeId = RecipeSeedUUID.KungPaoChicken,
                    Text = "Season and cook until Kung Pao Chicken is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("23d8ef4f-b448-467d-ab44-ca5d066af26e"),
                    RecipeId = RecipeSeedUUID.KungPaoChicken,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("f29ed9c0-daa4-40ef-853b-95dd3c5159e7"),
                    RecipeId = RecipeSeedUUID.KungPaoChicken,
                    Text = "Plate Kung Pao Chicken and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("76d7fafd-4b11-4896-b436-1f556ebc7bfc"),
                    RecipeId = RecipeSeedUUID.EggFriedRice,
                    Text = "Prep ingredients for Egg Fried Rice.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("d8f32ff5-9ed5-40d4-81f2-8ec4b748a719"),
                    RecipeId = RecipeSeedUUID.EggFriedRice,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("42e54874-2d09-43ff-9627-d285d150d9c7"),
                    RecipeId = RecipeSeedUUID.EggFriedRice,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("3ad48615-95f2-4446-ad3e-f4cd57232d45"),
                    RecipeId = RecipeSeedUUID.EggFriedRice,
                    Text = "Season and cook until Egg Fried Rice is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("59f7ae65-eb94-4813-b0a2-5b5dbfc46624"),
                    RecipeId = RecipeSeedUUID.EggFriedRice,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("c42b4304-9cf1-478e-81b9-7f66156b4bfb"),
                    RecipeId = RecipeSeedUUID.EggFriedRice,
                    Text = "Plate Egg Fried Rice and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("69d1aa09-9a36-4404-b71b-3157030eb78b"),
                    RecipeId = RecipeSeedUUID.WontonSoup,
                    Text = "Prep ingredients for Wonton Soup.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("e95aa3df-bda1-48fb-b5bd-4a674de9771f"),
                    RecipeId = RecipeSeedUUID.WontonSoup,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("f8159425-9a99-410c-b6c5-60f520f86bbb"),
                    RecipeId = RecipeSeedUUID.WontonSoup,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("c503e2aa-32b6-4173-8eb6-4b2c8a352998"),
                    RecipeId = RecipeSeedUUID.WontonSoup,
                    Text = "Season and cook until Wonton Soup is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("a5b7d82e-4201-4fe5-9328-a59a54cf8506"),
                    RecipeId = RecipeSeedUUID.WontonSoup,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("7be7c706-cf5d-4b89-a9e4-84ec590954ff"),
                    RecipeId = RecipeSeedUUID.WontonSoup,
                    Text = "Plate Wonton Soup and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("c9f85455-b7fa-4c12-adcf-63f9d1bfda8c"),
                    RecipeId = RecipeSeedUUID.CharSiu,
                    Text = "Prep ingredients for Char Siu Pork.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("c7567ce0-0427-4884-8704-ea74914279a7"),
                    RecipeId = RecipeSeedUUID.CharSiu,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("39c1d9bf-c09b-4d3a-be08-06401abfca44"),
                    RecipeId = RecipeSeedUUID.CharSiu,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("1ba5caed-4cae-42ec-8fed-ad6c9b2b90d3"),
                    RecipeId = RecipeSeedUUID.CharSiu,
                    Text = "Season and cook until Char Siu Pork is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("f3a9a85f-e8bb-4c20-bcff-f80bfd1bcf48"),
                    RecipeId = RecipeSeedUUID.CharSiu,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("9a4d2863-d296-45b4-8487-d0c77db3aa5f"),
                    RecipeId = RecipeSeedUUID.CharSiu,
                    Text = "Plate Char Siu Pork and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("721a79a5-8928-4f1c-ae26-fbc25d9ba2cf"),
                    RecipeId = RecipeSeedUUID.FrenchOnionSoup,
                    Text = "Prep ingredients for French Onion Soup.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("d2da14b4-f464-4e36-a72d-f7b7a889e936"),
                    RecipeId = RecipeSeedUUID.FrenchOnionSoup,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("d6ae7669-7e4f-42ef-9f05-d1967dd57362"),
                    RecipeId = RecipeSeedUUID.FrenchOnionSoup,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("ff421c06-7891-42b5-abf2-3a7879cdd784"),
                    RecipeId = RecipeSeedUUID.FrenchOnionSoup,
                    Text = "Season and cook until French Onion Soup is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("a761dcba-7cd9-40db-ba2d-357ddd5abacf"),
                    RecipeId = RecipeSeedUUID.FrenchOnionSoup,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("ca8e66c4-cae7-4528-87a3-8cee41073e9b"),
                    RecipeId = RecipeSeedUUID.FrenchOnionSoup,
                    Text = "Plate French Onion Soup and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("168dd525-5715-4649-bddc-03f3db0b2b0a"),
                    RecipeId = RecipeSeedUUID.Ratatouille,
                    Text = "Prep ingredients for Ratatouille.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("06f22e51-b2e1-4559-afd0-0c2e66f773a6"),
                    RecipeId = RecipeSeedUUID.Ratatouille,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("929ad0eb-809b-4c84-8011-bd4dc9e6533d"),
                    RecipeId = RecipeSeedUUID.Ratatouille,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("3901e8a5-b0ff-4cd9-8a31-7f464a814bf4"),
                    RecipeId = RecipeSeedUUID.Ratatouille,
                    Text = "Season and cook until Ratatouille is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("2e04d273-a3e6-454f-b8cc-1c8d41bd9f72"),
                    RecipeId = RecipeSeedUUID.Ratatouille,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("1a9ca981-a48f-49d6-a671-3cf06ff0640e"),
                    RecipeId = RecipeSeedUUID.Ratatouille,
                    Text = "Plate Ratatouille and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("6ba26308-fc44-491f-900f-6040e55157e2"),
                    RecipeId = RecipeSeedUUID.QuicheLorraine,
                    Text = "Prep ingredients for Quiche Lorraine.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("56492297-6ee6-422a-9dc1-e2c7d618e221"),
                    RecipeId = RecipeSeedUUID.QuicheLorraine,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("2a51e90e-d1a1-4aec-b088-0540e84fcdfc"),
                    RecipeId = RecipeSeedUUID.QuicheLorraine,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("b5be1d3c-8165-41a3-9f98-36fe338d4014"),
                    RecipeId = RecipeSeedUUID.QuicheLorraine,
                    Text = "Season and cook until Quiche Lorraine is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("1cbb8c95-0508-4391-a836-41e5c1569cf2"),
                    RecipeId = RecipeSeedUUID.QuicheLorraine,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("2c8cb058-230a-4e38-bc6c-7f3b9ad8794d"),
                    RecipeId = RecipeSeedUUID.QuicheLorraine,
                    Text = "Plate Quiche Lorraine and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("5231c63a-73d9-4ea2-960b-9c7bcff8cef3"),
                    RecipeId = RecipeSeedUUID.Crepes,
                    Text = "Prep ingredients for Crepes.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("e5078c07-1225-4cbc-a8b1-5021c5a7c68b"),
                    RecipeId = RecipeSeedUUID.Crepes,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("897cfaeb-8105-40b1-bd7c-78a72f13a5f5"),
                    RecipeId = RecipeSeedUUID.Crepes,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("9f77fc0c-cb03-4cdb-aa11-d484c227059a"),
                    RecipeId = RecipeSeedUUID.Crepes,
                    Text = "Season and cook until Crepes is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("e012cb66-41f4-44b2-adbd-728b65519606"),
                    RecipeId = RecipeSeedUUID.Crepes,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("78c7a68c-55e8-4ca1-98f6-ecf6676bdaad"),
                    RecipeId = RecipeSeedUUID.Crepes,
                    Text = "Plate Crepes and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("9a232d53-ca1c-4b58-9dab-509f5d39cc63"),
                    RecipeId = RecipeSeedUUID.CoqAuVin,
                    Text = "Prep ingredients for Coq au Vin.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("dedbbb87-7978-494e-8620-b0a701ba7fc4"),
                    RecipeId = RecipeSeedUUID.CoqAuVin,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("26bee7c8-45f4-43b2-9113-ea14ba57da8c"),
                    RecipeId = RecipeSeedUUID.CoqAuVin,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("215e43b0-936e-42fb-be89-78c3212bd90a"),
                    RecipeId = RecipeSeedUUID.CoqAuVin,
                    Text = "Season and cook until Coq au Vin is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("996ee38c-d38d-4329-9a1f-b2c53275ad83"),
                    RecipeId = RecipeSeedUUID.CoqAuVin,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("e2a2cd34-213a-4978-a732-0ea614c21430"),
                    RecipeId = RecipeSeedUUID.CoqAuVin,
                    Text = "Plate Coq au Vin and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("94e0fefc-0018-47da-8c65-2a3dc980d791"),
                    RecipeId = RecipeSeedUUID.GreekSalad,
                    Text = "Prep ingredients for Greek Salad.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("2607d8f3-fb06-4609-9bea-fb89cb8607ac"),
                    RecipeId = RecipeSeedUUID.GreekSalad,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("6ca98464-9662-42e2-a9dd-d81d668ec5f5"),
                    RecipeId = RecipeSeedUUID.GreekSalad,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("666f5878-6473-4944-a84d-073d9e2cae0f"),
                    RecipeId = RecipeSeedUUID.GreekSalad,
                    Text = "Season and cook until Greek Salad is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("31ef20eb-b8d2-4ee3-9d44-df0dee3f1f35"),
                    RecipeId = RecipeSeedUUID.GreekSalad,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("b2e58307-4f73-46da-a0f3-2170556f376e"),
                    RecipeId = RecipeSeedUUID.GreekSalad,
                    Text = "Plate Greek Salad and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("c7ed582f-4af6-4e43-b2dc-77706b7605d2"),
                    RecipeId = RecipeSeedUUID.Souvlaki,
                    Text = "Prep ingredients for Chicken Souvlaki.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("70f3ce8b-bb9b-4d79-aaf6-c3715c941b8e"),
                    RecipeId = RecipeSeedUUID.Souvlaki,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("59c72ab6-9661-4123-a814-6b596c691ad4"),
                    RecipeId = RecipeSeedUUID.Souvlaki,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("7b6f367d-2f53-4433-99a8-020d6426b572"),
                    RecipeId = RecipeSeedUUID.Souvlaki,
                    Text = "Season and cook until Chicken Souvlaki is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("4b277bf8-a92f-4fae-a390-d3a4a5f11acb"),
                    RecipeId = RecipeSeedUUID.Souvlaki,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("6c0b330d-346d-4160-b495-781e7c85aae1"),
                    RecipeId = RecipeSeedUUID.Souvlaki,
                    Text = "Plate Chicken Souvlaki and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("270f11c9-1ecb-4043-87b9-bc03e7f4335c"),
                    RecipeId = RecipeSeedUUID.Spanakopita,
                    Text = "Prep ingredients for Spanakopita.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("d108526f-0087-470e-b308-d77197267a95"),
                    RecipeId = RecipeSeedUUID.Spanakopita,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("1f322eab-1152-4265-a1b0-dfd37433c4e8"),
                    RecipeId = RecipeSeedUUID.Spanakopita,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("a74b9b9b-a19e-4ee5-9081-7e1082287fd3"),
                    RecipeId = RecipeSeedUUID.Spanakopita,
                    Text = "Season and cook until Spanakopita is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("ea3c446e-c879-4b46-8bf6-3dffd51d8d6e"),
                    RecipeId = RecipeSeedUUID.Spanakopita,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("ef67efde-dac5-4ba9-a392-45a05ce6bae2"),
                    RecipeId = RecipeSeedUUID.Spanakopita,
                    Text = "Plate Spanakopita and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("43732a0f-0847-4a17-962a-5844051709e7"),
                    RecipeId = RecipeSeedUUID.BaklavaGreek,
                    Text = "Prep ingredients for Baklava.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("42e59771-5253-491f-a628-94c096fd1d7a"),
                    RecipeId = RecipeSeedUUID.BaklavaGreek,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("87006a3b-e235-4cfb-b4ff-382e2a8d944b"),
                    RecipeId = RecipeSeedUUID.BaklavaGreek,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("ad03479c-049e-4055-9ed2-52c28756e87b"),
                    RecipeId = RecipeSeedUUID.BaklavaGreek,
                    Text = "Season and cook until Baklava is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("6fb96481-2a34-4dd3-b673-32223639997d"),
                    RecipeId = RecipeSeedUUID.BaklavaGreek,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("8a75c539-847a-44ab-bbda-dd99833b076d"),
                    RecipeId = RecipeSeedUUID.BaklavaGreek,
                    Text = "Plate Baklava and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("c6571443-01bc-45b0-bdfe-02ddfda7bb06"),
                    RecipeId = RecipeSeedUUID.ShepherdsPie,
                    Text = "Prep ingredients for Shepherd's Pie.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("9910a4fc-60d8-4479-a9ac-9c38db2f7bed"),
                    RecipeId = RecipeSeedUUID.ShepherdsPie,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("9f27aa16-7a51-4854-bad4-687ebbea0d95"),
                    RecipeId = RecipeSeedUUID.ShepherdsPie,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("2b34ef72-0508-40d2-b919-3cc0f7f3c604"),
                    RecipeId = RecipeSeedUUID.ShepherdsPie,
                    Text = "Season and cook until Shepherd's Pie is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("09caa2bd-0b41-47f8-a54a-10cb6b80cd58"),
                    RecipeId = RecipeSeedUUID.ShepherdsPie,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("6d2e20ac-b849-4977-a0f1-1a3e1069e18f"),
                    RecipeId = RecipeSeedUUID.ShepherdsPie,
                    Text = "Plate Shepherd's Pie and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("c977e857-bee6-436c-9b5c-36de8fb8b67f"),
                    RecipeId = RecipeSeedUUID.Scones,
                    Text = "Prep ingredients for Cream Scones.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("e9c3dc9f-703f-473c-8395-c168c129bbc8"),
                    RecipeId = RecipeSeedUUID.Scones,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("3ebef880-16e6-43f6-8748-436d1a74511b"),
                    RecipeId = RecipeSeedUUID.Scones,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("1a832a2b-8ad6-4cab-b41a-e107a4c5e4cd"),
                    RecipeId = RecipeSeedUUID.Scones,
                    Text = "Season and cook until Cream Scones is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("bd959276-e31d-4a93-991e-03f476eea7dc"),
                    RecipeId = RecipeSeedUUID.Scones,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("3025f7c4-fbc3-4b7d-8296-0247dd65b26d"),
                    RecipeId = RecipeSeedUUID.Scones,
                    Text = "Plate Cream Scones and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("287ab4ab-ffbe-4df2-802e-fd6419dc9fd7"),
                    RecipeId = RecipeSeedUUID.StickyToffee,
                    Text = "Prep ingredients for Sticky Toffee Pudding.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("6c8206de-48bb-4405-83bf-a4e1620e323d"),
                    RecipeId = RecipeSeedUUID.StickyToffee,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("4d1b423a-e428-4f0c-93fd-97e217a30baa"),
                    RecipeId = RecipeSeedUUID.StickyToffee,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("cad08318-058c-4336-9938-9f41b0b1d031"),
                    RecipeId = RecipeSeedUUID.StickyToffee,
                    Text = "Season and cook until Sticky Toffee Pudding is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("736deb06-68e4-4e76-bfd9-aff297fa45a5"),
                    RecipeId = RecipeSeedUUID.StickyToffee,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("ff7a3d10-fa26-4777-b2b4-f0ead0bc731a"),
                    RecipeId = RecipeSeedUUID.StickyToffee,
                    Text = "Plate Sticky Toffee Pudding and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("fb526897-b5e8-418a-81e2-a7be1c8eba05"),
                    RecipeId = RecipeSeedUUID.Bibimbap,
                    Text = "Prep ingredients for Bibimbap.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("fb3342db-e8be-4475-a665-7c7d03863f0d"),
                    RecipeId = RecipeSeedUUID.Bibimbap,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("bd905e9d-754d-4cc4-8977-34c05fa2cd45"),
                    RecipeId = RecipeSeedUUID.Bibimbap,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("19a1a2ed-8daf-4745-9902-4e06d34d5f0a"),
                    RecipeId = RecipeSeedUUID.Bibimbap,
                    Text = "Season and cook until Bibimbap is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("c1500447-05db-4ee7-a74d-93415319442e"),
                    RecipeId = RecipeSeedUUID.Bibimbap,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("500cf04a-7910-4f1d-9486-7c6a73f3c651"),
                    RecipeId = RecipeSeedUUID.Bibimbap,
                    Text = "Plate Bibimbap and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("c1429280-4cfb-4f06-9f28-4ab5d20d1305"),
                    RecipeId = RecipeSeedUUID.Tteokbokki,
                    Text = "Prep ingredients for Tteokbokki.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("2c4f8a41-44d6-4f0b-8c3f-f6369e4fe9a9"),
                    RecipeId = RecipeSeedUUID.Tteokbokki,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("c495c2f9-911c-4213-b3ca-e6fe7ccad118"),
                    RecipeId = RecipeSeedUUID.Tteokbokki,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("f1dc1fa1-9376-4b55-9abd-4ba5dac23243"),
                    RecipeId = RecipeSeedUUID.Tteokbokki,
                    Text = "Season and cook until Tteokbokki is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("d1d6681c-e598-4ec7-8f77-b4b2360a1123"),
                    RecipeId = RecipeSeedUUID.Tteokbokki,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("4e464b7d-0c82-44ee-8dac-f872c0ce9014"),
                    RecipeId = RecipeSeedUUID.Tteokbokki,
                    Text = "Plate Tteokbokki and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("df0fe104-fdf1-46bc-8188-ca08f928cf65"),
                    RecipeId = RecipeSeedUUID.Bulgogi,
                    Text = "Prep ingredients for Beef Bulgogi.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("afdd7f74-c443-4f98-92e2-5d3cf0c718d7"),
                    RecipeId = RecipeSeedUUID.Bulgogi,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("951707b3-43b3-488f-a0d1-d7951eb18499"),
                    RecipeId = RecipeSeedUUID.Bulgogi,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("eea7d8d8-ec53-4b8f-aed5-11f840feb3e5"),
                    RecipeId = RecipeSeedUUID.Bulgogi,
                    Text = "Season and cook until Beef Bulgogi is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("fe346a6b-7022-40cb-a902-5b35b2bd1ea0"),
                    RecipeId = RecipeSeedUUID.Bulgogi,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("643ded63-6794-4a08-a50f-4539fb5993bd"),
                    RecipeId = RecipeSeedUUID.Bulgogi,
                    Text = "Plate Beef Bulgogi and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("97e3ccf2-e246-41a1-b69c-5afccbcb9c63"),
                    RecipeId = RecipeSeedUUID.Japchae,
                    Text = "Prep ingredients for Japchae.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("726e71f7-914e-44ac-8f0f-4c1fb6108c01"),
                    RecipeId = RecipeSeedUUID.Japchae,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("5571c370-63eb-4033-af2f-1972cc1c2610"),
                    RecipeId = RecipeSeedUUID.Japchae,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("987477f4-c45b-441d-abdf-6fda6f24d9a9"),
                    RecipeId = RecipeSeedUUID.Japchae,
                    Text = "Season and cook until Japchae is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("4c1dfa7b-a2ef-49fe-b173-cc9b96001d23"),
                    RecipeId = RecipeSeedUUID.Japchae,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("9e404fbd-a927-48e3-863a-62939c356e48"),
                    RecipeId = RecipeSeedUUID.Japchae,
                    Text = "Plate Japchae and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("a72e3ebb-103d-44cb-824f-86ce7cf0732a"),
                    RecipeId = RecipeSeedUUID.KoreanFriedChicken,
                    Text = "Prep ingredients for Korean Fried Chicken.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("d2766e55-87d9-4eb2-a95d-29562c0e4679"),
                    RecipeId = RecipeSeedUUID.KoreanFriedChicken,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("7c7bf9de-6fce-40bc-8773-d7381a5feebe"),
                    RecipeId = RecipeSeedUUID.KoreanFriedChicken,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("ccbc042b-6e9a-4244-97ef-9c931ab7b441"),
                    RecipeId = RecipeSeedUUID.KoreanFriedChicken,
                    Text = "Season and cook until Korean Fried Chicken is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("b297ba14-c5d2-45b0-a848-8faebab51148"),
                    RecipeId = RecipeSeedUUID.KoreanFriedChicken,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("95498497-c4ec-4f63-b4a7-f70f661e050d"),
                    RecipeId = RecipeSeedUUID.KoreanFriedChicken,
                    Text = "Plate Korean Fried Chicken and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("1af0a3a9-9e25-4e61-ba94-286d88ec5a43"),
                    RecipeId = RecipeSeedUUID.Menemen,
                    Text = "Prep ingredients for Menemen.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("1c56980f-21bc-4edb-8594-84d82dbd29e4"),
                    RecipeId = RecipeSeedUUID.Menemen,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("ade46a9a-4f74-4328-a565-885fdcddb078"),
                    RecipeId = RecipeSeedUUID.Menemen,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("d6b5d4d9-3ef3-414c-bfe4-1faea92abb71"),
                    RecipeId = RecipeSeedUUID.Menemen,
                    Text = "Season and cook until Menemen is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("b444e4d9-1a8d-478d-babc-5d6c2c128f09"),
                    RecipeId = RecipeSeedUUID.Menemen,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("78ef2636-b237-47d7-b65d-42aafe38f4f8"),
                    RecipeId = RecipeSeedUUID.Menemen,
                    Text = "Plate Menemen and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("3dff3e87-784a-4722-8ec9-a0feb2b73466"),
                    RecipeId = RecipeSeedUUID.LentilSoup,
                    Text = "Prep ingredients for Turkish Lentil Soup.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("ec98a613-bc2d-49a9-8f27-9dd24f60fd4f"),
                    RecipeId = RecipeSeedUUID.LentilSoup,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("ff16f87f-f339-4077-8469-d3494424b077"),
                    RecipeId = RecipeSeedUUID.LentilSoup,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("1f6585ad-d092-487b-bdba-a37827c687a5"),
                    RecipeId = RecipeSeedUUID.LentilSoup,
                    Text = "Season and cook until Turkish Lentil Soup is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("0d0c8a3c-51a2-4461-b220-dfb6ee71e3bd"),
                    RecipeId = RecipeSeedUUID.LentilSoup,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("8b740de0-80f2-4163-ba2e-4953d535abc2"),
                    RecipeId = RecipeSeedUUID.LentilSoup,
                    Text = "Plate Turkish Lentil Soup and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("2845522f-5485-410a-944a-a5a07f88ae6c"),
                    RecipeId = RecipeSeedUUID.Lahmacun,
                    Text = "Prep ingredients for Lahmacun.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("b9e43af6-d4f9-463c-8fba-0ff026bb84b0"),
                    RecipeId = RecipeSeedUUID.Lahmacun,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("ddd6724b-9303-4285-8004-72e1039f98a9"),
                    RecipeId = RecipeSeedUUID.Lahmacun,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("11f65e76-f568-4ece-a411-096c987508f1"),
                    RecipeId = RecipeSeedUUID.Lahmacun,
                    Text = "Season and cook until Lahmacun is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("2713be63-7780-4a1e-add9-66f673d6c4f1"),
                    RecipeId = RecipeSeedUUID.Lahmacun,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("b185d1df-4fb8-4e22-8dc6-6b792050fef9"),
                    RecipeId = RecipeSeedUUID.Lahmacun,
                    Text = "Plate Lahmacun and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("1a1cf924-ad79-431a-813c-9a93bd6bd98d"),
                    RecipeId = RecipeSeedUUID.Koshari,
                    Text = "Prep ingredients for Koshari.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("cdf275d5-868b-44ab-b490-c3cb6fc7d017"),
                    RecipeId = RecipeSeedUUID.Koshari,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("965046d6-98f3-41cf-bd07-c9499e5cdaf9"),
                    RecipeId = RecipeSeedUUID.Koshari,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("b7e4d095-993c-43cd-ba60-319ddac48a42"),
                    RecipeId = RecipeSeedUUID.Koshari,
                    Text = "Season and cook until Koshari is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("fec1a6fa-ddc2-426d-b720-e5db82e8d036"),
                    RecipeId = RecipeSeedUUID.Koshari,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("963f3ccb-7365-440b-9951-65d4f043b44d"),
                    RecipeId = RecipeSeedUUID.Koshari,
                    Text = "Plate Koshari and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("1840aa2d-1569-4cbf-a3f9-0fc3cbf7c8c6"),
                    RecipeId = RecipeSeedUUID.FulMedames,
                    Text = "Prep ingredients for Ful Medames.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("37a47883-2ebd-44f7-979b-253a0a6b8b6b"),
                    RecipeId = RecipeSeedUUID.FulMedames,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("ccb1e8cf-e7e4-4cdb-a137-4649a8557b95"),
                    RecipeId = RecipeSeedUUID.FulMedames,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("4734ca3a-a981-4b83-a1ea-b90ffa102d5d"),
                    RecipeId = RecipeSeedUUID.FulMedames,
                    Text = "Season and cook until Ful Medames is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("53012825-5048-427e-8b80-7369e8ea34f7"),
                    RecipeId = RecipeSeedUUID.FulMedames,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("56e01bba-c013-4705-a2e6-f286c4d1cbe5"),
                    RecipeId = RecipeSeedUUID.FulMedames,
                    Text = "Plate Ful Medames and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("fa6b4830-5b97-4c79-aa8b-1fb79bff5d0a"),
                    RecipeId = RecipeSeedUUID.Taameya,
                    Text = "Prep ingredients for Taameya.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("28bfc120-557a-4647-b82d-0898c9130b0a"),
                    RecipeId = RecipeSeedUUID.Taameya,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("652f044c-cb96-4451-95f7-3f665554bd03"),
                    RecipeId = RecipeSeedUUID.Taameya,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("e660c690-5be4-4f1e-9a3c-97a965c36cf7"),
                    RecipeId = RecipeSeedUUID.Taameya,
                    Text = "Season and cook until Taameya is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("ea7bfb27-1f4c-4106-a062-e4a30dd63c47"),
                    RecipeId = RecipeSeedUUID.Taameya,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("958f2320-bb7c-4fe4-9efc-35e46c26e6c6"),
                    RecipeId = RecipeSeedUUID.Taameya,
                    Text = "Plate Taameya and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("4df1b1f1-faa3-4153-b871-dd2837087855"),
                    RecipeId = RecipeSeedUUID.PaoDeQueijo,
                    Text = "Prep ingredients for Pao de Queijo.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("ab99d69f-ff8f-45f3-a44c-9c3d0b38bf78"),
                    RecipeId = RecipeSeedUUID.PaoDeQueijo,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("8fc5d93b-7b06-437c-af06-eba1c46c9753"),
                    RecipeId = RecipeSeedUUID.PaoDeQueijo,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("0da51890-a3fc-4219-9d8b-1043b3d83fb6"),
                    RecipeId = RecipeSeedUUID.PaoDeQueijo,
                    Text = "Season and cook until Pao de Queijo is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("e9962ed6-5766-4880-8449-a61fa03ab953"),
                    RecipeId = RecipeSeedUUID.PaoDeQueijo,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("d5d62d88-afd1-4277-bf64-27a7d1885b00"),
                    RecipeId = RecipeSeedUUID.PaoDeQueijo,
                    Text = "Plate Pao de Queijo and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("ff570366-5131-4b25-9797-c4e291cbc49d"),
                    RecipeId = RecipeSeedUUID.Moqueca,
                    Text = "Prep ingredients for Moqueca.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("0df584ed-7cfc-46f2-abed-03fcb9ae9e50"),
                    RecipeId = RecipeSeedUUID.Moqueca,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("6d0295ad-51f4-43c4-b7b8-2a35cc6ca8b6"),
                    RecipeId = RecipeSeedUUID.Moqueca,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("b28f70c6-35d5-4df4-8083-ffbd68dfab45"),
                    RecipeId = RecipeSeedUUID.Moqueca,
                    Text = "Season and cook until Moqueca is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("36d55cfa-8c02-4b97-875f-34fc865ca5e2"),
                    RecipeId = RecipeSeedUUID.Moqueca,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("46482c2b-87a7-40f4-b088-e581b4a0e9d4"),
                    RecipeId = RecipeSeedUUID.Moqueca,
                    Text = "Plate Moqueca and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("e4e9c6b7-ff3b-49f6-b0a8-ac405fd047e3"),
                    RecipeId = RecipeSeedUUID.Brigadeiro,
                    Text = "Prep ingredients for Brigadeiro.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("60e1b331-e0fd-4e2a-a1b3-556c205e03e4"),
                    RecipeId = RecipeSeedUUID.Brigadeiro,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("caed3583-0e10-4a82-9d16-dc57cbed55c2"),
                    RecipeId = RecipeSeedUUID.Brigadeiro,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("f511c92c-de6a-4247-aff9-616189fa1dd1"),
                    RecipeId = RecipeSeedUUID.Brigadeiro,
                    Text = "Season and cook until Brigadeiro is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("03f12243-f87e-454f-b4de-b5f60e47f798"),
                    RecipeId = RecipeSeedUUID.Brigadeiro,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("cd58e40f-81f0-47c0-94b4-ad3b8504d708"),
                    RecipeId = RecipeSeedUUID.Brigadeiro,
                    Text = "Plate Brigadeiro and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("48baf3ed-73e6-4634-a5eb-1cbaaa6d9fc1"),
                    RecipeId = RecipeSeedUUID.LomoSaltado,
                    Text = "Prep ingredients for Lomo Saltado.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("ed9792dc-8c20-413e-a99e-39e88e6a82c4"),
                    RecipeId = RecipeSeedUUID.LomoSaltado,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("d054e34a-ddf8-4310-a16d-ffefbff2eb14"),
                    RecipeId = RecipeSeedUUID.LomoSaltado,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("6628c426-a7ed-43ec-8a18-85439b4f2cf2"),
                    RecipeId = RecipeSeedUUID.LomoSaltado,
                    Text = "Season and cook until Lomo Saltado is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("cac8ceb4-e81b-4f54-9046-6925cf3c4e05"),
                    RecipeId = RecipeSeedUUID.LomoSaltado,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("28171b59-34cb-4869-bb8a-8254e4763160"),
                    RecipeId = RecipeSeedUUID.LomoSaltado,
                    Text = "Plate Lomo Saltado and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("c44580bd-658b-4f52-b08c-87d7e29bf5b8"),
                    RecipeId = RecipeSeedUUID.CausaLimeña,
                    Text = "Prep ingredients for Causa Limeña.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("85c6f4bc-3fec-4251-ab3f-2fd5e9b630f1"),
                    RecipeId = RecipeSeedUUID.CausaLimeña,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("226b113b-5afc-4696-bf87-270877d127c5"),
                    RecipeId = RecipeSeedUUID.CausaLimeña,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("631bd738-9474-4888-979b-1ef2ef46dff2"),
                    RecipeId = RecipeSeedUUID.CausaLimeña,
                    Text = "Season and cook until Causa Limeña is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("c25e4790-3045-4988-86d0-3979adde504c"),
                    RecipeId = RecipeSeedUUID.CausaLimeña,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("867449f3-7499-4eec-89d2-166ad3ecece2"),
                    RecipeId = RecipeSeedUUID.CausaLimeña,
                    Text = "Plate Causa Limeña and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("1ef93594-bf4d-4494-9411-b74048d4d778"),
                    RecipeId = RecipeSeedUUID.ChickenKarahi,
                    Text = "Prep ingredients for Chicken Karahi.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("776e7f14-4324-4cb3-8ca4-8ffc3f3e1f89"),
                    RecipeId = RecipeSeedUUID.ChickenKarahi,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("9c99eb7c-e5c4-465c-9844-bd26f75be14e"),
                    RecipeId = RecipeSeedUUID.ChickenKarahi,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("751d2c1d-7039-4d6e-9b4b-150ed065995d"),
                    RecipeId = RecipeSeedUUID.ChickenKarahi,
                    Text = "Season and cook until Chicken Karahi is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("4b4d3736-324f-44f8-859b-8c3748776d30"),
                    RecipeId = RecipeSeedUUID.ChickenKarahi,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("47f99c9b-7bbf-437f-8d18-077cb5753fa0"),
                    RecipeId = RecipeSeedUUID.ChickenKarahi,
                    Text = "Plate Chicken Karahi and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("abff5797-f408-4375-ba52-798b99efdab2"),
                    RecipeId = RecipeSeedUUID.Nihari,
                    Text = "Prep ingredients for Nihari.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("54b90d77-73a9-4c35-9e10-94473122b545"),
                    RecipeId = RecipeSeedUUID.Nihari,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("d398ea27-69d7-492e-b552-d2450e139856"),
                    RecipeId = RecipeSeedUUID.Nihari,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("150d28fd-1945-4fe4-af19-ff2723e9abc0"),
                    RecipeId = RecipeSeedUUID.Nihari,
                    Text = "Season and cook until Nihari is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("98c21002-1046-4564-a6c7-f452af93023b"),
                    RecipeId = RecipeSeedUUID.Nihari,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("65ab716d-6309-4c11-9d73-0c87914bbf6b"),
                    RecipeId = RecipeSeedUUID.Nihari,
                    Text = "Plate Nihari and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("222231b0-aad3-4908-86e7-141fb3f3cd03"),
                    RecipeId = RecipeSeedUUID.MalvaPudding,
                    Text = "Prep ingredients for Malva Pudding.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("5a481b82-2e44-4195-9b80-0c795bb7dcb0"),
                    RecipeId = RecipeSeedUUID.MalvaPudding,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("88970c98-e2b3-42cd-b055-dc7587c7e1fc"),
                    RecipeId = RecipeSeedUUID.MalvaPudding,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("ee8a4b72-b0eb-4af2-b3f1-3facd1992558"),
                    RecipeId = RecipeSeedUUID.MalvaPudding,
                    Text = "Season and cook until Malva Pudding is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("5e1ee19e-16cb-4341-ba5d-875f451a4538"),
                    RecipeId = RecipeSeedUUID.MalvaPudding,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("8f98fe78-0f09-4eb5-ae24-a63c8ae7d0e5"),
                    RecipeId = RecipeSeedUUID.MalvaPudding,
                    Text = "Plate Malva Pudding and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("29e1296b-15c1-4f9e-a92a-2ab531a34ae5"),
                    RecipeId = RecipeSeedUUID.Chakalaka,
                    Text = "Prep ingredients for Chakalaka.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("11b6a492-8398-4ccd-ac5e-ff845acb6651"),
                    RecipeId = RecipeSeedUUID.Chakalaka,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("1a570819-3b36-49ff-bb34-a8cea0555668"),
                    RecipeId = RecipeSeedUUID.Chakalaka,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("c61aaa35-374a-46f6-864d-116c5ac906a3"),
                    RecipeId = RecipeSeedUUID.Chakalaka,
                    Text = "Season and cook until Chakalaka is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("3408c4a6-edd5-4ef9-96d9-d58fa175f8e0"),
                    RecipeId = RecipeSeedUUID.Chakalaka,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("12a3ab52-0553-4726-85e1-37cf33781a9b"),
                    RecipeId = RecipeSeedUUID.Chakalaka,
                    Text = "Plate Chakalaka and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("e89cf37c-1e6d-47d3-9610-d694a02c308d"),
                    RecipeId = RecipeSeedUUID.Bigos,
                    Text = "Prep ingredients for Bigos.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("49e93a35-35b7-404e-858b-924ebc75e200"),
                    RecipeId = RecipeSeedUUID.Bigos,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("3edc7a6b-c5a7-4f2c-9270-25a41ff18d9d"),
                    RecipeId = RecipeSeedUUID.Bigos,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("6c8780f0-fd22-4295-8edd-3a2235d07590"),
                    RecipeId = RecipeSeedUUID.Bigos,
                    Text = "Season and cook until Bigos is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("a0cb3632-5b3f-486a-a6da-df0a52fda9b6"),
                    RecipeId = RecipeSeedUUID.Bigos,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("0251440b-fa6d-4748-9b09-f6164f0fe1ee"),
                    RecipeId = RecipeSeedUUID.Bigos,
                    Text = "Plate Bigos and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("05794c87-6b93-4cd5-8832-c1e3bcd3dc60"),
                    RecipeId = RecipeSeedUUID.Zurek,
                    Text = "Prep ingredients for Zurek.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("c379cbfc-f51c-4825-b8f2-53500fc9bf33"),
                    RecipeId = RecipeSeedUUID.Zurek,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("9ed63f2b-b8dd-4b2e-8fa3-9c76d911fcdd"),
                    RecipeId = RecipeSeedUUID.Zurek,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("23a2fc43-9756-44f3-bac9-850009cea81b"),
                    RecipeId = RecipeSeedUUID.Zurek,
                    Text = "Season and cook until Zurek is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("d9da564a-d1cc-4f04-b5ea-0cd23e2d38ca"),
                    RecipeId = RecipeSeedUUID.Zurek,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("990e7dba-68bd-4a8d-a6ef-950ce0ac8030"),
                    RecipeId = RecipeSeedUUID.Zurek,
                    Text = "Plate Zurek and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("3c5ae3de-1ab5-486c-8a38-cb36e974f456"),
                    RecipeId = RecipeSeedUUID.Borscht,
                    Text = "Prep ingredients for Borscht.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("4bfb4ffe-c8a8-4ceb-99db-8391b3a5cf3d"),
                    RecipeId = RecipeSeedUUID.Borscht,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("badcafde-9d41-46f8-81f0-4acbb8fc5c67"),
                    RecipeId = RecipeSeedUUID.Borscht,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("c7e64c9d-a9c6-49e7-afc2-feb76c48b71d"),
                    RecipeId = RecipeSeedUUID.Borscht,
                    Text = "Season and cook until Borscht is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("523d791b-4502-4146-969e-ab888ed6f727"),
                    RecipeId = RecipeSeedUUID.Borscht,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("ab0907d0-d3c9-4dfe-871d-91b2566476cc"),
                    RecipeId = RecipeSeedUUID.Borscht,
                    Text = "Plate Borscht and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("d9ad9edc-8a61-4ddb-bf84-f6ffdf58b20b"),
                    RecipeId = RecipeSeedUUID.Pelmeni,
                    Text = "Prep ingredients for Pelmeni.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("9c905f71-75c1-4788-ba2d-d3ee6ec44d48"),
                    RecipeId = RecipeSeedUUID.Pelmeni,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("2b0bc62f-1519-47fe-b606-ca49d5905610"),
                    RecipeId = RecipeSeedUUID.Pelmeni,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("9d9015ab-6376-4402-8895-12e9e5ab1763"),
                    RecipeId = RecipeSeedUUID.Pelmeni,
                    Text = "Season and cook until Pelmeni is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("b58d5b59-3a07-463f-b91f-c15249f3d1db"),
                    RecipeId = RecipeSeedUUID.Pelmeni,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("833868bd-48e0-44ca-82a9-cf9a641b532f"),
                    RecipeId = RecipeSeedUUID.Pelmeni,
                    Text = "Plate Pelmeni and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("aa155c36-95c3-4e4a-a380-d4a66e3a1633"),
                    RecipeId = RecipeSeedUUID.Paella,
                    Text = "Prep ingredients for Seafood Paella.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("4232ff8b-0b8a-488b-a03d-1aa816ac8c36"),
                    RecipeId = RecipeSeedUUID.Paella,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("812acc47-b9fc-469e-a7d6-ad96986744d2"),
                    RecipeId = RecipeSeedUUID.Paella,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("f7a356a7-3eb1-4c84-88f1-fe6cbab2248b"),
                    RecipeId = RecipeSeedUUID.Paella,
                    Text = "Season and cook until Seafood Paella is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("98854807-e90a-4aff-8dd2-a60e38f2b82a"),
                    RecipeId = RecipeSeedUUID.Paella,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("cce7c930-3f3c-4489-8334-488fae4b1a2a"),
                    RecipeId = RecipeSeedUUID.Paella,
                    Text = "Plate Seafood Paella and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("a7f6391f-699b-456b-b223-ea861e4f7d98"),
                    RecipeId = RecipeSeedUUID.Gazpacho,
                    Text = "Prep ingredients for Gazpacho.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("3af7df43-049e-4d74-afd4-356d470313d1"),
                    RecipeId = RecipeSeedUUID.Gazpacho,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("c79139f6-23be-4220-a4f1-1d2c9bafbb21"),
                    RecipeId = RecipeSeedUUID.Gazpacho,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("04addcd3-31d6-4b0e-b5aa-7d4f6c6c4889"),
                    RecipeId = RecipeSeedUUID.Gazpacho,
                    Text = "Season and cook until Gazpacho is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("1cf264ce-4e14-4b6b-b0f2-b03fd3b49bf0"),
                    RecipeId = RecipeSeedUUID.Gazpacho,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("81c8b5fd-d015-4a33-9dcb-9288ea49d36d"),
                    RecipeId = RecipeSeedUUID.Gazpacho,
                    Text = "Plate Gazpacho and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("03b091c4-828b-4e40-bca9-a796c6644bf4"),
                    RecipeId = RecipeSeedUUID.Schnitzel,
                    Text = "Prep ingredients for Wiener Schnitzel.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("07b48aed-44d9-47cc-8f05-acb367968959"),
                    RecipeId = RecipeSeedUUID.Schnitzel,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("0b6af32f-7ae4-4966-89d4-36a4e9545f91"),
                    RecipeId = RecipeSeedUUID.Schnitzel,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("38da6b6c-5953-4bd1-9cb4-201f9d0d7ecb"),
                    RecipeId = RecipeSeedUUID.Schnitzel,
                    Text = "Season and cook until Wiener Schnitzel is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("f53e1fb2-1036-4937-b607-4c3e21bbd63e"),
                    RecipeId = RecipeSeedUUID.Schnitzel,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("cc29f970-5a1d-435d-99df-5fd1b7bc011a"),
                    RecipeId = RecipeSeedUUID.Schnitzel,
                    Text = "Plate Wiener Schnitzel and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("22cc85c0-1282-46cf-abe5-1641a7834843"),
                    RecipeId = RecipeSeedUUID.Pretzels,
                    Text = "Prep ingredients for Soft Pretzels.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("db80260c-7f17-4492-ae12-7118de386dc1"),
                    RecipeId = RecipeSeedUUID.Pretzels,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("401756d4-c350-4216-85d1-9f89e20e86c6"),
                    RecipeId = RecipeSeedUUID.Pretzels,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("e2aa5b73-277c-4906-a5c1-f9e72628cc04"),
                    RecipeId = RecipeSeedUUID.Pretzels,
                    Text = "Season and cook until Soft Pretzels is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("cf244451-fcf4-4e6b-b835-ca99608f9585"),
                    RecipeId = RecipeSeedUUID.Pretzels,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("cea210b1-e318-4d4b-9228-08f32e3491b5"),
                    RecipeId = RecipeSeedUUID.Pretzels,
                    Text = "Plate Soft Pretzels and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("351abc47-f038-4bc2-bd85-4584cf23e583"),
                    RecipeId = RecipeSeedUUID.Tagine,
                    Text = "Prep ingredients for Chicken Tagine.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("239c199f-d59e-4254-928f-bccc00b1b9b6"),
                    RecipeId = RecipeSeedUUID.Tagine,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("4d1d449c-cba4-4ba0-8c9f-c97a431a9b52"),
                    RecipeId = RecipeSeedUUID.Tagine,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("752f5989-73bd-4869-a622-2d1f42e9e37a"),
                    RecipeId = RecipeSeedUUID.Tagine,
                    Text = "Season and cook until Chicken Tagine is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("33262787-824a-46d5-9a99-59cfd8a48b35"),
                    RecipeId = RecipeSeedUUID.Tagine,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("86774c2e-9537-458e-b74f-14a18065c873"),
                    RecipeId = RecipeSeedUUID.Tagine,
                    Text = "Plate Chicken Tagine and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("fd51efe8-fb38-4c62-b5d6-7a308c87f7e5"),
                    RecipeId = RecipeSeedUUID.JollofRice,
                    Text = "Prep ingredients for Jollof Rice.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("0ef1ba44-c440-40d0-9270-9847eb50b90c"),
                    RecipeId = RecipeSeedUUID.JollofRice,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("2005c3db-9cde-4ee0-b3f8-930e29fe43cb"),
                    RecipeId = RecipeSeedUUID.JollofRice,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("aaac65b9-2aaf-472d-b926-5c408c499790"),
                    RecipeId = RecipeSeedUUID.JollofRice,
                    Text = "Season and cook until Jollof Rice is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("5f4b0b85-02b5-404e-aeb6-e7a8966d411e"),
                    RecipeId = RecipeSeedUUID.JollofRice,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("27085eae-3849-4d17-bfac-012071f54ca7"),
                    RecipeId = RecipeSeedUUID.JollofRice,
                    Text = "Plate Jollof Rice and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("6d5c5a33-8d34-4c6e-a406-5e7899a84a91"),
                    RecipeId = RecipeSeedUUID.JerkChicken,
                    Text = "Prep ingredients for Jerk Chicken.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7a6470e9-59ec-48e9-bb66-d463313cd852"),
                    RecipeId = RecipeSeedUUID.JerkChicken,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("0b502a3d-b646-41b6-a0e5-6bfdaa2f59aa"),
                    RecipeId = RecipeSeedUUID.JerkChicken,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("43d3852e-bae0-459b-981e-7ee8a0193d8f"),
                    RecipeId = RecipeSeedUUID.JerkChicken,
                    Text = "Season and cook until Jerk Chicken is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("5223d474-01a9-4f75-ad5e-3bb391690bd2"),
                    RecipeId = RecipeSeedUUID.JerkChicken,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("4454d40f-2a45-4d3b-9808-e1d734bd7aae"),
                    RecipeId = RecipeSeedUUID.JerkChicken,
                    Text = "Plate Jerk Chicken and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("457ff509-e481-4be2-b91a-0c9fbe4c7a37"),
                    RecipeId = RecipeSeedUUID.Empanadas,
                    Text = "Prep ingredients for Beef Empanadas.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("e2abb3bb-becb-48e1-bcf2-1be5c7656388"),
                    RecipeId = RecipeSeedUUID.Empanadas,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("f37086cf-ba2a-405f-b06d-9f348b2b6a6f"),
                    RecipeId = RecipeSeedUUID.Empanadas,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("dbc03cc7-2b17-43cf-b89c-d7409010ed65"),
                    RecipeId = RecipeSeedUUID.Empanadas,
                    Text = "Season and cook until Beef Empanadas is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("8802d2f6-ca4b-42f5-94e6-b568af5d0080"),
                    RecipeId = RecipeSeedUUID.Empanadas,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("76fbb1aa-e69e-4972-ad04-49a836a66883"),
                    RecipeId = RecipeSeedUUID.Empanadas,
                    Text = "Plate Beef Empanadas and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("5f58cc11-b3ba-46db-b96b-bff0afd909b7"),
                    RecipeId = RecipeSeedUUID.Adobo,
                    Text = "Prep ingredients for Chicken Adobo.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("4c646bb1-8aae-4957-991b-8dc8a3d74dd5"),
                    RecipeId = RecipeSeedUUID.Adobo,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("63aae33e-98be-43b3-a648-843e683fd649"),
                    RecipeId = RecipeSeedUUID.Adobo,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("c2a231bc-71d1-4c09-9159-060d3c5c7707"),
                    RecipeId = RecipeSeedUUID.Adobo,
                    Text = "Season and cook until Chicken Adobo is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("ea64d546-1d72-4de5-add9-a8e6048beeba"),
                    RecipeId = RecipeSeedUUID.Adobo,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("baaabf04-8852-4d61-b949-a6b145cd0df7"),
                    RecipeId = RecipeSeedUUID.Adobo,
                    Text = "Plate Chicken Adobo and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("99e8ebb1-d067-4b4b-a0b8-c486742d1a58"),
                    RecipeId = RecipeSeedUUID.Bacalhau,
                    Text = "Prep ingredients for Bacalhau.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7ca8e436-5ab9-461c-a0f0-ee5b006f5a57"),
                    RecipeId = RecipeSeedUUID.Bacalhau,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("842a054b-1bfb-43ad-aaf0-1b68b9c51e79"),
                    RecipeId = RecipeSeedUUID.Bacalhau,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("462b61c1-176e-4cc1-8dde-d0d5e91810e2"),
                    RecipeId = RecipeSeedUUID.Bacalhau,
                    Text = "Season and cook until Bacalhau is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("2529b88f-62b1-4933-932b-24f9c1fb3cd2"),
                    RecipeId = RecipeSeedUUID.Bacalhau,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("691da40f-9cf4-472e-a843-b2f6d52957dc"),
                    RecipeId = RecipeSeedUUID.Bacalhau,
                    Text = "Plate Bacalhau and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("b58dfc26-8988-429f-b92c-cfd3cebcbbd2"),
                    RecipeId = RecipeSeedUUID.Poutine,
                    Text = "Prep ingredients for Poutine.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("46a9b804-dc70-4c89-890d-cf00f5ef95ae"),
                    RecipeId = RecipeSeedUUID.Poutine,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("38e7bfff-513f-4b29-8c83-5d4a512d28fd"),
                    RecipeId = RecipeSeedUUID.Poutine,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("a15f9eb3-fe23-4b0f-a737-227285690bb2"),
                    RecipeId = RecipeSeedUUID.Poutine,
                    Text = "Season and cook until Poutine is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("2a71c5a3-e8e3-4692-8017-e276bccaef75"),
                    RecipeId = RecipeSeedUUID.Poutine,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("9a45acf7-45d2-467d-843b-bf859fa0bc82"),
                    RecipeId = RecipeSeedUUID.Poutine,
                    Text = "Plate Poutine and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("3f9f02b3-d4ba-4d32-86af-42f941f35509"),
                    RecipeId = RecipeSeedUUID.Pavlova,
                    Text = "Prep ingredients for Pavlova.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("efe197ee-1fe8-412d-ae74-2849b2ceecb4"),
                    RecipeId = RecipeSeedUUID.Pavlova,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("ad40bf0d-7233-43cc-92ac-cc4a3ac9b56a"),
                    RecipeId = RecipeSeedUUID.Pavlova,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("9ae2049c-e9cc-4f36-95e4-46dbe5c6a8b0"),
                    RecipeId = RecipeSeedUUID.Pavlova,
                    Text = "Season and cook until Pavlova is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("b6c5874d-c17e-4e94-9f53-9225c09c83f4"),
                    RecipeId = RecipeSeedUUID.Pavlova,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("97362498-b010-4192-9ef9-9cb38887f205"),
                    RecipeId = RecipeSeedUUID.Pavlova,
                    Text = "Plate Pavlova and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("b031c069-1716-4d96-8410-6a6f1498ad1b"),
                    RecipeId = RecipeSeedUUID.Arepa,
                    Text = "Prep ingredients for Cheese Arepas.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7cccc7f3-e655-460d-9d76-320270646f59"),
                    RecipeId = RecipeSeedUUID.Arepa,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("ebfb49e5-8d5c-408a-afd7-e94fba5cb0f7"),
                    RecipeId = RecipeSeedUUID.Arepa,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("cffae1a8-f5b3-414c-8e8e-3f61c5ddf6ec"),
                    RecipeId = RecipeSeedUUID.Arepa,
                    Text = "Season and cook until Cheese Arepas is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("f99942cc-07ba-4951-ad80-4464e3f67183"),
                    RecipeId = RecipeSeedUUID.Arepa,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("2df9e673-e64f-4ac9-a2bf-c1e7319c57cc"),
                    RecipeId = RecipeSeedUUID.Arepa,
                    Text = "Plate Cheese Arepas and serve.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("62d86316-745b-4fac-bca0-74c926f8b66f"),
                    RecipeId = RecipeSeedUUID.IrishStew,
                    Text = "Prep ingredients for Irish Stew.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("8b3f13ac-106f-4122-b7d5-5eb70b60b31c"),
                    RecipeId = RecipeSeedUUID.IrishStew,
                    Text = "Heat a pan or pot over medium heat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("bceae737-622e-4081-b9ab-2a6065d982c0"),
                    RecipeId = RecipeSeedUUID.IrishStew,
                    Text = "Cook the main protein or vegetables until tender.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("2a73a39c-fd35-49d0-afaf-15cc7bb92681"),
                    RecipeId = RecipeSeedUUID.IrishStew,
                    Text = "Season and cook until Irish Stew is done.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("3e1fd5f7-a5e2-42b4-9977-4bb5b9d01dd0"),
                    RecipeId = RecipeSeedUUID.IrishStew,
                    Text = "Taste and adjust salt, acid, or heat.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("cd8c7ea8-2a89-4695-b283-3b3d8f5554e9"),
                    RecipeId = RecipeSeedUUID.IrishStew,
                    Text = "Plate Irish Stew and serve.",
                    Order = 6
                }
            };
        }
    }
}