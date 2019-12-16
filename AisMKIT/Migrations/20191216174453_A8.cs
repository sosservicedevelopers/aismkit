using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class A8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameAllLangs",
                table: "DictRegion",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAllLangs",
                table: "DictMediaType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAllLangs",
                table: "DictMediaSuitPerm",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAllLangs",
                table: "DictMediaFreqRelease",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAllLangs",
                table: "DictMediaFinSource",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAllLangs",
                table: "DictMediaControlResult",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAllLangs",
                table: "DictLegalForm",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAllLangs",
                table: "DictLangMediaType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAllLangs",
                table: "DictDistrict",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAllLangs",
                table: "DictControlType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAllLangs",
                table: "DictAgencyPerm",
                nullable: true);

            migrationBuilder.InsertData(
                table: "DictDistrict",
                columns: new[] { "Id", "City", "CreateDate", "DeactiveDate", "NameAllLangs", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Сокулук (Сокулук)", "Сокулук", "Сокулук", null },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Рыбалов (Балыкчы)", "Балыкчы", "Рыбалов", null }
                });

            migrationBuilder.InsertData(
                table: "DictLangMediaType",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameAllLangs", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Русский (Орусча)", "Орусча", "Русский", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кыргызский (Кыргызча)", "Кыргызча", "Кыргызский", null }
                });

            migrationBuilder.InsertData(
                table: "DictLegalForm",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameAllLangs", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Закрытое акционерное общество (Жабык акционердик коому)", "Жабык акционердик коому", "Закрытое акционерное общество", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Общество с ограниченной ответсвенностью (Жоопкерчилиги чектелген коом)", "Жоопкерчилиги чектелген коом", "Общество с ограниченной ответсвенностью", null }
                });

            migrationBuilder.InsertData(
                table: "DictMediaFinSource",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameAllLangs", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Государственный (Мамлекеттик)", "Мамлекеттик", "Государственный", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Частный (Жекече)", "Жекече", "Частный", null }
                });

            migrationBuilder.InsertData(
                table: "DictMediaFreqRelease",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameAllLangs", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ежемесячно (Ар бир айда)", "Ар бир айда", "Ежемесячно", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Еженедельно (Ар бир жумада)", "Ар бир жумада", "Еженедельно", null }
                });

            migrationBuilder.InsertData(
                table: "DictMediaType",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameAllLangs", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Печатное периодическое издание (Басма уйу)", "Басма уйу", "Печатное периодическое издание", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Телеканал (Телеканал)", "Телеканал", "Телеканал", null }
                });

            migrationBuilder.InsertData(
                table: "DictRegion",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameAllLangs", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Чуй (Чуй)", "Чуй", "Чуй", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Баткен (Баткен)", "Баткен", "Баткен", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DictDistrict",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DictDistrict",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DictLangMediaType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DictLangMediaType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DictLegalForm",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DictLegalForm",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DictMediaFinSource",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DictMediaFinSource",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DictMediaFreqRelease",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DictMediaFreqRelease",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DictMediaType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DictMediaType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DictRegion",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DictRegion",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "NameAllLangs",
                table: "DictRegion");

            migrationBuilder.DropColumn(
                name: "NameAllLangs",
                table: "DictMediaType");

            migrationBuilder.DropColumn(
                name: "NameAllLangs",
                table: "DictMediaSuitPerm");

            migrationBuilder.DropColumn(
                name: "NameAllLangs",
                table: "DictMediaFreqRelease");

            migrationBuilder.DropColumn(
                name: "NameAllLangs",
                table: "DictMediaFinSource");

            migrationBuilder.DropColumn(
                name: "NameAllLangs",
                table: "DictMediaControlResult");

            migrationBuilder.DropColumn(
                name: "NameAllLangs",
                table: "DictLegalForm");

            migrationBuilder.DropColumn(
                name: "NameAllLangs",
                table: "DictLangMediaType");

            migrationBuilder.DropColumn(
                name: "NameAllLangs",
                table: "DictDistrict");

            migrationBuilder.DropColumn(
                name: "NameAllLangs",
                table: "DictControlType");

            migrationBuilder.DropColumn(
                name: "NameAllLangs",
                table: "DictAgencyPerm");
        }
    }
}
