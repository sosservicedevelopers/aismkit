using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class A45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NameRus",
                table: "ListOfMonument",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DictTypeOfOjbectMonumentId",
                table: "ListOfMonument",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DictTypeOfOjbectMonument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKyrg = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictTypeOfOjbectMonument", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMonument_DictTypeOfOjbectMonumentId",
                table: "ListOfMonument",
                column: "DictTypeOfOjbectMonumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfMonument_DictTypeOfOjbectMonument_DictTypeOfOjbectMonumentId",
                table: "ListOfMonument",
                column: "DictTypeOfOjbectMonumentId",
                principalTable: "DictTypeOfOjbectMonument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListOfMonument_DictTypeOfOjbectMonument_DictTypeOfOjbectMonumentId",
                table: "ListOfMonument");

            migrationBuilder.DropTable(
                name: "DictTypeOfOjbectMonument");

            migrationBuilder.DropIndex(
                name: "IX_ListOfMonument_DictTypeOfOjbectMonumentId",
                table: "ListOfMonument");

            migrationBuilder.DropColumn(
                name: "DictTypeOfOjbectMonumentId",
                table: "ListOfMonument");

            migrationBuilder.AlterColumn<string>(
                name: "NameRus",
                table: "ListOfMonument",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
