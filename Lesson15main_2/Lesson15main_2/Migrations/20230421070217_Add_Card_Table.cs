using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lesson15main_2.Migrations
{
    /// <inheritdoc />
    public partial class Add_Card_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "PayCardId",
                table: "Manufactures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PayCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayCard", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manufactures_PayCard_PayCardId",
                table: "Manufactures");

            migrationBuilder.DropTable(
                name: "PayCard");

            migrationBuilder.DropIndex(
                name: "IX_Manufactures_PayCardId",
                table: "Manufactures");

            migrationBuilder.DropColumn(
                name: "PayCardId",
                table: "Manufactures");

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
    }
}
