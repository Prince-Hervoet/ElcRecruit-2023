using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace interviewer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepId = table.Column<int>(type: "int", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interviewers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviewers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    College = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeChat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstDepartment = table.Column<int>(type: "int", nullable: false),
                    SecondDepartment = table.Column<int>(type: "int", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c0d3ae5-8fc3-4e3f-a72e-933d128c0af9", "a1a3bf7d-4555-479e-9270-9c878c33f0c3", "Interviewer", "INTERVIEWER" },
                    { "da6a8f20-546b-446f-9813-f28127373ff2", "7e2b6fcd-266d-4ccb-ae61-12553c88d854", "Admin", "ADMIN" },
                    { "ebbd3e78-82ee-4952-9ef7-41433c00d35f", "59aa4b0d-2f40-4d7d-a6ed-8108b60dcd62", "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "College", "FirstDepartment", "Grade", "Introduction", "Name", "Phone", "Qq", "SecondDepartment", "Skills", "State", "StudentId", "WeChat" },
                values: new object[,]
                {
                    { "0517ad3d-d879-49bf-a3bf-5c11e4be40f1", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "08873245-b5de-44da-966b-8ae418224b46", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "08b9fb8c-158f-4c0f-ad66-fc00857bd778", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "099404ba-f597-4ad0-9aca-a8cbcf840d5f", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "09bdad3e-2642-4e4c-a75b-0871121fb86d", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "0d051e25-1e63-4e39-8a37-6322d0112b1f", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "0e564bd7-b082-4feb-95c2-cf26a1dfff5a", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "118f5462-cecf-4088-98b3-66eb36d0fb99", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "1348cb25-a1c6-44ac-b5c0-2981f6f4d28d", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "13773050-2bad-4b7b-96ca-cf68ace3d54a", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "196af5d8-b86d-47be-9ed8-51505704e647", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "25aa847c-53f9-4c3f-9913-a56181afdf39", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "28b5793a-f3f2-4e09-aabd-da6b15411a9e", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "29a268ee-d4b9-4174-81c8-7cc44ffcc7a0", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "2b7e0017-d829-4b4b-b8e1-db82d0dd3d0c", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "2bf1babe-6241-481b-91dd-e8919258146c", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "2c87493f-9593-4185-bbd3-ecdfb090a04c", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "2d0b5b8a-88bf-498a-8cdf-2227b4f06b4c", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "30fc9f50-703d-4cb5-93a2-3f988904ef41", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "3313eacf-745e-4f34-bce2-9deda646253d", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "3b216550-1f9d-4340-be06-22e0fd0ac56a", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "3c9b7d09-b632-4b68-8b3e-c0185bf4bbbc", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "3ed3b86e-e619-486f-8647-c4f902e49e13", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "3f6bb0cf-acb9-4718-b9d7-0e85b688792f", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "407613dc-6017-4c73-b1e9-a7dfc70fcd0b", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "4439811c-3271-43b8-a490-97dc02148243", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "4557920e-79df-423d-a6c8-4b0ba6bb6a5a", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "474d68ab-a233-4e76-9c75-d353c44c4377", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "47e45ac3-232c-4245-9adf-1c7c2a1fde58", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "4816d8c0-e263-4f53-8c82-2cbb07d72303", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "4b266dbe-0701-4776-9b1c-10d200c8791e", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "533af88e-c2ef-426e-a1e3-8e0101e3d8b0", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "55186775-d49b-4882-a9f4-97ec57fc6201", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "595d0610-360d-49a5-addd-12007e6014ab", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "59bfde1e-607d-49a2-b32a-1aa7a8b723e6", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "5b51ac29-c7eb-4d9b-a216-27ad908bbc35", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "62c1f13b-d99f-413d-827d-a87918619115", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "65e7381e-20fd-4404-a196-c462c6485263", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "68887790-fb6a-4dd6-adc4-7ad78eddd6bb", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "696c2961-54a1-4d8f-8c1c-afbac8e3753e", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "69e5ab8e-c368-40eb-be36-acf550978027", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "6fd12da9-3c51-4b51-b21c-81058da631ba", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "6fdedba6-f6bb-4d08-a6ce-e19eb25658d4", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "70837f47-6eb7-4876-89cf-a911e7778af1", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "7187327d-c22d-499c-a508-fa85df58ecdb", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "71bdbb8c-fa99-4c6c-aff5-f9d0ea4b29bf", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "728c579b-6b01-4a0f-b2d0-a90c6c523896", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "7645fa4f-977b-485a-852f-2fdbf21d480c", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "781c8744-5339-4ef2-9aae-4b00bf52748c", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "7a1d0663-744b-4f70-98d1-68ca80cd4eff", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "828c1754-4a74-4cd8-b226-9fcc7cc0bb21", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "82fe69ec-abee-454d-8cef-ae922d656ded", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "8ec42148-3789-4d19-9dbe-2b028f2276c1", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "95866178-0a29-45bb-984e-4b93eebc1707", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "95ff46a5-9227-4b0a-b104-55ac1a863be7", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "970546d8-dca8-4701-ab5f-2601a93af8e3", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "9711245c-72a2-4624-8113-a044a0ed00e4", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "9780ce12-4b02-493e-9795-35c3abc7f7bb", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "986e52bc-de45-4dd9-9042-3d5d31b495f1", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "98cfbefb-f39b-413f-9a05-56a7224175ac", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "99b709f2-98b3-43f7-930e-52956b998ba2", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "9dc326f6-886d-419b-b7be-1a82ad848df7", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "9e4873bd-97bf-4da5-8d76-4506f559952d", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "a34f4922-0ffd-47f4-8f55-6206047b9ee8", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "a4449d70-1289-463b-9e7d-203f545ffad3", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "ac11d9ba-e05f-4e98-a2ef-446641a6531c", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "b1884b09-2ef8-41cd-acef-fe60019399f5", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "b20051c6-4d8a-4c18-a37f-e7fb5d88f1a9", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "b5d107de-06ec-47f2-a53a-5bd2e66c5191", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "b693790e-0796-4fb9-9f7b-c01c1ee87698", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "b9ae5d9d-91ce-4fca-af66-0c4bbaa90f89", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "b9cf6652-6f00-42e9-be2f-123f22c50e2a", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "bb8f78d6-5514-483b-be65-b276fb10417d", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "bfd30c89-a803-4740-bd99-278a6f7f052a", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "c1572eaf-a69c-4fd3-8674-4e77965b183a", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "c31b4d27-9e7d-477a-9551-ead4b622cd30", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "c520219b-0e08-4719-8238-2ee17bbcf3fc", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "c5d8595f-e40b-41a4-a1f7-b295c5fefc36", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "d0537eb5-be64-4f45-a686-a00e99b2db09", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "d1cf3f78-0af5-4c3d-ae4d-6916b2fcbdd8", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "d94b8024-a5fe-4656-9586-9b3f0d8bc821", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "da06800a-61cc-4535-981f-aa0cc9d0c96b", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "dbaf5f5f-d02e-403a-8eba-770fab9be68f", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "e369e4c2-3964-48ed-a63c-57424df67981", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "e3cd7f0b-bf9e-4519-8ece-21e2bcafaa6a", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "e4d116ce-97dd-4106-9975-27c9550f3e2c", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "e7eb19bf-50a8-49e2-beea-fb0d10bf7e2c", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "ee1c8d27-9ff7-46ab-94fd-01c29c62ab23", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "eec7fb0b-2065-41e4-b67e-ed266d0efa32", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "ef01ed9f-7428-407a-a994-380ff3c97edd", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "ef5cae69-f0e5-4eb5-9895-458a4478e772", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "ef86cc5a-7d7a-49ca-9761-8361e895f703", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "f0e43ac6-db92-45ec-8221-1e171c2d5f63", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "f1bc54af-ebe2-4658-8a37-70fee42debb0", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "f501f11d-d519-4d60-a0b9-d9ff533f47ad", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "f64ad80c-c795-4e47-8fc3-02879cb4b446", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "f7db669d-759f-4a45-a14d-41463e725eac", "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "f868739f-7dbd-4fb9-9dd0-7325b8902637", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "fc0c312b-e812-47dd-a32c-b5c2d5e3318f", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { "fe8e5cf2-4bd0-414d-8ae6-94a69a95b836", "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null }
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
        }

        /// <inheritdoc />
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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Interviewers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
