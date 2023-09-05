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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterviewerAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewerAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interviewers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviewers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "317cd16b-8026-4c93-9813-f5082aebd866", "c3348a9d-c627-4fb3-9055-ce39a6939e15", "Student", "STUDENT" },
                    { "a4933b64-49b2-4662-b1b6-a3caa9ecb584", "7a966263-4a43-4250-9bc5-fd9479746a36", "Admin", "ADMIN" },
                    { "bb68e4b7-bc10-4ad1-9bbc-cfda72072b17", "f8923ec5-1bad-4b3d-9bdd-fe445d735e66", "Interviewer", "INTERVIEWER" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "College", "FirstDepartment", "Grade", "Introduction", "Name", "Phone", "Qq", "SecondDepartment", "Skills", "State", "StudentId", "WeChat" },
                values: new object[,]
                {
                    { new Guid("01fc0e8e-df88-4ad2-bc2e-2b96b6b74f08"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("03319559-a12a-4e32-abe3-94c21dbf1d5b"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("0458f26a-f5b1-43f7-a3f1-45e8c6b7d99f"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("045abdd6-ff8d-487c-a624-8536a3f06a8b"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("0d75bd2e-9195-4350-a28b-fb787bf8147e"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("16e15e93-7aa3-4588-9917-a1a3142974ab"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("17122ee4-fd5a-4aaa-94cb-461b6686dc2c"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("19f1a0b2-70a7-46ad-8170-2efe9c7cf412"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1b638c6a-9438-4a09-a0fb-95964964f055"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1d5d8da9-224f-426a-9b40-38f5f8ad5107"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1ed322a0-7f04-4cf2-97b7-f14377ebd0d4"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1f7fb796-5828-430c-b7ff-35dcf2a976ff"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1f99c229-2792-4d1d-bc64-543a880e358b"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("227f6d27-a569-43f1-b070-7506e7d71b28"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("243a43a9-c3eb-4ffb-8461-5a02562825e4"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("30ee1afd-9533-4070-be03-7b07cf80b25e"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("32cf7b1f-3b8b-420e-86e0-8e7248e639fb"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3562b333-fe88-4bf9-b7d1-182f24ef8896"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("35feec4d-ccbb-4fd6-a29f-565152acf5aa"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("369ef227-c917-4449-8c0f-464f2f004fb3"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("38fb90cf-164b-44f2-80ac-a888f672483b"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3b7a44ec-afae-49c1-af74-dcd2005cb1b6"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3dddd41f-f568-4c37-8805-68be01cc333c"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("443752c5-3d3a-4a0e-aab7-9084e6c9a1ea"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("47b84575-981e-472d-8a2b-a4166e6f0b82"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("4994e296-7207-4e6d-a60e-3edd095244f8"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("4b37d3b0-64da-46da-bfc4-9ae7733fda43"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("4cb6162b-3f93-4ce0-828c-c4b2834c58b5"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("5916c495-6f87-4aff-9242-b2a8f8f14d7a"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("606ff42f-ada3-4c30-b068-84121e0c5683"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("60ebc69f-cab4-4d21-8a3a-77560694c7d4"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("631b5757-64eb-47aa-b581-ea3a87b43fe6"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("6dbaeeeb-a61a-402c-8531-1f4e7d592a24"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("6dff981f-4933-48fd-8cc4-93a960d1f907"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("75af736a-b0da-4dbe-bfc8-1b01512f182b"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("75cc7b94-f1b3-4bf2-8e3d-2db28fd330d9"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("76239523-3c5c-4460-b4c9-42d5b512b7af"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("776a95ec-1a30-4dcb-96d0-4fb34477e3ef"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("782e2a40-c43e-4321-bb19-99de1d8f0dc3"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("79da8e7b-6632-4929-a742-49a6b94fbb39"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("7a11dcf1-b2ae-4fe2-8454-6816cd262880"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("7aded075-b86c-438b-a34c-4e40395e3003"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("7f2dd864-3634-47e3-8f54-e398c1456b51"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("7f4bcb1c-9b88-4fe5-9d24-f12f0a9f5a07"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("7f53ca1c-1ed1-4959-839e-c2a6c2ae9946"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("84271435-ebb3-4bc3-98c6-35c3f9091e00"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("874999ac-902f-481a-8fa0-49fe1eab5303"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("87ec8397-705e-445e-b775-a6134ed26741"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("886d9226-ee57-4288-a35a-e880119ab167"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("888b5f0a-fcab-4b2d-9b1e-32cb894f3f3a"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8c2fcc2f-38b9-40d2-8447-7aac0f254fe6"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8d14e2f6-9437-4bea-9389-18d8fe8fd0d9"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8efa5fcb-c24c-4dc6-8afe-665316ada551"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8f102b11-2e59-4042-8143-ee9908d705da"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8f28b820-d1a5-4ea1-a34e-88b121f9bdfa"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("94922748-7d28-487f-8566-d375637b2d44"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("973e6431-f252-4209-b925-7b9150adeba9"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("995f9323-5f15-4343-8a7c-33321b03070d"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("9b68f913-a437-47c2-b866-005f3d9d109b"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("9c9f75c6-3fda-4497-861e-1eefd50a9648"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a4f77ab8-4136-42f0-9aa2-5d80ffeab4cf"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a695b11c-1f35-4fcb-b60f-6ffd04601380"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a748692f-792a-4521-b322-7ee2e6cf110c"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a914370a-fcc6-41c7-ad0a-2c6b3a88d0b3"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a982bcdc-e158-400a-866c-c03a936193e0"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ad9c32bd-3639-4e64-8a38-37fe8a26675a"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b2388e9f-f805-467d-99aa-143d710bdb68"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b46fa810-7eaa-4652-b570-31d8a0b714a6"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b64902ac-6757-4bc3-b226-68dbc4e56adc"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b9adb1dc-809f-4e6a-8826-39d3fe8a5b02"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("bac35c0e-d6df-4641-bbae-870427770117"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("bfad5c41-72a6-4fd2-821a-6abf827feb94"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c1c902b6-1ad5-4132-af43-b7050b055cb9"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c679380d-bd3e-4647-9acc-c6279c74518c"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c778096d-8edb-47ba-9e17-dd5dc988da15"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c8b1283b-1c8c-431e-aca6-60d137b3db6e"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("cf14c201-14b6-4df4-ad07-74c1e2c4a710"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d04f585b-b052-46e3-a208-8e37cb438421"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d39de320-b5d7-4f18-bcda-b4a3c3273adb"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d574d671-b3b7-4487-a657-cecca1331046"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d65937f5-cd1b-426a-ac17-d9d22bbcfca1"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d68d5307-5a3b-4f16-8030-7c0b010d1d38"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d9d1c963-4272-4622-b643-8017a0bae8ed"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("db217512-7ed0-4601-ac1c-540f0a602ec2"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("dff4752e-b471-4b01-98e2-844727bf3b47"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e1612391-1c2c-41fd-afe3-11a67fe283df"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e40ba8af-3e45-4295-926f-becc09d552fb"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e42d57b4-691b-4668-88ed-d08b983c3b06"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e6ee281f-6d8e-45bc-aa03-c08ccae63c02"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e7081d69-ad53-4652-97e8-8ad2ba31f35c"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e7e05273-8edf-4120-af9b-b551c9b1365b"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ef87c959-ee98-4fa3-926a-8253ffd256f0"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f0199003-47bb-41ad-9524-1da7261a4800"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f063240f-e57f-4d17-bb2e-0fced9975863"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f2f38962-280e-4ea9-91c4-19ea5feb7ea8"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f363d929-7bb6-4979-b2b5-2ee2fdbcbd8d"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f985147d-5c20-4a0d-b28a-dd23bc479834"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f9d5d15e-985c-41fd-9315-150baa5998b1"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("fab1401a-cca2-4ebc-9d21-3fb744a6e73f"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("feab0340-d2bd-4eff-96f6-08bbafd4342a"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null }
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
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "InterviewerAccounts");

            migrationBuilder.DropTable(
                name: "Interviewers");

            migrationBuilder.DropTable(
                name: "StudentAccounts");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
