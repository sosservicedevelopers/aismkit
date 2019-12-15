using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class A3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DictAgencyPerm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKyrg = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    StatusForDictId = table.Column<int>(nullable: true),
                    DeactiveDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictAgencyPerm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictAgencyPerm_StatusForDict_StatusForDictId",
                        column: x => x.StatusForDictId,
                        principalTable: "StatusForDict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ListOfMedia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameRus = table.Column<string>(nullable: true),
                    NameKyrg = table.Column<string>(nullable: true),
                    INN = table.Column<string>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DictLangMediaTypeId = table.Column<int>(nullable: true),
                    DictMediaTypeId = table.Column<int>(nullable: true),
                    AddressRus = table.Column<string>(nullable: true),
                    AddressKyrg = table.Column<string>(nullable: true),
                    DictDistrictId = table.Column<int>(nullable: true),
                    DictMediaFreqReleaseId = table.Column<int>(nullable: true),
                    DictMediaFinSourceId = table.Column<int>(nullable: true),
                    ReregistrationDate = table.Column<DateTime>(nullable: false),
                    EliminationDate = table.Column<DateTime>(nullable: false),
                    NumberOfPermission = table.Column<int>(nullable: false),
                    PermissionDate = table.Column<DateTime>(nullable: false),
                    DictAgencyPermId = table.Column<int>(nullable: true),
                    DateOfPay = table.Column<DateTime>(nullable: false),
                    NumOfPermGas = table.Column<string>(nullable: true),
                    PermGASDate = table.Column<DateTime>(nullable: false),
                    PermElimGASDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListOfMedia_DictAgencyPerm_DictAgencyPermId",
                        column: x => x.DictAgencyPermId,
                        principalTable: "DictAgencyPerm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfMedia_DictDistrict_DictDistrictId",
                        column: x => x.DictDistrictId,
                        principalTable: "DictDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfMedia_DictLangMediaType_DictLangMediaTypeId",
                        column: x => x.DictLangMediaTypeId,
                        principalTable: "DictLangMediaType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfMedia_DictMediaFinSource_DictMediaFinSourceId",
                        column: x => x.DictMediaFinSourceId,
                        principalTable: "DictMediaFinSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfMedia_DictMediaFreqRelease_DictMediaFreqReleaseId",
                        column: x => x.DictMediaFreqReleaseId,
                        principalTable: "DictMediaFreqRelease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfMedia_DictMediaType_DictMediaTypeId",
                        column: x => x.DictMediaTypeId,
                        principalTable: "DictMediaType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DictAgencyPerm_StatusForDictId",
                table: "DictAgencyPerm",
                column: "StatusForDictId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictAgencyPermId",
                table: "ListOfMedia",
                column: "DictAgencyPermId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictDistrictId",
                table: "ListOfMedia",
                column: "DictDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictLangMediaTypeId",
                table: "ListOfMedia",
                column: "DictLangMediaTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictMediaFinSourceId",
                table: "ListOfMedia",
                column: "DictMediaFinSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictMediaFreqReleaseId",
                table: "ListOfMedia",
                column: "DictMediaFreqReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictMediaTypeId",
                table: "ListOfMedia",
                column: "DictMediaTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListOfMedia");

            migrationBuilder.DropTable(
                name: "DictAgencyPerm");
        }
    }
}
