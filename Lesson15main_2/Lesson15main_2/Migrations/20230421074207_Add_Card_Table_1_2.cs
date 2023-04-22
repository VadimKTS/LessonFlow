using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lesson15main_2.Migrations
{
    /// <inheritdoc />
    public partial class Add_Card_Table_1_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manufactures_PayCard_PayCardId",
                table: "Manufactures");

            migrationBuilder.DropIndex(
                name: "IX_Manufactures_PayCardId",
                table: "Manufactures");

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

            migrationBuilder.DropColumn(
                name: "PayCardId",
                table: "Manufactures");

            migrationBuilder.AddColumn<int>(
                name: "ManufactureId",
                table: "PayCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PayCard_ManufactureId",
                table: "PayCard",
                column: "ManufactureId");

            migrationBuilder.AddForeignKey(
                name: "FK_PayCard_Manufactures_ManufactureId",
                table: "PayCard",
                column: "ManufactureId",
                principalTable: "Manufactures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayCard_Manufactures_ManufactureId",
                table: "PayCard");

            migrationBuilder.DropIndex(
                name: "IX_PayCard_ManufactureId",
                table: "PayCard");

            migrationBuilder.DropColumn(
                name: "ManufactureId",
                table: "PayCard");

            migrationBuilder.AddColumn<int>(
                name: "PayCardId",
                table: "Manufactures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "PayCard",
                columns: new[] { "Id", "BankName", "Number" },
                values: new object[,]
                {
                    { 1, "АльфаБанк", "3215-1235-1235" },
                    { 2, "Дабрабыт", "3578-3467-3457" },
                    { 3, "БелАПБ", "3255-6509-5700" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Manufactures_PayCardId",
                table: "Manufactures",
                column: "PayCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Manufactures_PayCard_PayCardId",
                table: "Manufactures",
                column: "PayCardId",
                principalTable: "PayCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
