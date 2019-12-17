using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AisMKIT.Migrations
{
    public partial class A18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClNagradTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Desciption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClNagradTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClObjProizIskusCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Desciption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClObjProizIskusCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClObjProizIskusTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Desciption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClObjProizIskusTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClOKNTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Desciption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClOKNTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Desciption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClUchZavedCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Desciption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClUchZavedCategory", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListOfEducations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INN = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    DomenNames = table.Column<string>(nullable: true),
                    DateOfCreated = table.Column<DateTime>(nullable: false),
                    ClUchZavedCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfEducations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListOfEducations_ClUchZavedCategory_ClUchZavedCategoryId",
                        column: x => x.ClUchZavedCategoryId,
                        principalTable: "ClUchZavedCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    DepartmentsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
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
                name: "DictDistrict",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameKyrg = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    StatusForDictId = table.Column<int>(nullable: true),
                    DeactiveDate = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictDistrict", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictDistrict_StatusForDict_StatusForDictId",
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
                name: "DictRegion",
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
                    table.PrimaryKey("PK_DictRegion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictRegion_StatusForDict_StatusForDictId",
                        column: x => x.StatusForDictId,
                        principalTable: "StatusForDict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                table: "DictDistrict",
                columns: new[] { "Id", "City", "CreateDate", "DeactiveDate", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Сокулук", "Сокулук", null },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Балыкчы", "Рыбалов", null }
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
                table: "DictRegion",
                columns: new[] { "Id", "CreateDate", "DeactiveDate", "NameKyrg", "NameRus", "StatusForDictId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Чуй", "Чуй", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Баткен", "Баткен", null }
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentsId",
                table: "AspNetUsers",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DictAgencyPerm_StatusForDictId",
                table: "DictAgencyPerm",
                column: "StatusForDictId");

            migrationBuilder.CreateIndex(
                name: "IX_DictControlType_StatusForDictId",
                table: "DictControlType",
                column: "StatusForDictId");

            migrationBuilder.CreateIndex(
                name: "IX_DictDistrict_StatusForDictId",
                table: "DictDistrict",
                column: "StatusForDictId");

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
                name: "IX_DictRegion_StatusForDictId",
                table: "DictRegion",
                column: "StatusForDictId");

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
                name: "IX_ListOfEducations_ClUchZavedCategoryId",
                table: "ListOfEducations",
                column: "ClUchZavedCategoryId");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ClNagradTypes");

            migrationBuilder.DropTable(
                name: "ClObjProizIskusCategory");

            migrationBuilder.DropTable(
                name: "ClObjProizIskusTypes");

            migrationBuilder.DropTable(
                name: "ClOKNTypes");

            migrationBuilder.DropTable(
                name: "ClServices");

            migrationBuilder.DropTable(
                name: "DictLegalForm");

            migrationBuilder.DropTable(
                name: "DictRegion");

            migrationBuilder.DropTable(
                name: "ListOfControlMedia");

            migrationBuilder.DropTable(
                name: "ListOfCouncilTheatrical");

            migrationBuilder.DropTable(
                name: "ListOfEducations");

            migrationBuilder.DropTable(
                name: "ListOfEventsTheatrical");

            migrationBuilder.DropTable(
                name: "ListOfTheatrical");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DictControlType");

            migrationBuilder.DropTable(
                name: "DictMediaControlResult");

            migrationBuilder.DropTable(
                name: "DictMediaSuitPerm");

            migrationBuilder.DropTable(
                name: "ListOfMedia");

            migrationBuilder.DropTable(
                name: "ClUchZavedCategory");

            migrationBuilder.DropTable(
                name: "DictTheatricalFinSource");

            migrationBuilder.DropTable(
                name: "DictTheatricalLegalForm");

            migrationBuilder.DropTable(
                name: "Departments");

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
                name: "StatusForDict");
        }
    }
}
