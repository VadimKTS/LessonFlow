using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson15main_2.Migrations
{
    /// <inheritdoc />
    public partial class Add_Card_Table_1_72 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PayCard",
                keyColumn: "Id",
                keyValue: 1,
                column: "ManufactureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PayCard",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManufactureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PayCard",
                keyColumn: "Id",
                keyValue: 3,
                column: "ManufactureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ManufactureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManufactureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ManufactureId",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PayCard",
                keyColumn: "Id",
                keyValue: 1,
                column: "ManufactureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PayCard",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManufactureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PayCard",
                keyColumn: "Id",
                keyValue: 3,
                column: "ManufactureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ManufactureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManufactureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ManufactureId",
                value: null);
        }
    }
}
