using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class A35 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReregistrationDate",
                table: "ListOfMedia",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "ListOfMedia",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PermissionDate",
                table: "ListOfMedia",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PermGASDate",
                table: "ListOfMedia",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PermElimGASDate",
                table: "ListOfMedia",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfPermission",
                table: "ListOfMedia",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EliminationDate",
                table: "ListOfMedia",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfPay",
                table: "ListOfMedia",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "DictDistribTerritoryMediaId",
                table: "ListOfMedia",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DictLegalFormId",
                table: "ListOfMedia",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DictRegionId",
                table: "ListOfMedia",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DictDistribTerritoryMedia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameRus = table.Column<string>(nullable: true),
                    NameKyrg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictDistribTerritoryMedia", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictDistribTerritoryMediaId",
                table: "ListOfMedia",
                column: "DictDistribTerritoryMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictLegalFormId",
                table: "ListOfMedia",
                column: "DictLegalFormId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictRegionId",
                table: "ListOfMedia",
                column: "DictRegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfMedia_DictDistribTerritoryMedia_DictDistribTerritoryMediaId",
                table: "ListOfMedia",
                column: "DictDistribTerritoryMediaId",
                principalTable: "DictDistribTerritoryMedia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfMedia_DictLegalForm_DictLegalFormId",
                table: "ListOfMedia",
                column: "DictLegalFormId",
                principalTable: "DictLegalForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfMedia_DictRegion_DictRegionId",
                table: "ListOfMedia",
                column: "DictRegionId",
                principalTable: "DictRegion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListOfMedia_DictDistribTerritoryMedia_DictDistribTerritoryMediaId",
                table: "ListOfMedia");

            migrationBuilder.DropForeignKey(
                name: "FK_ListOfMedia_DictLegalForm_DictLegalFormId",
                table: "ListOfMedia");

            migrationBuilder.DropForeignKey(
                name: "FK_ListOfMedia_DictRegion_DictRegionId",
                table: "ListOfMedia");

            migrationBuilder.DropTable(
                name: "DictDistribTerritoryMedia");

            migrationBuilder.DropIndex(
                name: "IX_ListOfMedia_DictDistribTerritoryMediaId",
                table: "ListOfMedia");

            migrationBuilder.DropIndex(
                name: "IX_ListOfMedia_DictLegalFormId",
                table: "ListOfMedia");

            migrationBuilder.DropIndex(
                name: "IX_ListOfMedia_DictRegionId",
                table: "ListOfMedia");

            migrationBuilder.DropColumn(
                name: "DictDistribTerritoryMediaId",
                table: "ListOfMedia");

            migrationBuilder.DropColumn(
                name: "DictLegalFormId",
                table: "ListOfMedia");

            migrationBuilder.DropColumn(
                name: "DictRegionId",
                table: "ListOfMedia");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReregistrationDate",
                table: "ListOfMedia",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "ListOfMedia",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PermissionDate",
                table: "ListOfMedia",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PermGASDate",
                table: "ListOfMedia",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PermElimGASDate",
                table: "ListOfMedia",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfPermission",
                table: "ListOfMedia",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EliminationDate",
                table: "ListOfMedia",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfPay",
                table: "ListOfMedia",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
