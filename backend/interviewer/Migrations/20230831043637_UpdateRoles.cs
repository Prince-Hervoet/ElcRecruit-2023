using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace interviewer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("01fc0e8e-df88-4ad2-bc2e-2b96b6b74f08"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("03319559-a12a-4e32-abe3-94c21dbf1d5b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0458f26a-f5b1-43f7-a3f1-45e8c6b7d99f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("045abdd6-ff8d-487c-a624-8536a3f06a8b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0d75bd2e-9195-4350-a28b-fb787bf8147e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("16e15e93-7aa3-4588-9917-a1a3142974ab"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("17122ee4-fd5a-4aaa-94cb-461b6686dc2c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("19f1a0b2-70a7-46ad-8170-2efe9c7cf412"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1b638c6a-9438-4a09-a0fb-95964964f055"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1d5d8da9-224f-426a-9b40-38f5f8ad5107"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1ed322a0-7f04-4cf2-97b7-f14377ebd0d4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1f7fb796-5828-430c-b7ff-35dcf2a976ff"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1f99c229-2792-4d1d-bc64-543a880e358b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("227f6d27-a569-43f1-b070-7506e7d71b28"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("243a43a9-c3eb-4ffb-8461-5a02562825e4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("30ee1afd-9533-4070-be03-7b07cf80b25e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("32cf7b1f-3b8b-420e-86e0-8e7248e639fb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3562b333-fe88-4bf9-b7d1-182f24ef8896"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("35feec4d-ccbb-4fd6-a29f-565152acf5aa"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("369ef227-c917-4449-8c0f-464f2f004fb3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("38fb90cf-164b-44f2-80ac-a888f672483b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3b7a44ec-afae-49c1-af74-dcd2005cb1b6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3dddd41f-f568-4c37-8805-68be01cc333c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("443752c5-3d3a-4a0e-aab7-9084e6c9a1ea"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("47b84575-981e-472d-8a2b-a4166e6f0b82"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4994e296-7207-4e6d-a60e-3edd095244f8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4b37d3b0-64da-46da-bfc4-9ae7733fda43"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4cb6162b-3f93-4ce0-828c-c4b2834c58b5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5916c495-6f87-4aff-9242-b2a8f8f14d7a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("606ff42f-ada3-4c30-b068-84121e0c5683"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("60ebc69f-cab4-4d21-8a3a-77560694c7d4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("631b5757-64eb-47aa-b581-ea3a87b43fe6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6dbaeeeb-a61a-402c-8531-1f4e7d592a24"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6dff981f-4933-48fd-8cc4-93a960d1f907"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("75af736a-b0da-4dbe-bfc8-1b01512f182b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("75cc7b94-f1b3-4bf2-8e3d-2db28fd330d9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("76239523-3c5c-4460-b4c9-42d5b512b7af"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("776a95ec-1a30-4dcb-96d0-4fb34477e3ef"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("782e2a40-c43e-4321-bb19-99de1d8f0dc3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("79da8e7b-6632-4929-a742-49a6b94fbb39"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7a11dcf1-b2ae-4fe2-8454-6816cd262880"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7aded075-b86c-438b-a34c-4e40395e3003"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7f2dd864-3634-47e3-8f54-e398c1456b51"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7f4bcb1c-9b88-4fe5-9d24-f12f0a9f5a07"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7f53ca1c-1ed1-4959-839e-c2a6c2ae9946"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("84271435-ebb3-4bc3-98c6-35c3f9091e00"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("874999ac-902f-481a-8fa0-49fe1eab5303"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("87ec8397-705e-445e-b775-a6134ed26741"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("886d9226-ee57-4288-a35a-e880119ab167"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("888b5f0a-fcab-4b2d-9b1e-32cb894f3f3a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8c2fcc2f-38b9-40d2-8447-7aac0f254fe6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8d14e2f6-9437-4bea-9389-18d8fe8fd0d9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8efa5fcb-c24c-4dc6-8afe-665316ada551"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8f102b11-2e59-4042-8143-ee9908d705da"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8f28b820-d1a5-4ea1-a34e-88b121f9bdfa"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("94922748-7d28-487f-8566-d375637b2d44"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("973e6431-f252-4209-b925-7b9150adeba9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("995f9323-5f15-4343-8a7c-33321b03070d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9b68f913-a437-47c2-b866-005f3d9d109b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9c9f75c6-3fda-4497-861e-1eefd50a9648"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a4f77ab8-4136-42f0-9aa2-5d80ffeab4cf"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a695b11c-1f35-4fcb-b60f-6ffd04601380"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a748692f-792a-4521-b322-7ee2e6cf110c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a914370a-fcc6-41c7-ad0a-2c6b3a88d0b3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a982bcdc-e158-400a-866c-c03a936193e0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ad9c32bd-3639-4e64-8a38-37fe8a26675a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b2388e9f-f805-467d-99aa-143d710bdb68"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b46fa810-7eaa-4652-b570-31d8a0b714a6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b64902ac-6757-4bc3-b226-68dbc4e56adc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("b9adb1dc-809f-4e6a-8826-39d3fe8a5b02"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("bac35c0e-d6df-4641-bbae-870427770117"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("bfad5c41-72a6-4fd2-821a-6abf827feb94"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c1c902b6-1ad5-4132-af43-b7050b055cb9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c679380d-bd3e-4647-9acc-c6279c74518c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c778096d-8edb-47ba-9e17-dd5dc988da15"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c8b1283b-1c8c-431e-aca6-60d137b3db6e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("cf14c201-14b6-4df4-ad07-74c1e2c4a710"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d04f585b-b052-46e3-a208-8e37cb438421"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d39de320-b5d7-4f18-bcda-b4a3c3273adb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d574d671-b3b7-4487-a657-cecca1331046"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d65937f5-cd1b-426a-ac17-d9d22bbcfca1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d68d5307-5a3b-4f16-8030-7c0b010d1d38"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d9d1c963-4272-4622-b643-8017a0bae8ed"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("db217512-7ed0-4601-ac1c-540f0a602ec2"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dff4752e-b471-4b01-98e2-844727bf3b47"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e1612391-1c2c-41fd-afe3-11a67fe283df"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e40ba8af-3e45-4295-926f-becc09d552fb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e42d57b4-691b-4668-88ed-d08b983c3b06"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e6ee281f-6d8e-45bc-aa03-c08ccae63c02"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e7081d69-ad53-4652-97e8-8ad2ba31f35c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e7e05273-8edf-4120-af9b-b551c9b1365b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ef87c959-ee98-4fa3-926a-8253ffd256f0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f0199003-47bb-41ad-9524-1da7261a4800"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f063240f-e57f-4d17-bb2e-0fced9975863"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f2f38962-280e-4ea9-91c4-19ea5feb7ea8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f363d929-7bb6-4979-b2b5-2ee2fdbcbd8d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f985147d-5c20-4a0d-b28a-dd23bc479834"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f9d5d15e-985c-41fd-9315-150baa5998b1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fab1401a-cca2-4ebc-9d21-3fb744a6e73f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("feab0340-d2bd-4eff-96f6-08bbafd4342a"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
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
        }
    }
}
