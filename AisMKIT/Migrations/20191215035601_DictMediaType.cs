using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class DictMediaType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatusForDict",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusForDict", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DictMediaType",
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
                    table.PrimaryKey("PK_DictMediaType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictMediaType_StatusForDict_StatusForDictId",
                        column: x => x.StatusForDictId,
                        principalTable: "StatusForDict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "StatusForDict",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "включён" });

            migrationBuilder.InsertData(
                table: "StatusForDict",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "отключён" });

            migrationBuilder.CreateIndex(
                name: "IX_DictMediaType_StatusForDictId",
                table: "DictMediaType",
                column: "StatusForDictId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DictMediaType");

            migrationBuilder.DropTable(
                name: "StatusForDict");
        }
    }
}
