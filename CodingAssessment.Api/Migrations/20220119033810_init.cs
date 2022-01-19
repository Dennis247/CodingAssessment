using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingAssessment.Api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cfa_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vetstreet_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vcahospitals_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    temperament = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country_codes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    life_span = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    indoor = table.Column<int>(type: "int", nullable: false),
                    lap = table.Column<int>(type: "int", nullable: false),
                    alt_names = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adaptability = table.Column<int>(type: "int", nullable: false),
                    affection_level = table.Column<int>(type: "int", nullable: false),
                    child_friendly = table.Column<int>(type: "int", nullable: false),
                    dog_friendly = table.Column<int>(type: "int", nullable: false),
                    energy_level = table.Column<int>(type: "int", nullable: false),
                    grooming = table.Column<int>(type: "int", nullable: false),
                    health_issues = table.Column<int>(type: "int", nullable: false),
                    intelligence = table.Column<int>(type: "int", nullable: false),
                    shedding_level = table.Column<int>(type: "int", nullable: false),
                    social_needs = table.Column<int>(type: "int", nullable: false),
                    stranger_friendly = table.Column<int>(type: "int", nullable: false),
                    vocalisation = table.Column<int>(type: "int", nullable: false),
                    experimental = table.Column<int>(type: "int", nullable: false),
                    hairless = table.Column<int>(type: "int", nullable: false),
                    natural = table.Column<int>(type: "int", nullable: false),
                    rare = table.Column<int>(type: "int", nullable: false),
                    rex = table.Column<int>(type: "int", nullable: false),
                    suppressed_tail = table.Column<int>(type: "int", nullable: false),
                    short_legs = table.Column<int>(type: "int", nullable: false),
                    wikipedia_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hypoallergenic = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weights",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Imperial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Metric = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weights_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_CatId",
                table: "Images",
                column: "CatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weights_CatId",
                table: "Weights",
                column: "CatId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Weights");

            migrationBuilder.DropTable(
                name: "Cats");
        }
    }
}
