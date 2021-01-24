using Microsoft.EntityFrameworkCore.Migrations;

namespace PCC.Data.Migrations
{
    public partial class ProcessorChange17012021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Generation",
                table: "Processors");

            migrationBuilder.AddColumn<string>(
                name: "Socket",
                table: "Processors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Socket",
                table: "Processors");

            migrationBuilder.AddColumn<string>(
                name: "Generation",
                table: "Processors",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
