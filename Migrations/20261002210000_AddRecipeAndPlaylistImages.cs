using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using foodiestopia.Database;

#nullable disable

namespace foodiestopia.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261002210000_AddRecipeAndPlaylistImages")]
    public class AddRecipeAndPlaylistImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Playlists",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<List<string>>(
                name: "ImageUrls",
                table: "Recipes",
                type: "text[]",
                nullable: false,
                defaultValueSql: "'{}'");

            migrationBuilder.Sql("""
                UPDATE "Recipes"
                SET "ImageUrls" = ARRAY["ImageUrl"]
                WHERE "ImageUrl" IS NOT NULL AND "ImageUrl" <> '';
                """);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "ImageUrls", table: "Recipes");
            migrationBuilder.DropColumn(name: "ImageUrl", table: "Playlists");
        }
    }
}
