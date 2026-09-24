using foodiestopia.Models;
using Microsoft.AspNetCore.Identity;

namespace foodiestopia.Database.Seeds
{
    public static class AppUserSeed
    {
        public static List<AppUser> GetAppUsers()
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return new List<AppUser>()
            {
                new AppUser
                {
                    Id = AppUserSeedUUID.PeterParker,
                    UserName = "Spider-man",
                    NormalizedUserName="SPIDER-MAN",
                    Email = "spiderman@email.com",
                    NormalizedEmail = "SPIDERMAN@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null!, "Spiderman1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.AdamWarlock,
                    UserName = "Warlock",
                    NormalizedUserName = "WARLOCK",
                    Email = "adamwarlock@email.com",
                    NormalizedEmail = "ADAMWARLOCK@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null!, "AdamWarlock1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.RocketRaccoon,
                    UserName = "Rocket",
                    NormalizedUserName = "ROCKET",
                    Email = "rocketraccoon@email.com",
                    NormalizedEmail = "ROCKETRACCOON@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null!, "RocketRaccoon!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.DrStrange,
                    UserName = "DrStrange",
                    NormalizedUserName = "DRSTRANGE",
                    Email = "drstrange@email.com",
                    NormalizedEmail = "DRSTRANGE@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null!,"DrStrange1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.Ironfist,
                    UserName = "IronFist",
                    NormalizedUserName = "IRONFIST",
                    Email = "ironfist@email.com",
                    NormalizedEmail = "IRONFIST@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null!,"IronFist1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.BlackWidow,
                    UserName = "BlackWidow",
                    NormalizedUserName = "BLACKWIDOW",
                    Email = "blackwidow@email.com",
                    NormalizedEmail = "BLACKWIDOW@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null!, "BlackWidow1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.StarLord,
                    UserName = "StarLord",
                    NormalizedUserName = "STARLORD",
                    Email = "starlord@email.com",
                    NormalizedEmail = "STARLORD@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null!, "StarLord1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.Gamora,
                    UserName = "Gamora",
                    NormalizedUserName = "GAMORA",
                    Email = "gamora@email.com",
                    NormalizedEmail = "GAMORA@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null!, "Gamora1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.Loki,
                    UserName = "Loki",
                    NormalizedUserName = "LOKI",
                    Email = "loki@email.com",
                    NormalizedEmail = "LOKI@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null!, "Loki1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.Thor,
                    UserName = "Thor",
                    NormalizedUserName = "THOR",
                    Email = "thor@email.com",
                    NormalizedEmail = "THOR@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null!, "Thor1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.Wanda,
                    UserName = "Wanda",
                    NormalizedUserName = "WANDA",
                    Email = "wanda@email.com",
                    NormalizedEmail = "WANDA@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null!, "Wanda1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.Shuri,
                    UserName = "Shuri",
                    NormalizedUserName = "SHURI",
                    Email = "shuri@email.com",
                    NormalizedEmail = "SHURI@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null!, "Shuri1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.Miles,
                    UserName = "Miles",
                    NormalizedUserName = "MILES",
                    Email = "miles@email.com",
                    NormalizedEmail = "MILES@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null!, "Miles1!")
                }
            };
        }
    }
}