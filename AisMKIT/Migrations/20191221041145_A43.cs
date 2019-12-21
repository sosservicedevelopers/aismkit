using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class A43 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ListOfControlMedia_ListOfMediaId",
                table: "ListOfControlMedia");

            migrationBuilder.AddColumn<int>(
                name: "ListOfControlMediaId",
                table: "ListOfMedia",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListOfControlMedia_ListOfMediaId",
                table: "ListOfControlMedia",
                column: "ListOfMediaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ListOfControlMedia_ListOfMediaId",
                table: "ListOfControlMedia");

            migrationBuilder.DropColumn(
                name: "ListOfControlMediaId",
                table: "ListOfMedia");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfControlMedia_ListOfMediaId",
                table: "ListOfControlMedia",
                column: "ListOfMediaId");
        }
    }
}
