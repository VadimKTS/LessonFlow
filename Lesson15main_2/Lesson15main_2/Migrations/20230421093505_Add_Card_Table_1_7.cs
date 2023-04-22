using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lesson15main_2.Migrations
{
    /// <inheritdoc />
    public partial class Add_Card_Table_1_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PayCard",
                columns: new[] { "Id", "BankName", "ManufactureId", "Number" },
                values: new object[,]
                {
                    { 1, "АльфаБанк", null, "3215-1235-1235" },
                    { 2, "Дабрабыт", null, "3578-3467-3457" },
                    { 3, "БелАПБ", null, "3255-6509-5700" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PayCard",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PayCard",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PayCard",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
