using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lesson15main_2.Migrations
{
    /// <inheritdoc />
    public partial class Add_Card_Table_1_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manufactures",
                columns: new[] { "Id", "CountOfMembers", "Name" },
                values: new object[,]
                {
                    { 1, 540, "Google" },
                    { 2, 400, "Microsoft" },
                    { 3, 250, "Intel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
