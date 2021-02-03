using Microsoft.EntityFrameworkCore.Migrations;

namespace FarmManagement.Migrations
{
    public partial class SeedSaplingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Saplings",
                columns: new[] { "Id", "CultivarName", "InitialPrice", "Name", "SpeciesName" },
                values: new object[] { 1, "Banganapalli", 155, "Banganapalli Mamidi", 1 });

            migrationBuilder.InsertData(
                table: "Saplings",
                columns: new[] { "Id", "CultivarName", "InitialPrice", "Name", "SpeciesName" },
                values: new object[] { 2, "Thai Pink Guava", 203, "Red Jama", 2 });

            migrationBuilder.InsertData(
                table: "Saplings",
                columns: new[] { "Id", "CultivarName", "InitialPrice", "Name", "SpeciesName" },
                values: new object[] { 3, "Apple Bear", 255, "Pedha Regayi", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Saplings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Saplings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Saplings",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
