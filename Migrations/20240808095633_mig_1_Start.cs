using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_Apı_Sysytem.Migrations
{
    public partial class mig_1_Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ordered = table.Column<bool>(type: "bit", nullable: false),
                    BookCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_BookCategories_BookCategoryId",
                        column: x => x.BookCategoryId,
                        principalTable: "BookCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Returned = table.Column<bool>(type: "bit", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinePaid = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "Id", "Category", "SubCategory" },
                values: new object[,]
                {
                    { 1, "Roman", "Dram" },
                    { 2, "Roman", "Bilim Kurgu" },
                    { 3, "Roman", "Biyografi" },
                    { 4, "Akademik", "Matematik" },
                    { 5, "Akademik", "Bilgisayar Bilimleri" },
                    { 6, "Dergi", "Kimya" },
                    { 7, "Dergi", "Fizik" },
                    { 8, "Dil", "Ingilizce" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { "02e1100c-fa7b-401f-abd7-7ccf1a74f565", 0, "ACTIVE", "79a43553-cb1a-4f58-aceb-4004671719d3", new DateTime(2024, 8, 3, 13, 28, 12, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Admin", "Adminlastname", false, null, null, null, "admin1992", null, "1234567890", false, "c7d3c25a-7749-41af-a4f3-0e11a4116e28", false, null, "EMPLOYEE" },
                    { "7ac8fc76-cd1c-40e9-999a-a2b8c586414a", 0, "ACTIVE", "5b26e37b-93a5-41f3-b499-7ffc9098e314", new DateTime(2024, 8, 8, 12, 56, 33, 233, DateTimeKind.Local).AddTicks(6452), "member@gmail.com", false, "Member", "MemberLastName", false, null, null, null, "member1999", null, "9876543210", false, "727fbe08-6d71-4fab-9805-df622d9cdceb", false, null, "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookCategoryId", "Ordered", "Title" },
                values: new object[,]
                {
                    { 1, "Yasar Kemal", 1, false, "Yer Demir Gök Bakır" },
                    { 2, "Yasar Kemal", 1, false, "Ortadirek" },
                    { 3, "Yasar Kemal", 1, false, "Kuşlar da Gitti" },
                    { 4, "Yasar Kemal", 1, false, "Karıncanın Su İçtiği" },
                    { 5, "Orhan Pamuk", 1, false, "Masumiyet Müzesi" },
                    { 6, "Orhan Pamuk", 1, false, "Benim Adım Kırmızı" },
                    { 7, "Orhan Pamuk", 1, false, "Veba Geceleri" },
                    { 8, "Orhan Pamuk", 1, false, "Cevdet Bey ve Oğulları" },
                    { 9, "Orhan Pamuk", 1, false, "Kafamda Bir Tuhaflık" },
                    { 10, "Stephen King", 2, false, "Medyum" },
                    { 11, "Stephen King", 2, false, "Sadist" },
                    { 12, "Stephen King", 2, false, "Yeşil Yol" },
                    { 13, "Paul Barry", 2, false, "" },
                    { 14, "Joshua Bloch", 2, false, "Java" },
                    { 15, "Joshua Bloch", 2, false, "JavaScript" },
                    { 16, "Kathy Sierra and Bert Bates", 2, false, "Head First Java" },
                    { 17, "Ursula K. Le Guin", 2, false, "Yerdeniz Büyücüsü" },
                    { 18, "Ursula K. Le Guin", 2, false, "Karanlığın Sol Eli" },
                    { 19, "Ursula K. Le Guin", 2, false, "Dünyaya Orman Denir" },
                    { 20, "Marijn Haverbeke", 2, false, "Python" },
                    { 21, "Donald E. Knuth", 2, false, "Design Pattern" },
                    { 22, "Donald E. Knuth", 2, false, "Redis" },
                    { 23, "James F Kurose and Keith W Ross", 3, false, "A Top-Down Approach: Computer Networking" },
                    { 24, "Rich Seifert and James Edwards", 3, false, "The All-New Switch Book (2nd Edition)" },
                    { 25, "Rich Seifert and James Edwards", 3, false, "The All-New Switch Book (2nd Edition)" },
                    { 26, "Jerry FitzGerald, Alan Dennis, and Alexandra Durcikova", 3, false, "Business Data Communications and Networking (14th Edition)" },
                    { 27, "Forouzan", 3, false, "Data Communications and Networking with TCP/IP Protocol Suite, 6th Edition" },
                    { 28, "Gary Donahue", 3, false, "Network Warrior, 2nd Edition" },
                    { 29, "Gary Donahue", 3, false, "Network Warrior, 2nd Edition" },
                    { 30, "Gary Donahue", 3, false, "Network Warrior, 2nd Edition" },
                    { 31, "Ramesh Gaonkar", 4, false, "Microprocessor Architecture, Programming, and Applications with the 8085 (4th Edition)" },
                    { 32, "Douglas V. Hall", 4, false, "Microprocessors and Interfacing: Programming and Hardware (Hardcover)" },
                    { 33, "Douglas V. Hall", 4, false, "Microprocessors and Interfacing: Programming and Hardware (Hardcover)" },
                    { 34, "Kenneth L. Short", 4, false, "Embedded Microprocessor Systems Design" },
                    { 35, "Dr. Vibhav Kumar Sachan", 4, false, "Digital Electronics & Microprocessor" },
                    { 36, "Xiaocong Fan", 4, false, "Real-Time Embedded Systems" },
                    { 37, "Jonathan A. Dell", 4, false, "Digital Interface Design and Application" },
                    { 38, "Shigley's Mechanical Engineering Design", 5, false, "Richard G. Budynas and Keith J. Nisbett" },
                    { 39, "Shigley's Mechanical Engineering Design", 5, false, "Richard G. Budynas and Keith J. Nisbett" },
                    { 40, "Shigley's Mechanical Engineering Design", 5, false, "Richard G. Budynas and Keith J. Nisbett" },
                    { 41, "Erik Oberg", 5, false, "Machinery's Handbook" },
                    { 42, "John J. Craig", 5, false, "Introduction to Robotics: Mechanics and Control" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookCategoryId", "Ordered", "Title" },
                values: new object[,]
                {
                    { 43, "Robert L. Norton", 5, false, "Machine Design" },
                    { 44, "Robert L. Norton", 5, false, "Machine Design" },
                    { 45, "Frank M. White", 6, false, "Fluid Mechanics" },
                    { 46, "Claus Borgnakke and Richard E. Sonntag", 6, false, "Fundamentals of Thermodynamics" },
                    { 47, "Claus Borgnakke and Richard E. Sonntag", 6, false, "Fundamentals of Thermodynamics" },
                    { 48, "James Stewart", 7, false, "Calculus: Early Transcendentals" },
                    { 49, "Mark Ryan", 7, false, "Calculus for Dummies" },
                    { 50, "Mark Ryan", 7, false, "Calculus for Dummies" },
                    { 51, "Louis Leithold", 7, false, "The Calculus with Analytic Geometry" },
                    { 52, "Euclid", 8, false, "Euclid's Elements" },
                    { 53, "Robert Kanigel", 8, false, "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
                    { 54, "Robert Kanigel", 8, false, "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
                    { 55, "Stephen Hawking", 8, false, "A Brief History of Time" },
                    { 56, "Albert Einstein", 8, false, "Relativity: The Special and the General Theory" },
                    { 57, "Albert Einstein", 8, false, "Relativity: The Special and the General Theory" },
                    { 58, "Albert Einstein", 8, false, "Relativity: The Special and the General Theory" },
                    { 59, "Albert Einstein", 8, false, "Relativity: The Special and the General Theory" },
                    { 60, "Albert Einstein", 8, false, "Relativity: The Special and the General Theory" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookCategoryId",
                table: "Books",
                column: "BookCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BookId",
                table: "Orders",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "BookCategories");
        }
    }
}
