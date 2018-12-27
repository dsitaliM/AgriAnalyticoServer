using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgriAnalyticoServer.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crops",
                columns: table => new
                {
                    CropId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    AlkalinityLow = table.Column<float>(nullable: false),
                    AlkalinityHigh = table.Column<float>(nullable: false),
                    RootDepthLow = table.Column<float>(nullable: false),
                    RootDepthHigh = table.Column<float>(nullable: false),
                    MADEstablishment = table.Column<float>(nullable: false),
                    MADVegetative = table.Column<float>(nullable: false),
                    MADFlowering = table.Column<float>(nullable: false),
                    MADMature = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crops", x => x.CropId);
                });

            migrationBuilder.CreateTable(
                name: "Soils",
                columns: table => new
                {
                    SoilId = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    FieldCapacity = table.Column<float>(nullable: false),
                    PermanentWiltingPoint = table.Column<float>(nullable: false),
                    TotalAvailableWater = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soils", x => x.SoilId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crops");

            migrationBuilder.DropTable(
                name: "Soils");
        }
    }
}
