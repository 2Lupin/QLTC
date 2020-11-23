using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppQLTCId",
                table: "Transactions",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AppQLTCId",
                table: "Transactions",
                column: "AppQLTCId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_QLTC_AppQLTCId",
                table: "Transactions",
                column: "AppQLTCId",
                principalTable: "QLTC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_QLTC_AppQLTCId",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_AppQLTCId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "AppQLTCId",
                table: "Transactions");
        }
    }
}
