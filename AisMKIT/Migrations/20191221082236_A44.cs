using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class A44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ListOfControlMedia_ListOfMediaId",
                table: "ListOfControlMedia");

            migrationBuilder.DropColumn(
                name: "ListOfControlMediaId",
                table: "ListOfMedia");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReregistrationDate",
                table: "ListOfTheatrical",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "NumEmployees",
                table: "ListOfTheatrical",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NameRus",
                table: "ListOfTheatrical",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "INN",
                table: "ListOfTheatrical",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeactiveDate",
                table: "ListOfTheatrical",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "ListOfEventsTheatrical",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameOfEvent",
                table: "ListOfEventsTheatrical",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Month",
                table: "ListOfEventsTheatrical",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DayOfMonth",
                table: "ListOfEventsTheatrical",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ListOfTheatricalId",
                table: "ListOfEventsTheatrical",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "LastNameOfArts",
                table: "ListOfCouncilTheatrical",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstNameOfArts",
                table: "ListOfCouncilTheatrical",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOutArtCouncil",
                table: "ListOfCouncilTheatrical",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateInArtCouncil",
                table: "ListOfCouncilTheatrical",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "ListOfTheatricalId",
                table: "ListOfCouncilTheatrical",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ListOfEventsTheatrical_ListOfTheatricalId",
                table: "ListOfEventsTheatrical",
                column: "ListOfTheatricalId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfCouncilTheatrical_ListOfTheatricalId",
                table: "ListOfCouncilTheatrical",
                column: "ListOfTheatricalId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfControlMedia_ListOfMediaId",
                table: "ListOfControlMedia",
                column: "ListOfMediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfCouncilTheatrical_ListOfTheatrical_ListOfTheatricalId",
                table: "ListOfCouncilTheatrical",
                column: "ListOfTheatricalId",
                principalTable: "ListOfTheatrical",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfEventsTheatrical_ListOfTheatrical_ListOfTheatricalId",
                table: "ListOfEventsTheatrical",
                column: "ListOfTheatricalId",
                principalTable: "ListOfTheatrical",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListOfCouncilTheatrical_ListOfTheatrical_ListOfTheatricalId",
                table: "ListOfCouncilTheatrical");

            migrationBuilder.DropForeignKey(
                name: "FK_ListOfEventsTheatrical_ListOfTheatrical_ListOfTheatricalId",
                table: "ListOfEventsTheatrical");

            migrationBuilder.DropIndex(
                name: "IX_ListOfEventsTheatrical_ListOfTheatricalId",
                table: "ListOfEventsTheatrical");

            migrationBuilder.DropIndex(
                name: "IX_ListOfCouncilTheatrical_ListOfTheatricalId",
                table: "ListOfCouncilTheatrical");

            migrationBuilder.DropIndex(
                name: "IX_ListOfControlMedia_ListOfMediaId",
                table: "ListOfControlMedia");

            migrationBuilder.DropColumn(
                name: "ListOfTheatricalId",
                table: "ListOfEventsTheatrical");

            migrationBuilder.DropColumn(
                name: "ListOfTheatricalId",
                table: "ListOfCouncilTheatrical");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReregistrationDate",
                table: "ListOfTheatrical",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumEmployees",
                table: "ListOfTheatrical",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameRus",
                table: "ListOfTheatrical",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "INN",
                table: "ListOfTheatrical",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeactiveDate",
                table: "ListOfTheatrical",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ListOfControlMediaId",
                table: "ListOfMedia",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "ListOfEventsTheatrical",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NameOfEvent",
                table: "ListOfEventsTheatrical",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Month",
                table: "ListOfEventsTheatrical",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "DayOfMonth",
                table: "ListOfEventsTheatrical",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastNameOfArts",
                table: "ListOfCouncilTheatrical",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstNameOfArts",
                table: "ListOfCouncilTheatrical",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOutArtCouncil",
                table: "ListOfCouncilTheatrical",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateInArtCouncil",
                table: "ListOfCouncilTheatrical",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListOfControlMedia_ListOfMediaId",
                table: "ListOfControlMedia",
                column: "ListOfMediaId",
                unique: true);
        }
    }
}
