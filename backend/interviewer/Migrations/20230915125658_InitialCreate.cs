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
                    College = table.Column<int>(type: "int", nullable: false),
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
                    { "47d42f17-2d28-44f3-935c-f2666fd1a3c9", "c6fc95d0-e993-4e5a-bc67-bc350c089cf2", "Student", "STUDENT" },
                    { "6f969a94-0480-43c5-82e6-c2cd67bed243", "dbdc1774-4c89-4eeb-a696-d6ab2a3e7975", "Admin", "ADMIN" },
                    { "d6729882-bbe0-487f-aaaa-e98372122c88", "840791c6-d504-4bd2-83a1-d8f3be3c03ad", "Interviewer", "INTERVIEWER" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "College", "FirstDepartment", "Grade", "Introduction", "Name", "Phone", "Qq", "SecondDepartment", "Skills", "State", "StudentId", "WeChat" },
                values: new object[,]
                {
                    { "020a32a1-a0f2-47f0-8c3c-9f1195c79524", 9, 5, "RAKRTC", "818874298532276974618296", "BEBJGD", "14865109915", "0190772823", null, null, 10, "3596818598", null },
                    { "069cb493-cb98-422b-8f81-3482b55b69a8", 3, 4, "RWZ1W9", "987395754894788873441999", "OPKWA8", "99768676270", "7428156792", null, null, 10, "5529441711", null },
                    { "079be6c4-4442-4285-923d-419ca26e3a81", 18, 2, "KUOZV4", "501921503691225974515270", "K0201Q", "36616000766", "3704460235", null, null, 10, "4969528069", null },
                    { "0b850039-9ad0-4c57-8d7e-f95435b21b39", 16, 2, "AZ2K4B", "252778956137852044929564", "TL438K", "68431933350", "9443940204", null, null, 10, "5214539271", null },
                    { "0f684c56-5cfa-4d50-9e5d-77a368e4c928", 18, 6, "TDUINA", "937806942085989985539106", "ZYKSCG", "08443905328", "4537342505", null, null, 10, "1612679828", null },
                    { "118c613a-a771-4fbd-96c7-2f6688ba7470", 7, 3, "KQHYW3", "010734189222066919606992", "M2K8VH", "77037242027", "1790647040", null, null, 10, "8860366363", null },
                    { "1548cd1c-330c-46bf-abb0-b2d22e117298", 1, 5, "TQIZLE", "438526049745164143707317", "N41D0M", "69512972444", "6857928827", null, null, 10, "1246180280", null },
                    { "16d9a969-4ca6-4b13-8fca-85dd31674a57", 26, 2, "4JV9DG", "632212467216121941079416", "H1ERCR", "27024957382", "7527494613", null, null, 10, "7387096988", null },
                    { "187df503-811d-4ccc-930a-36d6a8d24047", 7, 1, "HB9VUV", "581672805948828995095413", "RQAU4E", "62933401614", "3476130030", null, null, 10, "2484421824", null },
                    { "18d4a90c-1557-4914-bf37-807a7dcb5aaa", 10, 3, "H052EO", "383692053186399989941612", "986HTX", "51543442220", "7541554740", null, null, 10, "8943512864", null },
                    { "1e20001c-575d-406a-a3a7-b6f5f99d4b4c", 12, 6, "OLWSCB", "516287386953380361273505", "X7NKQL", "65970753426", "5906040262", null, null, 10, "6300673580", null },
                    { "24cfc59c-1abb-4f34-92ed-b663115df507", 25, 3, "74ZJSS", "102351674037737208975329", "VZ3U1X", "34824102532", "7955843961", null, null, 10, "3728133642", null },
                    { "27dbca16-404d-4c64-8092-3bcaab0c1cd3", 19, 6, "E3ZDK8", "031352702716113599639337", "A9GGRQ", "62664535198", "9974183999", null, null, 10, "5473757486", null },
                    { "2d08a3d2-c3ca-45a4-9a73-0579598b9fef", 6, 6, "QH1BOF", "773441208053903125276724", "GOPDY2", "13516285983", "8918058612", null, null, 10, "3019223966", null },
                    { "31779b2d-d26b-4aec-aa26-ebbb28783f4e", 11, 1, "V7USGO", "132362847405248768056643", "EK5ZKD", "19660266525", "5631555210", null, null, 10, "1373173546", null },
                    { "32970ffa-5d60-42f9-ad8c-ea5aa4605168", 7, 3, "ZWTBLS", "483369112728314188563636", "QFGRNQ", "78345574588", "3683367210", null, null, 10, "6379166319", null },
                    { "33761a2e-13a9-487d-818b-923cf4a3dee4", 23, 4, "0VWLYW", "966642416469301433569404", "3A916D", "25422869130", "7005615273", null, null, 10, "7004034263", null },
                    { "3413c7f1-8c69-42a3-9b29-43d3a6e2de96", 22, 1, "X70E0C", "238070388976350680199787", "4VVH70", "60884223826", "4496627364", null, null, 10, "2858945596", null },
                    { "38c965e7-193b-4143-9409-7d9bd97ad51c", 10, 4, "NDIWCU", "373756468604982464458535", "Z1YM5E", "75193698488", "5480277379", null, null, 10, "8096801916", null },
                    { "3c99c018-ebef-4d62-a660-dd0810c7b22b", 18, 2, "YHNHDR", "916579769166651595365545", "9AXIDO", "47765680523", "2603539064", null, null, 10, "9016688178", null },
                    { "3cad81e9-fa83-4555-9e52-74488211f2fa", 19, 2, "7QDJ85", "253406658550986099216824", "PP8PEJ", "93442419817", "2659066151", null, null, 10, "4781893130", null },
                    { "3da715f4-907f-4888-aaeb-3a61b640de01", 24, 2, "3QN1TU", "311743802988666258574998", "E1N9X3", "22303999800", "9006826436", null, null, 10, "8754045558", null },
                    { "3f2ce361-9f67-4cad-85dd-fd51add30f5b", 21, 2, "UHE4N7", "011462648938888576815171", "HAJS97", "27006176701", "6221249066", null, null, 10, "7549701109", null },
                    { "45b8d3a7-43ca-44f4-9e39-62feeb50dd2c", 3, 4, "S0ZNY1", "840430537421176787612350", "QEH3Q1", "61182767449", "6557123267", null, null, 10, "1793617991", null },
                    { "460b6523-7bcc-478b-b7b1-9f499fb2a66f", 7, 1, "8HWLPD", "232871565622961424171573", "NVW8BQ", "38885130656", "2940100630", null, null, 10, "7784009904", null },
                    { "4b1b8df1-4efa-4dda-b3fa-d296e48fec4e", 4, 1, "IPP1O2", "983004551066397304918815", "C5T1HM", "50981889877", "4533973886", null, null, 10, "5613401040", null },
                    { "4c06e042-2877-43f1-bfd3-edab0dde4170", 17, 6, "SLTAIL", "956679812106911944872349", "NL8A8I", "98766918525", "9244889183", null, null, 10, "3828525829", null },
                    { "4d2210d4-cd27-4819-afde-a504498cf68f", 8, 6, "MQ9MQ3", "177878671969866200057477", "ON8O56", "54778076132", "9236114329", null, null, 10, "3888949057", null },
                    { "4f6e2d01-ea71-4046-935e-dd71b8f4c603", 25, 1, "43EHXS", "773839707245492221434466", "1DBSNN", "06398890109", "9334291606", null, null, 10, "0410147513", null },
                    { "54c7ae91-7206-4097-b31d-58b4efba117a", 25, 1, "YAU338", "811722220538885576831906", "8UCRO2", "18942327812", "8694327624", null, null, 10, "4894605092", null },
                    { "56574992-51e8-4b22-ad89-1a47fa940d77", 23, 1, "LJI7Y7", "212029711084474512134173", "JFMEXK", "10661796160", "8682007759", null, null, 10, "4661875741", null },
                    { "5dbfecb1-4a97-4702-b1a4-ebaf48b58633", 4, 1, "3D2JCO", "752075001493322028365058", "NG0QAC", "80193965019", "0963060892", null, null, 10, "6398336345", null },
                    { "5fd1c9db-ae30-4285-8725-9726baec3ea9", 13, 1, "8MHOO2", "866560812006017724182113", "O01ZY1", "89436775850", "6877624485", null, null, 10, "8460051480", null },
                    { "5fe39bcf-766a-4264-8e25-0b9064109dbd", 9, 5, "I78N6G", "845369709295631238559292", "I0UWGW", "12290221611", "1999471083", null, null, 10, "6017816547", null },
                    { "62128959-51e8-4134-a062-de716f922c44", 9, 1, "BHO5QG", "399119003194721100825118", "FX4KSX", "24563517032", "3648920496", null, null, 10, "4580130249", null },
                    { "655450f5-f33b-4a35-910d-60c407e3b388", 4, 1, "YUB0CI", "044493962262442511092611", "FUXOIX", "34498747007", "5897031453", null, null, 10, "2357654436", null },
                    { "65c9b713-ff12-4281-b671-449bd948c9c1", 7, 4, "PSWF12", "759440887720476616022880", "JYFMK2", "79625123792", "8618703619", null, null, 10, "8118450142", null },
                    { "6a4788ec-991d-47d1-bb0c-92039cfefb9b", 5, 2, "8F2JIM", "009341857463675051941861", "4YA9VR", "38319452340", "4593585325", null, null, 10, "4549628179", null },
                    { "6f30ba45-8cb6-4a9b-a655-ff2c3ab322c7", 13, 2, "PAHPKC", "598236679060371090514586", "6HY3XN", "03103469702", "6342702822", null, null, 10, "8960745928", null },
                    { "74b95ec1-e69e-497a-a52c-1a3296c73f8f", 1, 5, "P6H86H", "170705611280918247682660", "LVGA3D", "08581649127", "6095819404", null, null, 10, "5518248889", null },
                    { "7a6d5454-f923-40df-a8d8-9f6d31653975", 23, 1, "NYQ165", "931195552186702058062043", "4ZRMRX", "88301134635", "0399339503", null, null, 10, "6220026710", null },
                    { "7ac8e76d-637f-438c-a90e-de2d52c2300e", 14, 1, "LYY3U4", "159548834057533725011872", "NUIJO1", "26434843527", "8494055976", null, null, 10, "0877145704", null },
                    { "80671529-f38a-4ee5-830e-14540b379025", 13, 2, "OQDOYZ", "693102363172424558388106", "RFSVET", "38359088168", "2257270743", null, null, 10, "7207698412", null },
                    { "81c8574d-67f3-4b88-8ad5-23fd173d118c", 2, 6, "0RFEVT", "418186883297327417911364", "2Y44DF", "54888886576", "9882993246", null, null, 10, "1656173651", null },
                    { "8244566f-2db6-452a-a395-5884f32d7b17", 23, 3, "U5MET4", "899876453461636150073219", "VQQL1M", "49634257196", "0272599311", null, null, 10, "9591463159", null },
                    { "83468b51-c397-4422-b61b-0e600f3ad821", 7, 5, "RI1QGN", "874556406937115642801125", "BFQ2NL", "88479523434", "2948109478", null, null, 10, "6834795291", null },
                    { "862f3dba-dcee-4a9f-af7a-f2c2c0554f11", 17, 2, "NG6RG4", "190173917212402287735303", "H7GX5R", "14070317241", "6499619834", null, null, 10, "5650247707", null },
                    { "8bfc2c52-aef3-4f74-b36c-2fd3e2cb73cf", 2, 2, "EBED8A", "184239112029400879984050", "0T7BYT", "12363908320", "5204419471", null, null, 10, "3979425388", null },
                    { "92840ac8-74fd-4b43-9264-9bee659f9c20", 4, 3, "65PK7T", "518515515978276200075774", "K0B4LD", "66680452519", "9649544011", null, null, 10, "7311981808", null },
                    { "955a770f-3b13-441f-8626-d9bafe942bd3", 21, 6, "55IUJP", "549611097363824039007388", "O15F4N", "46449848738", "4244144966", null, null, 10, "5519092097", null },
                    { "9635ee7d-912a-4a33-9b87-130f46f0f896", 10, 4, "HOZA2C", "604321690767859997432178", "2EZZRF", "92929078067", "7555573590", null, null, 10, "1674705277", null },
                    { "978e9cdc-ab3e-426a-95ec-b88bfaf1980f", 9, 3, "8SK7BP", "734312160171180382569982", "UZTUDW", "65375047027", "7346563232", null, null, 10, "1267608523", null },
                    { "9aa2a878-629c-4009-8343-d8928b70125e", 6, 2, "G55IYB", "274590470412930822541852", "BS5K2C", "37406773353", "3994160690", null, null, 10, "9711986988", null },
                    { "9aaba1a5-d3ab-434d-a465-1df5594af361", 3, 3, "RVN9HZ", "830751292380190310629995", "R5BFUZ", "41088912198", "7758813005", null, null, 10, "0574501447", null },
                    { "9c4f72af-adf4-487c-82df-d2a8340e649b", 6, 5, "PL3KFF", "806254377499473167205676", "DSIF2E", "71877861575", "3119008077", null, null, 10, "8627483893", null },
                    { "9ebc38a8-efec-4e9b-bdc7-cebdfcd0d657", 0, 2, "X5UMSE", "254832062378087425865101", "FFXJ0H", "68825651710", "6847964468", null, null, 10, "2146032392", null },
                    { "9ecbd1aa-0783-480f-bab8-ada8bfe5bb85", 8, 5, "840RU9", "337819951673983208465226", "WKGVCB", "27580567975", "4611698666", null, null, 10, "1116340902", null },
                    { "a0825758-4f2c-4587-b45a-5a7f2fec0230", 17, 1, "2EQX7L", "234107695624342928444055", "Y388XO", "52095309761", "7243982665", null, null, 10, "8653047843", null },
                    { "a14c0c30-5100-4e98-b7c3-3398cea56af5", 24, 5, "EDKT8M", "261488420479098390083633", "CC5GNM", "49699436731", "4730178747", null, null, 10, "0265647708", null },
                    { "a26821bb-2ca6-4192-9922-0b7b0062fe11", 3, 5, "14X7PZ", "865170196125736584248639", "SID668", "47193682924", "6864889952", null, null, 10, "0230988598", null },
                    { "a5ce1730-6f1e-4252-8e63-f42167371c3c", 19, 1, "WXOMBD", "203363483575238435797384", "AG50C1", "91047592496", "8713697976", null, null, 10, "1951325317", null },
                    { "a5dccc17-00b2-4bd3-811c-7f66c3acd710", 2, 4, "ZS4P6F", "799710353878271809454211", "JBBPRS", "21656643961", "0834753972", null, null, 10, "2292586802", null },
                    { "a6bf2c88-c92c-4772-ba97-a0f98742430e", 9, 1, "YANRPG", "022665061854950991333766", "FMM8Y5", "25499672161", "2077939808", null, null, 10, "2947721518", null },
                    { "a83e388d-b8fe-4c90-871c-cbb785c321ac", 5, 6, "T0DJ02", "544509836592622243812674", "KW6T72", "68359558002", "0721195151", null, null, 10, "5112858273", null },
                    { "a8baa4ea-2d49-4bab-a900-98859d2eafe7", 14, 1, "JTGED8", "730969639673342341941377", "0TJUX6", "91912111610", "0841034941", null, null, 10, "6164099838", null },
                    { "acc71ef8-5235-40c8-b09d-89a236d31c5f", 10, 1, "W9NE7O", "092500667760702684785516", "KJGXC1", "56326739321", "0132875976", null, null, 10, "4349627522", null },
                    { "ad1b8320-4817-4515-bef4-e649781c368c", 19, 1, "994TAZ", "119564072480812517814928", "T8GSFH", "20106338527", "3342137308", null, null, 10, "7594674304", null },
                    { "afaee1ed-f73d-417d-a904-cb541043399b", 15, 4, "F77KO6", "564744268876374735250659", "DJFL8C", "75723871743", "9000954794", null, null, 10, "4115705421", null },
                    { "b383997e-b25d-4e50-96b0-e7ab720e3d58", 19, 3, "AIM66W", "929907250898142471574055", "WQ7Y47", "45815960625", "7115656835", null, null, 10, "6639653781", null },
                    { "b4e8a1ad-694b-4ecd-970e-58880ac942eb", 20, 3, "K9SSX2", "861284176705053531024559", "R85RZ3", "89248715877", "0627861846", null, null, 10, "1813974065", null },
                    { "b6e38bda-4319-4d9c-995c-27dd1c4220ef", 19, 4, "1RDS7D", "779344526629510432941173", "ETNZ0N", "48199277805", "0734836507", null, null, 10, "9752513427", null },
                    { "b8b215b5-59ba-47dd-bb82-38527b26f999", 0, 4, "3PAT0Q", "892433269251852233339057", "I46HD1", "28266309572", "2945710023", null, null, 10, "3154906690", null },
                    { "b9970793-6f9f-43d5-8499-e09355544fad", 16, 1, "3MEISS", "192356380679108616679436", "2GO6ZF", "08843747447", "4973567288", null, null, 10, "0188211877", null },
                    { "ba2d4543-5ddd-42e5-a4e1-ffe1bd6080b7", 18, 5, "W4IXM8", "586511930616945692057833", "IXU935", "75677790906", "9553084771", null, null, 10, "2942774371", null },
                    { "bd7f02b0-64af-4687-96b7-c46dcc5051f0", 15, 4, "4Y9TWA", "630331325585183186390300", "L4MJ6C", "05670718836", "0267402251", null, null, 10, "4921188658", null },
                    { "c302f43f-c9cb-4cfd-a71d-d3f681f91c93", 24, 2, "EIEBI1", "182922001185180178524974", "KAV780", "86173897878", "3461770198", null, null, 10, "8258159084", null },
                    { "c7f34004-1455-4671-a8f1-eadc9da11d50", 26, 6, "N3LXND", "144346526646062706445028", "FXJ2ZU", "90162000130", "5190612215", null, null, 10, "0665250382", null },
                    { "cc49815c-f4bf-4cf9-98a3-69c28710ef7c", 0, 2, "07E3C5", "346155228562528396140177", "3R6XBE", "47792311658", "3568394303", null, null, 10, "1331984186", null },
                    { "ce70638c-a9cd-4e3b-bbe6-31cb653256bc", 17, 6, "UEVJOH", "343361596376308000292435", "NKDNLO", "32335091717", "8061415862", null, null, 10, "3665116972", null },
                    { "ce7908ae-5383-4f3c-96a9-e51e25106921", 14, 5, "2ZF87M", "338193084331885015604416", "ZB94IE", "32221647710", "5773090085", null, null, 10, "9554010485", null },
                    { "d2262018-fe11-43c9-a78f-9b16146e8ce5", 23, 5, "D7FGEX", "625189576491855057899274", "1OGQ6G", "74423161149", "4632369566", null, null, 10, "4319069104", null },
                    { "d3ecdd81-6d33-4f52-8b1c-ca1244a2314c", 21, 5, "YZNBHR", "453723395892626544051137", "954CP4", "47553197523", "0440725512", null, null, 10, "8376292672", null },
                    { "d4b2a20e-ee5c-4e9f-ad13-ce267f9860bf", 12, 2, "4HAC4V", "248793000742994364917356", "GTP78B", "52596519160", "4070531215", null, null, 10, "7813648602", null },
                    { "d4b397a5-6958-45b0-8aba-3e25678f1daf", 0, 6, "5QQKTT", "605500045566203469148386", "7VTJUD", "95904159066", "3062966558", null, null, 10, "3856886793", null },
                    { "d8b7ca4a-d0e8-40db-911e-9cefcc808d87", 17, 3, "8PLQ4Z", "423961850273791954201992", "OPCGH1", "19919013295", "0039331934", null, null, 10, "5780912946", null },
                    { "d9e007c0-014f-47c7-811b-ffd044b8c91d", 6, 3, "SOZMTP", "663937956432230132193956", "C668VB", "22205659091", "0675785407", null, null, 10, "9728585795", null },
                    { "da104aef-036e-4fec-934a-76ef963ee637", 2, 3, "K4UMWG", "379431378050796272119608", "ROWBKK", "16382121704", "6965668560", null, null, 10, "9809426128", null },
                    { "dbd80029-a714-432a-abe5-5342caddd8cc", 0, 6, "RSNCDC", "211109580389328282548758", "5XBYR3", "60039155750", "1456099853", null, null, 10, "0717825697", null },
                    { "dc3b74c2-c68d-4250-a8ea-49752279e9c4", 12, 6, "AUJRRH", "622901119700760033941646", "DFTRL1", "59213706644", "6413860590", null, null, 10, "9330192073", null },
                    { "e3ab3456-cd7a-4d05-9b66-75862bf21ea8", 16, 1, "LGW1LF", "530717632276821684054619", "LI5V5V", "10441149557", "8636145937", null, null, 10, "3898886952", null },
                    { "e454518b-5f2a-41e2-9075-cc6be415622a", 2, 6, "K7JF0M", "409589013785065523893968", "M9V61N", "20116640870", "9050177381", null, null, 10, "2276132229", null },
                    { "ee847be6-81de-4d11-b951-44aa0b1c295f", 21, 3, "M91RFP", "051261007810378659979555", "KNWCKN", "00020488778", "5806817540", null, null, 10, "2461373463", null },
                    { "efbf8271-7f34-4bf1-93a5-e441cdebe8e2", 7, 1, "T4IOY0", "970703911926144556647520", "3EU6O7", "69799552384", "5681215584", null, null, 10, "6803162443", null },
                    { "f04ea9a2-5a63-4593-9879-6ab39ea7e340", 14, 1, "RSYU1Q", "664648852936952780352431", "6Q1EET", "16191832112", "6379434928", null, null, 10, "9337617277", null },
                    { "f07ba120-04d4-4403-822f-686563293b52", 3, 1, "UMB4IL", "482364039473080021624535", "72PC1D", "68981153552", "9472314595", null, null, 10, "6533099406", null },
                    { "f3e6fcd7-e18b-4ec5-baa3-a6e7e7752688", 9, 2, "GRGT2F", "786512594053580624175956", "ZH8I74", "71316926567", "1221734058", null, null, 10, "0422770983", null },
                    { "f9495ec1-eb77-4399-a853-169294aae090", 15, 1, "FOYV1B", "612041735616898996862362", "WYE2B2", "75549290098", "7701370955", null, null, 10, "3990454070", null },
                    { "f990f93a-c4f2-4a19-8e49-70fb2d25ec63", 10, 1, "DYJ7IV", "415327294196606496752562", "JHI2UE", "20112944676", "1113847515", null, null, 10, "5735736916", null },
                    { "fae01284-5cc4-4ac4-a232-582e3789cbcf", 24, 4, "JNNO2K", "153367462388943287513428", "9QO4EX", "98822552134", "5883569768", null, null, 10, "8948264713", null },
                    { "fcc982d8-a8a2-43b3-a346-d017e0130bf1", 16, 3, "ORLNT7", "302150527560975976940524", "1I79N8", "75520007546", "2488293960", null, null, 10, "1400202284", null }
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
