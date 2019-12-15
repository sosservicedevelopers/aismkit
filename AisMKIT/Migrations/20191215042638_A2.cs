using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class A2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DictDistrict",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKyrg = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    StatusForDictId = table.Column<int>(nullable: true),
                    DeactiveDate = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictDistrict", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictDistrict_StatusForDict_StatusForDictId",
                        column: x => x.StatusForDictId,
                        principalTable: "StatusForDict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DictLangMediaType",
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
                    table.PrimaryKey("PK_DictLangMediaType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictLangMediaType_StatusForDict_StatusForDictId",
                        column: x => x.StatusForDictId,
                        principalTable: "StatusForDict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DictMediaFinSource",
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
                    table.PrimaryKey("PK_DictMediaFinSource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictMediaFinSource_StatusForDict_StatusForDictId",
                        column: x => x.StatusForDictId,
                        principalTable: "StatusForDict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DictMediaFreqRelease",
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
                    table.PrimaryKey("PK_DictMediaFreqRelease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictMediaFreqRelease_StatusForDict_StatusForDictId",
                        column: x => x.StatusForDictId,
                        principalTable: "StatusForDict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DictRegion",
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
                    table.PrimaryKey("PK_DictRegion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictRegion_StatusForDict_StatusForDictId",
                        column: x => x.StatusForDictId,
                        principalTable: "StatusForDict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DictDistrict_StatusForDictId",
                table: "DictDistrict",
                column: "StatusForDictId");

            migrationBuilder.CreateIndex(
                name: "IX_DictLangMediaType_StatusForDictId",
                table: "DictLangMediaType",
                column: "StatusForDictId");

            migrationBuilder.CreateIndex(
                name: "IX_DictMediaFinSource_StatusForDictId",
                table: "DictMediaFinSource",
                column: "StatusForDictId");

            migrationBuilder.CreateIndex(
                name: "IX_DictMediaFreqRelease_StatusForDictId",
                table: "DictMediaFreqRelease",
                column: "StatusForDictId");

            migrationBuilder.CreateIndex(
                name: "IX_DictRegion_StatusForDictId",
                table: "DictRegion",
                column: "StatusForDictId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DictDistrict");

            migrationBuilder.DropTable(
                name: "DictLangMediaType");

            migrationBuilder.DropTable(
                name: "DictMediaFinSource");

            migrationBuilder.DropTable(
                name: "DictMediaFreqRelease");

            migrationBuilder.DropTable(
                name: "DictRegion");
        }
    }
}
