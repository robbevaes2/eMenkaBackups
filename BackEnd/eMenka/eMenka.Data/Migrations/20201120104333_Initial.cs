using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eMenka.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(nullable: true),
                    IsInternal = table.Column<bool>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    NonActiveRemark = table.Column<string>(nullable: true),
                    VAT = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CostAllocation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Abbreviation = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostAllocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    POD = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    Language = table.Column<int>(nullable: false),
                    DriversLicenseNumber = table.Column<string>(nullable: true),
                    DriversLicenseType = table.Column<string>(nullable: true),
                    StartDateDriversLicense = table.Column<DateTime>(nullable: true),
                    EndDateDriversLicense = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Picture = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Types = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Internal = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
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
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
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
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
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
                name: "EngineTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EngineTypes_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExteriorColors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExteriorColors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExteriorColors_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InteriorColors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InteriorColors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InteriorColors_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Corporations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Abbreviation = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Corporations_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    FuelCardId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drivers_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FuelCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true),
                    VehicleId = table.Column<int>(nullable: true),
                    DriverId = table.Column<int>(nullable: true),
                    RecordId = table.Column<int>(nullable: true),
                    IsBlocked = table.Column<bool>(nullable: false),
                    BlockingDate = table.Column<DateTime>(nullable: true),
                    BlockingReason = table.Column<string>(nullable: true),
                    PinCode = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuelCards_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FuelCards_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelCardId = table.Column<int>(nullable: true),
                    CorporationId = table.Column<int>(nullable: true),
                    CostAllocationId = table.Column<int>(nullable: true),
                    Term = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Usage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_Corporations_CorporationId",
                        column: x => x.CorporationId,
                        principalTable: "Corporations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Records_CostAllocation_CostAllocationId",
                        column: x => x.CostAllocationId,
                        principalTable: "CostAllocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Records_FuelCards_FuelCardId",
                        column: x => x.FuelCardId,
                        principalTable: "FuelCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(nullable: true),
                    ModelId = table.Column<int>(nullable: true),
                    SeriesId = table.Column<int>(nullable: true),
                    EngineTypeId = table.Column<int>(nullable: true),
                    FuelCardId = table.Column<int>(nullable: true),
                    DoorTypeId = table.Column<int>(nullable: true),
                    FuelTypeId = table.Column<int>(nullable: true),
                    EngineCapacity = table.Column<int>(nullable: true),
                    EnginePower = table.Column<int>(nullable: false),
                    EndDateDelivery = table.Column<DateTime>(nullable: true),
                    AverageFuel = table.Column<int>(nullable: true),
                    Volume = table.Column<int>(nullable: true),
                    FiscalHP = table.Column<int>(nullable: true),
                    Emission = table.Column<int>(nullable: true),
                    Power = table.Column<int>(nullable: true),
                    LicensePlate = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    BuildYear = table.Column<int>(nullable: true),
                    Chassis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_DoorTypes_DoorTypeId",
                        column: x => x.DoorTypeId,
                        principalTable: "DoorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_EngineTypes_EngineTypeId",
                        column: x => x.EngineTypeId,
                        principalTable: "EngineTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_FuelCards_FuelCardId",
                        column: x => x.FuelCardId,
                        principalTable: "FuelCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "BMW" },
                    { 28, "blub" },
                    { 27, "aTest" },
                    { 26, "azerty" },
                    { 24, "TestMerk1" },
                    { 23, "Mini" },
                    { 22, "Porsche" },
                    { 21, "Smart" },
                    { 20, "Skoda" },
                    { 19, "Saab" },
                    { 18, "Lexus" },
                    { 17, "Honda" },
                    { 16, "Alfa Romeo" },
                    { 15, "Nissan" },
                    { 25, "Blastxsx" },
                    { 13, "Toyota" },
                    { 14, "Hyundai" },
                    { 3, "Volkswagen" },
                    { 4, "Opel" },
                    { 5, "Ferrari" },
                    { 6, "Peugeot" },
                    { 2, "Ford" },
                    { 8, "Mercedes" },
                    { 9, "KIA" },
                    { 12, "Fiat" },
                    { 10, "Volvo" },
                    { 11, "Citroën" },
                    { 7, "Audi" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Vrachtwagen" },
                    { 3, "Heftruck" },
                    { 1, "Personenwagen" },
                    { 2, "Bestelwagen" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountNumber", "Description", "IsActive", "IsInternal", "Name", "NonActiveRemark", "Reference", "VAT" },
                values: new object[,]
                {
                    { 27, "", "rechtsbijstandsverzekering", true, false, "DAS", "", "", "" },
                    { 21, "", "Federale overheidsdienst Financiën", true, false, "FodFin", "", "FODFIN", "" },
                    { 22, "001-4327984-17", "Gar BMW Smets", true, false, "Patrick Smets NV", "", "SMETS", "BE 0418.022.587" },
                    { 23, "", "", true, false, "Beerens", "", "", "" },
                    { 24, "", "Bandencentrale", true, false, "Jespers", "", "TYRECENTER", "BE39416100572119" },
                    { 25, "", "algemeen naam", true, false, "Autokeuring", "", "", "" },
                    { 26, "", "rechtsbijstand", true, false, "Euromex", "", "", "BE0404493859" },
                    { 28, "", "Maecon", true, false, "Maecon", "", "", "" },
                    { 36, null, null, null, null, null, null, null, null },
                    { 30, "", "banden donckers", true, false, "Moereels", "", "", "BE80230013411177" },
                    { 31, "", "", true, true, "eMenKa GmbH", "", "", "" },
                    { 32, "", "<p><span><span>Antwerpen is de hoofdstad van <span class=\"comment - copy\">This works fine, but be aware that copying a</span></span><span><span class=\"comment - copy\">nd </span></span><span><span class=\"comment - copy\">pasting </span></span></span></p>", true, true, "eMenKa BV", "", "", "" },
                    { 33, "", "test", true, false, "test", "", "", "" },
                    { 34, null, null, false, false, "Q8", null, null, null },
                    { 35, "", "", true, false, "Alphabet", "", "ALP", "" },
                    { 20, "335-0431795-94", "Carglass", true, false, "Carglass", "", "CAR", "BE 0432.023.845" },
                    { 29, "", "", true, true, "eMenKa NV", "", "", "BE 0888.140.116" },
                    { 19, "", "BMW dealer", true, false, "Peter DAENINCK NV", "", "", "" },
                    { 9, "1", "BMW Garage", true, false, "Sneyers", "", "D", "1" },
                    { 17, "BE31 4100 0007 1155", "", true, false, "Mercator Verzekeringen NV", "", "Mercator", "BE0400.048.883" },
                    { 1, null, null, false, false, "Total Belgium", null, null, null },
                    { 2, "123", "Esso", true, false, "Esso", "", "Esso", "123" },
                    { 18, "", "", true, false, "KAVEDE NV", "", "KAVEDE", "BE0429.270.926" },
                    { 4, "333-7777777-22", "Fictieve Opel garage", true, false, "OpelPlus", "", "Garage opel", "BE0456.565.667" },
                    { 5, "123-1234567-98", "KT leverancier ?", true, false, "AVIS", "", "AVIS", "BE 0455664455556" },
                    { 6, "2", "Texaco", true, false, "Texaco", "", "Texaco", "2" },
                    { 7, null, null, false, false, "Q8", null, null, null },
                    { 8, "xx", "Multimerkverhuurder", true, false, "CIACfleet", "", "CIAC", "xx" },
                    { 3, null, null, false, false, "Shell", null, null, null },
                    { 10, "1", "AXA", true, false, "AXA", "", "AXA", "1" },
                    { 11, "1", "VAB", true, false, "VAB", "", "VAB", "1" },
                    { 12, "2", "Touring", true, false, "Touring", "", "Touring", "2" },
                    { 13, "123-123456789-12", "Brocom", false, false, "Brocom", "tijdelijk niet acief gezet", "Brocom", "BE 123233134234" },
                    { 14, "BE30 4377 5013 7111", "KBC", true, false, "KBC Autolease", "", "KBC", "BE 0422.562.385" },
                    { 15, "BE42 4829 0171 1154", "Daimler Fleet Management", true, false, "Mercedes-Benz FS Belux NV", "", "MBFS", "BE0405816821" },
                    { 16, null, null, false, false, "GMAN Antwerpen", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "CostAllocation",
                columns: new[] { "Id", "Abbreviation", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 4, "HQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Bxl", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "VL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Lim", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "IsActive", "Name", "Nationality", "POD" },
                values: new object[,]
                {
                    { 1, "BE", true, "België", "Belg", false },
                    { 2, "NL", true, "Nederland", "Nederlandse", true },
                    { 3, "DE", true, "Duitsland", "Duitse", false },
                    { 4, "FR", true, "Frankrijk", "Franse", false },
                    { 5, "ES", false, "Spanje", "Spaanse", false }
                });

            migrationBuilder.InsertData(
                table: "DoorTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "Coupé" },
                    { 9, "Cabrio" },
                    { 8, "Moto" },
                    { 6, "2-Deurs" },
                    { 2, "5-Deurs" },
                    { 4, "3-Deurs" },
                    { 3, "4-Deurs" },
                    { 5, "Monovolume" },
                    { 1, "Break" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 9, "MULTI", "Multifuel" },
                    { 8, "DSL INT", "Diesel International" },
                    { 7, "B20", "Biodiesel" },
                    { 6, "E85", "Ethanol" },
                    { 10, "DSL", "Diesel" },
                    { 4, "LNG", "Liquefied Natural Gas" },
                    { 3, "CNG", "Compressed Natural Gas" },
                    { 2, "LPG", "Liquefied Petroleum Gas" },
                    { 1, "DSL", "Diesel" },
                    { 5, "M85", "Methanol" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "BirthDate", "DriversLicenseNumber", "DriversLicenseType", "EndDateDriversLicense", "Firstname", "Gender", "Language", "Lastname", "Picture", "StartDateDriversLicense", "Title" },
                values: new object[,]
                {
                    { 81, new DateTime(2019, 10, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "azert", "AB", new DateTime(2019, 10, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "lord", "M", 1, "dark", new byte[] { 0 }, new DateTime(2019, 10, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 82, new DateTime(2019, 10, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "23", null, null, "Joeri", "M", 2, "Jans", new byte[] { 0 }, null, "mr" },
                    { 83, new DateTime(2019, 10, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "3545632", "AB", new DateTime(2019, 11, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "beast", "M", 1, "60000", new byte[] { 0 }, new DateTime(2019, 11, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 84, new DateTime(2019, 11, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "4521", "ABC", new DateTime(2019, 11, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), "az", "M", 3, "man", new byte[] { 0 }, new DateTime(2019, 11, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), "sir" },
                    { 85, new DateTime(2019, 11, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "2145", "ABC", new DateTime(2019, 11, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "beast", "M", 2, "6000", new byte[] { 0 }, new DateTime(2019, 10, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 88, new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "4554", "ABC", new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "beast", "M", 1, "60000", new byte[] { 0 }, new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 87, new DateTime(2019, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "241562", "ABC", new DateTime(2019, 11, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), "azerty", "M", 1, "qwerty", new byte[] { 0 }, new DateTime(2019, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "hello" },
                    { 91, new DateTime(2019, 11, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "21521", "ABC", new DateTime(2019, 11, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "beast", "M", 3, "7000", new byte[] { 0 }, new DateTime(2019, 11, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 89, new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "12456", "ABCD", new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "beast", "M", 1, "7895", new byte[] { 0 }, new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 90, new DateTime(2019, 11, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "21452", "ABC", new DateTime(2019, 11, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "beast", "M", 1, "6000", new byte[] { 0 }, new DateTime(2019, 11, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 80, new DateTime(1987, 9, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "45456456456", "B", new DateTime(2034, 7, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "Joeri", "M", 2, "Jans", new byte[] { 0 }, new DateTime(1998, 2, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "Mr." },
                    { 86, new DateTime(2019, 10, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "2562", "ABC", new DateTime(2019, 11, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "james", "M", 2, "john", new byte[] { 0 }, new DateTime(2019, 11, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 79, new DateTime(2019, 10, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "254854152", "ABC", new DateTime(2019, 9, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 1, "azerty", new byte[] { 0 }, new DateTime(2019, 10, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 73, new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "a", new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "a", 2, "string", new byte[] { 0 }, new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "string" },
                    { 77, null, null, "AZERT", null, "bla", "M", 2, "bla", new byte[] { 0 }, null, "bla" },
                    { 76, new DateTime(2019, 10, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "32585", "ABc", new DateTime(2019, 10, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "super", "M", 1, "man", new byte[] { 0 }, new DateTime(2019, 10, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 75, new DateTime(2019, 10, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "144445584", "Az", new DateTime(2019, 10, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "seinfield", "M", 2, "larry", new byte[] { 0 }, new DateTime(2019, 10, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "mister" },
                    { 74, new DateTime(1994, 12, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "1452145214", "SIHFi", new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "super", "M", 2, "man", new byte[] { 0 }, new DateTime(2019, 10, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 92, new DateTime(2019, 11, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "5545", "ABC", new DateTime(2019, 11, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "hero", "M", 3, "man", new byte[] { 0 }, new DateTime(2019, 11, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 72, new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "a", "a", new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "a", 2, "string", new byte[] { 0 }, new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "string" },
                    { 71, new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "a", new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "a", 2, "string", new byte[] { 0 }, new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "string" },
                    { 70, new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "string", "a", 2, "string", new byte[] { 0 }, null, "string" },
                    { 69, new DateTime(2019, 10, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "aazear", "a", new DateTime(2019, 10, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "super", "F", 1, "woman", new byte[] { 0 }, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "mss" },
                    { 68, new DateTime(2019, 10, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "azerty", "a", new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "super", "M", 2, "man", new byte[] { 0 }, new DateTime(2019, 10, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 67, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "azerty", "b", new DateTime(2019, 9, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 1, "lumani", new byte[] { 0 }, new DateTime(2019, 9, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 66, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "b", new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 2, "lumani", new byte[] { 0 }, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "string" },
                    { 65, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "b", new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 2, "lumani", new byte[] { 0 }, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "string" },
                    { 78, new DateTime(2019, 10, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "214521", "AZV", new DateTime(2019, 10, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "azerty", "F", 2, "azerty", new byte[] { 0 }, new DateTime(2019, 10, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 93, new DateTime(2019, 11, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "524152", "ABC", new DateTime(2019, 11, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "super", "M", 4, "man", new byte[] { 0 }, new DateTime(2019, 11, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 100, new DateTime(2020, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345", "ABC", new DateTime(2020, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 1, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 95, new DateTime(2019, 11, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), "2521", "A", new DateTime(2019, 11, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "azerty", null, 1, "azerty", new byte[] { 0 }, new DateTime(2019, 11, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 64, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "b", new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 2, "lumani", new byte[] { 0 }, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 123, new DateTime(2020, 3, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "e", "b", null, "J", "F", 2, "C", new byte[] { 0 }, new DateTime(2020, 3, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 122, new DateTime(1997, 2, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), "123456789", "B", null, "Jelle", "M", 2, "Cox", new byte[] { 0 }, new DateTime(2015, 9, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Doctor" },
                    { 121, new DateTime(2020, 2, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "driver", "M", 3, "test", new byte[] { 0 }, new DateTime(2020, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 120, new DateTime(2020, 2, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "driver", "F", 2, "test1", new byte[] { 0 }, null, "mr" },
                    { 119, new DateTime(1985, 5, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "ja", "B52", new DateTime(2025, 5, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "Stijn", "M", 2, "Lenaerts", new byte[] { 0 }, new DateTime(2000, 5, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "Dhr" },
                    { 118, new DateTime(1993, 6, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Stijn", "M", 2, "Lenaerts", new byte[] { 0 }, new DateTime(2006, 11, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "dhr" },
                    { 117, new DateTime(2019, 12, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "456456456", "B", new DateTime(2019, 12, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "joeri", "F", 1, "jans17", new byte[] { 0 }, new DateTime(2019, 12, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 116, new DateTime(1995, 7, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "7897897-78", "B", new DateTime(2020, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "larry", "M", 2, "jame", new byte[] { 0 }, new DateTime(2020, 1, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 115, new DateTime(2020, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "789", "789", new DateTime(2020, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 1, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 114, new DateTime(2020, 1, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2020, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", null, 1, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 113, new DateTime(2020, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2020, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 1, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 112, new DateTime(2020, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "789", "78789", new DateTime(2020, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 1, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 94, new DateTime(2019, 11, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "2145", "ABC", new DateTime(2019, 11, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "super", "M", 3, "man", new byte[] { 0 }, new DateTime(2019, 11, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 111, new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "789456", "AB", new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 2, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 109, new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "7894685", "AB", new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 1, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 108, new DateTime(2020, 1, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "0azerty", "ABC", new DateTime(2020, 1, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "0azerty0azerty", "M", 1, "0azerty", new byte[] { 0 }, new DateTime(2020, 1, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 107, new DateTime(2020, 1, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "0azerty", "ABC", new DateTime(2020, 1, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "0azerty", "M", 1, "0azerty", new byte[] { 0 }, new DateTime(2020, 1, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 106, new DateTime(1995, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "789541", "ABC", new DateTime(2020, 4, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 1, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 105, new DateTime(2020, 1, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "152312313212", "AB", new DateTime(2020, 1, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvinxxxxxxxxxx", "M", 1, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 104, new DateTime(2020, 1, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "223", "AB", new DateTime(2020, 1, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 1, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 103, new DateTime(1995, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "123", "AB", new DateTime(2020, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 1, "lumani411", new byte[] { 0 }, new DateTime(2020, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 102, new DateTime(2020, 1, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "124", "AB", new DateTime(2020, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "F", 1, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 101, new DateTime(2020, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "123456", "ABC", null, "elvin", "M", 1, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 99, new DateTime(2020, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "456", "AB", new DateTime(2020, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 1, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 98, new DateTime(2020, 1, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "457865", "ABC", new DateTime(2020, 1, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "super", "F", 1, "woman", new byte[] { 0 }, new DateTime(2020, 1, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "ms" },
                    { 97, null, "456", "A", new DateTime(2020, 3, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "azzeeer", "M", 1, "azerty", new byte[] { 0 }, new DateTime(2019, 11, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 96, new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "123", "AB", new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "beast", "M", 1, "7000", new byte[] { 0 }, new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 110, new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "789", "ABC", new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 2, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 63, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "b", new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "", 2, "lumani", new byte[] { 0 }, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 15, new DateTime(1975, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Yannick", "M", 2, "Hammelinx", null, new DateTime(1994, 3, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 61, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "", null, "elvin", "", 2, "lumani", new byte[] { 0 }, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 28, new DateTime(1987, 4, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Jorn", "M", 2, "Hens", null, new DateTime(2000, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 27, new DateTime(1985, 4, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Mario", "M", 2, "Van Genth", null, new DateTime(1987, 12, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 26, new DateTime(1978, 6, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "", null, "Arnaud", "M", 2, "Verstrepen", new byte[] { 0 }, null, "Meneer" },
                    { 25, null, "12345678-25", "", null, "Bart", "M", 1, "Billemoons", new byte[] { 0 }, null, "" },
                    { 24, new DateTime(1985, 1, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Pieter", "M", 2, "Van Vlaanderen", null, new DateTime(2004, 11, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 23, new DateTime(1984, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Tom", "M", 2, "Van der Meersch", new byte[] { 0 }, new DateTime(2008, 7, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 22, new DateTime(1980, 10, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Korneel", "M", 2, "Vandijck", null, new DateTime(1999, 6, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 21, new DateTime(1985, 5, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Gien", "V", 2, "Verschoten", new byte[] { 0 }, new DateTime(2004, 4, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 20, new DateTime(1978, 10, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Michaël", "M", 2, "Borremans", null, new DateTime(1996, 10, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), "de heer" },
                    { 19, new DateTime(1974, 11, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Benoit", "M", 2, "Geeraerts", new byte[] { 0 }, new DateTime(1993, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 18, new DateTime(1976, 5, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Steve", "M", 2, "Baeyens", new byte[] { 0 }, new DateTime(1997, 1, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 17, new DateTime(1987, 9, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Joeri", "M", 2, "Jansens", null, new DateTime(2006, 9, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 16, new DateTime(1985, 4, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", new DateTime(2019, 10, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "Marc", "M", 2, "Agten", new byte[] { 0 }, new DateTime(1977, 8, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "Mr" },
                    { 29, new DateTime(1989, 5, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Sep", "M", 2, "Feyaerts", new byte[] { 0 }, new DateTime(2007, 7, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 124, new DateTime(2016, 6, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "123456789", "B", new DateTime(2025, 6, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "abc", "M", 2, "def", new byte[] { 0 }, new DateTime(2017, 2, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), "Test" },
                    { 13, new DateTime(1982, 9, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Bart", "M", 1, "Boeckmans", new byte[] { 0 }, new DateTime(1999, 12, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "Mr." },
                    { 12, new DateTime(1982, 2, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Joris", "M", 2, "Hultermans", null, new DateTime(2001, 1, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "Dhr" },
                    { 11, new DateTime(1977, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Steven", "M", 2, "Van Lierde", new byte[] { 0 }, new DateTime(2009, 3, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "Dhr" },
                    { 10, new DateTime(1979, 10, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "BCD", null, "Gert", "M", 2, "Corten", null, new DateTime(1998, 9, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "Dhr" },
                    { 9, new DateTime(1987, 7, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Daan", "M", 2, "Seymens", new byte[] { 0 }, new DateTime(2007, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Dhr." },
                    { 8, new DateTime(1989, 5, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "", null, "Peter", "M", 2, "Roefs", null, null, "" },
                    { 7, new DateTime(1982, 9, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "", null, "Mark", "M", 2, "Poels", null, null, "" },
                    { 6, new DateTime(1962, 4, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Johan", "M", 2, "Petermans", null, new DateTime(1983, 2, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "Dhr." },
                    { 5, new DateTime(1985, 5, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", new DateTime(2009, 4, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "Joris", "M", 2, "Lambaerts", null, new DateTime(2004, 4, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), "Dhr." },
                    { 4, new DateTime(1977, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Frederik", "M", 2, "Vanwijck", new byte[] { 0 }, new DateTime(1996, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "Dhr." },
                    { 3, new DateTime(1979, 2, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Luk", "M", 2, "Vandenweghe", null, new DateTime(1999, 10, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "Mr." },
                    { 2, new DateTime(1982, 1, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Tim", "M", 2, "Van Lierde", new byte[] { 0 }, new DateTime(2007, 11, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), "Dhr." },
                    { 1, new DateTime(1985, 1, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Kevin", "M", 2, "Borremans", new byte[] { 0 }, new DateTime(2005, 2, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "Mr" },
                    { 14, new DateTime(1984, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Kristof", "M", 2, "Van den berk", null, new DateTime(2003, 4, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 62, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "", new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "", 2, "lumani", new byte[] { 0 }, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 30, new DateTime(1973, 12, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Marc", "M", 2, "Hens", new byte[] { 0 }, new DateTime(1998, 2, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 32, new DateTime(1990, 5, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Kevin", "M", 2, "Cloostermans", new byte[] { 0 }, new DateTime(2010, 5, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 60, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "", null, "elvin", "", 2, "lumani", new byte[] { 0 }, null, "" },
                    { 59, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "", "", null, "elvin", "", 2, "lumani", new byte[] { 0 }, null, "" },
                    { 58, null, "", "", null, "elvin", "", 2, "lumani", new byte[] { 0 }, null, "" },
                    { 57, null, "", "", null, "elvin", "", 2, "lumani", new byte[] { 0 }, null, "" },
                    { 56, null, "", "", null, "elvin", "", 2, "lumani", new byte[] { 0 }, null, "" },
                    { 55, null, "", "", null, "elvin", "", 2, "lumani", new byte[] { 0 }, null, "" },
                    { 54, null, null, null, null, "string", null, 2, "string", null, null, null },
                    { 53, null, null, null, null, "string", null, 2, "string", null, null, null },
                    { 52, null, null, null, null, "string", null, 2, "string", null, null, null },
                    { 51, null, null, null, null, "string", null, 2, "string", null, null, null },
                    { 50, new DateTime(2019, 9, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2019, 9, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", null, 2, "string", null, new DateTime(2019, 9, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49, new DateTime(1995, 8, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Stijn", "M", 2, "Claeys", null, new DateTime(2017, 9, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Mr" },
                    { 48, new DateTime(1993, 5, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "", "B", null, "Stijn", "M", 2, "Ceunen", null, new DateTime(2017, 8, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 31, new DateTime(1985, 11, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Bert", "M", 2, "Lernout", new byte[] { 0 }, new DateTime(2009, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 47, new DateTime(1993, 5, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "", "B", null, "Stijn", "M", 2, "Ceunen", null, new DateTime(2017, 9, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 45, new DateTime(1984, 8, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "", "", null, "Frederik", "M", 2, "Hermans", null, null, "" },
                    { 44, new DateTime(1991, 12, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "hgjj", "B", null, "Be", "M", 2, "Ve", null, new DateTime(2017, 2, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), "Dhr" },
                    { 43, new DateTime(1970, 10, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Steven", "M", 2, "Claas", null, new DateTime(1988, 11, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 42, new DateTime(1990, 6, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "", null, "Wouter", "M", 2, "Van Zeeland", null, null, "" },
                    { 41, new DateTime(1985, 7, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "C", null, "Tjorven", "M", 2, "Broers", new byte[] { 0 }, null, "" },
                    { 40, new DateTime(1978, 1, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Gunther", "M", 2, "Schuiten", null, new DateTime(1996, 7, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), "Dhr" },
                    { 39, new DateTime(1989, 11, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", new DateTime(2025, 9, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "Yannick", "M", 2, "Jespers", null, new DateTime(2015, 9, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "Dhr" },
                    { 38, new DateTime(1998, 11, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Maria", "V", 2, "Geldermans", null, new DateTime(2011, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 37, new DateTime(1986, 11, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "", null, "Marco", "M", 2, "Jans", null, null, "" },
                    { 36, new DateTime(1989, 5, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Cobe", "M", 3, "Laplage", null, null, "" },
                    { 35, new DateTime(1989, 11, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Yoeri", "M", 2, "Depraeter", null, new DateTime(2007, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "Dhr" },
                    { 34, new DateTime(1987, 4, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Kevin", "M", 2, "Cleymans", new byte[] { 0 }, new DateTime(2011, 6, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 33, new DateTime(1989, 9, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Geoffrey", "M", 2, "Lagagne", new byte[] { 0 }, new DateTime(2012, 5, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 46, new DateTime(1999, 9, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "123/123456", "", null, "Kevin", "M", 2, "Rousseeuw", null, null, "" },
                    { 125, new DateTime(1999, 4, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "123465", "B", new DateTime(2021, 6, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "Jamie", "M", 2, "Luyten", new byte[] { 0 }, new DateTime(2020, 10, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), "Test" }
                });

            migrationBuilder.InsertData(
                table: "Corporations",
                columns: new[] { "Id", "Abbreviation", "CompanyId", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 3, "Antwerpen", 29, null, "eMenKa NV", new DateTime(2010, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Keulen", 31, null, "eMenKa GmbH", new DateTime(2010, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "Holland", 32, null, "eMenKa BV", new DateTime(2010, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "EndDate", "FuelCardId", "PersonId", "StartDate" },
                values: new object[,]
                {
                    { 54, null, null, 124, new DateTime(2020, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2008, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, null, null, 24, new DateTime(2011, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2015, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2011, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2012, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2011, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2014, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2011, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, null, null, 20, new DateTime(2011, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2012, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2011, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, null, null, 18, new DateTime(2008, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, null, null, 17, new DateTime(2009, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, null, null, 16, new DateTime(2007, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, null, 15, new DateTime(2007, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, null, 13, new DateTime(2009, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2008, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2007, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2010, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new DateTime(2008, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2011, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new DateTime(2009, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2011, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2009, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2009, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2010, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2008, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, null, 3, new DateTime(2007, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, null, null, 2, new DateTime(2007, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2015, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2008, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, null, null, 123, new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2008, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2007, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, null, null, 27, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2010, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2007, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2014, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2012, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, null, null, 122, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, null, null, 28, new DateTime(2012, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, null, null, 119, new DateTime(2020, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, null, null, 116, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, null, null, 97, new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, null, null, 94, new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, null, null, 92, new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, null, null, 86, new DateTime(2019, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, null, null, 84, new DateTime(2019, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, null, null, 80, new DateTime(2019, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, null, null, 49, new DateTime(2017, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, null, null, 46, new DateTime(2017, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, null, null, 43, new DateTime(2007, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, null, null, 93, new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, null, null, 41, new DateTime(2007, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2014, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2012, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, null, null, 42, new DateTime(2015, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2015, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, new DateTime(2012, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2013, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, new DateTime(2012, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, null, null, 35, new DateTime(2013, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2015, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, new DateTime(2013, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, null, null, 37, new DateTime(2014, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, null, null, 38, new DateTime(2014, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, null, null, 39, new DateTime(2015, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, null, null, 40, new DateTime(2015, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, null, null, 36, new DateTime(2014, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2014, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2012, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EngineTypes",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 39, 9, "200 CDI" },
                    { 78, 9, "B 200 CDI" },
                    { 40, 9, "220 CDI" },
                    { 41, 9, "180 CDI" },
                    { 76, 8, "PowerPlus" },
                    { 43, 9, "160 CDI" },
                    { 77, 9, "B 180 CDI" },
                    { 84, 9, "E 200 CDI" },
                    { 81, 9, "C 180 CDI" },
                    { 82, 9, "C 200" },
                    { 83, 9, "E 350 CDI" },
                    { 85, 9, "GLK 220 CDI 4matic" },
                    { 86, 9, "ML 300 CDI" },
                    { 56, 8, "3.0 TDI" },
                    { 87, 9, "ML 300 CDI Blue Efficiency" },
                    { 79, 9, "C 200 CDI" },
                    { 55, 8, "2.8 V6 Multitronic" },
                    { 9, 7, "1.6 HDi" },
                    { 53, 8, "2.7 TDI" },
                    { 88, 9, "350 CDI Bluetec" },
                    { 27, 6, "1.5" },
                    { 38, 6, "16D" },
                    { 95, 6, "2.0 dCi" },
                    { 96, 6, "1.5 dCi" },
                    { 97, 6, "1.9 dCi FAP" },
                    { 32, 7, "2" },
                    { 54, 8, "2.0 TDi Multitronic" },
                    { 94, 7, "2.0 HDi" },
                    { 10, 8, "1.9 Tdi" },
                    { 33, 8, "2.0 Tdi" },
                    { 48, 8, "1.6 TDI" },
                    { 49, 8, "1.6 Tiptronic" },
                    { 50, 8, "2.0 TDi DPF" },
                    { 51, 8, "2.0 TDI e" },
                    { 52, 8, "1.8 T" },
                    { 115, 7, "1.4 HDi" },
                    { 89, 9, "S 320 CDI" },
                    { 47, 17, "2,0 JTDM 163PK" },
                    { 17, 11, "1.6 D" },
                    { 31, 15, "2.0 CRDi" },
                    { 73, 16, "1.5 dCi" },
                    { 90, 16, "1.5dCi" },
                    { 45, 17, "1.9 JTDm" },
                    { 46, 17, "1.9 JTD" },
                    { 14, 6, "1,6" },
                    { 114, 17, "2.4 JTDm" },
                    { 30, 15, "1.6 GDi" },
                    { 74, 18, "300cc" },
                    { 98, 20, "1.9 TiD" },
                    { 99, 21, "1.6 TD" },
                    { 100, 21, "2.0 TD" },
                    { 116, 26, "whosh" },
                    { 118, 27, "azerty" },
                    { 119, 28, "blob" },
                    { 120, 28, "blasterx" },
                    { 75, 19, "Hybrid 2.0" },
                    { 101, 10, "0.8 CDI" },
                    { 29, 15, "1.7 CRDi" },
                    { 26, 15, "1,5" },
                    { 18, 11, "2.0 D" },
                    { 19, 11, "2.4 D" },
                    { 112, 11, "2.4 D5 GEARTRONIC" },
                    { 21, 12, "1.6 HDi 92" },
                    { 22, 12, "1.6 HDi 110" },
                    { 23, 12, "2.0 HDi 138" },
                    { 34, 12, "2.2 ESS" },
                    { 28, 15, "1.4 Crdi" },
                    { 61, 12, "2.0 HDi" },
                    { 63, 12, "2.2 HDI" },
                    { 64, 12, "2.2 HDI 74" },
                    { 42, 13, "1500" },
                    { 44, 13, "1600" },
                    { 102, 14, "2.0 D" },
                    { 103, 14, "1.8" },
                    { 104, 14, "1.4 D4D" },
                    { 62, 12, "2.0 HDi 136" },
                    { 25, 5, "3456" },
                    { 80, 9, "C 220 CDI" },
                    { 1, 1, "1.9" },
                    { 24, 3, "1.6" },
                    { 105, 3, "1.6 TDi" },
                    { 106, 3, "2.0 TDi" },
                    { 107, 3, "1.9 TDI BlueMotion" },
                    { 108, 3, "1.6 CR TDI" },
                    { 109, 3, "2.0 CR Tdi bluemotion" },
                    { 110, 3, "2.0 CR TDi" },
                    { 111, 3, "2.0 TDI BlueMotion" },
                    { 113, 4, "1.6 CDTi ecoFLEX" },
                    { 93, 4, "1.7 CDTi ecoFLEX" },
                    { 92, 4, "1.7 CDTI DPF" },
                    { 91, 4, "2.0 CDTI" },
                    { 4, 4, "1.8 ECOTEC" },
                    { 5, 4, "1.9 CDTI" },
                    { 6, 4, "1.6 CNG" },
                    { 7, 4, "1.6 CNG ECOTEC" },
                    { 8, 4, "1.7 CDTI" },
                    { 15, 4, "1.3 CDTi 16v" },
                    { 16, 4, "3.0 CDTI" },
                    { 20, 4, "2.0 DPF CDTi" },
                    { 35, 4, "1.7 CDTI ECOTEC" },
                    { 3, 3, "1.9 TDI" },
                    { 36, 4, "2.0 CDTI ecoflex S/S DPF" },
                    { 37, 4, "1.7 CDTI ecoflex S/S DPF" },
                    { 60, 1, "25d" },
                    { 68, 2, "2.0 TDCi Turbo" },
                    { 67, 2, "1.6 TDCI ECOnetic" },
                    { 117, 2, "blablu" },
                    { 66, 2, "1.6 TDCi Turbo" },
                    { 71, 2, "1.8 TDCi Turbo" },
                    { 72, 2, "2.0 Monovol 6v" },
                    { 70, 2, "1.8 TDCi" },
                    { 69, 2, "2.2 TDCi Turbo" },
                    { 58, 1, "1,6" },
                    { 65, 2, "2.0 TDCi AUT" },
                    { 57, 1, "16d" },
                    { 13, 1, "20d" },
                    { 12, 1, "35d" },
                    { 11, 1, "30d" },
                    { 2, 1, "2" },
                    { 59, 1, "18d" }
                });

            migrationBuilder.InsertData(
                table: "ExteriorColors",
                columns: new[] { "Id", "BrandId", "Code", "Name" },
                values: new object[,]
                {
                    { 15, 15, null, "Grijs" },
                    { 6, 4, "MT", "Metro" },
                    { 19, 4, null, "Carbon Flash Black" },
                    { 24, 4, "GJW", "Deep Sky Blue" },
                    { 23, 4, null, "Waterworld Blue" },
                    { 22, 4, null, "Asteroid Grey" },
                    { 11, 12, "GRRR", "Groen" },
                    { 21, 7, null, "Grijs" },
                    { 29, 17, "ext", "Test" },
                    { 20, 16, null, "Zwart" },
                    { 10, 12, null, "Knalgeel" },
                    { 28, 27, "azerty", "azerty" },
                    { 13, 4, null, "Silver Lightning" },
                    { 14, 5, "Fred", "Red" },
                    { 1, 1, "", "Saphirschwarz" },
                    { 25, 11, "492", "Savile Grey" },
                    { 27, 8, null, "Zwart" },
                    { 30, 4, "red", "red" },
                    { 26, 4, "", "Deep Espresso Brown" },
                    { 9, 6, "Y", "Yellow" },
                    { 18, 4, "GU9", "Luxor" },
                    { 17, 8, null, "Lavagrijs" },
                    { 2, 1, null, "Titansilber" },
                    { 16, 1, "SG", "Spacegrau" },
                    { 3, 4, "GR", "Technical Grey" },
                    { 4, 4, "BLs", "Black Sapphires" },
                    { 5, 4, "WH", "Olympic White" },
                    { 7, 4, "UB", "Ultra Blue" },
                    { 12, 4, null, "Star Silver" },
                    { 8, 8, "GR", "Grijs" }
                });

            migrationBuilder.InsertData(
                table: "FuelCards",
                columns: new[] { "Id", "BlockingDate", "BlockingReason", "CompanyId", "DriverId", "EndDate", "IsBlocked", "Number", "PinCode", "RecordId", "StartDate", "VehicleId" },
                values: new object[,]
                {
                    { 39, null, null, 19, null, new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "123456789", "8896", null, new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "vervanging", 4, null, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0001 LUVA", "7846", null, new DateTime(2007, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "vervanging", 23, null, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0006 SALES", "****", null, new DateTime(2007, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, new DateTime(2017, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ok", 4, null, null, true, "0011", "9714", null, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, null, "", 4, null, null, false, "0139", "9183", null, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, null, "", 4, null, null, false, "0014", "6325", null, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, null, "", 4, null, null, false, "0019", "3030", null, new DateTime(2012, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, null, "", 4, null, null, false, "0020", "3315", null, new DateTime(2012, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, null, "", 4, null, null, false, "0100", "7491", null, new DateTime(2013, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, null, null, 4, null, null, false, "0021", "9363", null, new DateTime(2013, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, null, null, 4, null, null, false, "0017", "1312", null, new DateTime(2012, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, null, "", 4, null, null, false, "0129", "2765", null, new DateTime(2012, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, null, "", 4, null, null, false, "0016", "535", null, new DateTime(2011, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, null, null, 4, null, null, false, "0023", "****", null, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, null, "", 4, null, null, false, "1234", "1234", null, new DateTime(2014, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 6, null, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0005 AANLOOP 4", "****", null, new DateTime(2007, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vervangen door nieuwe tankkaart", 15, null, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0001", "123456", null, new DateTime(2017, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 1, new DateTime(2009, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "kaart niet meer geldig", 16, null, new DateTime(2008, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "188395479", "1011", null, new DateTime(2008, 11, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, null, null, 19, null, null, false, "008", "88", null, new DateTime(2020, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, null, null, 19, null, null, false, "Test Nummer", "1234", null, new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, null, "", 4, null, null, false, "0010", "7861", null, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, null, "", 4, null, null, false, "0007", "6491", null, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, null, "", 4, null, null, false, "0008", "401", null, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, new DateTime(2017, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", 4, null, null, true, "0005", "321", null, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "vervanging", 4, null, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0008 Tankkaartje 555", "****888", null, new DateTime(2007, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, new DateTime(2010, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "vervanging", 4, null, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0004 AANLOOP 3", "7293", null, new DateTime(2007, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, null, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0010 AANLOOP 88", "****", null, new DateTime(2008, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, null, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "0009 AANLOOP 7", "14589", null, new DateTime(2009, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "vervanging", 4, null, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0002 AANLOOP 1", "2937", null, new DateTime(2007, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "vervanging", 4, null, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0003 AANLOOP 2", "3177", null, new DateTime(2007, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, null, null, 24, null, null, false, "Test", "12345678", null, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "vervanging", 4, null, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0007 AANLOOP 5", "****", null, new DateTime(2007, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "vervanging", 4, null, new DateTime(2010, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0011 AANLOOP 9", "****", null, new DateTime(2008, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, null, "", 4, null, null, false, "0006", "4606", null, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, new DateTime(2009, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "verloren", 4, null, new DateTime(2011, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0012 AANLOOP 10", "604", null, new DateTime(2008, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, null, "", 4, null, null, false, "0002", "2938", null, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, null, "", 4, null, new DateTime(2018, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "0003", "3177", null, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, null, "", 4, null, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "0004", "7293", null, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, null, "", 4, null, null, false, "0009", "7008", null, new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "InteriorColors",
                columns: new[] { "Id", "BrandId", "Code", "Name" },
                values: new object[,]
                {
                    { 11, 4, null, "Leder Sienna Anthraciet black" },
                    { 7, 12, null, "Zwart leder" },
                    { 2, 1, null, "Leder Dakota Schwarz" },
                    { 25, 16, null, "Zwart" },
                    { 8, 1, null, "Fluid Anthracit" },
                    { 23, 11, "G761", "Select Leder" },
                    { 26, 27, "azerty", "azerty" },
                    { 28, 28, "ssss", "cccc" },
                    { 12, 4, "GR4", "groen" },
                    { 10, 4, null, "Cashmere beige/anthraciet" },
                    { 3, 4, "CC", "Charcoal" },
                    { 4, 4, "CA", "Cable Anthraciet" },
                    { 6, 4, "DB", "Dune Black" },
                    { 9, 4, null, "Anthraciet (Tabita/Elba)" },
                    { 14, 8, null, "Steppe Zwart Leder" },
                    { 13, 7, null, "Leder Beige" },
                    { 5, 7, "KR", "Knalrood" },
                    { 27, 8, "AO23", "pikzwart" },
                    { 24, 4, null, "Leder Jasmin Saddle Up" },
                    { 21, 4, null, "Lyra/Jet Black" },
                    { 20, 4, null, "Salta Jet black" },
                    { 19, 4, null, "Stof/leder morrocana" },
                    { 18, 4, null, "Mando/Atlantis cocoa" },
                    { 17, 4, null, "Ribbon/Morrocana" },
                    { 16, 4, "TAAS", "Dune Beige" },
                    { 15, 4, null, "Lace/jet Black" },
                    { 22, 4, null, "Ribbon/Jet Black" },
                    { 1, 6, "b", "Black" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 103, 20, "9 - mei" },
                    { 132, 23, "TEst" },
                    { 106, 22, "Fortwo" },
                    { 105, 21, "Superb" },
                    { 104, 21, "Octavia Combi" },
                    { 134, 26, "lightning" },
                    { 124, 7, "208" },
                    { 135, 27, "azerty" },
                    { 23, 7, "407" },
                    { 102, 20, "9 - mrt" },
                    { 79, 2, "Transit Connect" },
                    { 22, 7, "307" },
                    { 136, 28, "qsdf" },
                    { 137, 28, "baz" },
                    { 18, 7, "207" },
                    { 51, 7, "508" },
                    { 82, 19, "IS" },
                    { 128, 17, "Brera" },
                    { 130, 18, "ttttt" },
                    { 108, 14, "Yaris" },
                    { 10, 3, "Passat" },
                    { 9, 3, "Bora" },
                    { 8, 3, "Golf" },
                    { 41, 15, "Getz" },
                    { 43, 15, "i20" },
                    { 44, 15, "ix35" },
                    { 45, 15, "i10" },
                    { 46, 15, "i30" },
                    { 47, 15, "ix20" },
                    { 48, 15, "H1" },
                    { 49, 15, "i40" },
                    { 50, 15, "ix55" },
                    { 53, 16, "Note" },
                    { 87, 16, "Qashqai" },
                    { 93, 7, "807" },
                    { 92, 7, "5008" },
                    { 91, 7, "308" },
                    { 61, 17, "159" },
                    { 62, 17, "Giulietta" },
                    { 131, 6, "Talisman" },
                    { 54, 7, "3008" },
                    { 80, 18, "Moto" },
                    { 81, 19, "CT" },
                    { 101, 6, "Scénic II Phase II" },
                    { 21, 6, "Laguna" },
                    { 99, 6, "Meganescenic" },
                    { 133, 1, "X6" },
                    { 71, 1, "X1" },
                    { 70, 1, "530d" },
                    { 69, 1, "525d" },
                    { 68, 1, "320d" },
                    { 67, 1, "316d" },
                    { 66, 1, "118d" },
                    { 65, 1, "116d" },
                    { 31, 1, "118i" },
                    { 19, 1, "725D" },
                    { 5, 1, "X5" },
                    { 4, 1, "520d" },
                    { 3, 1, "320i" },
                    { 2, 1, "318d" },
                    { 1, 1, "X3" },
                    { 14, 4, "Vectra" },
                    { 13, 4, "Corsa" },
                    { 12, 4, "Zafira" },
                    { 11, 4, "Astra" },
                    { 29, 4, "Insignia" },
                    { 88, 4, "Antara" },
                    { 89, 4, "Meriva" },
                    { 90, 4, "Zafira tourer" },
                    { 98, 6, "Mégane Grandtour" },
                    { 97, 6, "Koleos" },
                    { 96, 6, "Grand Scénic" },
                    { 95, 6, "Grand Espace" },
                    { 94, 6, "Espace" },
                    { 42, 6, "Mégane" },
                    { 107, 14, "Auris" },
                    { 17, 6, "Clio" },
                    { 15, 5, "456 GT" },
                    { 100, 6, "Scénic" },
                    { 78, 2, "S - Max" },
                    { 76, 2, "Galaxy" },
                    { 75, 2, "Focus C - Max" },
                    { 74, 2, "Focus" },
                    { 73, 2, "C - Max" },
                    { 40, 2, "Fiesta" },
                    { 7, 2, "Mondeo" },
                    { 6, 2, "Escort" },
                    { 129, 4, "Adam" },
                    { 127, 4, "Mokka" },
                    { 77, 2, "Grand C - Max" },
                    { 39, 14, "Prius" },
                    { 72, 12, "Jumper" },
                    { 110, 3, "Golf Plus" },
                    { 83, 9, "B - klasse" },
                    { 84, 9, "G - klasse" },
                    { 125, 12, "DS3" },
                    { 85, 9, "M - klasse" },
                    { 86, 9, "S - klasse" },
                    { 38, 12, "C8" },
                    { 37, 12, "C6" },
                    { 36, 12, "C5" },
                    { 35, 12, "C4" },
                    { 34, 12, "C3" },
                    { 33, 12, "C2" },
                    { 32, 12, "C1" },
                    { 114, 3, "Passat CC" },
                    { 58, 9, "A - klasse" },
                    { 115, 3, "Polo" },
                    { 117, 3, "Tiguan" },
                    { 118, 3, "Touran" },
                    { 24, 11, "540" },
                    { 25, 11, "C30" },
                    { 26, 11, "V50" },
                    { 27, 11, "V70" },
                    { 28, 11, "C70" },
                    { 109, 3, "Caddy" },
                    { 119, 11, "S60" },
                    { 120, 11, "S80" },
                    { 121, 11, "V60" },
                    { 122, 11, "XC60" },
                    { 123, 11, "XC70" },
                    { 116, 3, "Sharan" },
                    { 56, 9, "E - klasse" },
                    { 126, 9, "Ecoliner" },
                    { 30, 8, "A3" },
                    { 55, 9, "C - klasse" },
                    { 111, 3, "Golf V" },
                    { 59, 13, "kevin" },
                    { 16, 8, "A4" },
                    { 64, 8, "Q7" },
                    { 113, 3, "Jetta" },
                    { 52, 8, "Q5" },
                    { 20, 8, "A5" },
                    { 60, 13, "testFiat" },
                    { 112, 3, "Golf VI" },
                    { 57, 13, "Punto" },
                    { 63, 8, "A6" }
                });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 82, 4, "Edition Sports Tourer" },
                    { 81, 4, "Cosmo Sports Tourer" },
                    { 25, 8, "Sportback" },
                    { 24, 4, "Edition" },
                    { 7, 4, "OPC" },
                    { 37, 4, "Sport" },
                    { 114, 3, "Conceptline DPF" },
                    { 128, 4, "Enjoy Active" },
                    { 129, 4, "Business" },
                    { 36, 8, "SUV" },
                    { 57, 8, "Quattro" },
                    { 30, 5, "tt" },
                    { 56, 8, "DPF" },
                    { 55, 8, "Start/Stop DPF" },
                    { 54, 8, "S line" },
                    { 53, 8, "Allroad Quattro" },
                    { 52, 8, "Sportback Attraction" },
                    { 51, 8, "Sportback Ambiente" },
                    { 50, 8, "Sport Back Ambition" },
                    { 22, 11, "Basis" },
                    { 23, 11, "Summum" },
                    { 90, 7, "ST Confort" },
                    { 109, 3, "Trend" },
                    { 19, 8, "Avant" },
                    { 111, 3, "United DPF" },
                    { 115, 3, "Highline" },
                    { 116, 3, "BMT" },
                    { 1, 1, "Touring" },
                    { 2, 1, "Berline" },
                    { 14, 1, "Coupé" },
                    { 15, 1, "Cabrio" },
                    { 16, 1, "Hatch" },
                    { 17, 1, "xDrive" },
                    { 21, 1, "test" },
                    { 58, 1, "sDrive18d" },
                    { 59, 1, "sDrive20d" },
                    { 117, 3, "Edition" },
                    { 110, 3, "United DSG DPF" },
                    { 118, 3, "Upgrade" },
                    { 120, 11, "Kinetic" },
                    { 40, 9, "Avantgarde" },
                    { 41, 9, "Classic" },
                    { 4, 4, "Enjoy" },
                    { 5, 4, "Cosmo" },
                    { 6, 4, "Essentia" },
                    { 78, 9, "Blue Efficience" },
                    { 79, 9, "Elegance" },
                    { 80, 9, "L Avantgarde" },
                    { 11, 8, "Berline" },
                    { 113, 3, "Comfortline" },
                    { 112, 3, "Comfort" },
                    { 119, 3, "Trendline" },
                    { 121, 11, "DRIVe Start/Stop" },
                    { 94, 6, "Latitude" },
                    { 123, 11, "D4 Kinetic St/St" },
                    { 10, 7, "Berline" },
                    { 9, 7, "Coupé" },
                    { 63, 12, "Picasso Bus+" },
                    { 62, 12, "Grand Picasso Business" },
                    { 38, 16, "Acenta" },
                    { 8, 7, "SW" },
                    { 48, 8, "Ambiente" },
                    { 18, 7, "Urban" },
                    { 61, 12, "Grand Picasso Bus+" },
                    { 32, 12, "Exclusive" },
                    { 29, 12, "Pluriel" },
                    { 28, 12, "Tourer" },
                    { 27, 12, "Picasso" },
                    { 44, 17, "Eco" },
                    { 45, 17, "Progression" },
                    { 46, 17, "Progression Corp. Leder" },
                    { 60, 12, "Grand Picasso" },
                    { 47, 17, "Distinctive" },
                    { 39, 7, "Acces" },
                    { 34, 15, "Base" },
                    { 103, 14, "DPF" },
                    { 104, 14, "Luna DPF" },
                    { 105, 14, "1.8 Hybrid" },
                    { 106, 14, "Linea Terra" },
                    { 43, 13, "cabrio" },
                    { 42, 13, "Break" },
                    { 85, 7, "SW Premium Break" },
                    { 35, 15, "Facility Pack" },
                    { 84, 7, "Premium Pack FAP" },
                    { 68, 12, "Van" },
                    { 67, 12, "Business" },
                    { 66, 12, "Picasso Exclusive" },
                    { 65, 12, "Picasso Business GPS" },
                    { 64, 12, "Picasso Business" },
                    { 31, 15, "Hatchback" },
                    { 33, 15, "Trocadéro" },
                    { 83, 7, "Premium Coach" },
                    { 122, 11, "DRIVe Kinetic" },
                    { 26, 12, "Coupé" },
                    { 20, 18, "rerezrtrz" },
                    { 132, 28, "blablu" },
                    { 133, 28, "ssss" },
                    { 107, 3, "Van" },
                    { 108, 3, "B2B-line" },
                    { 127, 11, "Momentum" },
                    { 97, 6, "Family FAP" },
                    { 96, 6, "FAP" },
                    { 3, 3, "Rabbit" },
                    { 95, 6, "Authentique" },
                    { 92, 6, "Alyum FAP" },
                    { 91, 6, "Latitude FAP" },
                    { 13, 6, "DCI" },
                    { 12, 6, "dd" },
                    { 126, 11, "DRIVe Start/Stop Kinetic" },
                    { 125, 11, "D3 Kinetic St/St" },
                    { 124, 11, "DRIVe" },
                    { 93, 6, "Dynamique" },
                    { 86, 7, "Executive AUT." }
                });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 69, 2, "Ghia DPF" },
                    { 89, 7, "Premium Pack" },
                    { 76, 18, "ST300" },
                    { 75, 2, "Econetic" },
                    { 77, 19, "Business" },
                    { 74, 2, "Titanium" },
                    { 98, 20, "Business" },
                    { 99, 20, "Linear Advantage" },
                    { 100, 20, "Vector" },
                    { 131, 27, "azerty" },
                    { 73, 2, "Trend DPF" },
                    { 101, 21, "Elegance" },
                    { 102, 22, "Fun" },
                    { 87, 7, "Premium" },
                    { 71, 2, "Trend" },
                    { 88, 7, "SW Executive" },
                    { 130, 26, "speedy" },
                    { 70, 2, "Titanium DPF" },
                    { 72, 2, "Ghia" },
                    { 49, 8, "Attraction" }
                });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "CorporationId", "CostAllocationId", "EndDate", "FuelCardId", "StartDate", "Term", "Usage" },
                values: new object[,]
                {
                    { 23, 1, 4, new DateTime(2017, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, new DateTime(2012, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 22, null, 4, new DateTime(2016, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, new DateTime(2012, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 },
                    { 21, null, 4, new DateTime(2016, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, new DateTime(2012, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 20, null, 4, new DateTime(2016, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, new DateTime(2012, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 },
                    { 19, null, 2, new DateTime(2017, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new DateTime(2013, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 12, null, 4, new DateTime(2018, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, new DateTime(2014, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 13, null, 3, new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, new DateTime(2014, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 15, null, 1, new DateTime(2017, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, new DateTime(2013, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 16, null, 4, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new DateTime(2013, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 17, null, 4, new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, new DateTime(2013, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 18, null, 4, new DateTime(2017, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, new DateTime(2013, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 11, null, 4, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new DateTime(2014, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 },
                    { 7, null, 2, new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new DateTime(2013, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 9, null, 4, new DateTime(2018, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2014, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 },
                    { 3, null, null, null, 5, null, 0, 1 },
                    { 10, null, 2, new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2014, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 24, null, 3, new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, new DateTime(2012, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 25, null, 2, new DateTime(2017, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, new DateTime(2012, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 5, 1, 2, null, 8, null, 0, 1 },
                    { 1, 2, 4, null, 1, null, 0, 0 },
                    { 8, null, 4, new DateTime(2015, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 1, 3 },
                    { 27, null, 4, new DateTime(2015, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, new DateTime(2012, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 26, null, 3, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, new DateTime(2012, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 14, 3, 4, new DateTime(2018, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new DateTime(2014, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 28, null, 1, null, 29, null, 2, 1 },
                    { 6, 3, 2, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 2, 3, 4, null, 4, null, 0, 1 },
                    { 4, 3, 2, null, 6, null, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "AverageFuel", "BrandId", "BuildYear", "CategoryId", "Chassis", "CountryId", "DoorTypeId", "Emission", "EndDateDelivery", "EngineCapacity", "EnginePower", "EngineTypeId", "FiscalHP", "FuelCardId", "FuelTypeId", "IsActive", "LicensePlate", "ModelId", "Power", "SeriesId", "Volume" },
                values: new object[,]
                {
                    { 25, null, 4, 2004, null, "145", 1, 2, 2532, null, 1686, 81, 8, 9, 26, 10, false, "1FDZ352", 11, null, 4, 3232 },
                    { 72, null, 1, 2001, null, "W0LPD8EW9D8062050", 1, 1, 587, null, 1800, 100, 61, 11, null, 10, false, "1RWH764", 2, null, 1, 3529 },
                    { 73, null, 1, 2002, null, "SJNFDAE11U2157331", 1, 1, 561, null, 1800, 100, 61, 11, null, 10, false, "1RXG869", 2, null, 1, 3528 },
                    { 91, null, 12, 2009, null, "MK89Y77Y67UI", 1, 2, 791, null, 2000, 100, 64, 11, null, 10, false, "1WBI951", 34, null, 27, 3655 },
                    { 159, 0, 12, 2018, null, "WBA1090K051447", 5, 2, 129, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 100, 36, 100, null, 9, false, "1CAG654", 33, null, 27, 2911 },
                    { 89, null, 12, 2007, null, "7856", 1, 2, 633, null, 1600, 80, 22, 9, null, 10, false, "1VCP955", 34, null, 61, 3657 },
                    { 88, null, 12, 2006, null, "W09EM4D2025752", 1, 2, 622, null, 2000, 110, 63, 11, null, 10, false, "1VXW951", 34, null, 60, 3658 },
                    { 71, null, 1, 2000, null, "120142", 1, 3, 590, null, 1800, 100, 61, 11, null, 10, false, "1RGJ766", 2, null, 2, 3526 },
                    { 90, null, 12, 2008, null, "5454", 1, 2, 664, null, 1560, 82, 22, 9, null, 10, false, "1VVO952", 34, null, 62, 3654 },
                    { 92, null, 12, 2000, null, "W0HM759G027219", 1, 2, 782, null, 1600, 80, 22, 9, null, 10, false, "1WNU952", 34, null, 63, 3656 },
                    { 93, null, 12, 2001, null, "nv", 1, 2, 763, null, 1560, 82, 22, 9, null, 10, false, "1WPY953", 34, null, 64, 3653 },
                    { 34, null, 12, 2003, null, "W0LPE6EW4C1078195", 1, 4, 293, null, 1233, 43, 21, 11, null, 10, false, "1HXX457", 33, null, 28, 3232 },
                    { 70, null, 1, 2009, null, null, 1, 3, 5861, null, 1800, 100, 61, 11, null, 10, false, "1RFK765", 2, null, 2, 3525 },
                    { 68, null, 1, 2007, null, null, 1, 3, 5685, null, 1800, 100, 61, 11, null, 10, false, "1PSU761", 2, null, 2, 3521 },
                    { 94, null, 12, 2002, null, "10", 1, 2, 774, null, 1560, 82, 22, 9, null, 10, false, "1WOT956", 34, null, 65, 3652 },
                    { 134, null, 11, 2016, null, "14525611", 2, 2, 974, null, 2000, 100, 18, 11, null, 10, false, "1BGF325", 26, null, 22, 2821 },
                    { 135, null, 11, 2015, null, "W0HG153913", 3, 1, 911, null, 1600, 80, 17, 9, null, 10, false, "1BHE326", 26, null, 22, 2825 },
                    { 136, null, 11, 2014, null, null, 3, 1, 982, null, 2000, 100, 18, 11, null, 10, false, "1BFZ324", 26, null, 22, 2826 },
                    { 131, null, 11, 2019, null, "1566655614", 2, 9, 917, null, 2000, 100, 18, 11, null, 10, false, "1BWY211", 28, null, 120, 2726 },
                    { 144, null, 11, 2013, null, "nbefzzf", 4, 1, 1322, null, 1600, 80, 17, 9, null, 10, false, "1BFU624", 27, null, 120, 2823 },
                    { 132, null, 11, 2018, null, "VF3LB9ES115707", 2, 3, 976, null, 1600, 80, 17, 9, null, 10, false, "1BST212", 24, null, 121, 2823 },
                    { 138, null, 11, 2012, null, "ezrra", 3, 1, 986, null, 1600, 84, 17, 9, null, 10, false, "1BQS328", 26, null, 121, 2822 },
                    { 69, null, 1, 2008, null, "W0LGM8ES4E1181678", 1, 3, 5796, null, 1800, 85, 61, 11, null, 10, false, "1PDL764", 2, null, 2, 3524 },
                    { 139, null, 11, 2016, null, null, 3, 1, 985, null, 1600, 80, 17, 9, null, 10, false, "1BAS199", 26, null, 121, 2823 },
                    { 142, null, 11, 2011, null, "nvt", 4, 1, 912, null, 1600, 80, 17, 9, null, 10, false, "1BFO446", 27, null, 122, 2824 },
                    { 143, null, 11, 2012, null, "W0LGM8LC68598", 4, 1, 131, null, 1560, 85, 17, 9, null, 10, false, "1BFI535", 27, null, 122, 2822 },
                    { 140, null, 11, 2013, null, null, 3, 1, 912, null, 1984, 120, 18, 11, null, 10, false, "1BZH268", 27, null, 123, 2826 },
                    { 137, null, 11, 2011, null, null, 3, 1, 983, null, 1600, 80, 17, 9, null, 10, false, "1BDA327", 26, null, 124, 2824 },
                    { 145, null, 11, 2014, null, "W0LM8E1137406", 4, 1, 1335, null, 2000, 100, 18, 11, null, 10, false, "1BFY713", 27, null, 127, 2816 },
                    { 155, 0, 7, 2014, null, "nf56ez1fb", 5, 6, 1236, null, 0, 0, 34, 0, null, 10, false, "1CEW499", 18, null, 39, 2915 },
                    { 156, 0, 7, 2015, null, "12056142", 5, 4, 122, null, 0, 0, 34, 0, null, 9, false, "1CEL781", 23, null, 9, 2914 },
                    { 141, null, 11, 2012, null, "W0EE9G046079", 4, 2, 911, null, 1984, 120, 18, 163, null, 10, false, "1BEG357", 27, null, 122, 2825 },
                    { 95, null, 12, 2003, null, "155154", 1, 2, 755, null, 1560, 82, 22, 9, null, 10, false, "1XIR955", 34, null, 66, 3654 },
                    { 4, null, 4, 2003, null, "7897456", 1, 2, 156, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1910, 74, 5, 10, 4, 10, false, "1AEB124", 12, null, 5, 3116 },
                    { 130, null, 11, 2010, null, "797165619", 2, 6, 929, null, 2400, 120, 114, 11, null, 10, false, "1BZU214", 28, null, 120, 2725 },
                    { 28, null, 4, 2007, null, "123456789", 1, 1, 2382, null, 1686, 81, 39, 9, 27, 10, false, "1GHG451", 11, null, 5, 3235 },
                    { 26, null, 4, 2005, null, "45414521451454125", 1, 2, 266, null, 1686, 81, 8, 9, 25, 10, false, "1FFD351", 11, null, 37, 3233 },
                    { 24, null, 4, 2003, null, null, 1, 1, 244, null, 2999, 150, 16, 11, 24, 10, false, "1FSE343", 29, null, 5, 3230 },
                    { 22, null, 4, 2001, null, "W0LPF6EG8A8044691", 1, 1, 0, null, 1296, 66, 15, 9, 23, 10, false, "1FPT345", 29, null, 5, 3236 },
                    { 27, null, 4, 2006, null, "SJNFDAE11U2159420", 1, 1, 217, null, 1956, 96, 38, 11, 28, 10, false, "1GGF450", 29, null, 24, 3231 },
                    { 23, null, 6, 2002, null, "123456", 1, 3, 233, null, null, 0, 27, 0, 22, 10, false, "1FQR344", 17, null, 13, 3234 },
                    { 21, null, 4, 2000, null, "789", 1, 1, 111, null, 1910, 88, 5, 10, 21, 10, false, "1EOS346", 14, null, 5, 3130 },
                    { 29, null, 4, 2008, null, "123458", 1, 1, 2493, null, 1686, 96, 39, 9, 29, 10, false, "1GJ?452", 11, null, 5, 3236 },
                    { 20, null, 4, 2009, null, null, 1, 2, 17, null, 1686, 81, 8, 9, 20, 10, false, "1EIX347", 12, null, 4, 3135 },
                    { 30, null, 6, 2009, null, "454745747547", 1, 4, 251, null, 1233, 120, 40, 10, 30, 10, false, "1GKN453", 17, null, 12, 3234 },
                    { 18, null, 12, 2007, null, "WBAWY31SDFDSGEGF21", 1, 3, 165, null, 1560, 66, 21, 9, 19, 10, false, "1EYB349", 34, null, 26, 3132 },
                    { 32, null, 4, 2001, null, "VF30U9HR8BS316981", 1, 3, 2732, null, 1956, 95, 20, 11, 31, 10, false, "1HMV455", 29, null, 24, 3237 },
                    { 19, null, 5, 2008, null, "NLHBB51RABZ026442", 1, 4, 184, null, 4500, 233, 25, 19, 18, 9, false, "1EUB348", 15, null, 30, 3131 },
                    { 17, null, 1, 2006, null, null, 1, 4, 156, null, 1800, 8, 1, 11, 17, 9, false, "1DTB247", 31, null, 16, 3133 },
                    { 98, null, 2, 2005, null, "W00ZC81087846", 2, 2, 738, null, 1800, 92, 73, 10, null, 10, false, "1XKA958", 7, null, 72, 2652 },
                    { 31, null, 1, 2000, null, null, 1, 2, 216, null, 1, 1, 12, 1, 32, 10, false, "1GLB454", 1, null, 16, 3239 },
                    { 14, null, 11, 2003, null, "U5YZU81UABL093503", 1, 4, 122, null, 2000, 136, 18, 11, 15, 10, false, "1DZB234", 24, null, 22, 3111 },
                    { 2, null, 1, 2001, null, "0azerty", 1, 1, 134, new DateTime(2013, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1995, 130, 13, 10, 3, 10, false, "1ACS122", 5, null, 17, 3117 },
                    { 15, null, 4, 2004, null, "W0LGT8EL1D1035314", 1, 3, 131, null, 1956, 96, 20, 11, 14, 10, false, "1DEB235", 29, null, 24, 3130 },
                    { 1, null, 4, 2005, null, "SJNFDAE11U2117751", 1, 1, 123, new DateTime(2009, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1686, 74, 8, 9, 1, 10, false, "1ABQ121", 11, null, 4, 3112 },
                    { 13, null, 1, 2002, null, "W0L0ZCF3581087846", 1, 2, 146, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1999, 90, 2, 11, 13, 10, false, "1CAB233", 2, null, 1, 3113 },
                    { 10, null, 6, 2009, null, "1515154", 1, 4, 112, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1233, 120, 14, 10, 10, 10, false, "1CKB130", 17, null, 12, 3119 },
                    { 11, null, 1, 2000, null, "W0LPD6EW6DG097221", 1, 2, 121, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1995, 120, 13, 11, 12, 10, false, "1CLB231", 1, null, 17, 3117 },
                    { 133, null, 11, 2017, null, "14565100", 2, 2, 975, null, 1600, 80, 17, 9, null, 10, false, "1BQR213", 26, null, 22, 2822 },
                    { 7, null, 1, 2006, null, "W0L0AHM759G027219", 1, 1, 189, new DateTime(2013, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2001, 165, 2, 12, 9, 10, false, "1BHB127", 4, null, 1, 3116 },
                    { 8, null, 8, 2007, null, "nvt", 1, 1, 196, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2100, 120, 10, 10, 8, 9, false, "1BIB138", 16, null, 19, 3118 },
                    { 9, null, 7, 2008, null, "100", 1, 4, 103, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1560, 123, 9, 9, 7, 10, false, "1CJB139", 18, null, 18, 3114 },
                    { 5, null, 4, 2004, null, "547854", 1, 1, 167, new DateTime(2014, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1990, 124, 5, 11, 6, 9, false, "1BFB125", 14, null, 4, 3114 },
                    { 6, null, 1, 2005, null, "MKLI89Y77Y67UI", 1, 3, 178, new DateTime(2011, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1995, 90, 1, 10, 5, 10, false, "1BGB126", 2, null, 2, 3115 },
                    { 3, null, 3, 2002, null, "W0LPE9EM4D2025752", 1, 2, 145, new DateTime(2009, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1577, 80, 24, 9, 2, 9, false, "1ADB123", 8, null, 3, 3113 },
                    { 16, null, 11, 2005, null, "W0L0AHL4898044253", 1, 2, 143, null, 3232, 168, 18, 13, 16, 9, false, "1DRB236", 27, null, 23, 3131 },
                    { 12, null, 4, 2001, null, "145", 1, 2, 130, null, 1248, 66, 15, 7, 11, 10, false, "1CMB232", 13, null, 4, 3112 },
                    { 124, null, 3, 2006, null, "W00SDL6884193058", 2, 1, 993, null, 2000, 100, 112, 11, null, 10, false, "1AGG234", 10, null, 115, 2748 },
                    { 42, null, 8, 2001, null, null, 1, 6, 382, null, 0, 150, 78, 0, null, 5, false, "1JYP573", 16, null, 11, 3346 },
                    { 97, null, 2, 2005, null, "14", 1, 1, 737, null, 2000, 84, 70, 11, null, 10, false, "1XYZ957", 7, null, 75, 2655 },
                    { 36, null, 3, 2005, null, null, 1, 2, 2255, null, null, 0, 3, 0, null, 10, false, "1HVB579", 8, null, 3, 3243 },
                    { 127, null, 3, 2011, null, null, 2, 3, 924, null, 1999, 100, 108, 11, null, 10, false, "1AAS219", 10, null, 109, 2748 },
                    { 128, null, 3, 2012, null, "W0EX7850002", 2, 3, 925, null, 1999, 100, 108, 11, null, 10, false, "1BZW216", 10, null, 109, 2727 },
                    { 129, null, 3, 2014, null, "VFROE203509", 2, 3, 928, null, 2000, 103, 108, 11, null, 10, false, "1BER215", 10, null, 109, 2724 },
                    { 117, null, 3, 2003, null, "VF09HR8BS316981", 2, 3, 936, null, 1600, 77, 110, 9, null, 10, false, "1ABT138", 10, null, 112, 2749 },
                    { 118, null, 3, 2004, null, "WBV11040VG85589", 2, 3, 955, null, 1600, 77, 110, 9, null, 10, false, "1ANY231", 10, null, 112, 2748 },
                    { 119, null, 3, 2005, null, "W0P6EW4C1078195", 2, 3, 954, null, 1600, 77, 110, 9, null, 10, false, "1AMU233", 10, null, 112, 2747 },
                    { 120, null, 3, 2006, null, "15616512", 2, 1, 935, null, 1598, 77, 110, 9, null, 10, false, "1ALI232", 10, null, 113, 2744 },
                    { 121, null, 3, 2007, null, null, 2, 1, 938, null, 1968, 100, 111, 11, null, 10, false, "1AKK231", 10, null, 113, 2745 },
                    { 122, null, 3, 2008, null, null, 2, 1, 929, null, 1598, 77, 110, 9, null, 10, false, "1AJJ236", 10, null, 114, 2746 },
                    { 125, null, 3, 2015, null, "W08EG2B8045397", 2, 1, 962, null, 2000, 81, 111, 11, null, 10, false, "1AGW217", 10, null, 115, 2746 },
                    { 126, null, 3, 2014, null, "W08ELXD1044444", 2, 1, 961, null, 2000, 103, 108, 11, null, 10, false, "1AYQ218", 10, null, 115, 2749 },
                    { 33, null, 4, 2002, null, "WBAVC11040VG85589", 1, 1, 282, null, 1910, 100, 5, 10, null, 10, false, "1HWC456", 14, null, 4, 3236 },
                    { 104, null, 4, 2006, null, "NLHB1BZ026442", 2, 2, 843, null, 1686, 59, 8, 9, null, 10, false, "1ZQW946", 11, null, 4, 2659 },
                    { 105, null, 4, 2003, null, null, 2, 2, 8632, null, 1686, 74, 8, 9, null, 10, false, "1ZSZ142", 11, null, 4, 2658 }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "AverageFuel", "BrandId", "BuildYear", "CategoryId", "Chassis", "CountryId", "DoorTypeId", "Emission", "EndDateDelivery", "EngineCapacity", "EnginePower", "EngineTypeId", "FiscalHP", "FuelCardId", "FuelTypeId", "IsActive", "LicensePlate", "ModelId", "Power", "SeriesId", "Volume" },
                values: new object[,]
                {
                    { 106, null, 4, 2002, null, "789", 2, 1, 834, null, 1700, 73, 8, 9, null, 10, false, "1ZDA149", 11, null, 4, 2657 },
                    { 112, null, 4, 2006, null, "SJFDEU2159420", 2, 2, 882, null, 1686, 92, 8, 9, null, 10, false, "1AHW143", 12, null, 4, 2742 },
                    { 35, null, 4, 2004, null, "123", 1, 1, 214, null, 1686, 81, 37, 9, null, 10, false, "1HCG456", 11, null, 5, 3241 },
                    { 96, null, 2, 2004, null, "W06EW6DG097221", 1, 2, 746, null, 1600, 85, 68, 9, null, 10, false, "1XUE954", 7, null, 75, 2656 },
                    { 101, null, 2, 2006, null, "W0L0A898044253", 2, 2, 721, null, 2000, 96, 70, 11, null, 10, false, "1YEQ949", 7, null, 73, 2654 },
                    { 99, null, 2, 2006, null, "U5YZUABL093503", 2, 1, 719, null, 2000, 102, 70, 11, null, 10, false, "1YAS956", 7, null, 72, 2653 },
                    { 100, null, 2, 2004, null, "W0LGTL1D1035314", 2, 1, 710, null, 1800, 92, 72, 10, null, 10, false, "1YZW956", 7, null, 71, 2651 },
                    { 75, null, 1, 2004, null, "100", 1, 1, 523, null, 1995, 100, 2, 11, null, 10, false, "1SVD867", 2, null, 1, 3525 },
                    { 82, null, 1, 2001, null, "blablubli", 1, 1, 646, null, 2001, 130, 2, 11, null, 10, false, "1UTN818", 4, null, 1, 3656 },
                    { 83, null, 1, 2002, null, "W0LJD7EL0EB618949", 1, 1, 617, null, 2000, 120, 13, 11, null, 10, false, "1UYN819", 4, null, 1, 3653 },
                    { 153, 0, 1, 2012, null, null, 5, 5, 131, new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 789, 7894, 1, 7894, null, 9, false, "1CDD527", 5, null, 1, 2919 },
                    { 157, 0, 1, 2016, null, "W0LEW9D8062050", 5, 2, 126, new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 789, 789, 1, 789, null, 9, false, "1CEF872", 1, null, 1, 2916 },
                    { 158, 0, 1, 2019, null, "SJDE11U2157331", 5, 5, 128, new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 789, 789, 1, 789, null, 9, false, "1CAJ963", 1, null, 1, 2912 },
                    { 162, 0, 1, 2012, null, "WAUZZZ8R81105", 5, 3, 122, null, 0, 0, 2, 0, null, 10, false, "1CZI127", 1, null, 1, 2918 },
                    { 39, null, 1, 2008, null, "W0L0SDL6884193058", 1, 2, 3588, null, null, 0, 12, 0, null, 3, false, "1IML575", 4, null, 2, 3240 },
                    { 76, null, 1, 2005, null, "W0LGM57K391058231", 1, 3, 510, null, 2000, 120, 2, 11, null, 10, false, "1SBN866", 4, null, 2, 3526 },
                    { 108, null, 4, 2000, null, "1265165134", 2, 3, 876, null, 1956, 96, 20, 11, null, 10, false, "1QWB147", 29, null, 24, 2745 },
                    { 77, null, 1, 2006, null, "WAUZZZ8R1BA081105", 1, 3, 691, null, 2000, 120, 2, 11, null, 10, false, "1SND863", 4, null, 2, 3529 },
                    { 79, null, 1, 2008, null, "W0LPE8E63E8064049", 1, 3, 673, null, 2000, 120, 2, 11, null, 10, false, "1TZG861", 4, null, 2, 3627 },
                    { 80, null, 1, 2009, null, "YV1DZ73CDE2608659", 1, 3, 664, new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000, 135, 13, 10, null, 10, false, "1TEG864", 4, null, 2, 3624 },
                    { 81, null, 1, 2000, null, "W0L0SDL6884314639", 1, 3, 655, null, 2000, 135, 13, 11, null, 10, false, "1TRH815", 4, null, 2, 3625 },
                    { 151, null, 1, 2016, null, "W0L0AH599371", 5, 3, 137, null, 2000, 150, 11, 11, null, 10, false, "1CEF345", 19, null, 2, 2917 },
                    { 37, null, 1, 2006, null, null, 1, 2, 2366, null, 1900, 0, 12, 0, null, 10, false, "1IBA578", 4, null, 15, 3242 },
                    { 84, null, 1, 2003, null, "123", 1, 2, 638, null, 2000, 120, 13, 11, null, 10, false, "1UUB817", 1, null, 16, 3652 },
                    { 85, null, 1, 2004, null, "2541", 1, 2, 629, null, 2000, 135, 13, 11, null, 10, false, "1UQV816", 1, null, 17, 3651 },
                    { 86, null, 1, 2005, null, "JNA1U2117751", 1, 2, 610, null, 3500, 210, 12, 15, null, 10, false, "1VSC813", 5, null, 17, 3656 },
                    { 87, null, 1, 2007, null, "0arty", 1, 2, 601, null, 3500, 240, 12, 15, null, 10, false, "1VWX952", 5, null, 17, 3659 },
                    { 78, null, 1, 2007, null, "VF38ERHR8BL085484", 1, 3, 682, null, 2000, 120, 2, 11, null, 10, false, "1TAQ862", 4, null, 2, 3628 },
                    { 109, null, 4, 2007, null, "zeaeaz?", 2, 2, 899, null, 1956, 96, 20, 11, null, 10, false, "1QXV146", 29, null, 24, 2746 },
                    { 107, null, 4, 2001, null, "W0PE8844691", 2, 2, 825, null, 1700, 80, 8, 9, null, 10, false, "1QFQ148", 11, null, 37, 2744 },
                    { 110, null, 4, 2008, null, "1489414", 2, 1, 828, null, 1956, 96, 20, 11, null, 10, false, "1QCC146", 29, null, 82, 2743 },
                    { 160, 0, 8, 2017, null, "100zda4545", 5, 6, 128, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 120, 10, 50, null, 9, false, "1CAD345", 16, null, 11, 2916 },
                    { 47, null, 8, 2006, null, "VF3LB9HPAES115707", 1, 2, 348, null, 1999, 100, 35, 12, null, 10, false, "1KEB686", 16, null, 19, 3446 },
                    { 48, null, 8, 2007, null, "100", 1, 1, 356, null, 2000, 88, 35, 11, null, 10, false, "1KRV685", 16, null, 19, 3444 },
                    { 49, null, 8, 2008, null, "14521", 1, 1, 382, null, 2000, 100, 52, 11, null, 10, false, "1KTC684", 16, null, 19, 3442 },
                    { 50, null, 8, 2009, null, "W0L0AHM758G153913", 1, 1, 37, null, 2000, 100, 53, 11, null, 10, false, "1LYX684", 16, null, 19, 3446 },
                    { 64, null, 8, 2003, null, null, 1, 2, 461, null, 1968, 100, 35, 11, null, 10, false, "1OUB798", 20, null, 25, 3427 },
                    { 65, null, 8, 2004, null, "147", 1, 2, 452, null, 2000, 120, 35, 11, null, 10, false, "1OIA799", 20, null, 25, 3426 },
                    { 66, null, 8, 2005, null, "W0L0AHL3582099371", 1, 2, 5571, null, 2000, 100, 56, 11, null, 10, false, "1POZ793", 20, null, 25, 3523 },
                    { 40, null, 8, 2009, null, "W0LPE8EG2B8045397", 1, 4, 369, null, 1600, 77, 50, 10, null, 10, false, "1IOI576", 30, null, 49, 3244 },
                    { 152, 0, 8, 2013, null, "W0LPEC8095933", 5, 6, 135, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200, 70, 10, 80, null, 9, false, "1CDF436", 16, null, 11, 2918 },
                    { 41, null, 8, 2000, null, "W0LGT8ELXD1044444", 1, 4, 371, null, 1600, 75, 51, 9, null, 9, false, "1IUM571", 30, null, 49, 3245 },
                    { 44, null, 8, 2003, null, "VF3CC8HROET203509", 1, 2, 314, new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1900, 77, 10, 10, null, 10, false, "1JRL581", 30, null, 51, 3348 },
                    { 45, null, 8, 2004, null, "789789", 1, 4, 325, null, 1600, 77, 50, 9, null, 10, false, "1JAO682", 30, null, 52, 3349 },
                    { 46, null, 8, 2005, null, "12354", 1, 2, 336, null, 2000, 120, 35, 11, null, 10, false, "1KZN683", 16, null, 53, 3345 },
                    { 63, null, 8, 2002, null, null, 1, 6, 432, null, 2700, 120, 55, 14, null, 10, false, "1OYV797", 20, null, 54, 3429 },
                    { 67, null, 8, 2006, null, "W0LPE8EX6C8095933", 1, 7, 5653, null, 2000, 120, 35, 11, null, 10, false, "1PQT792", 20, null, 55, 3522 },
                    { 147, null, 4, 2016, null, "za4561htger", 4, 2, 1348, null, 1686, 81, 39, 9, null, 10, false, "1BER981", 11, null, 128, 2814 },
                    { 148, null, 4, 2017, null, null, 4, 1, 1369, null, 1686, 81, 39, 9, null, 10, false, "1BEE072", 11, null, 128, 2812 },
                    { 38, null, 6, 2007, null, "4521", 1, 1, 2477, null, 1229, 122, 40, 11, null, 9, false, "1ILK577", 21, null, 12, 3241 },
                    { 116, null, 6, 2001, null, null, 2, 4, 933, null, 1233, 120, 40, 10, null, 10, false, "1AHR136", 17, null, 91, 2746 },
                    { 43, null, 8, 2002, null, "W0LPE8EX7D8050002", 1, 2, 393, null, 1600, 77, 50, 9, null, 10, false, "1JTU570", 30, null, 51, 3347 },
                    { 123, null, 3, 2009, null, "451", 2, 1, 996, null, 2000, 100, 112, 11, null, 10, false, "1AHH235", 10, null, 115, 2749 },
                    { 62, null, 8, 2001, null, "zaer", 1, 3, 4256, null, 2000, 100, 53, 11, null, 10, false, "1OTC796", 16, null, 11, 3428 },
                    { 60, null, 8, 2009, null, "W0LGM8ES4E1137406", 1, 3, 407, null, 2000, 100, 53, 11, null, 10, false, "1NES794", 16, null, 11, 3425 },
                    { 146, null, 4, 2015, null, "W0LJD7EB615571", 4, 1, 1357, null, 1956, 96, 38, 11, null, 10, false, "1BFT892", 29, null, 5, 2815 },
                    { 149, null, 4, 2018, null, "nfezf654b", 5, 1, 1399, null, 1956, 103, 38, 11, null, 10, false, "1CEZ163", 29, null, 129, 2813 },
                    { 111, null, 4, 2009, null, "45442141454125", 2, 2, 817, null, 1700, 81, 95, 9, null, 10, false, "1AVX142", 12, null, 5, 2746 },
                    { 102, null, 4, 2007, null, null, 2, 2, 722, null, 1686, 92, 94, 9, null, 10, false, "1YTA948", 11, null, 5, 2655 },
                    { 103, null, 4, 2005, null, "WBA1SDFDSGEGF21", 2, 1, 851, null, 1686, 92, 94, 9, null, 10, false, "1ZRZ947", 11, null, 81, 2656 },
                    { 150, null, 4, 2019, null, "146517", 5, 1, 1385, null, 1598, 81, 115, 9, null, 10, false, "1CEA254", 11, null, 81, 2811 },
                    { 161, 0, 7, 2011, null, "W0LGM57K39231", 5, 4, 172, null, 0, 0, 9, 0, null, 3, false, "1CZK236", 22, null, 9, 2919 },
                    { 154, 0, 7, 2011, null, "W0LME418678", 5, 2, 122, new DateTime(2019, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 25, 117, 25, null, 3, false, "1CDX618", 23, null, 39, 2916 },
                    { 113, null, 7, 2005, null, "1246789", 2, 3, 811, null, 2000, 100, 96, 11, null, 10, false, "1AFF141", 23, null, 86, 2741 },
                    { 61, null, 8, 2000, null, "W0LJD7EL6EB615571", 1, 3, 414, null, 2000, 100, 53, 11, null, 10, false, "1NRW795", 16, null, 11, 3424 },
                    { 114, null, 7, 2004, null, "12458", 2, 1, 941, null, 2000, 100, 96, 11, null, 10, false, "1AAQ144", 23, null, 87, 2744 },
                    { 51, null, 8, 2000, null, null, 1, 4, 412, null, 1800, 120, 54, 10, null, 9, false, "1LQW687", 16, null, 11, 3443 },
                    { 52, null, 8, 2001, null, null, 1, 3, 4231, null, 1800, 120, 54, 10, null, 9, false, "1LSD688", 16, null, 11, 3444 },
                    { 53, null, 8, 2002, null, "ezrtrra", 1, 3, 4322, null, 1900, 85, 10, 10, null, 10, false, "1LDA689", 16, null, 11, 3446 },
                    { 54, null, 8, 2003, null, null, 1, 3, 4513, null, 1900, 84, 10, 10, null, 10, false, "1MFZ696", 16, null, 11, 3443 },
                    { 55, null, 8, 2004, null, null, 1, 3, 464, null, 2000, 100, 35, 11, null, 10, false, "1MGE695", 16, null, 11, 3442 },
                    { 56, null, 8, 2005, null, "W0LPE6EW9DG046079", 1, 3, 446, null, 2000, 88, 35, 11, null, 10, false, "1MHR694", 16, null, 11, 3441 },
                    { 57, null, 8, 2006, null, "nvt", 1, 3, 476, null, 2000, 100, 52, 11, null, 10, false, "1MJT691", 16, null, 11, 3420 },
                    { 58, null, 8, 2007, null, "W0LGM8EL3C1068598", 1, 3, 489, null, 2000, 100, 52, 11, null, 10, false, "1NAY792", 16, null, 11, 3421 },
                    { 59, null, 8, 2008, null, null, 1, 3, 498, null, 2000, 120, 53, 11, null, 10, false, "1NZS793", 16, null, 11, 3422 },
                    { 115, null, 7, 2002, null, "45745747547", 2, 2, 942, null, 2000, 100, 96, 11, null, 10, false, "1AZE135", 23, null, 88, 2745 },
                    { 74, null, 1, 2003, null, "WBAVU11090K051447", 1, 1, 534, null, 1999, 90, 2, 11, null, 10, false, "1SCF868", 2, null, 1, 3527 }
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
                name: "IX_Corporations_CompanyId",
                table: "Corporations",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_PersonId",
                table: "Drivers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineTypes_BrandId",
                table: "EngineTypes",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ExteriorColors_BrandId",
                table: "ExteriorColors",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelCards_CompanyId",
                table: "FuelCards",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelCards_DriverId",
                table: "FuelCards",
                column: "DriverId",
                unique: true,
                filter: "[DriverId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InteriorColors_BrandId",
                table: "InteriorColors",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_CorporationId",
                table: "Records",
                column: "CorporationId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_CostAllocationId",
                table: "Records",
                column: "CostAllocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_FuelCardId",
                table: "Records",
                column: "FuelCardId",
                unique: true,
                filter: "[FuelCardId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Series_BrandId",
                table: "Series",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BrandId",
                table: "Vehicles",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CategoryId",
                table: "Vehicles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CountryId",
                table: "Vehicles",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DoorTypeId",
                table: "Vehicles",
                column: "DoorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_EngineTypeId",
                table: "Vehicles",
                column: "EngineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_FuelCardId",
                table: "Vehicles",
                column: "FuelCardId",
                unique: true,
                filter: "[FuelCardId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_FuelTypeId",
                table: "Vehicles",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ModelId",
                table: "Vehicles",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_SeriesId",
                table: "Vehicles",
                column: "SeriesId");
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
                name: "ExteriorColors");

            migrationBuilder.DropTable(
                name: "InteriorColors");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Corporations");

            migrationBuilder.DropTable(
                name: "CostAllocation");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "DoorTypes");

            migrationBuilder.DropTable(
                name: "EngineTypes");

            migrationBuilder.DropTable(
                name: "FuelCards");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
