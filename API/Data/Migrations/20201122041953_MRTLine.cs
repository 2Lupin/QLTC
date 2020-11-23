using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class MRTLine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MRTLine1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Station = table.Column<int>(type: "INTEGER", nullable: false),
                    F1 = table.Column<double>(type: "REAL", nullable: false),
                    F2 = table.Column<double>(type: "REAL", nullable: false),
                    F3 = table.Column<double>(type: "REAL", nullable: false),
                    F4 = table.Column<double>(type: "REAL", nullable: false),
                    F5 = table.Column<double>(type: "REAL", nullable: false),
                    F6 = table.Column<double>(type: "REAL", nullable: false),
                    F7 = table.Column<double>(type: "REAL", nullable: false),
                    F8 = table.Column<double>(type: "REAL", nullable: false),
                    F9 = table.Column<double>(type: "REAL", nullable: false),
                    F10 = table.Column<double>(type: "REAL", nullable: false),
                    F11 = table.Column<double>(type: "REAL", nullable: false),
                    F12 = table.Column<double>(type: "REAL", nullable: false),
                    F13 = table.Column<double>(type: "REAL", nullable: false),
                    F14 = table.Column<double>(type: "REAL", nullable: false),
                    F15 = table.Column<double>(type: "REAL", nullable: false),
                    F16 = table.Column<double>(type: "REAL", nullable: false),
                    F17 = table.Column<double>(type: "REAL", nullable: false),
                    F18 = table.Column<double>(type: "REAL", nullable: false),
                    F19 = table.Column<double>(type: "REAL", nullable: false),
                    F20 = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MRTLine1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MRTLine2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Station = table.Column<int>(type: "INTEGER", nullable: false),
                    F1 = table.Column<double>(type: "REAL", nullable: false),
                    F2 = table.Column<double>(type: "REAL", nullable: false),
                    F3 = table.Column<double>(type: "REAL", nullable: false),
                    F4 = table.Column<double>(type: "REAL", nullable: false),
                    F5 = table.Column<double>(type: "REAL", nullable: false),
                    F6 = table.Column<double>(type: "REAL", nullable: false),
                    F7 = table.Column<double>(type: "REAL", nullable: false),
                    F8 = table.Column<double>(type: "REAL", nullable: false),
                    F9 = table.Column<double>(type: "REAL", nullable: false),
                    F10 = table.Column<double>(type: "REAL", nullable: false),
                    F11 = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MRTLine2", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MRTLine1");

            migrationBuilder.DropTable(
                name: "MRTLine2");
        }
    }
}
