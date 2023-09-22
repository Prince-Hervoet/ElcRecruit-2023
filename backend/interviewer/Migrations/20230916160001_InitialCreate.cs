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
                    StudentUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    StudentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { "b3621b98-6e9f-4f27-9968-d8109f634285", "24ce2a9c-e5fc-4704-8b38-5c0f8980ba76", "Admin", "ADMIN" },
                    { "e90e669d-94d4-4205-9f6e-f478746cbc38", "8400538c-1bd5-4ffb-ae95-cf262507c19d", "Interviewer", "INTERVIEWER" },
                    { "f0ab04eb-29b9-4d71-9205-63b8d439154c", "d2a94451-a634-4d19-acd0-1bd319b5720b", "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "College", "FirstDepartment", "Grade", "Introduction", "Name", "Phone", "Qq", "SecondDepartment", "Skills", "State", "StudentNumber", "WeChat" },
                values: new object[,]
                {
                    { "02738e33-6ec0-4310-a87a-cb6484485a8d", 7, 3, "9A49JO", "724286873233558755714071", "CF652Z", "76656803691", "7288378396", null, null, 10, "6640472706", null },
                    { "0344d342-e9c9-4051-8c71-6ab3381a3cbf", 16, 5, "G2UCMQ", "689220013100745496078529", "W2OQGH", "90812519369", "7657942547", null, null, 10, "0713111768", null },
                    { "071ac596-21cb-415e-9644-108bc42c9293", 9, 1, "RF9SD2", "900900247541540315848832", "PR1190", "20103580997", "7959764856", null, null, 10, "4813407240", null },
                    { "07613f49-a183-4946-9812-3168062b50cd", 19, 5, "Z6N6YY", "925702325858299163972401", "2DWD0I", "96747241467", "0759501805", null, null, 10, "0300928823", null },
                    { "078e9860-2a4d-43b9-9c2e-f65b87b0fc1d", 24, 3, "ROP0WI", "910695666223603582699790", "6Q35EQ", "23693681439", "6309603755", null, null, 10, "2242852890", null },
                    { "0bf2e849-4afc-459c-8c07-5f4ead012e09", 25, 5, "SOFY0X", "249620629924820842593731", "V1SSUX", "00394876239", "4048577224", null, null, 10, "1090299967", null },
                    { "0d5f8c4e-5d89-4523-8a73-fb58fcb1b209", 12, 6, "EXSHD4", "512458561102862459068588", "ZXZJ7W", "84473316793", "6139711744", null, null, 10, "0002971889", null },
                    { "16bf6019-9129-4271-8e7d-f2f9bcc1c5db", 13, 4, "JMZD4X", "559533502609126782266277", "RF9UGD", "16781556558", "1927046227", null, null, 10, "3608171666", null },
                    { "1763e28e-9ac1-4df6-aab9-421163586298", 7, 6, "U9JYYA", "632946659932009397307968", "TJ3D29", "99711614936", "7485403694", null, null, 10, "3493918751", null },
                    { "186186e0-172c-46b7-8205-24da08a96198", 18, 4, "UAVXKM", "454825328076567946425802", "L2YX8Z", "25154214447", "3295673387", null, null, 10, "1973862384", null },
                    { "193677e4-8de6-421e-a35e-735d92aa8167", 7, 2, "Z1UP5K", "091145597832892734819410", "4NW0HV", "58350409282", "7685055030", null, null, 10, "2096399946", null },
                    { "1d783dc9-e53d-42df-9be4-1f03067da7b3", 26, 6, "Z7WJKL", "033034886364231252323873", "PHI5AO", "18769909898", "7776624617", null, null, 10, "9436281226", null },
                    { "20c47d0c-1b6b-4525-bb06-6bb7df0c7687", 8, 5, "8EG9XW", "107853234425401003886181", "0MJCGU", "21071236395", "0167484531", null, null, 10, "9202567717", null },
                    { "21e90bd6-cff6-415d-bae8-581dc7f6649b", 5, 5, "DCRQ59", "279021288940700885986974", "82BG3G", "74326021756", "4588219384", null, null, 10, "8573629171", null },
                    { "24db3206-cda9-42aa-8e4a-fa685ea2bbb6", 5, 6, "VPCB6T", "086745315554602600477695", "AZ1SAF", "29309184530", "8718433297", null, null, 10, "3854257836", null },
                    { "26679ebe-54c4-4887-8f0c-6f570a7f1808", 11, 5, "UTGRTL", "776987870866983542845841", "Q5YZB6", "32651714812", "3707170689", null, null, 10, "8117272171", null },
                    { "27d27ce7-dbde-42b5-b5ab-24de6bae9315", 2, 5, "TV7UR7", "302187847497026003772853", "BJ35AQ", "09702074145", "6967729854", null, null, 10, "8260480602", null },
                    { "2c27b375-723e-467a-ab39-7e2c4bc86109", 16, 6, "VFXWM2", "224865837183202953376470", "RZ5VM9", "75373388790", "5279751945", null, null, 10, "9897244999", null },
                    { "2f087ae3-525c-47b7-8e6c-9d43f49d6531", 18, 3, "SSGZR9", "178478393672261400870603", "CGMZG8", "22623806341", "5455843923", null, null, 10, "8106007628", null },
                    { "2f931127-ac2d-450a-b1c4-483d938fd854", 16, 2, "8Z3SIO", "438421503541598529746959", "YWDN19", "91369691289", "6077599330", null, null, 10, "7507745614", null },
                    { "3cbda965-1b96-4b62-a7c3-4fef98c1bd50", 5, 5, "VEQCGE", "946164087464060338767516", "B8TER9", "19990807843", "4032965772", null, null, 10, "1251681754", null },
                    { "3f7162f4-1e7d-4d7d-b1e9-dc4d14b97548", 6, 5, "17LM6L", "346837290208177940820543", "LBNBFH", "90760931846", "1462746588", null, null, 10, "0390189229", null },
                    { "3f7a64d2-5e1e-40cb-a092-9380bd71d779", 25, 1, "K1FYXY", "864149562271850645817689", "FNIPCD", "22206131562", "9875129846", null, null, 10, "6581624064", null },
                    { "40d53478-69ef-4241-b7c5-791289976a6a", 24, 6, "JVELLO", "447889408750847032971863", "JUNXIP", "56450378413", "9162360816", null, null, 10, "8061993173", null },
                    { "4145b599-3e51-45ad-b902-5b423adfdbd4", 20, 2, "2L77NG", "804358876052996819094239", "Y24G6B", "52980988585", "4358868362", null, null, 10, "2690112289", null },
                    { "44e3d5ff-3614-40c0-ace2-3bb976ef637d", 6, 3, "E3TGXN", "308835991196901882038326", "HU6WYR", "58256952378", "4546508508", null, null, 10, "1763385712", null },
                    { "489da1ea-cf7a-4b86-a289-2e5be22f2c7f", 5, 3, "YHUTZ7", "102186539704749352918627", "8EGV80", "08665844594", "5109240537", null, null, 10, "0867506541", null },
                    { "52585c5f-ebd3-4756-89be-340e9260e71d", 26, 4, "G746K0", "010276630288893115731544", "5I24VC", "79362580066", "9809065064", null, null, 10, "5743281955", null },
                    { "55f5b8b4-11d5-4f68-a8eb-89b67112b76a", 5, 2, "8PMYFB", "659789408329741329964830", "ADKK1L", "76232760458", "1369367866", null, null, 10, "1067570446", null },
                    { "56567f89-071a-4868-9f18-c400696f54c3", 15, 1, "BCOVQH", "606695616875897757457597", "U4WDLB", "53130143519", "9836460117", null, null, 10, "8668599684", null },
                    { "5771cb53-eed5-4e58-8d0a-ce8af10091c3", 8, 4, "MEP71F", "202350208878412887304659", "7EA6J0", "13332313268", "0745545961", null, null, 10, "2665870701", null },
                    { "577f283b-3feb-4907-a9e2-9c25956b47eb", 20, 2, "DK9QJG", "537055696413759129641910", "PLHGQC", "18814980836", "2276949021", null, null, 10, "9594573950", null },
                    { "58157f17-b67f-4d19-96fa-d320bd962b37", 1, 4, "2BITZ6", "531776667589148467810843", "VW61RG", "71232439153", "2720710692", null, null, 10, "4685781445", null },
                    { "582ddd17-f48b-412c-82f0-81e94647c943", 25, 4, "UEAA91", "614646268061587239866380", "7TEZ4B", "97132703370", "8490104961", null, null, 10, "0328287490", null },
                    { "59cd7dd6-d719-4fd7-8139-9f34afcb0278", 1, 2, "6PMP7K", "404064837215086517237331", "7EHKYT", "42327110578", "2494409109", null, null, 10, "4612322994", null },
                    { "5e5134ea-2023-4666-9bf1-f76846591df8", 7, 1, "KUTK1K", "737119172486145515337790", "LB44MT", "18159456616", "1640083205", null, null, 10, "2118926090", null },
                    { "5fc793fb-a954-4540-a4de-8e7f20f4963b", 25, 3, "GZ9KNG", "227251034452646621072933", "65OFKN", "79225216459", "0595938432", null, null, 10, "5662697861", null },
                    { "61d07c1a-6f8e-42dd-bd31-a7434133f290", 23, 4, "LBV3LW", "596156893909909355225460", "7FENPP", "21524836697", "4051271265", null, null, 10, "5020736479", null },
                    { "635c4228-19e7-4e4d-9931-2d9bb40735cb", 21, 4, "OFOOMB", "408505841669635274422407", "9KG83M", "92374143477", "0879393410", null, null, 10, "2524911621", null },
                    { "688b3fee-bc78-4312-b272-13a19c2c3e2b", 26, 4, "JQ2FAA", "442646345696874769966819", "0LA36C", "26918567805", "0007261449", null, null, 10, "5089760906", null },
                    { "6a01f0ca-3673-4c33-af2a-5caa081ac125", 0, 3, "QLTZPR", "497000928972394146913569", "C379KX", "08578655549", "0389651473", null, null, 10, "1007684869", null },
                    { "6d25e8bc-2af3-44a2-a8ff-efa9ed2a21e1", 2, 4, "NGZDYC", "451401996846125686886273", "93ZIAF", "91361873132", "9641664534", null, null, 10, "4851219007", null },
                    { "7153d6f6-b811-47f1-b6d9-bc6893cd38f3", 7, 4, "3CPU81", "970052753938604014435629", "GTQ3FU", "17255678338", "7913780134", null, null, 10, "0376741043", null },
                    { "76296a81-e90a-466f-8726-9d5d9fe28474", 7, 3, "JJUS27", "732014821586956734698420", "GUZDCI", "62042546715", "4222964898", null, null, 10, "3101180311", null },
                    { "7778662e-6fb6-4bd5-9fcd-bd18c0ae03bb", 17, 3, "ADXU63", "364383890009131659037464", "NFRPSV", "41996471143", "6743414737", null, null, 10, "6211298827", null },
                    { "7b0e6607-3962-4728-9525-9db9acff4fc7", 16, 4, "LZYP3A", "945121519397654826851268", "2BXH37", "76559880280", "8685273768", null, null, 10, "3657315118", null },
                    { "7c488bb4-8cf5-48bd-828f-cbd7b1c9ee1f", 13, 6, "TT8B4Q", "550152203309089636786135", "2N48WD", "74640089315", "3967457725", null, null, 10, "6839990974", null },
                    { "7f5eaf09-4938-4d03-8f52-5cf5e392c09c", 11, 3, "JA2I9X", "473824735564329293978137", "3WVYAC", "89870019424", "3823252886", null, null, 10, "0761730871", null },
                    { "7fb7cde2-b9db-48c4-8be1-82ce000dfd5b", 15, 4, "10HUSM", "112691861681937524506101", "IAVGYM", "25776015685", "0169957309", null, null, 10, "0021638806", null },
                    { "8063318c-611e-4504-acd9-7dbbe3561e14", 20, 2, "03PJP0", "976902666228983019431642", "Y9K18B", "13073353330", "5418759196", null, null, 10, "2525294860", null },
                    { "82e65658-6c39-4d97-b086-c208dda3f300", 21, 3, "N4JC1V", "553594938511679295883027", "6XWINH", "61357260909", "7339812920", null, null, 10, "7973994990", null },
                    { "84b29606-6337-4909-84bd-4d13b1253a57", 15, 2, "729WZ4", "970645670551855514423417", "8G09UZ", "50943903033", "3729257204", null, null, 10, "9179687169", null },
                    { "867b4441-c9e1-4ea3-825a-0ccd6af1a34b", 11, 6, "33GYK3", "812484599343174115234520", "Y4ZQL8", "76974016678", "7797103487", null, null, 10, "8210180885", null },
                    { "86b14ee6-af79-4aea-b55a-3d901cba7d3b", 22, 5, "EMKMA5", "977899823495732931022901", "IZ31GR", "60579968632", "9710751649", null, null, 10, "8329374308", null },
                    { "8eb6e480-2ff2-430f-bc11-244d843b23eb", 10, 4, "QIMQQO", "090698025437065839112027", "9N8U1T", "43556855142", "4645685749", null, null, 10, "8541327277", null },
                    { "90cbb824-cb1e-4c9e-8611-91448d2e5d44", 23, 4, "3LEUXB", "130484891035323648336794", "2X840P", "38479255551", "8872821470", null, null, 10, "4612313839", null },
                    { "931a6532-33dc-4ede-8c2a-dc3102713596", 7, 3, "D53LI8", "286653859379761067165106", "ZKPLYG", "00801715873", "3866125812", null, null, 10, "8318943698", null },
                    { "932ba6d0-a354-49fe-9b78-f387ef8e9a84", 16, 5, "LU26UT", "352796682927869809715701", "IM1T1B", "07562238525", "3457205873", null, null, 10, "1199799255", null },
                    { "9ae7b914-51e5-48aa-b1c8-403708342e7d", 0, 2, "S0ZE4C", "461601356918526977999758", "BUKWIB", "44502813233", "7211221989", null, null, 10, "2019174424", null },
                    { "9df7f130-e381-41c7-8203-8f69da4aa30e", 22, 1, "SWNNI3", "185391047298834805588829", "T8QQ4P", "92536928845", "1004258311", null, null, 10, "0581188103", null },
                    { "a03a0c6d-4103-47bc-b4c2-1f6ac7d55de4", 16, 2, "OUZ615", "835671848056608561412097", "V6Z97E", "25203900076", "6716237788", null, null, 10, "8649305789", null },
                    { "a3048fbe-36e0-41ba-9deb-0b21ad69d34a", 2, 1, "OG2WQV", "381170447917807875479454", "YADZ2D", "06168035735", "9646705289", null, null, 10, "2362554266", null },
                    { "a411f2f8-2cb3-4af2-8059-f41c580b5130", 23, 2, "R6JCD4", "631865956715515452771813", "LNCW77", "55990993659", "0311048024", null, null, 10, "1895440309", null },
                    { "b093ed10-4b63-41b3-9995-d0188ecb4f84", 6, 3, "YV08FL", "874513513751101425909532", "NFLYJ7", "01562391111", "8426813256", null, null, 10, "1950315869", null },
                    { "b14b0c3c-101e-44f9-845f-d0b94eaf0d1c", 8, 6, "I6L16F", "245108472253975974443840", "0PUQG1", "23576696734", "8335798784", null, null, 10, "5115674916", null },
                    { "b17875c7-63dc-4eb4-b39b-f05ae5e4be39", 13, 5, "QJ6TQF", "757741539082542895751591", "GDAJAC", "98499972110", "5094851726", null, null, 10, "8476675135", null },
                    { "b439fcd4-4ad2-49e0-abdc-57b2978d5da0", 19, 5, "WW1X5Z", "915736658266588021451984", "68TPWT", "80285224953", "4548351848", null, null, 10, "9249891049", null },
                    { "b44911c7-b03c-461b-bd82-2b3d4e4d724f", 12, 6, "MPAXZ4", "857437036182516877747482", "URBA8F", "13257140509", "2080408309", null, null, 10, "5473016374", null },
                    { "b5cca599-288b-4363-9aa3-596cb357c3cc", 5, 6, "4A1AF2", "189064226923990217287208", "PRW2YS", "84235173009", "9962376806", null, null, 10, "5317879422", null },
                    { "b6126d5f-ac4f-466f-83bb-6ed41e1f9997", 15, 2, "0GSQC1", "088345348450664182985858", "3OC1HU", "50595498531", "1068139106", null, null, 10, "6953713792", null },
                    { "b7cc5cf0-d07f-4d1b-b250-212820a4c8ec", 3, 5, "1XMM0N", "011246315448035414912825", "W8NRBP", "74103924433", "4514315136", null, null, 10, "5882712103", null },
                    { "bc6764bd-996a-4c66-811f-3ebdb2067df5", 19, 5, "R696YF", "665764210937010516430589", "7WD09A", "42963580091", "8036551478", null, null, 10, "4079742416", null },
                    { "bda50dec-66b8-4de5-a4f5-465da3c7cfb0", 15, 1, "WGC1RC", "252094407462939157524265", "IE9K5T", "31531868435", "3318448970", null, null, 10, "5343189857", null },
                    { "bef88de7-01b6-40d6-90de-b5642e718859", 5, 5, "IN0Y16", "164708410522496546783715", "UHFTOK", "83135116833", "4312091491", null, null, 10, "1028820096", null },
                    { "c1d244f5-77dd-49ef-ac78-64c23a771236", 20, 4, "D2TBPC", "818544288354873362902539", "B28D1X", "55147153279", "2107683993", null, null, 10, "7581738914", null },
                    { "c2255ec1-0de4-4b64-8ced-8cdaa1931758", 11, 2, "SD2ULS", "812979848130432490190640", "8LUPQ6", "25852286206", "8103052914", null, null, 10, "2177007657", null },
                    { "c2bab5a5-1620-40be-ad07-46aa8f3ec3d0", 22, 2, "KI7S9T", "443811898374342125053440", "KRS031", "57515019994", "0015523718", null, null, 10, "4741225424", null },
                    { "c3a5aadf-8369-4bec-b2f2-21c3b8ff5ec0", 24, 4, "9I5RCM", "475659418804439900672271", "D615C5", "83691235687", "6109568433", null, null, 10, "2634010903", null },
                    { "c4e686f3-caf2-4caf-8f62-8561a4fb86f4", 5, 4, "6U46Y2", "633704950212750895913660", "YV2BDC", "09621056590", "8011236987", null, null, 10, "2996233541", null },
                    { "c694b887-54af-404b-ade8-7fec758964b4", 20, 3, "4FKMJD", "022614764633430430614027", "4A67EC", "98520135557", "8981483665", null, null, 10, "7707919910", null },
                    { "ca0b1a84-5da9-426c-9411-81d1705e61d1", 25, 6, "W80G0C", "854776122954338933708432", "TDR7WR", "38345039971", "9715023451", null, null, 10, "0905596999", null },
                    { "d4b9fe61-89c4-4491-9bdc-16976487c6e8", 16, 3, "XYS6KH", "400218861412167536317978", "1AS3WI", "18419701135", "2565903962", null, null, 10, "2722636911", null },
                    { "d4bbde5c-971c-4d6b-9715-63a4cee71afb", 23, 1, "Q8W9H7", "985033188073080346557058", "HR9RO6", "19321812953", "0906626046", null, null, 10, "2340387446", null },
                    { "d8fb3554-e6ac-4876-9414-775bf8fcbe69", 3, 4, "7XA6C0", "556940591142493309780174", "N2H4EH", "65497884192", "6350234657", null, null, 10, "7811603488", null },
                    { "dcbba3ad-e144-4cdb-a53e-04f60d8a3b1b", 23, 4, "LY7HYK", "643591750283296488667246", "PLZU00", "53467567189", "9270548361", null, null, 10, "9511927039", null },
                    { "dfae4bcc-aa81-4228-be90-bbb46e10c084", 12, 3, "C0QVHN", "679695398857921111367506", "3XO891", "76043844601", "3742975158", null, null, 10, "9656748816", null },
                    { "e3d5fa5c-ab22-41f7-af0e-a5344aac8257", 19, 5, "XZRPNP", "392284062857129029789813", "Z6OO1M", "26773162891", "2583528310", null, null, 10, "8713329767", null },
                    { "e45cae0e-c725-43e2-b3b9-d5f8baf79572", 17, 4, "SGRXHJ", "054207485069021399836293", "RQ3PZX", "86660875795", "1298393743", null, null, 10, "9223039114", null },
                    { "ea0895fb-cc13-4db2-baa7-78d57d682fd9", 16, 6, "BDWTRW", "956472920531887399969507", "KHXOPA", "40995006029", "2538979194", null, null, 10, "9951156402", null },
                    { "ea20776d-d73c-427d-b609-c0e93f0216a6", 9, 6, "I6NXUV", "710939951405314398338246", "OQSRQ4", "09040951501", "4894213954", null, null, 10, "1065264165", null },
                    { "efb4ed24-59db-4c53-94f8-f42cb5f7dd7f", 19, 3, "3AJRBC", "069469294911351565411389", "1ORDEC", "17959031721", "0148995891", null, null, 10, "4450331784", null },
                    { "f0f33813-20aa-4b97-b05d-50da40dae5f6", 25, 3, "WCNVZE", "241872633845353164318695", "5DHRPE", "17632823601", "1464278862", null, null, 10, "0151757704", null },
                    { "f25e3cfd-b528-40fb-bc45-16920922a772", 10, 1, "BL7QNW", "048318877332746339188513", "6KMM7N", "52540739834", "0520028441", null, null, 10, "5770157426", null },
                    { "f2f87d8f-e346-449a-8b91-024b2088f773", 23, 3, "D5NJHR", "907554369064811286051900", "3W14LN", "74855700983", "6037206216", null, null, 10, "8142689861", null },
                    { "f715d2e1-6dc7-4dba-890e-ca8beddf6335", 22, 2, "3F97JT", "181940236478726953576301", "XCEW6W", "65065937593", "1526790552", null, null, 10, "2922461557", null },
                    { "f7edc7a0-2ab1-4d17-b57b-06dddc5296e8", 9, 5, "WG1FJZ", "367464140335153136979032", "HYOU8Q", "92015675075", "4135835690", null, null, 10, "0316553487", null },
                    { "faf7de1f-5e09-4d77-83eb-e17499a2a14a", 18, 1, "9GYG6S", "841202779749063476246100", "EJI6A1", "72218391119", "0177481353", null, null, 10, "9539512339", null },
                    { "fc362b41-a3b7-4ab0-9fdd-3372bbec1e91", 23, 2, "5MKDH0", "613514968640738773128453", "3OI74A", "02548122997", "8935543605", null, null, 10, "4034796723", null },
                    { "ff060c8e-2a29-4cf9-8c2d-3101a17554dd", 1, 4, "2GVLDL", "315388729876386174632794", "PMQDIW", "34190729692", "4356300442", null, null, 10, "1112845842", null },
                    { "ffe1c4b0-2cff-4e7e-83d2-e12380a1d42a", 4, 3, "FX62EU", "905956407621966235044716", "ULJIEG", "21284823836", "3699731960", null, null, 10, "6423836140", null }
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
