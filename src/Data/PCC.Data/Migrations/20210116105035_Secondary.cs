using Microsoft.EntityFrameworkCore.Migrations;

namespace PCC.Data.Migrations
{
    public partial class Secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "RAMs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Processors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "PowerSupplies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Motherboards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "HardDisks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "GPUs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "RAMs");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Processors");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "PowerSupplies");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Motherboards");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "HardDisks");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "GPUs");
        }
    }
}
