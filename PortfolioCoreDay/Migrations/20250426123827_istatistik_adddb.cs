using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioCoreDay.Migrations
{
    public partial class istatistik_adddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Istatistiks",
                columns: table => new
                {
                    IstatistikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IstatistikName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillCount = table.Column<int>(type: "int", nullable: false),
                    ProjectCount = table.Column<int>(type: "int", nullable: false),
                    MessageCount = table.Column<int>(type: "int", nullable: false),
                    RandomNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Istatistiks", x => x.IstatistikId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Istatistiks");
        }
    }
}
