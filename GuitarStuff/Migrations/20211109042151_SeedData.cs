using Microsoft.EntityFrameworkCore.Migrations;

namespace GuitarStuff.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Guitars",
                columns: new[] { "GuitarId", "GuitarPlayersAssociated", "GuitarType" },
                values: new object[,]
                {
                    { 1, "Woolly Mammoth", "Matilda" },
                    { 2, "Dinosaur", "Rexie" },
                    { 3, "Dinosaur", "Matilda" },
                    { 4, "Shark", "Pip" },
                    { 5, "Dinosaur", "Bartholomew" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 5);
        }
    }
}
