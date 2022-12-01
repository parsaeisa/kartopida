using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kartopida_Server.Migrations
{
    public partial class InitialCreate : Migration
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
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                name: "Startups",
                columns: table => new
                {
                    StartupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    founderID = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    WorkingTitle = table.Column<string>(nullable: false),
                    InternationalName = table.Column<string>(nullable: false),
                    StartWork = table.Column<int>(nullable: false),
                    EndWork = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Situation = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Entres = table.Column<string>(nullable: true),
                    Clers = table.Column<string>(nullable: true),
                    Field = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Startups", x => x.StartupID);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    AnnouncementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    originID = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    Field = table.Column<string>(nullable: false),
                    RequiredEmployees = table.Column<int>(nullable: false),
                    Requirments = table.Column<string>(nullable: false),
                    count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.AnnouncementID);
                    table.ForeignKey(
                        name: "FK_Announcements_Startups_originID",
                        column: x => x.originID,
                        principalTable: "Startups",
                        principalColumn: "StartupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clerks",
                columns: table => new
                {
                    ClerkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(nullable: false),
                    lastname = table.Column<string>(nullable: false),
                    username = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    phonenumber = table.Column<string>(maxLength: 11, nullable: false),
                    password = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Field = table.Column<string>(nullable: false),
                    FieldTitle = table.Column<string>(nullable: false),
                    degree = table.Column<string>(nullable: false),
                    officeID = table.Column<int>(nullable: false),
                    StartupID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clerks", x => x.ClerkID);
                    table.ForeignKey(
                        name: "FK_Clerks_Startups_StartupID",
                        column: x => x.StartupID,
                        principalTable: "Startups",
                        principalColumn: "StartupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entrepreneurs",
                columns: table => new
                {
                    EntrepreneurID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(nullable: false),
                    lastname = table.Column<string>(nullable: false),
                    username = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    phonenumber = table.Column<string>(maxLength: 11, nullable: false),
                    password = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    fields = table.Column<string>(nullable: true),
                    startupsNames = table.Column<string>(nullable: true),
                    StartupID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrepreneurs", x => x.EntrepreneurID);
                    table.ForeignKey(
                        name: "FK_Entrepreneurs_Startups_StartupID",
                        column: x => x.StartupID,
                        principalTable: "Startups",
                        principalColumn: "StartupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clerks",
                columns: new[] { "ClerkID", "Description", "Field", "FieldTitle", "StartupID", "degree", "email", "firstname", "lastname", "officeID", "password", "phonenumber", "username" },
                values: new object[] { 4, "he's awesome", "Android", "برنامه نویسی اندروید", null, "bachelor", "Password1!", "پارسا", "عیس زاده", 0, "p_eissazadeh@comp.iust.ac.ir", "09305709847", "parsa_eisa" });

            migrationBuilder.InsertData(
                table: "Clerks",
                columns: new[] { "ClerkID", "Description", "Field", "FieldTitle", "StartupID", "degree", "email", "firstname", "lastname", "officeID", "password", "phonenumber", "username" },
                values: new object[] { 2, "He's awesome too", "full-stack developer", "برنامه نویسی full-stack", null, "bachelor", "Password1!", "امیرعلی", "پاکدامن دنیوی ", 0, "p_donyavi@comp.iust.ac.ir", "34823094", "amirali_p" });

            migrationBuilder.InsertData(
                table: "Entrepreneurs",
                columns: new[] { "EntrepreneurID", "Description", "StartupID", "email", "fields", "firstname", "lastname", "password", "phonenumber", "startupsNames", "username" },
                values: new object[] { 1, "توضیح3", null, "a_esf@yahoo.com", "مهندسی", "علی", "اسفندیاری", "Password1!", "234235", null, "ali_esfandiari" });

            migrationBuilder.InsertData(
                table: "Startups",
                columns: new[] { "StartupID", "Address", "City", "Clers", "Description", "EndWork", "Entres", "Field", "InternationalName", "Situation", "StartWork", "State", "WorkingTitle", "founderID", "name" },
                values: new object[] { 1, "تهران ، ونک", "تهران", null, null, 0, null, null, "cafeBazaar", "در حال استخدام", 0, "تهران", "AndroidApp", 1, "کافه بازار" });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_originID",
                table: "Announcements",
                column: "originID");

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
                name: "IX_Clerks_StartupID",
                table: "Clerks",
                column: "StartupID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrepreneurs_StartupID",
                table: "Entrepreneurs",
                column: "StartupID");

            migrationBuilder.CreateIndex(
                name: "IX_Startups_founderID",
                table: "Startups",
                column: "founderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Startups_Entrepreneurs_founderID",
                table: "Startups",
                column: "founderID",
                principalTable: "Entrepreneurs",
                principalColumn: "EntrepreneurID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrepreneurs_Startups_StartupID",
                table: "Entrepreneurs");

            migrationBuilder.DropTable(
                name: "Announcements");

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
                name: "Clerks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Startups");

            migrationBuilder.DropTable(
                name: "Entrepreneurs");
        }
    }
}
