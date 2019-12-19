using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Contacts = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DictEduCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Desciption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictEduCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DictRegion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKyrg = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictRegion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DictTheatricalFinSource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKyrg = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictTheatricalFinSource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DictTheatricalLegalForm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKyrg = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictTheatricalLegalForm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DictTypeOfMonument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKyrg = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictTypeOfMonument", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DictTypeOfSub",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKyrg = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictTypeOfSub", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationalUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    SecondName = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "ListOfCouncilTheatrical",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastNameOfArts = table.Column<string>(nullable: true),
                    FirstNameOfArts = table.Column<string>(nullable: true),
                    PatronicNameOfArts = table.Column<string>(nullable: true),
                    DateInArtCouncil = table.Column<DateTime>(nullable: false),
                    DateOutArtCouncil = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfCouncilTheatrical", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListOfEventsTheatrical",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<string>(nullable: true),
                    Month = table.Column<string>(nullable: true),
                    DayOfMonth = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    NameOfEvent = table.Column<string>(nullable: true),
                    NameOfHall = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfEventsTheatrical", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.Id);
                });

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
                name: "EduInstitutions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INN = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    DomenNames = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfCreated = table.Column<DateTime>(nullable: false),
                    BriefInfo = table.Column<string>(nullable: true),
                    DictEduCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduInstitutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EduInstitutions_DictEduCategories_DictEduCategoryId",
                        column: x => x.DictEduCategoryId,
                        principalTable: "DictEduCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DictDistrict",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKyrg = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    DictRegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictDistrict", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictDistrict_DictRegion_DictRegionId",
                        column: x => x.DictRegionId,
                        principalTable: "DictRegion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListOfTheatrical",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameRus = table.Column<string>(nullable: true),
                    NameKyrg = table.Column<string>(nullable: true),
                    DictTheatricalLegalFormId = table.Column<int>(nullable: true),
                    INN = table.Column<string>(nullable: true),
                    LastNameDirector = table.Column<string>(nullable: true),
                    FirstNameDirector = table.Column<string>(nullable: true),
                    PatronicNameDirector = table.Column<string>(nullable: true),
                    LastNameOfArtsDirector = table.Column<string>(nullable: true),
                    FirstNameOfArtsDirector = table.Column<string>(nullable: true),
                    PatronicNameOfArtsDirector = table.Column<string>(nullable: true),
                    NumEmployees = table.Column<int>(nullable: false),
                    DictTheatricalFinSourceId = table.Column<int>(nullable: true),
                    ReregistrationDate = table.Column<DateTime>(nullable: false),
                    DeactiveDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfTheatrical", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListOfTheatrical_DictTheatricalFinSource_DictTheatricalFinSourceId",
                        column: x => x.DictTheatricalFinSourceId,
                        principalTable: "DictTheatricalFinSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfTheatrical_DictTheatricalLegalForm_DictTheatricalLegalFormId",
                        column: x => x.DictTheatricalLegalFormId,
                        principalTable: "DictTheatricalLegalForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DictAgencyPerm",
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
                    table.PrimaryKey("PK_DictAgencyPerm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictAgencyPerm_StatusForDict_StatusForDictId",
                        column: x => x.StatusForDictId,
                        principalTable: "StatusForDict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DictControlType",
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
                    table.PrimaryKey("PK_DictControlType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictControlType_StatusForDict_StatusForDictId",
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
                name: "DictLegalForm",
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
                    table.PrimaryKey("PK_DictLegalForm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictLegalForm_StatusForDict_StatusForDictId",
                        column: x => x.StatusForDictId,
                        principalTable: "StatusForDict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DictMediaControlResult",
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
                    table.PrimaryKey("PK_DictMediaControlResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictMediaControlResult_StatusForDict_StatusForDictId",
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
                name: "DictMediaSuitPerm",
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
                    table.PrimaryKey("PK_DictMediaSuitPerm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictMediaSuitPerm_StatusForDict_StatusForDictId",
                        column: x => x.StatusForDictId,
                        principalTable: "StatusForDict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EduInstitutionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faculties_EduInstitutions_EduInstitutionId",
                        column: x => x.EduInstitutionId,
                        principalTable: "EduInstitutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ListOfMonument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameRus = table.Column<string>(nullable: true),
                    NameKyrg = table.Column<string>(nullable: true),
                    DictTypeOfMonumentId = table.Column<int>(nullable: true),
                    DateOfMonument = table.Column<string>(nullable: true),
                    DictRegionId = table.Column<int>(nullable: true),
                    DictDistrictId = table.Column<int>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfMonument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListOfMonument_DictDistrict_DictDistrictId",
                        column: x => x.DictDistrictId,
                        principalTable: "DictDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfMonument_DictRegion_DictRegionId",
                        column: x => x.DictRegionId,
                        principalTable: "DictRegion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfMonument_DictTypeOfMonument_DictTypeOfMonumentId",
                        column: x => x.DictTypeOfMonumentId,
                        principalTable: "DictTypeOfMonument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ListOfSubInstitutions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameRus = table.Column<string>(nullable: true),
                    NameKyrg = table.Column<string>(nullable: true),
                    INN = table.Column<string>(nullable: true),
                    DictTypeOfSubId = table.Column<int>(nullable: false),
                    Fax = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfCreated = table.Column<DateTime>(nullable: false),
                    BriefInfo = table.Column<string>(nullable: true),
                    DictRegionId = table.Column<int>(nullable: true),
                    DictDistrictId = table.Column<int>(nullable: true),
                    AddressRus = table.Column<string>(nullable: true),
                    AddressKyrg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfSubInstitutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListOfSubInstitutions_DictDistrict_DictDistrictId",
                        column: x => x.DictDistrictId,
                        principalTable: "DictDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfSubInstitutions_DictRegion_DictRegionId",
                        column: x => x.DictRegionId,
                        principalTable: "DictRegion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfSubInstitutions_DictTypeOfSub_DictTypeOfSubId",
                        column: x => x.DictTypeOfSubId,
                        principalTable: "DictTypeOfSub",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListOfMedia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameRus = table.Column<string>(nullable: true),
                    NameKyrg = table.Column<string>(nullable: true),
                    INN = table.Column<string>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DictLangMediaTypeId = table.Column<int>(nullable: true),
                    DictMediaTypeId = table.Column<int>(nullable: true),
                    AddressRus = table.Column<string>(nullable: true),
                    AddressKyrg = table.Column<string>(nullable: true),
                    DictDistrictId = table.Column<int>(nullable: true),
                    DictMediaFreqReleaseId = table.Column<int>(nullable: true),
                    DictMediaFinSourceId = table.Column<int>(nullable: true),
                    ReregistrationDate = table.Column<DateTime>(nullable: false),
                    EliminationDate = table.Column<DateTime>(nullable: false),
                    NumberOfPermission = table.Column<int>(nullable: false),
                    PermissionDate = table.Column<DateTime>(nullable: false),
                    DictAgencyPermId = table.Column<int>(nullable: true),
                    DateOfPay = table.Column<DateTime>(nullable: false),
                    NumOfPermGas = table.Column<string>(nullable: true),
                    PermGASDate = table.Column<DateTime>(nullable: false),
                    PermElimGASDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListOfMedia_DictAgencyPerm_DictAgencyPermId",
                        column: x => x.DictAgencyPermId,
                        principalTable: "DictAgencyPerm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfMedia_DictDistrict_DictDistrictId",
                        column: x => x.DictDistrictId,
                        principalTable: "DictDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfMedia_DictLangMediaType_DictLangMediaTypeId",
                        column: x => x.DictLangMediaTypeId,
                        principalTable: "DictLangMediaType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfMedia_DictMediaFinSource_DictMediaFinSourceId",
                        column: x => x.DictMediaFinSourceId,
                        principalTable: "DictMediaFinSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfMedia_DictMediaFreqRelease_DictMediaFreqReleaseId",
                        column: x => x.DictMediaFreqReleaseId,
                        principalTable: "DictMediaFreqRelease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfMedia_DictMediaType_DictMediaTypeId",
                        column: x => x.DictMediaTypeId,
                        principalTable: "DictMediaType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmplEducationalUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: true),
                    EducationalUnitId = table.Column<int>(nullable: true),
                    WorkStartDate = table.Column<DateTime>(nullable: false),
                    WorkEndDate = table.Column<DateTime>(nullable: false),
                    FacultyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmplEducationalUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmplEducationalUnits_EducationalUnits_EducationalUnitId",
                        column: x => x.EducationalUnitId,
                        principalTable: "EducationalUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmplEducationalUnits_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmplEducationalUnits_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmplPosHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: true),
                    PositionId = table.Column<int>(nullable: true),
                    WorkStartDate = table.Column<DateTime>(nullable: false),
                    WorkEndDate = table.Column<DateTime>(nullable: false),
                    FacultyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmplPosHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmplPosHistories_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmplPosHistories_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmplPosHistories_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacultySpecialties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialtyId = table.Column<int>(nullable: true),
                    FacultyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultySpecialties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacultySpecialties_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacultySpecialties_Specialties_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalTable: "Specialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ListOfControlMedia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListOfMediaId = table.Column<int>(nullable: true),
                    DictControlTypeId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    StartDatePeriod = table.Column<DateTime>(nullable: true),
                    EndDatePeriod = table.Column<DateTime>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    PatronicName = table.Column<string>(nullable: true),
                    ActDateControl = table.Column<DateTime>(nullable: true),
                    NumberOfAct = table.Column<string>(nullable: true),
                    DictMediaControlResultId = table.Column<int>(nullable: true),
                    NumberOfWarning = table.Column<string>(nullable: true),
                    WarningDate = table.Column<DateTime>(nullable: true),
                    WarningEndDate = table.Column<DateTime>(nullable: true),
                    DateOfPenalty = table.Column<DateTime>(nullable: true),
                    DocNumPenalty = table.Column<string>(nullable: true),
                    PenaltySum = table.Column<string>(nullable: true),
                    DateOfPenaltyPay = table.Column<DateTime>(nullable: true),
                    AnulmentDate = table.Column<DateTime>(nullable: true),
                    NumberOfAnulment = table.Column<string>(nullable: true),
                    DateOfSuit = table.Column<DateTime>(nullable: true),
                    NumberOfSuit = table.Column<string>(nullable: true),
                    DateOfSuitPerm = table.Column<DateTime>(nullable: true),
                    NumberOfSuitPerm = table.Column<string>(nullable: true),
                    DictMediaSuitPermId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfControlMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListOfControlMedia_DictControlType_DictControlTypeId",
                        column: x => x.DictControlTypeId,
                        principalTable: "DictControlType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfControlMedia_DictMediaControlResult_DictMediaControlResultId",
                        column: x => x.DictMediaControlResultId,
                        principalTable: "DictMediaControlResult",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfControlMedia_DictMediaSuitPerm_DictMediaSuitPermId",
                        column: x => x.DictMediaSuitPermId,
                        principalTable: "DictMediaSuitPerm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListOfControlMedia_ListOfMedia_ListOfMediaId",
                        column: x => x.ListOfMediaId,
                        principalTable: "ListOfMedia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "DictAgencyPerm",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ИИМ", "МВД", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "МКНБ", "ГКНБ", null }
                });

            migrationBuilder.InsertData(
                table: "DictControlType",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Пландык", "Плановая", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Пландык эмес", "Неплановая", null }
                });

            migrationBuilder.InsertData(
                table: "DictLangMediaType",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Орусча", "Русский", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кыргызча", "Кыргызский", null }
                });

            migrationBuilder.InsertData(
                table: "DictLegalForm",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Жабык акционердик коому", "Закрытое акционерное общество", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Жоопкерчилиги чектелген коом", "Общество с ограниченной ответсвенностью", null }
                });

            migrationBuilder.InsertData(
                table: "DictMediaControlResult",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Отзыв разрешения", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Наложен штраф", null },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Без нарушений", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Вынесено предупреждение", null }
                });

            migrationBuilder.InsertData(
                table: "DictMediaFinSource",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Мамлекеттик", "Государственный", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Жекече", "Частный", null }
                });

            migrationBuilder.InsertData(
                table: "DictMediaFreqRelease",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ар бир айда", "Ежемесячно", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ар бир жумада", "Еженедельно", null }
                });

            migrationBuilder.InsertData(
                table: "DictMediaSuitPerm",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "В пользу лицензиата", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "В пользу лицензиара", null }
                });

            migrationBuilder.InsertData(
                table: "DictMediaType",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Басма уйу", "Печатное периодическое издание", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Телеканал", "Телеканал", null }
                });

            migrationBuilder.InsertData(
                table: "StatusForDict",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "включён" },
                    { 2, "отключён" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DictAgencyPerm_StatusForDictId",
                table: "DictAgencyPerm",
                column: "StatusForDictId");

            migrationBuilder.CreateIndex(
                name: "IX_DictControlType_StatusForDictId",
                table: "DictControlType",
                column: "StatusForDictId");

            migrationBuilder.CreateIndex(
                name: "IX_DictDistrict_DictRegionId",
                table: "DictDistrict",
                column: "DictRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_DictLangMediaType_StatusForDictId",
                table: "DictLangMediaType",
                column: "StatusForDictId");

            migrationBuilder.CreateIndex(
                name: "IX_DictLegalForm_StatusForDictId",
                table: "DictLegalForm",
                column: "StatusForDictId");

            migrationBuilder.CreateIndex(
                name: "IX_DictMediaControlResult_StatusForDictId",
                table: "DictMediaControlResult",
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
                name: "IX_DictMediaSuitPerm_StatusForDictId",
                table: "DictMediaSuitPerm",
                column: "StatusForDictId");

            migrationBuilder.CreateIndex(
                name: "IX_DictMediaType_StatusForDictId",
                table: "DictMediaType",
                column: "StatusForDictId");

            migrationBuilder.CreateIndex(
                name: "IX_EduInstitutions_DictEduCategoryId",
                table: "EduInstitutions",
                column: "DictEduCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EmplEducationalUnits_EducationalUnitId",
                table: "EmplEducationalUnits",
                column: "EducationalUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_EmplEducationalUnits_EmployeeId",
                table: "EmplEducationalUnits",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmplEducationalUnits_FacultyId",
                table: "EmplEducationalUnits",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_EmplPosHistories_EmployeeId",
                table: "EmplPosHistories",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmplPosHistories_FacultyId",
                table: "EmplPosHistories",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_EmplPosHistories_PositionId",
                table: "EmplPosHistories",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_EduInstitutionId",
                table: "Faculties",
                column: "EduInstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_FacultySpecialties_FacultyId",
                table: "FacultySpecialties",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_FacultySpecialties_SpecialtyId",
                table: "FacultySpecialties",
                column: "SpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfControlMedia_DictControlTypeId",
                table: "ListOfControlMedia",
                column: "DictControlTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfControlMedia_DictMediaControlResultId",
                table: "ListOfControlMedia",
                column: "DictMediaControlResultId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfControlMedia_DictMediaSuitPermId",
                table: "ListOfControlMedia",
                column: "DictMediaSuitPermId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfControlMedia_ListOfMediaId",
                table: "ListOfControlMedia",
                column: "ListOfMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictAgencyPermId",
                table: "ListOfMedia",
                column: "DictAgencyPermId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictDistrictId",
                table: "ListOfMedia",
                column: "DictDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictLangMediaTypeId",
                table: "ListOfMedia",
                column: "DictLangMediaTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictMediaFinSourceId",
                table: "ListOfMedia",
                column: "DictMediaFinSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictMediaFreqReleaseId",
                table: "ListOfMedia",
                column: "DictMediaFreqReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMedia_DictMediaTypeId",
                table: "ListOfMedia",
                column: "DictMediaTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMonument_DictDistrictId",
                table: "ListOfMonument",
                column: "DictDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMonument_DictRegionId",
                table: "ListOfMonument",
                column: "DictRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMonument_DictTypeOfMonumentId",
                table: "ListOfMonument",
                column: "DictTypeOfMonumentId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfSubInstitutions_DictDistrictId",
                table: "ListOfSubInstitutions",
                column: "DictDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfSubInstitutions_DictRegionId",
                table: "ListOfSubInstitutions",
                column: "DictRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfSubInstitutions_DictTypeOfSubId",
                table: "ListOfSubInstitutions",
                column: "DictTypeOfSubId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfTheatrical_DictTheatricalFinSourceId",
                table: "ListOfTheatrical",
                column: "DictTheatricalFinSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfTheatrical_DictTheatricalLegalFormId",
                table: "ListOfTheatrical",
                column: "DictTheatricalLegalFormId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "DictLegalForm");

            migrationBuilder.DropTable(
                name: "EmplEducationalUnits");

            migrationBuilder.DropTable(
                name: "EmplPosHistories");

            migrationBuilder.DropTable(
                name: "FacultySpecialties");

            migrationBuilder.DropTable(
                name: "listISRCFilms");

            migrationBuilder.DropTable(
                name: "ListOfControlMedia");

            migrationBuilder.DropTable(
                name: "ListOfCouncilTheatrical");

            migrationBuilder.DropTable(
                name: "ListOfEventsTheatrical");

            migrationBuilder.DropTable(
                name: "ListOfMonument");

            migrationBuilder.DropTable(
                name: "ListOfSubInstitutions");

            migrationBuilder.DropTable(
                name: "ListOfTheatrical");

            migrationBuilder.DropTable(
                name: "EducationalUnits");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DropTable(
                name: "DictControlType");

            migrationBuilder.DropTable(
                name: "DictMediaControlResult");

            migrationBuilder.DropTable(
                name: "DictMediaSuitPerm");

            migrationBuilder.DropTable(
                name: "ListOfMedia");

            migrationBuilder.DropTable(
                name: "DictTypeOfMonument");

            migrationBuilder.DropTable(
                name: "DictTypeOfSub");

            migrationBuilder.DropTable(
                name: "DictTheatricalFinSource");

            migrationBuilder.DropTable(
                name: "DictTheatricalLegalForm");

            migrationBuilder.DropTable(
                name: "EduInstitutions");

            migrationBuilder.DropTable(
                name: "DictAgencyPerm");

            migrationBuilder.DropTable(
                name: "DictDistrict");

            migrationBuilder.DropTable(
                name: "DictLangMediaType");

            migrationBuilder.DropTable(
                name: "DictMediaFinSource");

            migrationBuilder.DropTable(
                name: "DictMediaFreqRelease");

            migrationBuilder.DropTable(
                name: "DictMediaType");

            migrationBuilder.DropTable(
                name: "DictEduCategories");

            migrationBuilder.DropTable(
                name: "DictRegion");

            migrationBuilder.DropTable(
                name: "StatusForDict");
        }
    }
}
