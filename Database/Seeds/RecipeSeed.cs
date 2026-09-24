using foodiestopia.Models;

namespace foodiestopia.Database.Seeds
{
    public static class RecipeSeed
    {
        public static IEnumerable<Recipe> GetRecipes()
        {

            return new List<Recipe>{
                new Recipe
                {
                    Id = RecipeSeedUUID.LowCaloriePizza,
                    Name = "Low calorie pizza",
                    UserId = AppUserSeedUUID.PeterParker,
                    CountryId = CountrySeedUUID.USA,
                    ImageUrl = "images/recipes/low_calorie_pizza.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(), // initialize as empty (since Recipe model has as "required") then shortly after seeded List
                    Instructions = new List<Instruction>(), // initialize as empty (since Recipe model has as "required") then shortly after seeded List
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ClassicCheeseburger,
                    Name = "Classic Cheeseburger",
                    UserId = AppUserSeedUUID.PeterParker,
                    CountryId = CountrySeedUUID.USA,
                    ImageUrl = "images/recipes/classic_cheeseburger.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.TacosAlPastor,
                    Name = "Tacos al Pastor",
                    UserId = AppUserSeedUUID.PeterParker,
                    CountryId = CountrySeedUUID.Mexico,
                    ImageUrl = "images/recipes/tacos_al_pastor.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ChickenBiryani,
                    Name = "Chicken Biryani",
                    UserId = AppUserSeedUUID.PeterParker,
                    CountryId = CountrySeedUUID.India,
                    ImageUrl = "images/recipes/chicken_biryani.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 45,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.PekingDuck,
                    Name = "Peking Duck",
                    UserId = AppUserSeedUUID.AdamWarlock,
                    CountryId = CountrySeedUUID.China,
                    ImageUrl = "images/recipes/peking_duck.jpg",
                    PrepTimeMinutes = 40,
                    CookTimeMinutes = 90,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.BeefStroganoff,
                    Name = "Beef Stroganoff",
                    UserId = AppUserSeedUUID.AdamWarlock,
                    CountryId = CountrySeedUUID.Russia,
                    ImageUrl = "images/recipes/beef_stroganoff.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 25,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Feijoada,
                    Name = "Feijoada",
                    UserId = AppUserSeedUUID.RocketRaccoon,
                    CountryId = CountrySeedUUID.Brazil,
                    ImageUrl = "images/recipes/feijoada.png",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 90,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>()
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Sushi,
                    Name = "Sushi",
                    UserId = AppUserSeedUUID.DrStrange,
                    CountryId = CountrySeedUUID.Japan,
                    ImageUrl = "images/recipes/sushi.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 0,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.PadThai,
                    Name = "Pad Thai",
                    UserId = AppUserSeedUUID.Ironfist,
                    CountryId = CountrySeedUUID.Thailand,
                    ImageUrl = "images/recipes/pad_thai.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Pho,
                    Name = "Pho",
                    UserId = AppUserSeedUUID.Ironfist,
                    CountryId = CountrySeedUUID.Vietnam,
                    ImageUrl = "images/recipes/pho.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 45,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Ceviche,
                    Name = "Ceviche",
                    UserId = AppUserSeedUUID.Ironfist,
                    CountryId = CountrySeedUUID.Peru,
                    ImageUrl = "images/recipes/ceviche.jpeg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 0,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Kebab,
                    Name = "Kebab",
                    UserId = null,
                    CountryId = CountrySeedUUID.Turkey,
                    ImageUrl = "images/recipes/kebab.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ButterChicken,
                    Name = "Butter Chicken",
                    UserId = null,
                    CountryId = CountrySeedUUID.Pakistan,
                    ImageUrl = "images/recipes/butter_chicken.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 30,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Bobotie,
                    Name = "Bobotie",
                    UserId = null,
                    CountryId = CountrySeedUUID.SouthAfrica,
                    ImageUrl = "images/recipes/bobotie.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 45,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Kimchi,
                    Name = "Kimchi",
                    UserId = null,
                    CountryId = CountrySeedUUID.SouthKorea,
                    ImageUrl = "images/recipes/kimchi.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 0,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Pierogi,
                    Name = "Pierogi",
                    UserId = null,
                    CountryId = CountrySeedUUID.Poland,
                    ImageUrl = "images/recipes/pierogi.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.FishAndChips,
                    Name = "Fish and Chips",
                    UserId = null,
                    CountryId = CountrySeedUUID.UK,
                    ImageUrl = "images/recipes/fish_and_chips.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Moussaka,
                    Name = "Moussaka",
                    UserId = null,
                    CountryId = CountrySeedUUID.Greece,
                    ImageUrl = "images/recipes/moussaka.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 60,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Lasagna,
                    Name = "Lasagna",
                    UserId = null,
                    CountryId = CountrySeedUUID.Italy,
                    ImageUrl = "images/recipes/lasagna.jpg",
                    PrepTimeMinutes = 25,
                    CookTimeMinutes = 45,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Croissant,
                    Name = "Croissant",
                    UserId = null,
                    CountryId = CountrySeedUUID.France,
                    ImageUrl = "images/recipes/croissant.jpg",
                    PrepTimeMinutes = 45,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Shawarma,
                    Name = "Shawarma",
                    UserId = null,
                    CountryId = CountrySeedUUID.Egypt,
                    ImageUrl = "images/recipes/shawarma.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 25,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.TomYumGoong,
                    Name = "Tom Yum Goong",
                    UserId = AppUserSeedUUID.StarLord,
                    CountryId = CountrySeedUUID.Thailand,
                    ImageUrl = "images/recipes/pad_thai.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 25,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.GreenCurry,
                    Name = "Thai Green Curry",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = CountrySeedUUID.Thailand,
                    ImageUrl = "images/recipes/pad_thai.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 30,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.MassamanCurry,
                    Name = "Massaman Curry",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = CountrySeedUUID.Thailand,
                    ImageUrl = "images/recipes/pad_thai.jpg",
                    PrepTimeMinutes = 25,
                    CookTimeMinutes = 90,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.SomTam,
                    Name = "Som Tam",
                    UserId = AppUserSeedUUID.Shuri,
                    CountryId = CountrySeedUUID.Thailand,
                    ImageUrl = "images/recipes/pad_thai.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 0,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.MangoStickyRice,
                    Name = "Mango Sticky Rice",
                    UserId = AppUserSeedUUID.Miles,
                    CountryId = CountrySeedUUID.Thailand,
                    ImageUrl = "images/recipes/pad_thai.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 25,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ThaiBasilChicken,
                    Name = "Thai Basil Chicken",
                    UserId = AppUserSeedUUID.BlackWidow,
                    CountryId = CountrySeedUUID.Thailand,
                    ImageUrl = "images/recipes/pad_thai.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 12,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.PanangCurry,
                    Name = "Panang Curry",
                    UserId = AppUserSeedUUID.Loki,
                    CountryId = CountrySeedUUID.Thailand,
                    ImageUrl = "images/recipes/pad_thai.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 25,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.CoconutSoup,
                    Name = "Tom Kha Gai",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = CountrySeedUUID.Thailand,
                    ImageUrl = "images/recipes/pad_thai.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.BanhMi,
                    Name = "Banh Mi",
                    UserId = AppUserSeedUUID.StarLord,
                    CountryId = CountrySeedUUID.Vietnam,
                    ImageUrl = "images/recipes/pho.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 10,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.BunCha,
                    Name = "Bun Cha",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = CountrySeedUUID.Vietnam,
                    ImageUrl = "images/recipes/pho.jpg",
                    PrepTimeMinutes = 25,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.GoiCuon,
                    Name = "Goi Cuon",
                    UserId = AppUserSeedUUID.Shuri,
                    CountryId = CountrySeedUUID.Vietnam,
                    ImageUrl = "images/recipes/pho.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 0,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ComTam,
                    Name = "Com Tam",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = CountrySeedUUID.Vietnam,
                    ImageUrl = "images/recipes/pho.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 25,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Ramen,
                    Name = "Tonkotsu Ramen",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = CountrySeedUUID.Japan,
                    ImageUrl = "images/recipes/sushi.jpg",
                    PrepTimeMinutes = 40,
                    CookTimeMinutes = 180,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Tonkatsu,
                    Name = "Tonkatsu",
                    UserId = AppUserSeedUUID.Miles,
                    CountryId = CountrySeedUUID.Japan,
                    ImageUrl = "images/recipes/sushi.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Okonomiyaki,
                    Name = "Okonomiyaki",
                    UserId = AppUserSeedUUID.Loki,
                    CountryId = CountrySeedUUID.Japan,
                    ImageUrl = "images/recipes/sushi.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.MisoSoup,
                    Name = "Miso Soup",
                    UserId = AppUserSeedUUID.BlackWidow,
                    CountryId = CountrySeedUUID.Japan,
                    ImageUrl = "images/recipes/sushi.jpg",
                    PrepTimeMinutes = 5,
                    CookTimeMinutes = 10,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Udon,
                    Name = "Kitsune Udon",
                    UserId = AppUserSeedUUID.StarLord,
                    CountryId = CountrySeedUUID.Japan,
                    ImageUrl = "images/recipes/sushi.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Tempura,
                    Name = "Vegetable Tempura",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = CountrySeedUUID.Japan,
                    ImageUrl = "images/recipes/sushi.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Onigiri,
                    Name = "Onigiri",
                    UserId = AppUserSeedUUID.Shuri,
                    CountryId = CountrySeedUUID.Japan,
                    ImageUrl = "images/recipes/sushi.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Carbonara,
                    Name = "Spaghetti Carbonara",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = CountrySeedUUID.Italy,
                    ImageUrl = "images/recipes/lasagna.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.MargheritaPizza,
                    Name = "Margherita Pizza",
                    UserId = AppUserSeedUUID.Loki,
                    CountryId = CountrySeedUUID.Italy,
                    ImageUrl = "images/recipes/lasagna.jpg",
                    PrepTimeMinutes = 90,
                    CookTimeMinutes = 12,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.MushroomRisotto,
                    Name = "Mushroom Risotto",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = CountrySeedUUID.Italy,
                    ImageUrl = "images/recipes/lasagna.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 35,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Tiramisu,
                    Name = "Tiramisu",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = CountrySeedUUID.Italy,
                    ImageUrl = "images/recipes/lasagna.jpg",
                    PrepTimeMinutes = 25,
                    CookTimeMinutes = 0,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Gnocchi,
                    Name = "Potato Gnocchi",
                    UserId = AppUserSeedUUID.Miles,
                    CountryId = CountrySeedUUID.Italy,
                    ImageUrl = "images/recipes/lasagna.jpg",
                    PrepTimeMinutes = 45,
                    CookTimeMinutes = 10,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.PestoPasta,
                    Name = "Pesto Linguine",
                    UserId = AppUserSeedUUID.BlackWidow,
                    CountryId = CountrySeedUUID.Italy,
                    ImageUrl = "images/recipes/lasagna.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 12,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Minestrone,
                    Name = "Minestrone",
                    UserId = AppUserSeedUUID.StarLord,
                    CountryId = CountrySeedUUID.Italy,
                    ImageUrl = "images/recipes/lasagna.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 40,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ChickenEnchiladas,
                    Name = "Chicken Enchiladas",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = CountrySeedUUID.Mexico,
                    ImageUrl = "images/recipes/tacos_al_pastor.jpg",
                    PrepTimeMinutes = 25,
                    CookTimeMinutes = 30,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Guacamole,
                    Name = "Guacamole",
                    UserId = AppUserSeedUUID.Shuri,
                    CountryId = CountrySeedUUID.Mexico,
                    ImageUrl = "images/recipes/tacos_al_pastor.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 0,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Pozole,
                    Name = "Pozole Rojo",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = CountrySeedUUID.Mexico,
                    ImageUrl = "images/recipes/tacos_al_pastor.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 120,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Elote,
                    Name = "Elote",
                    UserId = AppUserSeedUUID.Loki,
                    CountryId = CountrySeedUUID.Mexico,
                    ImageUrl = "images/recipes/tacos_al_pastor.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.CheeseQuesadilla,
                    Name = "Cheese Quesadilla",
                    UserId = AppUserSeedUUID.Miles,
                    CountryId = CountrySeedUUID.Mexico,
                    ImageUrl = "images/recipes/tacos_al_pastor.jpg",
                    PrepTimeMinutes = 5,
                    CookTimeMinutes = 8,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Tamales,
                    Name = "Pork Tamales",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = CountrySeedUUID.Mexico,
                    ImageUrl = "images/recipes/tacos_al_pastor.jpg",
                    PrepTimeMinutes = 60,
                    CookTimeMinutes = 90,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.MacAndCheese,
                    Name = "Stovetop Mac and Cheese",
                    UserId = AppUserSeedUUID.StarLord,
                    CountryId = CountrySeedUUID.USA,
                    ImageUrl = "images/recipes/classic_cheeseburger.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.FriedChicken,
                    Name = "Buttermilk Fried Chicken",
                    UserId = AppUserSeedUUID.BlackWidow,
                    CountryId = CountrySeedUUID.USA,
                    ImageUrl = "images/recipes/classic_cheeseburger.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 25,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ClamChowder,
                    Name = "New England Clam Chowder",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = CountrySeedUUID.USA,
                    ImageUrl = "images/recipes/classic_cheeseburger.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 40,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Pancakes,
                    Name = "Buttermilk Pancakes",
                    UserId = AppUserSeedUUID.Miles,
                    CountryId = CountrySeedUUID.USA,
                    ImageUrl = "images/recipes/classic_cheeseburger.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.BeefChili,
                    Name = "Beef Chili",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = CountrySeedUUID.USA,
                    ImageUrl = "images/recipes/classic_cheeseburger.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 75,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ApplePie,
                    Name = "Apple Pie",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = CountrySeedUUID.USA,
                    ImageUrl = "images/recipes/classic_cheeseburger.jpg",
                    PrepTimeMinutes = 40,
                    CookTimeMinutes = 50,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.TikkaMasala,
                    Name = "Chicken Tikka Masala",
                    UserId = AppUserSeedUUID.Loki,
                    CountryId = CountrySeedUUID.India,
                    ImageUrl = "images/recipes/chicken_biryani.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 40,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.PalakPaneer,
                    Name = "Palak Paneer",
                    UserId = AppUserSeedUUID.Shuri,
                    CountryId = CountrySeedUUID.India,
                    ImageUrl = "images/recipes/chicken_biryani.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 25,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Samosas,
                    Name = "Vegetable Samosas",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = CountrySeedUUID.India,
                    ImageUrl = "images/recipes/chicken_biryani.jpg",
                    PrepTimeMinutes = 45,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ChanaMasala,
                    Name = "Chana Masala",
                    UserId = AppUserSeedUUID.StarLord,
                    CountryId = CountrySeedUUID.India,
                    ImageUrl = "images/recipes/chicken_biryani.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 35,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.DalTadka,
                    Name = "Dal Tadka",
                    UserId = AppUserSeedUUID.BlackWidow,
                    CountryId = CountrySeedUUID.India,
                    ImageUrl = "images/recipes/chicken_biryani.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 30,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.MasalaDosa,
                    Name = "Masala Dosa",
                    UserId = AppUserSeedUUID.Miles,
                    CountryId = CountrySeedUUID.India,
                    ImageUrl = "images/recipes/chicken_biryani.jpg",
                    PrepTimeMinutes = 50,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.MapoTofu,
                    Name = "Mapo Tofu",
                    UserId = AppUserSeedUUID.Shuri,
                    CountryId = CountrySeedUUID.China,
                    ImageUrl = "images/recipes/peking_duck.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.PorkDumplings,
                    Name = "Pork Dumplings",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = CountrySeedUUID.China,
                    ImageUrl = "images/recipes/peking_duck.jpg",
                    PrepTimeMinutes = 45,
                    CookTimeMinutes = 12,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.KungPaoChicken,
                    Name = "Kung Pao Chicken",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = CountrySeedUUID.China,
                    ImageUrl = "images/recipes/peking_duck.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.EggFriedRice,
                    Name = "Egg Fried Rice",
                    UserId = AppUserSeedUUID.Loki,
                    CountryId = CountrySeedUUID.China,
                    ImageUrl = "images/recipes/peking_duck.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 10,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.WontonSoup,
                    Name = "Wonton Soup",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = CountrySeedUUID.China,
                    ImageUrl = "images/recipes/peking_duck.jpg",
                    PrepTimeMinutes = 35,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.CharSiu,
                    Name = "Char Siu Pork",
                    UserId = AppUserSeedUUID.StarLord,
                    CountryId = CountrySeedUUID.China,
                    ImageUrl = "images/recipes/peking_duck.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 50,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.FrenchOnionSoup,
                    Name = "French Onion Soup",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = CountrySeedUUID.France,
                    ImageUrl = "images/recipes/croissant.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 70,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Ratatouille,
                    Name = "Ratatouille",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = CountrySeedUUID.France,
                    ImageUrl = "images/recipes/croissant.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 50,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.QuicheLorraine,
                    Name = "Quiche Lorraine",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = CountrySeedUUID.France,
                    ImageUrl = "images/recipes/croissant.jpg",
                    PrepTimeMinutes = 25,
                    CookTimeMinutes = 40,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Crepes,
                    Name = "Crepes",
                    UserId = AppUserSeedUUID.Miles,
                    CountryId = CountrySeedUUID.France,
                    ImageUrl = "images/recipes/croissant.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.CoqAuVin,
                    Name = "Coq au Vin",
                    UserId = AppUserSeedUUID.BlackWidow,
                    CountryId = CountrySeedUUID.France,
                    ImageUrl = "images/recipes/croissant.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 90,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.GreekSalad,
                    Name = "Greek Salad",
                    UserId = AppUserSeedUUID.Shuri,
                    CountryId = CountrySeedUUID.Greece,
                    ImageUrl = "images/recipes/moussaka.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 0,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Souvlaki,
                    Name = "Chicken Souvlaki",
                    UserId = AppUserSeedUUID.StarLord,
                    CountryId = CountrySeedUUID.Greece,
                    ImageUrl = "images/recipes/moussaka.jpg",
                    PrepTimeMinutes = 40,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Spanakopita,
                    Name = "Spanakopita",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = CountrySeedUUID.Greece,
                    ImageUrl = "images/recipes/moussaka.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 40,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.BaklavaGreek,
                    Name = "Baklava",
                    UserId = AppUserSeedUUID.Loki,
                    CountryId = CountrySeedUUID.Greece,
                    ImageUrl = "images/recipes/moussaka.jpg",
                    PrepTimeMinutes = 40,
                    CookTimeMinutes = 50,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ShepherdsPie,
                    Name = "Shepherd's Pie",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = CountrySeedUUID.UK,
                    ImageUrl = "images/recipes/fish_and_chips.jpg",
                    PrepTimeMinutes = 25,
                    CookTimeMinutes = 40,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Scones,
                    Name = "Cream Scones",
                    UserId = AppUserSeedUUID.Miles,
                    CountryId = CountrySeedUUID.UK,
                    ImageUrl = "images/recipes/fish_and_chips.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 18,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.StickyToffee,
                    Name = "Sticky Toffee Pudding",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = CountrySeedUUID.UK,
                    ImageUrl = "images/recipes/fish_and_chips.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 40,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Bibimbap,
                    Name = "Bibimbap",
                    UserId = AppUserSeedUUID.Shuri,
                    CountryId = CountrySeedUUID.SouthKorea,
                    ImageUrl = "images/recipes/kimchi.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Tteokbokki,
                    Name = "Tteokbokki",
                    UserId = AppUserSeedUUID.Loki,
                    CountryId = CountrySeedUUID.SouthKorea,
                    ImageUrl = "images/recipes/kimchi.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Bulgogi,
                    Name = "Beef Bulgogi",
                    UserId = AppUserSeedUUID.BlackWidow,
                    CountryId = CountrySeedUUID.SouthKorea,
                    ImageUrl = "images/recipes/kimchi.jpg",
                    PrepTimeMinutes = 40,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Japchae,
                    Name = "Japchae",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = CountrySeedUUID.SouthKorea,
                    ImageUrl = "images/recipes/kimchi.jpg",
                    PrepTimeMinutes = 25,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.KoreanFriedChicken,
                    Name = "Korean Fried Chicken",
                    UserId = AppUserSeedUUID.StarLord,
                    CountryId = CountrySeedUUID.SouthKorea,
                    ImageUrl = "images/recipes/kimchi.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 25,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Menemen,
                    Name = "Menemen",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = CountrySeedUUID.Turkey,
                    ImageUrl = "images/recipes/kebab.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 12,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.LentilSoup,
                    Name = "Turkish Lentil Soup",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = CountrySeedUUID.Turkey,
                    ImageUrl = "images/recipes/kebab.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 35,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Lahmacun,
                    Name = "Lahmacun",
                    UserId = AppUserSeedUUID.Miles,
                    CountryId = CountrySeedUUID.Turkey,
                    ImageUrl = "images/recipes/kebab.jpg",
                    PrepTimeMinutes = 40,
                    CookTimeMinutes = 12,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Koshari,
                    Name = "Koshari",
                    UserId = AppUserSeedUUID.Loki,
                    CountryId = CountrySeedUUID.Egypt,
                    ImageUrl = "images/recipes/shawarma.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 45,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.FulMedames,
                    Name = "Ful Medames",
                    UserId = AppUserSeedUUID.Shuri,
                    CountryId = CountrySeedUUID.Egypt,
                    ImageUrl = "images/recipes/shawarma.jpg",
                    PrepTimeMinutes = 10,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Taameya,
                    Name = "Taameya",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = CountrySeedUUID.Egypt,
                    ImageUrl = "images/recipes/shawarma.jpg",
                    PrepTimeMinutes = 25,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.PaoDeQueijo,
                    Name = "Pao de Queijo",
                    UserId = AppUserSeedUUID.StarLord,
                    CountryId = CountrySeedUUID.Brazil,
                    ImageUrl = "images/recipes/feijoada.png",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Moqueca,
                    Name = "Moqueca",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = CountrySeedUUID.Brazil,
                    ImageUrl = "images/recipes/feijoada.png",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 35,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Brigadeiro,
                    Name = "Brigadeiro",
                    UserId = AppUserSeedUUID.Miles,
                    CountryId = CountrySeedUUID.Brazil,
                    ImageUrl = "images/recipes/feijoada.png",
                    PrepTimeMinutes = 5,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.LomoSaltado,
                    Name = "Lomo Saltado",
                    UserId = AppUserSeedUUID.BlackWidow,
                    CountryId = CountrySeedUUID.Peru,
                    ImageUrl = "images/recipes/ceviche.jpeg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.CausaLimeña,
                    Name = "Causa Limeña",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = CountrySeedUUID.Peru,
                    ImageUrl = "images/recipes/ceviche.jpeg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ChickenKarahi,
                    Name = "Chicken Karahi",
                    UserId = AppUserSeedUUID.Loki,
                    CountryId = CountrySeedUUID.Pakistan,
                    ImageUrl = "images/recipes/butter_chicken.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 30,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Nihari,
                    Name = "Nihari",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = CountrySeedUUID.Pakistan,
                    ImageUrl = "images/recipes/butter_chicken.jpg",
                    PrepTimeMinutes = 25,
                    CookTimeMinutes = 180,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.MalvaPudding,
                    Name = "Malva Pudding",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = CountrySeedUUID.SouthAfrica,
                    ImageUrl = "images/recipes/bobotie.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 45,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Chakalaka,
                    Name = "Chakalaka",
                    UserId = AppUserSeedUUID.Shuri,
                    CountryId = CountrySeedUUID.SouthAfrica,
                    ImageUrl = "images/recipes/bobotie.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 25,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Bigos,
                    Name = "Bigos",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = CountrySeedUUID.Poland,
                    ImageUrl = "images/recipes/pierogi.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 120,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Zurek,
                    Name = "Zurek",
                    UserId = AppUserSeedUUID.StarLord,
                    CountryId = CountrySeedUUID.Poland,
                    ImageUrl = "images/recipes/pierogi.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 50,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Borscht,
                    Name = "Borscht",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = CountrySeedUUID.Russia,
                    ImageUrl = "images/recipes/beef_stroganoff.jpg",
                    PrepTimeMinutes = 25,
                    CookTimeMinutes = 60,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Pelmeni,
                    Name = "Pelmeni",
                    UserId = AppUserSeedUUID.BlackWidow,
                    CountryId = CountrySeedUUID.Russia,
                    ImageUrl = "images/recipes/beef_stroganoff.jpg",
                    PrepTimeMinutes = 50,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Paella,
                    Name = "Seafood Paella",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = Guid.Parse("e1c716b5-4bda-47b2-9955-920e263bec73"),
                    ImageUrl = "images/recipes/pad_thai.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 45,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Gazpacho,
                    Name = "Gazpacho",
                    UserId = AppUserSeedUUID.Shuri,
                    CountryId = Guid.Parse("e1c716b5-4bda-47b2-9955-920e263bec73"),
                    ImageUrl = "images/recipes/ceviche.jpeg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 0,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Schnitzel,
                    Name = "Wiener Schnitzel",
                    UserId = AppUserSeedUUID.Loki,
                    CountryId = Guid.Parse("9f4b3a8f-c053-4a14-8053-bca8f4465c33"),
                    ImageUrl = "images/recipes/classic_cheeseburger.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Pretzels,
                    Name = "Soft Pretzels",
                    UserId = AppUserSeedUUID.Miles,
                    CountryId = Guid.Parse("9f4b3a8f-c053-4a14-8053-bca8f4465c33"),
                    ImageUrl = "images/recipes/croissant.jpg",
                    PrepTimeMinutes = 90,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Tagine,
                    Name = "Chicken Tagine",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = Guid.Parse("feecd4a1-2a0d-489e-8b1a-efed38f8ce8e"),
                    ImageUrl = "images/recipes/shawarma.jpg",
                    PrepTimeMinutes = 25,
                    CookTimeMinutes = 70,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.JollofRice,
                    Name = "Jollof Rice",
                    UserId = AppUserSeedUUID.StarLord,
                    CountryId = Guid.Parse("52ca5dd4-843a-4408-a450-de8d6756a62f"),
                    ImageUrl = "images/recipes/chicken_biryani.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 40,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.JerkChicken,
                    Name = "Jerk Chicken",
                    UserId = AppUserSeedUUID.BlackWidow,
                    CountryId = Guid.Parse("66fb47e6-62ad-477a-bd36-06179278cef8"),
                    ImageUrl = "images/recipes/classic_cheeseburger.jpg",
                    PrepTimeMinutes = 30,
                    CookTimeMinutes = 45,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Empanadas,
                    Name = "Beef Empanadas",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = Guid.Parse("7ff86fe8-b9b6-485d-a244-59bfb9840160"),
                    ImageUrl = "images/recipes/tacos_al_pastor.jpg",
                    PrepTimeMinutes = 40,
                    CookTimeMinutes = 25,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Adobo,
                    Name = "Chicken Adobo",
                    UserId = AppUserSeedUUID.Gamora,
                    CountryId = Guid.Parse("d2f03586-3ac2-48a5-9745-398584df4dba"),
                    ImageUrl = "images/recipes/peking_duck.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 45,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Bacalhau,
                    Name = "Bacalhau",
                    UserId = AppUserSeedUUID.Loki,
                    CountryId = Guid.Parse("117df930-fe06-461a-8438-e0400ab4dd7d"),
                    ImageUrl = "images/recipes/fish_and_chips.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 40,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Poutine,
                    Name = "Poutine",
                    UserId = AppUserSeedUUID.Miles,
                    CountryId = Guid.Parse("de5c696e-94f2-4516-a902-8015ad3007a1"),
                    ImageUrl = "images/recipes/classic_cheeseburger.jpg",
                    PrepTimeMinutes = 15,
                    CookTimeMinutes = 20,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Pavlova,
                    Name = "Pavlova",
                    UserId = AppUserSeedUUID.Wanda,
                    CountryId = Guid.Parse("1d5d4476-a20d-4160-b009-2a7f2565e0c2"),
                    ImageUrl = "images/recipes/croissant.jpg",
                    PrepTimeMinutes = 25,
                    CookTimeMinutes = 75,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Arepa,
                    Name = "Cheese Arepas",
                    UserId = AppUserSeedUUID.Shuri,
                    CountryId = Guid.Parse("846d9792-33d6-42f9-aa56-a2ede3edf63b"),
                    ImageUrl = "images/recipes/tacos_al_pastor.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 15,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.IrishStew,
                    Name = "Irish Stew",
                    UserId = AppUserSeedUUID.Thor,
                    CountryId = Guid.Parse("689dcce4-f72b-4af0-9e48-f2961612a37c"),
                    ImageUrl = "images/recipes/beef_stroganoff.jpg",
                    PrepTimeMinutes = 20,
                    CookTimeMinutes = 90,
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                }
            };
        }
    }
}