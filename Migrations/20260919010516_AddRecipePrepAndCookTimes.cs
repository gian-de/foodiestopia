using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foodiestopia.Migrations
{
    /// <inheritdoc />
    public partial class AddRecipePrepAndCookTimes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CookTimeMinutes",
                table: "Recipes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrepTimeMinutes",
                table: "Recipes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("01f65cb2-826b-4ee2-88f9-fa7e95ebfd95"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 45, 20 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("266aed83-7009-4250-881c-fb20cb3f0f1f"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 0, 30 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2b53f900-d736-4393-a585-1f6624c177b2"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 15, 10 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("2f5f5e32-253d-4132-a2f6-494d48fb15cd"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 15, 15 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 20, 15 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("58b9b0ab-aad1-43d0-b440-4add773b9b28"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 20, 15 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6792204d-6f00-4a94-923b-1a93564f4c49"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 45, 30 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7b4b3461-f83c-4809-a840-d81a874587ab"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 45, 20 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8013d36f-1c68-4223-b4e4-49f91d9e17b5"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 30, 15 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("89d816e6-a468-42c9-91a2-ead8fb21fe4c"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 90, 40 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8d600c3e-1849-4afb-86f8-446d4be2edb9"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 20, 20 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("8ef9e3ab-d115-46ec-8232-4b36f00cc771"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 60, 30 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9ae1f555-9bc4-498f-817d-e8c76f2095b0"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 25, 15 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba2a4db4-bbe5-4dde-a153-e46885b8c7c0"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 90, 20 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bc259740-607d-4a1d-9347-c38713669a6c"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 15, 20 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c0f46fa1-463f-47c4-a17f-02c8c417882a"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 0, 30 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c1471c8b-0f1f-4791-a65e-7a2d077e00d9"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 0, 20 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ce84d52a-bef3-4c3b-87b1-baf517596487"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 45, 25 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4d4a23b-2ccd-40de-a2e6-dd6457bc977a"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 25, 20 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dd094901-2566-4ce1-8213-457b1ed3703a"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 20, 45 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f70d9de1-a4fd-4422-97dd-f4615a9cff92"),
                columns: new[] { "CookTimeMinutes", "PrepTimeMinutes" },
                values: new object[] { 20, 30 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CookTimeMinutes",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "PrepTimeMinutes",
                table: "Recipes");
        }
    }
}
