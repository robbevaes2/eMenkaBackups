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
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    FuelCardId = table.Column<int>(nullable: false),
                    Language = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
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
                name: "MotorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotorTypes_Brands_BrandId",
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
                name: "FuelCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(nullable: false),
                    DriverId = table.Column<int>(nullable: false),
                    RecordId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuelCards_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelCardId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Term = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Usage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Records_FuelCards_FuelCardId",
                        column: x => x.FuelCardId,
                        principalTable: "FuelCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(nullable: true),
                    ModelId = table.Column<int>(nullable: true),
                    MotorTypeId = table.Column<int>(nullable: true),
                    FuelCardId = table.Column<int>(nullable: true),
                    DoorTypeId = table.Column<int>(nullable: true),
                    FuelTypeId = table.Column<int>(nullable: true),
                    Volume = table.Column<int>(nullable: false),
                    FiscalePk = table.Column<int>(nullable: false),
                    Emission = table.Column<int>(nullable: false),
                    Power = table.Column<int>(nullable: false),
                    LicensePlate = table.Column<string>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
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
                        name: "FK_Vehicles_DoorTypes_DoorTypeId",
                        column: x => x.DoorTypeId,
                        principalTable: "DoorTypes",
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
                        name: "FK_Vehicles_MotorTypes_MotorTypeId",
                        column: x => x.MotorTypeId,
                        principalTable: "MotorTypes",
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
                    { 25, "Blastxsx" },
                    { 24, "TestMerk1" },
                    { 22, "Porsche" },
                    { 21, "Smart" },
                    { 20, "Skoda" },
                    { 19, "Saab" },
                    { 18, "Lexus" },
                    { 17, "Honda" },
                    { 16, "Alfa Romeo" },
                    { 15, "Nissan" },
                    { 23, "Mini" },
                    { 13, "Toyota" },
                    { 14, "Hyundai" },
                    { 2, "Ford" },
                    { 3, "Volkswagen" },
                    { 5, "Ferrari" },
                    { 6, "Peugeot" },
                    { 4, "Opel" },
                    { 8, "Mercedes" },
                    { 9, "KIA" },
                    { 10, "Volvo" },
                    { 11, "Citroën" },
                    { 12, "Fiat" },
                    { 7, "Audi" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "AccountNumber", "Description", "IsActive", "IsInternal", "Name", "NonActiveRemark", "Reference", "VAT" },
                values: new object[,]
                {
                    { 21, "", "Federale overheidsdienst Financiën", true, false, "FodFin", "", "FODFIN", "" },
                    { 27, "", "rechtsbijstandsverzekering", true, false, "DAS", "", "", "" },
                    { 22, "001-4327984-17", "Gar BMW Smets", true, false, "Patrick Smets NV", "", "SMETS", "BE 0418.022.587" },
                    { 23, "", "", true, false, "Beerens", "", "", "" },
                    { 24, "", "Bandencentrale", true, false, "Jespers", "", "TYRECENTER", "BE39416100572119" },
                    { 25, "", "algemeen naam", true, false, "Autokeuring", "", "", "" },
                    { 26, "", "rechtsbijstand", true, false, "Euromex", "", "", "BE0404493859" },
                    { 28, "", "Maecon", true, false, "Maecon", "", "", "" },
                    { 34, null, null, false, false, "Q8", null, null, null },
                    { 30, "", "banden donckers", true, false, "Moereels", "", "", "BE80230013411177" },
                    { 31, "", "", true, true, "eMenKa GmbH", "", "", "" },
                    { 32, "", "<p><span><span>Antwerpen is de hoofdstad van <span class=\"comment - copy\">This works fine, but be aware that copying a</span></span><span><span class=\"comment - copy\">nd </span></span><span><span class=\"comment - copy\">pasting </span></span></span></p>", true, true, "eMenKa BV", "", "", "" },
                    { 33, "", "test", true, false, "test", "", "", "" },
                    { 35, "", "", true, false, "Alphabet", "", "ALP", "" },
                    { 36, null, null, null, null, null, null, null, null },
                    { 20, "335-0431795-94", "Carglass", true, false, "Carglass", "", "CAR", "BE 0432.023.845" },
                    { 29, "", "", true, true, "eMenKa NV", "", "", "BE 0888.140.116" },
                    { 19, "", "BMW dealer", true, false, "Peter DAENINCK NV", "", "", "" },
                    { 9, "1", "BMW Garage", true, false, "Sneyers", "", "D", "1" },
                    { 17, "BE31 4100 0007 1155", "", true, false, "Mercator Verzekeringen NV", "", "Mercator", "BE0400.048.883" },
                    { 1, null, null, false, false, "Total Belgium", null, null, null },
                    { 2, "123", "Esso", true, false, "Esso", "", "Esso", "123" },
                    { 3, null, null, false, false, "Shell", null, null, null },
                    { 4, "333-7777777-22", "Fictieve Opel garage", true, false, "OpelPlus", "", "Garage opel", "BE0456.565.667" },
                    { 18, "", "", true, false, "KAVEDE NV", "", "KAVEDE", "BE0429.270.926" },
                    { 6, "2", "Texaco", true, false, "Texaco", "", "Texaco", "2" },
                    { 7, null, null, false, false, "Q8", null, null, null },
                    { 8, "xx", "Multimerkverhuurder", true, false, "CIACfleet", "", "CIAC", "xx" },
                    { 5, "123-1234567-98", "KT leverancier ?", true, false, "AVIS", "", "AVIS", "BE 0455664455556" },
                    { 10, "1", "AXA", true, false, "AXA", "", "AXA", "1" },
                    { 11, "1", "VAB", true, false, "VAB", "", "VAB", "1" },
                    { 12, "2", "Touring", true, false, "Touring", "", "Touring", "2" },
                    { 13, "123-123456789-12", "Brocom", false, false, "Brocom", "tijdelijk niet acief gezet", "Brocom", "BE 123233134234" },
                    { 14, "BE30 4377 5013 7111", "KBC", true, false, "KBC Autolease", "", "KBC", "BE 0422.562.385" },
                    { 15, "BE42 4829 0171 1154", "Daimler Fleet Management", true, false, "Mercedes-Benz FS Belux NV", "", "MBFS", "BE0405816821" },
                    { 16, null, null, false, false, "GMAN Antwerpen", null, null, null }
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
                    { 9, "Cabrio" },
                    { 8, "Moto" },
                    { 7, "Coupé" },
                    { 5, "Monovolume" },
                    { 6, "2-Deurs" },
                    { 3, "4-Deurs" },
                    { 2, "5-Deurs" },
                    { 1, "Break" },
                    { 4, "3-Deurs" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 10, "DSL", "Diesel" },
                    { 9, "MULTI", "Multifuel" },
                    { 8, "DSL INT", "Diesel International" },
                    { 7, "B20", "Biodiesel" },
                    { 6, "E85", "Ethanol" },
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
                    { 86, new DateTime(2019, 10, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "2562", "ABC", new DateTime(2019, 11, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "james", "M", 2, "john", new byte[] { 0 }, new DateTime(2019, 11, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 64, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "b", new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 2, "lumani", new byte[] { 0 }, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 88, new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "4554", "ABC", new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "beast", "M", 1, "60000", new byte[] { 0 }, new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 89, new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "12456", "ABCD", new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "beast", "M", 1, "7895", new byte[] { 0 }, new DateTime(2019, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 90, new DateTime(2019, 11, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "21452", "ABC", new DateTime(2019, 11, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "beast", "M", 1, "6000", new byte[] { 0 }, new DateTime(2019, 11, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 91, new DateTime(2019, 11, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "21521", "ABC", new DateTime(2019, 11, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "beast", "M", 3, "7000", new byte[] { 0 }, new DateTime(2019, 11, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 80, new DateTime(1987, 9, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "45456456456", "B", new DateTime(2034, 7, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "Joeri", "M", 2, "Jans", new byte[] { 0 }, new DateTime(1998, 2, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "Mr." },
                    { 87, new DateTime(2019, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "241562", "ABC", new DateTime(2019, 11, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), "azerty", "M", 1, "qwerty", new byte[] { 0 }, new DateTime(2019, 11, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "hello" },
                    { 79, new DateTime(2019, 10, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "254854152", "ABC", new DateTime(2019, 9, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 1, "azerty", new byte[] { 0 }, new DateTime(2019, 10, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 72, new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "a", "a", new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "a", 2, "string", new byte[] { 0 }, new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "string" },
                    { 77, null, null, "AZERT", null, "bla", "M", 2, "bla", new byte[] { 0 }, null, "bla" },
                    { 76, new DateTime(2019, 10, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "32585", "ABc", new DateTime(2019, 10, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "super", "M", 1, "man", new byte[] { 0 }, new DateTime(2019, 10, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 75, new DateTime(2019, 10, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "144445584", "Az", new DateTime(2019, 10, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "seinfield", "M", 2, "larry", new byte[] { 0 }, new DateTime(2019, 10, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "mister" },
                    { 74, new DateTime(1994, 12, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "1452145214", "SIHFi", new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "super", "M", 2, "man", new byte[] { 0 }, new DateTime(2019, 10, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 73, new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "a", new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "a", 2, "string", new byte[] { 0 }, new DateTime(2019, 10, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "string" },
                    { 92, new DateTime(2019, 11, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "5545", "ABC", new DateTime(2019, 11, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "hero", "M", 3, "man", new byte[] { 0 }, new DateTime(2019, 11, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
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
                    { 111, new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "789456", "AB", new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 2, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 110, new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "789", "ABC", new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "M", 2, "lumani", new byte[] { 0 }, new DateTime(2020, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
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
                    { 94, new DateTime(2019, 11, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "2145", "ABC", new DateTime(2019, 11, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "super", "M", 3, "man", new byte[] { 0 }, new DateTime(2019, 11, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 63, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "string", "b", new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "elvin", "", 2, "lumani", new byte[] { 0 }, new DateTime(2019, 10, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 19, new DateTime(1974, 11, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Benoit", "M", 2, "Geeraerts", new byte[] { 0 }, new DateTime(1993, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
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
                    { 124, new DateTime(2016, 6, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), "123456789", "B", new DateTime(2025, 6, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "abc", "M", 2, "def", new byte[] { 0 }, new DateTime(2017, 2, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), "Test" },
                    { 18, new DateTime(1976, 5, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Steve", "M", 2, "Baeyens", new byte[] { 0 }, new DateTime(1997, 1, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "mr" },
                    { 17, new DateTime(1987, 9, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Joeri", "M", 2, "Jansens", null, new DateTime(2006, 9, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 16, new DateTime(1985, 4, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", new DateTime(2019, 10, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "Marc", "M", 2, "Agten", new byte[] { 0 }, new DateTime(1977, 8, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "Mr" },
                    { 29, new DateTime(1989, 5, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Sep", "M", 2, "Feyaerts", new byte[] { 0 }, new DateTime(2007, 7, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
                    { 15, new DateTime(1975, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "12345678-25", "B", null, "Yannick", "M", 2, "Hammelinx", null, new DateTime(1994, 3, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "" },
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
                    { 1, "Holland", 32, null, "eMenKa BV", new DateTime(2010, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Antwerpen", 29, null, "eMenKa NV", new DateTime(2010, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Keulen", 31, null, "eMenKa GmbH", new DateTime(2010, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ExteriorColors",
                columns: new[] { "Id", "BrandId", "Code", "Name" },
                values: new object[,]
                {
                    { 5, 4, "WH", "Olympic White" },
                    { 6, 4, "MT", "Metro" },
                    { 7, 4, "UB", "Ultra Blue" },
                    { 12, 4, null, "Star Silver" },
                    { 13, 4, null, "Silver Lightning" },
                    { 18, 4, "GU9", "Luxor" },
                    { 19, 4, null, "Carbon Flash Black" },
                    { 22, 4, null, "Asteroid Grey" },
                    { 23, 4, null, "Waterworld Blue" },
                    { 24, 4, "GJW", "Deep Sky Blue" },
                    { 26, 4, "", "Deep Espresso Brown" },
                    { 30, 4, "red", "red" },
                    { 9, 6, "Y", "Yellow" },
                    { 4, 4, "BLs", "Black Sapphires" },
                    { 21, 7, null, "Grijs" },
                    { 8, 8, "GR", "Grijs" },
                    { 17, 8, null, "Lavagrijs" },
                    { 27, 8, null, "Zwart" },
                    { 25, 11, "492", "Savile Grey" },
                    { 10, 12, null, "Knalgeel" },
                    { 11, 12, "GRRR", "Groen" },
                    { 15, 15, null, "Grijs" },
                    { 20, 16, null, "Zwart" },
                    { 29, 17, "ext", "Test" },
                    { 28, 27, "azerty", "azerty" },
                    { 14, 5, "Fred", "Red" },
                    { 3, 4, "GR", "Technical Grey" },
                    { 1, 1, "", "Saphirschwarz" },
                    { 2, 1, null, "Titansilber" },
                    { 16, 1, "SG", "Spacegrau" }
                });

            migrationBuilder.InsertData(
                table: "InteriorColors",
                columns: new[] { "Id", "BrandId", "Code", "Name" },
                values: new object[,]
                {
                    { 1, 6, "b", "Black" },
                    { 5, 7, "KR", "Knalrood" },
                    { 13, 7, null, "Leder Beige" },
                    { 26, 27, "azerty", "azerty" },
                    { 28, 28, "ssss", "cccc" },
                    { 23, 11, "G761", "Select Leder" },
                    { 3, 4, "CC", "Charcoal" },
                    { 4, 4, "CA", "Cable Anthraciet" },
                    { 6, 4, "DB", "Dune Black" },
                    { 9, 4, null, "Anthraciet (Tabita/Elba)" },
                    { 2, 1, null, "Leder Dakota Schwarz" },
                    { 10, 4, null, "Cashmere beige/anthraciet" },
                    { 11, 4, null, "Leder Sienna Anthraciet black" },
                    { 12, 4, "GR4", "groen" },
                    { 7, 12, null, "Zwart leder" },
                    { 25, 16, null, "Zwart" },
                    { 24, 4, null, "Leder Jasmin Saddle Up" },
                    { 22, 4, null, "Ribbon/Jet Black" },
                    { 15, 4, null, "Lace/jet Black" },
                    { 27, 8, "AO23", "pikzwart" },
                    { 14, 8, null, "Steppe Zwart Leder" },
                    { 20, 4, null, "Salta Jet black" },
                    { 21, 4, null, "Lyra/Jet Black" },
                    { 18, 4, null, "Mando/Atlantis cocoa" },
                    { 17, 4, null, "Ribbon/Morrocana" },
                    { 16, 4, "TAAS", "Dune Beige" },
                    { 8, 1, null, "Fluid Anthracit" },
                    { 19, 4, null, "Stof/leder morrocana" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 48, 15, "H1" },
                    { 81, 19, "CT" },
                    { 82, 19, "IS" },
                    { 80, 18, "Moto" },
                    { 45, 15, "i10" },
                    { 68, 1, "320d" },
                    { 47, 15, "ix20" },
                    { 130, 18, "ttttt" },
                    { 15, 5, "456 GT" },
                    { 44, 15, "ix35" },
                    { 46, 15, "i30" },
                    { 43, 15, "i20" },
                    { 129, 4, "Adam" },
                    { 103, 20, "9 - mei" },
                    { 55, 9, "C - klasse" },
                    { 56, 9, "E - klasse" },
                    { 58, 9, "A - klasse" },
                    { 83, 9, "B - klasse" },
                    { 84, 9, "G - klasse" },
                    { 85, 9, "M - klasse" },
                    { 86, 9, "S - klasse" },
                    { 126, 9, "Ecoliner" },
                    { 67, 1, "316d" },
                    { 127, 4, "Mokka" },
                    { 90, 4, "Zafira tourer" },
                    { 89, 4, "Meriva" },
                    { 102, 20, "9 - mrt" },
                    { 95, 6, "Grand Espace" },
                    { 3, 1, "320i" },
                    { 21, 6, "Laguna" },
                    { 93, 7, "807" },
                    { 124, 7, "208" },
                    { 62, 17, "Giulietta" },
                    { 61, 17, "159" },
                    { 72, 12, "Jumper" },
                    { 36, 12, "C5" },
                    { 87, 16, "Qashqai" },
                    { 53, 16, "Note" },
                    { 92, 7, "5008" },
                    { 38, 12, "C8" },
                    { 37, 12, "C6" },
                    { 31, 1, "118i" },
                    { 19, 1, "725D" },
                    { 5, 1, "X5" },
                    { 16, 8, "A4" },
                    { 20, 8, "A5" },
                    { 30, 8, "A3" },
                    { 52, 8, "Q5" },
                    { 65, 1, "116d" },
                    { 91, 7, "308" },
                    { 54, 7, "3008" },
                    { 51, 7, "508" },
                    { 42, 6, "Mégane" },
                    { 94, 6, "Espace" },
                    { 88, 4, "Antara" },
                    { 96, 6, "Grand Scénic" },
                    { 97, 6, "Koleos" },
                    { 98, 6, "Mégane Grandtour" },
                    { 99, 6, "Meganescenic" },
                    { 100, 6, "Scénic" },
                    { 101, 6, "Scénic II Phase II" },
                    { 131, 6, "Talisman" },
                    { 49, 15, "i40" },
                    { 50, 15, "ix55" },
                    { 35, 12, "C4" },
                    { 125, 12, "DS3" },
                    { 128, 17, "Brera" },
                    { 66, 1, "118d" },
                    { 18, 7, "207" },
                    { 22, 7, "307" },
                    { 23, 7, "407" },
                    { 17, 6, "Clio" },
                    { 63, 8, "A6" },
                    { 29, 4, "Insignia" },
                    { 13, 4, "Corsa" },
                    { 9, 3, "Bora" },
                    { 10, 3, "Passat" },
                    { 109, 3, "Caddy" },
                    { 110, 3, "Golf Plus" },
                    { 111, 3, "Golf V" },
                    { 112, 3, "Golf VI" },
                    { 113, 3, "Jetta" },
                    { 8, 3, "Golf" },
                    { 114, 3, "Passat CC" },
                    { 115, 3, "Polo" },
                    { 116, 3, "Sharan" },
                    { 117, 3, "Tiguan" },
                    { 118, 3, "Touran" },
                    { 120, 11, "S80" },
                    { 119, 11, "S60" },
                    { 28, 11, "C70" },
                    { 14, 4, "Vectra" },
                    { 135, 27, "azerty" },
                    { 121, 11, "V60" },
                    { 122, 11, "XC60" },
                    { 2, 1, "318d" },
                    { 39, 14, "Prius" },
                    { 107, 14, "Auris" },
                    { 108, 14, "Yaris" },
                    { 137, 28, "baz" },
                    { 6, 2, "Escort" },
                    { 7, 2, "Mondeo" },
                    { 40, 2, "Fiesta" },
                    { 73, 2, "C - Max" },
                    { 74, 2, "Focus" },
                    { 75, 2, "Focus C - Max" },
                    { 76, 2, "Galaxy" },
                    { 77, 2, "Grand C - Max" },
                    { 78, 2, "S - Max" },
                    { 79, 2, "Transit Connect" },
                    { 123, 11, "XC70" },
                    { 136, 28, "qsdf" },
                    { 27, 11, "V70" },
                    { 26, 11, "V50" },
                    { 64, 8, "Q7" },
                    { 24, 11, "540" },
                    { 41, 15, "Getz" },
                    { 1, 1, "X3" },
                    { 34, 12, "C3" },
                    { 104, 21, "Octavia Combi" },
                    { 25, 11, "C30" },
                    { 105, 21, "Superb" },
                    { 33, 12, "C2" },
                    { 71, 1, "X1" },
                    { 70, 1, "530d" },
                    { 69, 1, "525d" },
                    { 133, 1, "X6" },
                    { 11, 4, "Astra" },
                    { 60, 13, "testFiat" },
                    { 106, 22, "Fortwo" },
                    { 59, 13, "kevin" },
                    { 132, 23, "TEst" },
                    { 134, 26, "lightning" },
                    { 12, 4, "Zafira" },
                    { 57, 13, "Punto" },
                    { 4, 1, "520d" },
                    { 32, 12, "C1" }
                });

            migrationBuilder.InsertData(
                table: "MotorTypes",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 104, 14, "1.4 D4D" },
                    { 103, 14, "1.8" },
                    { 33, 8, "2.0 Tdi" },
                    { 102, 14, "2.0 D" },
                    { 81, 9, "C 180 CDI" },
                    { 112, 11, "2.4 D5 GEARTRONIC" },
                    { 43, 9, "160 CDI" },
                    { 39, 9, "200 CDI" },
                    { 40, 9, "220 CDI" },
                    { 41, 9, "180 CDI" },
                    { 19, 11, "2.4 D" },
                    { 77, 9, "B 180 CDI" },
                    { 78, 9, "B 200 CDI" },
                    { 79, 9, "C 200 CDI" },
                    { 80, 9, "C 220 CDI" },
                    { 18, 11, "2.0 D" },
                    { 84, 9, "E 200 CDI" },
                    { 50, 8, "2.0 TDi DPF" },
                    { 101, 10, "0.8 CDI" },
                    { 26, 15, "1,5" },
                    { 29, 15, "1.7 CRDi" },
                    { 30, 15, "1.6 GDi" },
                    { 31, 15, "2.0 CRDi" },
                    { 76, 8, "PowerPlus" },
                    { 56, 8, "3.0 TDI" },
                    { 55, 8, "2.8 V6 Multitronic" },
                    { 54, 8, "2.0 TDi Multitronic" },
                    { 49, 8, "1.6 Tiptronic" },
                    { 53, 8, "2.7 TDI" },
                    { 88, 9, "350 CDI Bluetec" },
                    { 87, 9, "ML 300 CDI Blue Efficiency" },
                    { 86, 9, "ML 300 CDI" },
                    { 85, 9, "GLK 220 CDI 4matic" },
                    { 83, 9, "E 350 CDI" },
                    { 82, 9, "C 200" },
                    { 17, 11, "1.6 D" },
                    { 52, 8, "1.8 T" },
                    { 51, 8, "2.0 TDI e" },
                    { 89, 9, "S 320 CDI" },
                    { 28, 15, "1.4 Crdi" },
                    { 48, 8, "1.6 TDI" },
                    { 73, 16, "1.5 dCi" },
                    { 111, 3, "2.0 TDI BlueMotion" },
                    { 116, 26, "whosh" },
                    { 100, 21, "2.0 TD" },
                    { 99, 21, "1.6 TD" },
                    { 42, 13, "1500" },
                    { 64, 12, "2.2 HDI 74" },
                    { 63, 12, "2.2 HDI" },
                    { 110, 3, "2.0 CR TDi" },
                    { 98, 20, "1.9 TiD" },
                    { 59, 1, "18d" },
                    { 58, 1, "1,6" },
                    { 57, 1, "16d" },
                    { 13, 1, "20d" },
                    { 12, 1, "35d" },
                    { 11, 1, "30d" },
                    { 2, 1, "2" },
                    { 60, 1, "25d" },
                    { 10, 8, "1.9 Tdi" },
                    { 109, 3, "2.0 CR Tdi bluemotion" },
                    { 107, 3, "1.9 TDI BlueMotion" },
                    { 120, 28, "blasterx" },
                    { 119, 28, "blob" },
                    { 65, 2, "2.0 TDCi AUT" },
                    { 66, 2, "1.6 TDCi Turbo" },
                    { 67, 2, "1.6 TDCI ECOnetic" },
                    { 68, 2, "2.0 TDCi Turbo" },
                    { 69, 2, "2.2 TDCi Turbo" },
                    { 108, 3, "1.6 CR TDI" },
                    { 70, 2, "1.8 TDCi" },
                    { 72, 2, "2.0 Monovol 6v" },
                    { 117, 2, "blablu" },
                    { 118, 27, "azerty" },
                    { 3, 3, "1.9 TDI" },
                    { 24, 3, "1.6" },
                    { 105, 3, "1.6 TDi" },
                    { 106, 3, "2.0 TDi" },
                    { 71, 2, "1.8 TDCi Turbo" },
                    { 4, 4, "1.8 ECOTEC" },
                    { 1, 1, "1.9" },
                    { 6, 4, "1.6 CNG" },
                    { 38, 6, "16D" },
                    { 95, 6, "2.0 dCi" },
                    { 96, 6, "1.5 dCi" },
                    { 97, 6, "1.9 dCi FAP" },
                    { 23, 12, "2.0 HDi 138" },
                    { 22, 12, "1.6 HDi 110" },
                    { 21, 12, "1.6 HDi 92" },
                    { 5, 4, "1.9 CDTI" },
                    { 114, 17, "2.4 JTDm" },
                    { 46, 17, "1.9 JTD" },
                    { 45, 17, "1.9 JTDm" },
                    { 9, 7, "1.6 HDi" },
                    { 32, 7, "2" },
                    { 94, 7, "2.0 HDi" },
                    { 115, 7, "1.4 HDi" },
                    { 90, 16, "1.5dCi" },
                    { 47, 17, "2,0 JTDM 163PK" },
                    { 14, 6, "1,6" },
                    { 27, 6, "1.5" },
                    { 74, 18, "300cc" },
                    { 7, 4, "1.6 CNG ECOTEC" },
                    { 8, 4, "1.7 CDTI" },
                    { 15, 4, "1.3 CDTi 16v" },
                    { 16, 4, "3.0 CDTI" },
                    { 20, 4, "2.0 DPF CDTi" },
                    { 35, 4, "1.7 CDTI ECOTEC" },
                    { 36, 4, "2.0 CDTI ecoflex S/S DPF" },
                    { 25, 5, "3456" },
                    { 37, 4, "1.7 CDTI ecoflex S/S DPF" },
                    { 92, 4, "1.7 CDTI DPF" },
                    { 93, 4, "1.7 CDTi ecoFLEX" },
                    { 113, 4, "1.6 CDTi ecoFLEX" },
                    { 62, 12, "2.0 HDi 136" },
                    { 75, 19, "Hybrid 2.0" },
                    { 61, 12, "2.0 HDi" },
                    { 34, 12, "2.2 ESS" },
                    { 91, 4, "2.0 CDTI" },
                    { 44, 13, "1600" }
                });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 68, 12, "Van" },
                    { 67, 12, "Business" },
                    { 66, 12, "Picasso Exclusive" },
                    { 46, 17, "Progression Corp. Leder" },
                    { 43, 13, "cabrio" },
                    { 133, 28, "ssss" },
                    { 132, 28, "blablu" },
                    { 131, 27, "azerty" },
                    { 130, 26, "speedy" },
                    { 102, 22, "Fun" },
                    { 101, 21, "Elegance" },
                    { 100, 20, "Vector" },
                    { 99, 20, "Linear Advantage" },
                    { 98, 20, "Business" },
                    { 77, 19, "Business" },
                    { 76, 18, "ST300" },
                    { 20, 18, "rerezrtrz" },
                    { 47, 17, "Distinctive" },
                    { 65, 12, "Picasso Business GPS" },
                    { 45, 17, "Progression" },
                    { 44, 17, "Eco" },
                    { 38, 16, "Acenta" },
                    { 35, 15, "Facility Pack" },
                    { 34, 15, "Base" },
                    { 33, 15, "Trocadéro" },
                    { 31, 15, "Hatchback" },
                    { 106, 14, "Linea Terra" },
                    { 105, 14, "1.8 Hybrid" },
                    { 104, 14, "Luna DPF" },
                    { 103, 14, "DPF" },
                    { 42, 13, "Break" },
                    { 64, 12, "Picasso Business" },
                    { 14, 1, "Coupé" },
                    { 62, 12, "Grand Picasso Business" },
                    { 118, 3, "Upgrade" },
                    { 119, 3, "Trendline" },
                    { 1, 1, "Touring" },
                    { 4, 4, "Enjoy" },
                    { 5, 4, "Cosmo" },
                    { 6, 4, "Essentia" },
                    { 7, 4, "OPC" },
                    { 24, 4, "Edition" },
                    { 37, 4, "Sport" },
                    { 81, 4, "Cosmo Sports Tourer" },
                    { 82, 4, "Edition Sports Tourer" },
                    { 128, 4, "Enjoy Active" },
                    { 129, 4, "Business" },
                    { 30, 5, "tt" },
                    { 12, 6, "dd" },
                    { 13, 6, "DCI" },
                    { 91, 6, "Latitude FAP" },
                    { 92, 6, "Alyum FAP" },
                    { 93, 6, "Dynamique" },
                    { 94, 6, "Latitude" },
                    { 95, 6, "Authentique" },
                    { 117, 3, "Edition" },
                    { 96, 6, "FAP" },
                    { 116, 3, "BMT" },
                    { 114, 3, "Conceptline DPF" },
                    { 15, 1, "Cabrio" },
                    { 16, 1, "Hatch" },
                    { 17, 1, "xDrive" },
                    { 21, 1, "test" },
                    { 58, 1, "sDrive18d" },
                    { 59, 1, "sDrive20d" },
                    { 69, 2, "Ghia DPF" },
                    { 70, 2, "Titanium DPF" },
                    { 71, 2, "Trend" },
                    { 72, 2, "Ghia" },
                    { 73, 2, "Trend DPF" },
                    { 74, 2, "Titanium" },
                    { 75, 2, "Econetic" },
                    { 3, 3, "Rabbit" },
                    { 107, 3, "Van" },
                    { 108, 3, "B2B-line" },
                    { 109, 3, "Trend" },
                    { 110, 3, "United DSG DPF" },
                    { 111, 3, "United DPF" },
                    { 112, 3, "Comfort" },
                    { 113, 3, "Comfortline" },
                    { 115, 3, "Highline" },
                    { 97, 6, "Family FAP" },
                    { 8, 7, "SW" },
                    { 9, 7, "Coupé" },
                    { 41, 9, "Classic" },
                    { 78, 9, "Blue Efficience" },
                    { 79, 9, "Elegance" },
                    { 80, 9, "L Avantgarde" },
                    { 22, 11, "Basis" },
                    { 23, 11, "Summum" },
                    { 120, 11, "Kinetic" },
                    { 121, 11, "DRIVe Start/Stop" },
                    { 122, 11, "DRIVe Kinetic" },
                    { 123, 11, "D4 Kinetic St/St" },
                    { 124, 11, "DRIVe" },
                    { 125, 11, "D3 Kinetic St/St" },
                    { 126, 11, "DRIVe Start/Stop Kinetic" },
                    { 127, 11, "Momentum" },
                    { 26, 12, "Coupé" },
                    { 27, 12, "Picasso" },
                    { 28, 12, "Tourer" },
                    { 29, 12, "Pluriel" },
                    { 32, 12, "Exclusive" },
                    { 60, 12, "Grand Picasso" },
                    { 61, 12, "Grand Picasso Bus+" },
                    { 40, 9, "Avantgarde" },
                    { 57, 8, "Quattro" },
                    { 56, 8, "DPF" },
                    { 55, 8, "Start/Stop DPF" },
                    { 10, 7, "Berline" },
                    { 18, 7, "Urban" },
                    { 39, 7, "Acces" },
                    { 83, 7, "Premium Coach" },
                    { 84, 7, "Premium Pack FAP" },
                    { 85, 7, "SW Premium Break" },
                    { 86, 7, "Executive AUT." },
                    { 87, 7, "Premium" },
                    { 88, 7, "SW Executive" },
                    { 90, 7, "ST Confort" },
                    { 63, 12, "Picasso Bus+" },
                    { 2, 1, "Berline" },
                    { 19, 8, "Avant" },
                    { 25, 8, "Sportback" },
                    { 36, 8, "SUV" },
                    { 48, 8, "Ambiente" },
                    { 49, 8, "Attraction" },
                    { 50, 8, "Sport Back Ambition" },
                    { 51, 8, "Sportback Ambiente" },
                    { 52, 8, "Sportback Attraction" },
                    { 53, 8, "Allroad Quattro" },
                    { 54, 8, "S line" },
                    { 11, 8, "Berline" },
                    { 89, 7, "Premium Pack" }
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
                name: "IX_ExteriorColors_BrandId",
                table: "ExteriorColors",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelCards_DriverId",
                table: "FuelCards",
                column: "DriverId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InteriorColors_BrandId",
                table: "InteriorColors",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorTypes_BrandId",
                table: "MotorTypes",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_CompanyId",
                table: "Records",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_FuelCardId",
                table: "Records",
                column: "FuelCardId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Series_BrandId",
                table: "Series",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BrandId",
                table: "Vehicles",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DoorTypeId",
                table: "Vehicles",
                column: "DoorTypeId");

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
                name: "IX_Vehicles_MotorTypeId",
                table: "Vehicles",
                column: "MotorTypeId");
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
                name: "Corporations");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "ExteriorColors");

            migrationBuilder.DropTable(
                name: "InteriorColors");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "DoorTypes");

            migrationBuilder.DropTable(
                name: "FuelCards");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "MotorTypes");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
