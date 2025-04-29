using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioCoreDay.Migrations
{
    public partial class work_deleteColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameSurname",
                table: "Works");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameSurname",
                table: "Works",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
