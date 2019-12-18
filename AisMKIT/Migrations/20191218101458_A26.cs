using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class A26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DictTypeOfSub",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKyrg = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictTypeOfSub", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListOfSubInstitutions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameRus = table.Column<string>(nullable: true),
                    NameKyrg = table.Column<string>(nullable: true),
                    INN = table.Column<string>(nullable: true),
                    DictTypeOfSubId = table.Column<int>(nullable: false),
                    Fax = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfCreated = table.Column<DateTime>(nullable: false),
                    BriefInfo = table.Column<string>(nullable: true),
                    DictRegionId = table.Column<int>(nullable: false),
                    DictDistrictId = table.Column<int>(nullable: false),
                    AddressRus = table.Column<string>(nullable: true),
                    AddressKyrg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfSubInstitutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListOfSubInstitutions_DictDistrict_DictDistrictId",
                        column: x => x.DictDistrictId,
                        principalTable: "DictDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListOfSubInstitutions_DictRegion_DictRegionId",
                        column: x => x.DictRegionId,
                        principalTable: "DictRegion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListOfSubInstitutions_DictTypeOfSub_DictTypeOfSubId",
                        column: x => x.DictTypeOfSubId,
                        principalTable: "DictTypeOfSub",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListOfSubInstitutions_DictDistrictId",
                table: "ListOfSubInstitutions",
                column: "DictDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfSubInstitutions_DictRegionId",
                table: "ListOfSubInstitutions",
                column: "DictRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfSubInstitutions_DictTypeOfSubId",
                table: "ListOfSubInstitutions",
                column: "DictTypeOfSubId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListOfSubInstitutions");

            migrationBuilder.DropTable(
                name: "DictTypeOfSub");
        }
    }
}
