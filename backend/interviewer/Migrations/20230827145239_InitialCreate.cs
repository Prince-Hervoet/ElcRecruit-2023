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

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "College", "FirstDepartment", "Grade", "Introduction", "Name", "Phone", "Qq", "SecondDepartment", "Skills", "State", "StudentId", "WeChat" },
                values: new object[,]
                {
                    { new Guid("0633a86b-63ef-400d-8e4d-e50abcae2b54"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("0691ac51-6378-47f0-a7d5-795437eb6ce8"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("08abfa77-cf8d-4c61-bd01-3a70d4b7c4de"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("0c3505cf-0dca-40e9-b2b4-bc6c433fa329"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("0ec9293d-575a-450c-840d-b29d7ac3f694"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("12303e73-cb77-43c2-8e53-db2eec1249dc"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("14384888-db80-4899-8b72-af9e06ce83f0"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("17434036-991f-4433-874d-ec1d9808e2e3"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1a65fdc5-4ae8-46c0-8baf-2916ea036e2b"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1bddfc66-5941-4bb6-873c-95fd87f02405"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1dc4e750-e03e-4d16-9833-b73f6b975306"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1e60a1a4-1873-44c7-bdd8-90d06e117ba5"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("2260a7cb-209a-46e2-8ba9-a6bc32bd5561"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("2568f7bf-94bb-4f81-851e-1413d455a5d7"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("25b9ae4e-3503-4b37-bc22-f84935d74d06"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("2880a2ec-6429-4801-8642-629cb8da1cf8"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("288bb338-f320-4d88-bda8-99e768cc18dd"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("2a7f2672-99da-4380-a8bd-caf850750b2f"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("2bd63cca-a422-485b-959a-db34799566a9"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("2c1ef94a-78d7-4a10-a6b7-6f1f32f5a398"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("2d4cc2cd-e289-4639-be94-abfc46e29996"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("312db54c-1a30-4fbc-ad62-0ef3e8f88a6d"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("315cd767-78c9-48e0-b6c1-7c292c92f491"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3276c67b-8044-43cc-b84d-7778b6a1e313"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("33fb28dd-a7ee-47aa-837e-d8462963bab4"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("359f8690-add4-4302-a34e-c1712eb53879"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("37b4400e-e607-4cc5-afca-7e7f80263028"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3bc6b261-6787-487a-9fb2-6665f06fddfb"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3bdec72c-27a7-4b98-a529-7c6527edae0a"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3dbde933-7676-4201-889d-32718b5efe50"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3dbf13dc-bccb-458c-a492-e156932322f6"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("4c144ae2-07a7-4bcb-a1f8-45503761fa0b"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("4e4e0378-9619-43aa-ab23-50d9b40d8eab"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("4e9eb1f5-5fb1-4bd5-a313-a2f94f5eb987"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("5357a12e-4f4a-4f38-bcba-0af86643151c"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("53777e55-fae2-4b1f-b46c-30276efbba23"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("553abdd9-e0c0-4783-8425-5b2904b55ba5"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("5ce1e7b3-c6af-476a-bf98-9a7560362de3"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("617d8d7b-9e90-45c2-b8bd-d1aeea38d556"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("62e14b3a-a3e3-4698-a702-5534ca7243c0"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("63967f83-010e-46ff-b940-f2be93e92cbd"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("64c0bb7d-ce23-4a5b-8c3c-0152a3489731"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("66008bd0-fe47-452b-b632-ab50387e23a4"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("67a25d74-a2fc-471b-b9ab-4ac5ac8aca9a"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("6d73b99e-93e2-42c1-a735-d8159202ed10"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("71ec3886-9011-4dc2-bf74-ac521e890ba9"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("71f28f02-78ec-49de-a838-672de3137869"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("730b3397-a812-44ed-90e8-3da73b382842"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("77864514-3fc8-42a5-9342-b18184b68ae4"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("7bf16ab2-8e1b-4080-b6e1-34b81216de06"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("7fbdb46b-01fe-4bff-9da2-0f8e15e6f8bc"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("7fe77ab7-791f-4ecf-a24c-321c905da5ac"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("82804c54-4e83-41ec-ae4a-4b617d946c38"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("861cc60a-fbb2-46bf-b125-471959592200"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8bb69bd3-3260-4f0a-8309-e71aae8c4ed1"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8c7cf603-cbcb-4240-ac0d-de7ce219f2ed"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8d4a76ba-ef2e-4b02-af69-616284c557e8"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8eec7d7f-119d-4686-8f6b-ec16d177c031"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("97d8ba7f-8d3e-47f5-b34b-5a02b37d742e"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("9da8c426-241d-4a29-ba52-dc2340c70ce3"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("9e1ec3cd-8c25-4c46-b804-bed1aecae669"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("9f73cb55-e527-46ae-b135-1e39a0ee6741"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a2b56364-f458-44f0-9595-56ccdb34e31b"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a556b090-d5f1-4a83-bb99-7eac1fc9dd32"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a559ab85-402f-4d78-accf-ddf2cc802408"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a91696a2-9a84-40d1-987f-16f140a1889e"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("aa5dd587-9074-4b97-b45e-dfacda3d75e2"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ab5a0f20-a703-4761-ba81-d19140d23e61"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ad3e6aa6-16b8-4b14-908a-e46dbcbc3d9a"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("af399c73-4464-4ea1-bb96-125b33d25702"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b09ce400-a979-4dc5-a979-8bf52f976606"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("badeed9c-1f55-4ad5-bd86-7758d5f436e2"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("baff6090-e12c-4647-bec3-082d3f5a2c5a"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("bc79aa35-e772-4c09-8770-37bd907ecd0e"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("bcf36a21-3f79-4f2b-a479-c2cb64fec74b"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c12824dc-b2f8-4019-815a-846e1abe89e8"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c5282ed3-c808-41a8-b273-5ad37e5ec35a"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("cb170f60-7023-4106-a215-7dd5a33043bc"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("cbe90a70-2442-4668-8232-b2247351ef96"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("cfa4a663-00a0-4ffb-b7ad-bfec71bc6810"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d4bedf30-abeb-4f77-9714-318311a9131f"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d62ebf1b-bcfa-4062-8fb4-e04d1c003d12"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d8289cf1-2e04-4849-a3e5-fefce106f395"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d829f374-6846-44e7-af6d-bf81d4cc08b8"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("df0d0b3b-e821-418a-be03-988ba1042a0e"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("dfe954be-f4df-49c7-bd91-3745f5e5439e"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e27eb08f-31bd-4890-aaf3-4127c6936b82"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e48106ad-726c-4f93-8ac5-67f5d0ed1948"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e49a15a3-6acf-4af1-95f0-90a498d1f573"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e798b0c8-ea59-42c5-9059-a8fadd11519c"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e995b071-5bc9-4d66-b526-b0fc9e06a3c2"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ec13bb8b-bd56-4da3-b26d-b4efc1588ad8"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f05e4ce6-815a-4799-b07f-fa2ebb24fde6"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f3edf26b-24c4-4292-8dcc-4279080623c2"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f4b70234-f51b-4f21-ae94-7e9ed0d63113"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f73d7917-9b64-4404-8dc3-667f51cc7bf7"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f9b9a86f-2900-4bfe-abb4-6bfbd0e871e9"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f9deeb6f-8ca9-42f6-a12d-13f90440fccd"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("fbb6a63f-b67b-44c2-b525-5bb6a99bb52d"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("fc98dcdb-bb0b-424a-a314-a737846bc6f2"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterviewerAccounts");

            migrationBuilder.DropTable(
                name: "Interviewers");

            migrationBuilder.DropTable(
                name: "StudentAccounts");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
