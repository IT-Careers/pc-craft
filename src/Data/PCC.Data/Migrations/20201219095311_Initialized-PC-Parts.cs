using Microsoft.EntityFrameworkCore.Migrations;

namespace PCC.Data.Migrations
{
    public partial class InitializedPCParts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GPUs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ElectricalPowerConsumption = table.Column<int>(nullable: false),
                    Memory = table.Column<long>(nullable: false),
                    Clockspeed = table.Column<long>(nullable: false),
                    Generation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardDisks",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ElectricalPowerConsumption = table.Column<int>(nullable: false),
                    Capacity = table.Column<long>(nullable: false),
                    Speed = table.Column<long>(nullable: false),
                    IsSSD = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardDisks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ElectricalPowerConsumption = table.Column<int>(nullable: false),
                    CPUSupport = table.Column<string>(nullable: true),
                    MemorySupport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerSupplies",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ElectricalPowerConsumption = table.Column<int>(nullable: false),
                    SupportedElectricalPowerConsumption = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSupplies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ElectricalPowerConsumption = table.Column<int>(nullable: false),
                    Cores = table.Column<int>(nullable: false),
                    Clockspeed = table.Column<long>(nullable: false),
                    Generation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RAMs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ElectricalPowerConsumption = table.Column<int>(nullable: false),
                    Capacity = table.Column<long>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Speed = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsGame = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Softwares",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IsGame = table.Column<bool>(nullable: false),
                    ParamatersId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParameterSettings",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RecommendedRAM = table.Column<long>(nullable: false),
                    RecommendedRAMType = table.Column<string>(nullable: true),
                    RecommendedRAMSpeed = table.Column<long>(nullable: false),
                    RecommendedProcessorClockspeed = table.Column<long>(nullable: false),
                    RecommendedProcessorCores = table.Column<long>(nullable: false),
                    RecommendedProcessorGeneration = table.Column<string>(nullable: true),
                    RecommendedStorageSpace = table.Column<long>(nullable: false),
                    RecommendedVideoMemory = table.Column<long>(nullable: false),
                    RecommendedVideoClockspeed = table.Column<long>(nullable: false),
                    RecommendedVideoGeneration = table.Column<string>(nullable: true),
                    SettingId = table.Column<string>(nullable: true),
                    SoftwareId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParameterSettings_Settings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "Settings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParameterSettings_Softwares_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Softwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParameterSettings_SettingId",
                table: "ParameterSettings",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterSettings_SoftwareId",
                table: "ParameterSettings",
                column: "SoftwareId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GPUs");

            migrationBuilder.DropTable(
                name: "HardDisks");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "ParameterSettings");

            migrationBuilder.DropTable(
                name: "PowerSupplies");

            migrationBuilder.DropTable(
                name: "Processors");

            migrationBuilder.DropTable(
                name: "RAMs");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Softwares");
        }
    }
}
