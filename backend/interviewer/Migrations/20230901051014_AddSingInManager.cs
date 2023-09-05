using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace interviewer.Migrations
{
    /// <inheritdoc />
    public partial class AddSingInManager : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterviewerAccounts");

            migrationBuilder.DropTable(
                name: "StudentAccounts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1ff75dee-9346-43fa-a975-1f561a7deab2"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b63f7c2d-4172-4016-8a1a-f594f621e9c1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ce0156f1-1293-4e99-b1f3-4f3cc84713da"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("051bb7b7-c3d0-49ba-8c5b-2a06b1f5f2d8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0a71e2a0-d6fd-499f-9c4f-689a504f4762"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0b064738-e640-4836-b533-4bf5977f7d26"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0bce99b9-ebcd-4c88-8b09-e75e7ff02084"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("128fba97-5b17-45a1-9f6e-5390cc991b27"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("12b0f689-a47a-40f1-818a-a63f1e22ce66"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("12ccbe4f-eecc-41b5-875a-e728ead133e1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("14417579-7fba-4052-9fa1-1910b3d62a56"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("193c011e-39c7-4113-9077-8d73d7761a31"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1aa337dc-03fe-4df0-83ad-816aab6b9915"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1beeae0e-cf89-4c65-bd3f-a06232d66954"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1f18f0f2-7a8b-44af-9ff9-2485d320ee12"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("21ff3d77-627e-418f-90d8-f118cc4cd80d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("24a2b3db-00ee-4296-9f3c-384c9b01ca59"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("28a7995e-db42-47b9-a648-de8ae33c051a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3193d1e8-c02b-4fe2-8342-30ef18d74940"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("33af5166-fb5b-43e4-a7e2-80e4b5679077"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("371c2eb0-52b8-4979-ab7f-d92e131b09ed"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3922fe2f-1949-4431-ba7a-55d778e94b83"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3c060deb-1278-418b-854e-8e602371d35d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3c58f026-cf60-4c14-9596-f6c00c3b1503"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3dfeaeec-5b9b-4a75-b8ba-60309d6b8c28"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3f92efa2-6b4e-4c4d-a0cb-1204adf6cdad"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3fd1bd24-adda-41b8-a149-920e3790ba6d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40032199-4acc-42a6-819c-c62e1c34b40e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40615c66-76b1-45a7-9970-b85841ae9d24"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40e911ea-1815-4df7-b6d3-f666f0a9604a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("454eb92d-9a6a-4de2-832c-c8cb859d902b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5100f01a-7fb8-4b3d-b1bb-97022c2079fa"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("54a9decf-a0d5-4d94-916a-c385e725ff20"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("55f5987b-fb5a-4674-b077-a1d82c37eda4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("58bc228a-bc04-432c-b1a8-b0532d20c22b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5c521ce3-19bd-4ca0-a022-908d5756690f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5d3d03b5-06bd-49e6-ac16-8f9671ee238c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6343d11f-89c5-4da0-b6f2-b9bc36d49b95"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6990c9e4-43b6-48d0-83f3-027b9e069f15"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6b15c18f-f2b8-4b5c-b0aa-08543ce40fa4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6d28e9c6-47b6-4d54-b90b-482f99bce79c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6e20aac2-24b4-4018-9033-d886c85ad33f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6f28e6ae-fd40-4985-92b8-bdfd521845d6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6fcd63de-e9b0-40f1-bc72-a07a2eb7c353"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("716b6af4-d6e1-41ba-a7d1-12c836b385d0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7b59cd00-7021-428c-b99e-d08af8ec6409"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7e4ebea1-ec9c-4388-baa2-9439b457db95"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("838a19ec-f872-4f49-8ba0-e719dfc66898"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("852757eb-233f-4820-ace0-a5d206fc61fd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("853ff7b7-cfe8-4d41-80e9-39f23f71f247"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8613f4ff-c997-45f0-a39c-03d461f0b84d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("86c28181-79e0-47ec-9d38-481eef0c05d1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("86d1e4fe-182c-4d8d-b2cd-c095fc6edc38"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("89f2e417-5724-45c2-a4c5-248556bdc134"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8d200d64-bea7-444a-92b7-f00e7a9e78ac"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("907237ec-2291-4644-9870-4aed96f6fe16"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("917eb1d2-6135-4869-bdc0-95b0ca5d439c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("92778e71-9698-491f-8a7c-715fda753b68"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("94590279-538a-4a8b-adbe-062cc22586f2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9bffe19d-6d51-46a1-8d17-853499df6e3e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9d7c1f76-601f-4fa5-ae87-099be7db13a4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a1643251-93c4-4ec7-b230-15ad00017d79"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a623774d-afc1-462f-8719-ff127ff8b0e2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a8e4d2fa-f33b-4f55-9d69-4c3854fa827d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("aa0863e0-2e24-4879-9902-b9d899183037"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("aa4f0d31-6a76-4b3d-b3ac-1ca66ee84ce5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b1ed936b-d896-4f44-87c2-f36f460a0066"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b373615d-dceb-4e37-9229-33d52a17bcc5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b67e3cfd-c739-44a3-85d2-2bb9ea0503ef"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b6a06f8e-e707-47a3-845c-507443cbf0ee"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b75d8743-8f80-4789-900c-2621f01aeab7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b84b7b18-41a2-4013-9773-6cf32f5a1244"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b8cce48e-90e2-4518-861f-6953f6d82680"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("be1658ed-3370-4e23-bc0d-20db98d45b99"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c048fcc7-7056-444f-ab91-9198c621be98"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c3517b6c-0aa1-4a6e-81e8-316b182038f0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c84a7e71-8fa7-443d-a81a-dbd5d113ef81"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c9bf18fd-2ed0-4618-96e8-ed4d2c3ac617"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ca76dc0e-432e-42b1-b676-d2208464aed3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("cc60d8f1-ed4b-42de-ae1b-d9d8b860cd19"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("cdeab141-92d0-4d49-924f-a6259e1cc4e4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("cdf13dc1-573d-42a5-8483-8a13f502108c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ce90517b-b198-49b9-8262-740366f5cda0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("cecdb11e-9512-48d3-b05b-36d2b71e31e2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d2e4825e-cc5c-4a16-8eee-2ef200cbf693"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d353ea4d-211e-4113-bd2c-be33dadf25ed"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d60b1ec5-778e-4064-a36f-0e31dbec1ea4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d6828423-4610-4ebe-908c-e76f4c6adf46"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d994adbd-e346-4746-a5b0-a00a213931e1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dc814079-4ad6-490c-bb49-3ca539a23eeb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dd3f407b-de6d-40e3-9517-5f3c1775b9a6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dd909617-f98b-47b2-8783-b0ab690dba7b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e5b70da9-5713-4858-84ef-ec233b21ade1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e6c78b16-17cf-4d98-a97c-adabf9de7eb7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e9738cde-9ef8-4d9f-a964-4024be2b7bee"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e9f52f7f-03de-4689-954d-3c20485e594c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ec5a826f-d899-4e94-aa67-8dc3a28be275"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("edaeddc0-f7bd-4456-913d-deba5b33c456"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f54c4812-1c3f-4538-8ec0-8bfd65a01e12"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f7a86267-ccc3-467b-9c58-55f6d4fc472b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f9720e32-fe1e-4db1-9b29-c2038a938b29"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fbb26032-a4b0-48ad-8858-41efe0c87279"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fc9d5405-f9f7-47e3-9a8e-19f4c812da25"));

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InterviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepId = table.Column<int>(type: "int", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("48622ea5-0d59-4e9e-b9e6-47db128533bf"), "16a87b09-7a52-47fd-a1ae-5551f13acdc0", "Interviewer", "INTERVIEWER" },
                    { new Guid("acd3e7f3-f42b-4ce4-812d-f86f8afc2ebd"), "c593ae35-84e9-4271-8df2-d296b423724b", "Student", "STUDENT" },
                    { new Guid("bf3b5dd6-263b-44c5-95d5-0392d4855eea"), "ffdde4fd-6055-46af-899e-9fe68601342a", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "College", "FirstDepartment", "Grade", "Introduction", "Name", "Phone", "Qq", "SecondDepartment", "Skills", "State", "StudentId", "WeChat" },
                values: new object[,]
                {
                    { new Guid("0e7b7915-c34d-47a8-b756-136c49a87456"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1055e179-d80c-469a-b172-1341fa1969b7"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("173aeadd-2f7c-4dfc-bbf9-b3c52d8edafe"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1847dd74-8979-4ef5-946e-345a95564636"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1b9d779a-0539-4f4e-bf56-5e56c66afa3f"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("21bd5db3-0e23-43e8-9097-fc26789f6d78"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("21c9d77d-89f1-4924-869b-d4f8523bf95a"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("264d0ebd-821e-4569-b8d1-67f519f17566"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("267a9851-e49f-4947-b8c5-f67809800e71"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("298014f7-c166-417c-81f7-41152cb0051a"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("29b03e2f-be45-480d-bfc9-b96e88957d66"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("2f71e53a-b749-4960-92f8-ff317c982b05"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("32455910-2279-4571-a84a-fc5cacdb1ad8"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("327ac977-5432-45f5-8b9f-cdbe5756e80c"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("343be415-3044-4302-a52d-d98b4f089181"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("357217a3-9e72-4fbc-9250-3b86038accb9"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("35e2ad47-cdd7-4523-b6c0-c9942b27b052"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("462783ac-197e-477c-9bd4-8b75c52b5c91"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("47126ab3-a520-46cd-ab89-704280f353f0"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("472985fa-5daf-4c0b-bb17-f0ece22a4e4d"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("4b7a1611-96cd-440e-94d1-379c28af5713"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("4be1161c-35e5-440f-b03a-bfac94799946"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("4c386985-cef4-4345-9321-d07697f3543e"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("51489cf5-48d3-4a23-8ad7-ae74b33d2e10"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("51be9d74-f8dc-4b98-b41c-5fcca5345569"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("5215e686-fc0e-47d6-8e7c-e5e0dbab9794"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("5234d693-bb18-4236-ac77-3c1a80ec94fc"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("53b8d57e-eff6-4b50-9420-6f04ec63ee62"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("56a546ef-8444-4d0d-afba-1fa71fbf22d5"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("57862187-77f9-4614-bb1e-c193a3638ce0"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("5a143dc9-c115-44c5-87ee-903b7b40e314"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("5b22577c-c725-45bd-9d5a-af7929fb0066"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("5b7c4757-ae7b-45cd-b363-9a43043ad89f"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("5d6edd33-be63-4efe-8aa5-ae1357535bf5"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("60eb1ab1-c4b4-4385-9cff-9371affc8c09"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("61dacfce-f54e-4249-97c7-8c849db20f43"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("68a5fde2-206c-4ce5-b5b1-3cd87e2afb3b"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("69f5a84c-2a91-4996-96d6-ef5e4c474df9"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("6bef99ae-9cbf-4da1-932d-61f5a5494bbc"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("6f560cdf-9a8d-46c9-af09-90bab3dd5c49"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("6fd4c29d-a71f-4f18-a14a-a3e2823bc764"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("70e2a3bf-0c2c-4a5a-a737-3a774ffbc0ae"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("75f38c44-f5b6-4e5c-9f48-6836e96d50d9"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("761f871a-f960-4f61-9102-1f996d3bd545"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("764484f8-7906-42da-afbc-c75137442aa6"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("7978f100-8757-42e8-b4d3-c62e0b684fad"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("7a4ce336-a3dd-48d0-a86c-18e39ab82f87"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("7b61225b-90d2-40a7-b85f-a8cdddbfb2de"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8a77c3da-ff73-4c61-bfd1-f6ef77dc53ef"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8a86aaac-66db-4de7-8821-f284a9a5d40e"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8c5f5a6e-8517-4237-979a-8b069479f18a"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8cf0084b-0e1d-4a27-ab7a-8b9653a12539"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8fa56ad6-3587-40e2-a92d-a0c2e5f25146"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("9057f65d-26a3-4134-8b16-cf488b4c467b"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("90b31671-648c-436f-97e1-fb57bd5b80ac"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("925df3ae-499a-42e5-9e97-601adf8f4327"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("9288b6bf-6e8e-45da-8e38-1427b4e038f4"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("9ac42ef5-db80-4541-ac73-a6d092b4f3a6"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("9acb730a-9512-4797-8ee5-2247946bd8bd"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("9c7b1437-dd03-4c77-b7b1-6523a854879b"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a805ec5d-37fa-4ae9-8a9c-4b7771fcf25c"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a9b385df-949a-42df-a3da-b2fd8e48315b"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("adf4d890-66b1-461c-bcf7-ec3df14a2a0f"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ae07e84f-0d32-4c7d-a830-d4252cb18522"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b3db3685-25e3-488d-86dd-f53a78766cc9"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b656e414-6af8-45f5-9c2e-ddef924ebaad"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b7e0eeef-b956-4197-8c4f-72d0df0f48b6"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b90c25f1-93a5-4a72-ad0f-310be0a6966f"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ba562f18-0e19-4f3c-a588-90eee47579fe"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("baa5d3e1-05a7-4bfa-bd23-b82d4eee1706"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("bcff8031-bf0b-4a8c-8653-31127f2ff648"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c018a7fd-3320-41c6-90b8-42955667665c"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c10f48f1-c37f-4d74-b3e1-8c0caa23ea9f"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c17f0ec5-e28e-424c-96bf-9e3ed03d15f2"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c3ab51e5-4c97-4242-8382-af6670d0f2ad"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c4054f7a-841f-4615-8116-49f610d27182"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ce7a1e3b-8d43-4806-b9b9-c7804e67d373"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("cf447d2d-c56f-4bce-be6b-30d963ab6568"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d0b165d9-9edc-4377-87b3-6078e7e4f54a"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("db3dcbab-7c3c-4b2a-bd05-9a5f1318699b"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e04e762b-3110-46b7-85a0-4c0b9014a6f0"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e1319eb9-9645-46db-b934-ab5602a86cc2"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e1e5e404-3a76-41e2-ae96-42834526a59e"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e367fd46-a737-4b61-b4e9-de169c95e783"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e641e9a4-6786-4a1c-86d3-3b45caa923f8"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e6fa3fee-3649-4829-82ac-c7aa3ab94fc5"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e891b704-4c76-4b00-991b-ba848493e016"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e9a49d45-b755-48a9-aafa-88746de1317c"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ea7cb714-c023-41c4-ac56-6bd0b7ba5768"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ebfbffda-b66a-453d-9a73-8068527be841"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ee6c045c-0c7c-427b-9828-4b20aab99678"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("eef8891d-b789-4a28-9cca-202077d6766b"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ef1f7bf5-bf35-4112-a116-e695e56a5454"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f20a8df1-18ea-459f-80e4-dce2a8f0fd56"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f250bd8a-6d4b-4a63-ae7c-fbfb93c01cc9"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f49e2403-dfca-44ed-a7f2-c64c4126068f"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f4f074d4-2f04-4e73-829d-17d6b77cacbd"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f8ecb7f6-359d-43dc-afc1-0787ce00d873"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f93ab696-0429-4a29-acba-9b5f2de2fd6e"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("fd7536e6-f6b5-4b30-a0ed-dffdfaf615ee"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("48622ea5-0d59-4e9e-b9e6-47db128533bf"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("acd3e7f3-f42b-4ce4-812d-f86f8afc2ebd"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bf3b5dd6-263b-44c5-95d5-0392d4855eea"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0e7b7915-c34d-47a8-b756-136c49a87456"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1055e179-d80c-469a-b172-1341fa1969b7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("173aeadd-2f7c-4dfc-bbf9-b3c52d8edafe"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1847dd74-8979-4ef5-946e-345a95564636"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1b9d779a-0539-4f4e-bf56-5e56c66afa3f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("21bd5db3-0e23-43e8-9097-fc26789f6d78"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("21c9d77d-89f1-4924-869b-d4f8523bf95a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("264d0ebd-821e-4569-b8d1-67f519f17566"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("267a9851-e49f-4947-b8c5-f67809800e71"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("298014f7-c166-417c-81f7-41152cb0051a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("29b03e2f-be45-480d-bfc9-b96e88957d66"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2f71e53a-b749-4960-92f8-ff317c982b05"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("32455910-2279-4571-a84a-fc5cacdb1ad8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("327ac977-5432-45f5-8b9f-cdbe5756e80c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("343be415-3044-4302-a52d-d98b4f089181"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("357217a3-9e72-4fbc-9250-3b86038accb9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("35e2ad47-cdd7-4523-b6c0-c9942b27b052"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("462783ac-197e-477c-9bd4-8b75c52b5c91"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("47126ab3-a520-46cd-ab89-704280f353f0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("472985fa-5daf-4c0b-bb17-f0ece22a4e4d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4b7a1611-96cd-440e-94d1-379c28af5713"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4be1161c-35e5-440f-b03a-bfac94799946"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4c386985-cef4-4345-9321-d07697f3543e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("51489cf5-48d3-4a23-8ad7-ae74b33d2e10"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("51be9d74-f8dc-4b98-b41c-5fcca5345569"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5215e686-fc0e-47d6-8e7c-e5e0dbab9794"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5234d693-bb18-4236-ac77-3c1a80ec94fc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("53b8d57e-eff6-4b50-9420-6f04ec63ee62"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("56a546ef-8444-4d0d-afba-1fa71fbf22d5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("57862187-77f9-4614-bb1e-c193a3638ce0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5a143dc9-c115-44c5-87ee-903b7b40e314"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5b22577c-c725-45bd-9d5a-af7929fb0066"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5b7c4757-ae7b-45cd-b363-9a43043ad89f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5d6edd33-be63-4efe-8aa5-ae1357535bf5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("60eb1ab1-c4b4-4385-9cff-9371affc8c09"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("61dacfce-f54e-4249-97c7-8c849db20f43"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("68a5fde2-206c-4ce5-b5b1-3cd87e2afb3b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("69f5a84c-2a91-4996-96d6-ef5e4c474df9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6bef99ae-9cbf-4da1-932d-61f5a5494bbc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6f560cdf-9a8d-46c9-af09-90bab3dd5c49"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6fd4c29d-a71f-4f18-a14a-a3e2823bc764"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("70e2a3bf-0c2c-4a5a-a737-3a774ffbc0ae"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("75f38c44-f5b6-4e5c-9f48-6836e96d50d9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("761f871a-f960-4f61-9102-1f996d3bd545"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("764484f8-7906-42da-afbc-c75137442aa6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7978f100-8757-42e8-b4d3-c62e0b684fad"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7a4ce336-a3dd-48d0-a86c-18e39ab82f87"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7b61225b-90d2-40a7-b85f-a8cdddbfb2de"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8a77c3da-ff73-4c61-bfd1-f6ef77dc53ef"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8a86aaac-66db-4de7-8821-f284a9a5d40e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8c5f5a6e-8517-4237-979a-8b069479f18a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8cf0084b-0e1d-4a27-ab7a-8b9653a12539"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8fa56ad6-3587-40e2-a92d-a0c2e5f25146"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9057f65d-26a3-4134-8b16-cf488b4c467b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("90b31671-648c-436f-97e1-fb57bd5b80ac"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("925df3ae-499a-42e5-9e97-601adf8f4327"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9288b6bf-6e8e-45da-8e38-1427b4e038f4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9ac42ef5-db80-4541-ac73-a6d092b4f3a6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9acb730a-9512-4797-8ee5-2247946bd8bd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9c7b1437-dd03-4c77-b7b1-6523a854879b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a805ec5d-37fa-4ae9-8a9c-4b7771fcf25c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a9b385df-949a-42df-a3da-b2fd8e48315b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("adf4d890-66b1-461c-bcf7-ec3df14a2a0f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ae07e84f-0d32-4c7d-a830-d4252cb18522"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b3db3685-25e3-488d-86dd-f53a78766cc9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b656e414-6af8-45f5-9c2e-ddef924ebaad"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b7e0eeef-b956-4197-8c4f-72d0df0f48b6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b90c25f1-93a5-4a72-ad0f-310be0a6966f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ba562f18-0e19-4f3c-a588-90eee47579fe"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("baa5d3e1-05a7-4bfa-bd23-b82d4eee1706"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("bcff8031-bf0b-4a8c-8653-31127f2ff648"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c018a7fd-3320-41c6-90b8-42955667665c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c10f48f1-c37f-4d74-b3e1-8c0caa23ea9f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c17f0ec5-e28e-424c-96bf-9e3ed03d15f2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c3ab51e5-4c97-4242-8382-af6670d0f2ad"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c4054f7a-841f-4615-8116-49f610d27182"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ce7a1e3b-8d43-4806-b9b9-c7804e67d373"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("cf447d2d-c56f-4bce-be6b-30d963ab6568"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d0b165d9-9edc-4377-87b3-6078e7e4f54a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("db3dcbab-7c3c-4b2a-bd05-9a5f1318699b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e04e762b-3110-46b7-85a0-4c0b9014a6f0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e1319eb9-9645-46db-b934-ab5602a86cc2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e1e5e404-3a76-41e2-ae96-42834526a59e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e367fd46-a737-4b61-b4e9-de169c95e783"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e641e9a4-6786-4a1c-86d3-3b45caa923f8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e6fa3fee-3649-4829-82ac-c7aa3ab94fc5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e891b704-4c76-4b00-991b-ba848493e016"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e9a49d45-b755-48a9-aafa-88746de1317c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ea7cb714-c023-41c4-ac56-6bd0b7ba5768"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ebfbffda-b66a-453d-9a73-8068527be841"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ee6c045c-0c7c-427b-9828-4b20aab99678"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("eef8891d-b789-4a28-9cca-202077d6766b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ef1f7bf5-bf35-4112-a116-e695e56a5454"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f20a8df1-18ea-459f-80e4-dce2a8f0fd56"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f250bd8a-6d4b-4a63-ae7c-fbfb93c01cc9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f49e2403-dfca-44ed-a7f2-c64c4126068f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f4f074d4-2f04-4e73-829d-17d6b77cacbd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f8ecb7f6-359d-43dc-afc1-0787ce00d873"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f93ab696-0429-4a29-acba-9b5f2de2fd6e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fd7536e6-f6b5-4b30-a0ed-dffdfaf615ee"));

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1ff75dee-9346-43fa-a975-1f561a7deab2"), "12e74a3c-9833-44b9-aa94-770325aae6f7", "Interviewer", "INTERVIEWER" },
                    { new Guid("b63f7c2d-4172-4016-8a1a-f594f621e9c1"), "25c7af36-d867-4b5b-b0e2-477a45d30b34", "Student", "STUDENT" },
                    { new Guid("ce0156f1-1293-4e99-b1f3-4f3cc84713da"), "4c385851-d18f-4626-91f4-5b8244d0e47c", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "College", "FirstDepartment", "Grade", "Introduction", "Name", "Phone", "Qq", "SecondDepartment", "Skills", "State", "StudentId", "WeChat" },
                values: new object[,]
                {
                    { new Guid("051bb7b7-c3d0-49ba-8c5b-2a06b1f5f2d8"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("0a71e2a0-d6fd-499f-9c4f-689a504f4762"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("0b064738-e640-4836-b533-4bf5977f7d26"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("0bce99b9-ebcd-4c88-8b09-e75e7ff02084"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("128fba97-5b17-45a1-9f6e-5390cc991b27"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("12b0f689-a47a-40f1-818a-a63f1e22ce66"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("12ccbe4f-eecc-41b5-875a-e728ead133e1"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("14417579-7fba-4052-9fa1-1910b3d62a56"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("193c011e-39c7-4113-9077-8d73d7761a31"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1aa337dc-03fe-4df0-83ad-816aab6b9915"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1beeae0e-cf89-4c65-bd3f-a06232d66954"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("1f18f0f2-7a8b-44af-9ff9-2485d320ee12"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("21ff3d77-627e-418f-90d8-f118cc4cd80d"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("24a2b3db-00ee-4296-9f3c-384c9b01ca59"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("28a7995e-db42-47b9-a648-de8ae33c051a"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3193d1e8-c02b-4fe2-8342-30ef18d74940"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("33af5166-fb5b-43e4-a7e2-80e4b5679077"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("371c2eb0-52b8-4979-ab7f-d92e131b09ed"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3922fe2f-1949-4431-ba7a-55d778e94b83"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3c060deb-1278-418b-854e-8e602371d35d"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3c58f026-cf60-4c14-9596-f6c00c3b1503"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3dfeaeec-5b9b-4a75-b8ba-60309d6b8c28"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3f92efa2-6b4e-4c4d-a0cb-1204adf6cdad"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("3fd1bd24-adda-41b8-a149-920e3790ba6d"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("40032199-4acc-42a6-819c-c62e1c34b40e"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("40615c66-76b1-45a7-9970-b85841ae9d24"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("40e911ea-1815-4df7-b6d3-f666f0a9604a"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("454eb92d-9a6a-4de2-832c-c8cb859d902b"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("5100f01a-7fb8-4b3d-b1bb-97022c2079fa"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("54a9decf-a0d5-4d94-916a-c385e725ff20"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("55f5987b-fb5a-4674-b077-a1d82c37eda4"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("58bc228a-bc04-432c-b1a8-b0532d20c22b"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("5c521ce3-19bd-4ca0-a022-908d5756690f"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("5d3d03b5-06bd-49e6-ac16-8f9671ee238c"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("6343d11f-89c5-4da0-b6f2-b9bc36d49b95"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("6990c9e4-43b6-48d0-83f3-027b9e069f15"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("6b15c18f-f2b8-4b5c-b0aa-08543ce40fa4"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("6d28e9c6-47b6-4d54-b90b-482f99bce79c"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("6e20aac2-24b4-4018-9033-d886c85ad33f"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("6f28e6ae-fd40-4985-92b8-bdfd521845d6"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("6fcd63de-e9b0-40f1-bc72-a07a2eb7c353"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("716b6af4-d6e1-41ba-a7d1-12c836b385d0"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("7b59cd00-7021-428c-b99e-d08af8ec6409"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("7e4ebea1-ec9c-4388-baa2-9439b457db95"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("838a19ec-f872-4f49-8ba0-e719dfc66898"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("852757eb-233f-4820-ace0-a5d206fc61fd"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("853ff7b7-cfe8-4d41-80e9-39f23f71f247"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8613f4ff-c997-45f0-a39c-03d461f0b84d"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("86c28181-79e0-47ec-9d38-481eef0c05d1"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("86d1e4fe-182c-4d8d-b2cd-c095fc6edc38"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("89f2e417-5724-45c2-a4c5-248556bdc134"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("8d200d64-bea7-444a-92b7-f00e7a9e78ac"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("907237ec-2291-4644-9870-4aed96f6fe16"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("917eb1d2-6135-4869-bdc0-95b0ca5d439c"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("92778e71-9698-491f-8a7c-715fda753b68"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("94590279-538a-4a8b-adbe-062cc22586f2"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("9bffe19d-6d51-46a1-8d17-853499df6e3e"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("9d7c1f76-601f-4fa5-ae87-099be7db13a4"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a1643251-93c4-4ec7-b230-15ad00017d79"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a623774d-afc1-462f-8719-ff127ff8b0e2"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("a8e4d2fa-f33b-4f55-9d69-4c3854fa827d"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("aa0863e0-2e24-4879-9902-b9d899183037"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("aa4f0d31-6a76-4b3d-b3ac-1ca66ee84ce5"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b1ed936b-d896-4f44-87c2-f36f460a0066"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b373615d-dceb-4e37-9229-33d52a17bcc5"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b67e3cfd-c739-44a3-85d2-2bb9ea0503ef"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b6a06f8e-e707-47a3-845c-507443cbf0ee"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b75d8743-8f80-4789-900c-2621f01aeab7"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b84b7b18-41a2-4013-9773-6cf32f5a1244"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("b8cce48e-90e2-4518-861f-6953f6d82680"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("be1658ed-3370-4e23-bc0d-20db98d45b99"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c048fcc7-7056-444f-ab91-9198c621be98"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c3517b6c-0aa1-4a6e-81e8-316b182038f0"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c84a7e71-8fa7-443d-a81a-dbd5d113ef81"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("c9bf18fd-2ed0-4618-96e8-ed4d2c3ac617"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ca76dc0e-432e-42b1-b676-d2208464aed3"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("cc60d8f1-ed4b-42de-ae1b-d9d8b860cd19"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("cdeab141-92d0-4d49-924f-a6259e1cc4e4"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("cdf13dc1-573d-42a5-8483-8a13f502108c"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ce90517b-b198-49b9-8262-740366f5cda0"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("cecdb11e-9512-48d3-b05b-36d2b71e31e2"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d2e4825e-cc5c-4a16-8eee-2ef200cbf693"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d353ea4d-211e-4113-bd2c-be33dadf25ed"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d60b1ec5-778e-4064-a36f-0e31dbec1ea4"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d6828423-4610-4ebe-908c-e76f4c6adf46"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("d994adbd-e346-4746-a5b0-a00a213931e1"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("dc814079-4ad6-490c-bb49-3ca539a23eeb"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("dd3f407b-de6d-40e3-9517-5f3c1775b9a6"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("dd909617-f98b-47b2-8783-b0ab690dba7b"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e5b70da9-5713-4858-84ef-ec233b21ade1"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e6c78b16-17cf-4d98-a97c-adabf9de7eb7"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e9738cde-9ef8-4d9f-a964-4024be2b7bee"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("e9f52f7f-03de-4689-954d-3c20485e594c"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("ec5a826f-d899-4e94-aa67-8dc3a28be275"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("edaeddc0-f7bd-4456-913d-deba5b33c456"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f54c4812-1c3f-4538-8ec0-8bfd65a01e12"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f7a86267-ccc3-467b-9c58-55f6d4fc472b"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("f9720e32-fe1e-4db1-9b29-c2038a938b29"), "计算机学院", 3, "22网络工程", "学生", "ChuHe", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("fbb26032-a4b0-48ad-8858-41efe0c87279"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null },
                    { new Guid("fc9d5405-f9f7-47e3-9a8e-19f4c812da25"), "计算机学院", 7, "22网络工程", "学生", "HeChu", "13323588435", "235247902", null, null, 10, "3122004832", null }
                });
        }
    }
}
