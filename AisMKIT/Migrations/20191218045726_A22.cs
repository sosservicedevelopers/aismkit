using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class A22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "listISRCFilms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieTitle = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    ReleaseYear = table.Column<string>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Duration = table.Column<string>(nullable: false),
                    AgeRestrictions = table.Column<string>(nullable: false),
                    DateCertificated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_listISRCFilms", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "listISRCFilms");
        }
    }
}
