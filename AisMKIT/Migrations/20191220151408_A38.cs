using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class A38 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListOfControlMedia_DictControlType_DictControlTypeId",
                table: "ListOfControlMedia");

            migrationBuilder.DropForeignKey(
                name: "FK_ListOfControlMedia_ListOfMedia_ListOfMediaId",
                table: "ListOfControlMedia");

            migrationBuilder.AlterColumn<int>(
                name: "ListOfMediaId",
                table: "ListOfControlMedia",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "ListOfControlMedia",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "ListOfControlMedia",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DictControlTypeId",
                table: "ListOfControlMedia",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfControlMedia_DictControlType_DictControlTypeId",
                table: "ListOfControlMedia",
                column: "DictControlTypeId",
                principalTable: "DictControlType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfControlMedia_ListOfMedia_ListOfMediaId",
                table: "ListOfControlMedia",
                column: "ListOfMediaId",
                principalTable: "ListOfMedia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListOfControlMedia_DictControlType_DictControlTypeId",
                table: "ListOfControlMedia");

            migrationBuilder.DropForeignKey(
                name: "FK_ListOfControlMedia_ListOfMedia_ListOfMediaId",
                table: "ListOfControlMedia");

            migrationBuilder.AlterColumn<int>(
                name: "ListOfMediaId",
                table: "ListOfControlMedia",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "ListOfControlMedia",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "ListOfControlMedia",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "DictControlTypeId",
                table: "ListOfControlMedia",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfControlMedia_DictControlType_DictControlTypeId",
                table: "ListOfControlMedia",
                column: "DictControlTypeId",
                principalTable: "DictControlType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfControlMedia_ListOfMedia_ListOfMediaId",
                table: "ListOfControlMedia",
                column: "ListOfMediaId",
                principalTable: "ListOfMedia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
