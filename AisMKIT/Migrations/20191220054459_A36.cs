using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class A36 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DictAffiliationOfMonumentId",
                table: "ListOfMonument",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DictAffiliationOfMonument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKyrg = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictAffiliationOfMonument", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMonument_DictAffiliationOfMonumentId",
                table: "ListOfMonument",
                column: "DictAffiliationOfMonumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfMonument_DictAffiliationOfMonument_DictAffiliationOfMonumentId",
                table: "ListOfMonument",
                column: "DictAffiliationOfMonumentId",
                principalTable: "DictAffiliationOfMonument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListOfMonument_DictAffiliationOfMonument_DictAffiliationOfMonumentId",
                table: "ListOfMonument");

            migrationBuilder.DropTable(
                name: "DictAffiliationOfMonument");

            migrationBuilder.DropIndex(
                name: "IX_ListOfMonument_DictAffiliationOfMonumentId",
                table: "ListOfMonument");

            migrationBuilder.DropColumn(
                name: "DictAffiliationOfMonumentId",
                table: "ListOfMonument");
        }
    }
}
