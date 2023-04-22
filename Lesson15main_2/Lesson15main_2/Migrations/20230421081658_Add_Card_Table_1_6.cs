using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lesson15main_2.Migrations
{
    /// <inheritdoc />
    public partial class Add_Card_Table_1_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_PayCard_Manufactures_ManufactureId",
            //    table: "PayCard");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Users_Manufactures_ManufactureId",
            //    table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "ManufactureId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ManufactureId",
                table: "PayCard",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Age", "LastName", "ManufactureId", "Name" },
                values: new object[,]
                {
                    { 1, "Slobodskaya 17", 35, "Tatyrzha", null, "Vadik" },
                    { 2, "Lobanka 45", 30, "Zyglin", null, "Artem" },
                    { 3, "Zhilunovicha 24", 31, "Krechko", null, "Paul" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PayCard_Manufactures_ManufactureId",
                table: "PayCard",
                column: "ManufactureId",
                principalTable: "Manufactures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Manufactures_ManufactureId",
                table: "Users",
                column: "ManufactureId",
                principalTable: "Manufactures",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayCard_Manufactures_ManufactureId",
                table: "PayCard");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Manufactures_ManufactureId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "ManufactureId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ManufactureId",
                table: "PayCard",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PayCard_Manufactures_ManufactureId",
                table: "PayCard",
                column: "ManufactureId",
                principalTable: "Manufactures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Manufactures_ManufactureId",
                table: "Users",
                column: "ManufactureId",
                principalTable: "Manufactures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
