using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class A25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DictTypeOfMonument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKyrg = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictTypeOfMonument", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListOfMonument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DictTypeOfMonumentId = table.Column<int>(nullable: false),
                    DateOfMonument = table.Column<string>(nullable: true),
                    DictRegionId = table.Column<int>(nullable: false),
                    DictDistrictId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfMonument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListOfMonument_DictDistrict_DictDistrictId",
                        column: x => x.DictDistrictId,
                        principalTable: "DictDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListOfMonument_DictRegion_DictRegionId",
                        column: x => x.DictRegionId,
                        principalTable: "DictRegion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListOfMonument_DictTypeOfMonument_DictTypeOfMonumentId",
                        column: x => x.DictTypeOfMonumentId,
                        principalTable: "DictTypeOfMonument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMonument_DictDistrictId",
                table: "ListOfMonument",
                column: "DictDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMonument_DictRegionId",
                table: "ListOfMonument",
                column: "DictRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMonument_DictTypeOfMonumentId",
                table: "ListOfMonument",
                column: "DictTypeOfMonumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListOfMonument");

            migrationBuilder.DropTable(
                name: "DictTypeOfMonument");
        }
    }
}
