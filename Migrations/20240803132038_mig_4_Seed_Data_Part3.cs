using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_Apı_Sysytem.Migrations
{
    public partial class mig_4_Seed_Data_Part3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "06c157ca-50f9-4002-a7dc-c97c0b722f04");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "62b7d818-9d24-4117-aff7-42934b43d806");

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

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { "1fac1448-8493-4855-941b-a94acc6fb377", 0, "ACTIVE", "f4bc7fe9-3e8f-452c-b0d8-7990dad29be7", new DateTime(2024, 8, 3, 13, 28, 12, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Admin", "Adminlastname", false, null, null, null, "admin1992", null, "1234567890", false, "b3a3ab54-aa98-4b44-8b6f-347a6e14b645", false, null, "EMPLOYEE" },
                    { "36e5404e-fc23-498c-a228-6bdc42d50d82", 0, "ACTIVE", "edf35aa5-3e7c-4b5b-ac03-00878bae2e85", new DateTime(2024, 8, 3, 16, 20, 37, 673, DateTimeKind.Local).AddTicks(6674), "member@gmail.com", false, "Member", "MemberLastName", false, null, null, null, "member1999", null, "9876543210", false, "198a03d0-1334-4d48-9ade-e74a345c2588", false, null, "MEMBER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1fac1448-8493-4855-941b-a94acc6fb377");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "36e5404e-fc23-498c-a228-6bdc42d50d82");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "06c157ca-50f9-4002-a7dc-c97c0b722f04", 0, "ACTIVE", "3e736fe3-334f-4986-a157-81c6e2a42bb3", new DateTime(2024, 8, 3, 13, 28, 12, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Admin", "Adminlastname", false, null, null, null, "admin1992", null, "1234567890", false, "fc87017b-7ab6-4586-b841-432e779486c7", false, null, "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "62b7d818-9d24-4117-aff7-42934b43d806", 0, "ACTIVE", "6429f5c9-5c2e-4277-9adc-0aba45528fe3", new DateTime(2024, 8, 3, 15, 26, 9, 246, DateTimeKind.Local).AddTicks(1464), "member@gmail.com", false, "Member", "MemberLastName", false, null, null, null, "member1999", null, "9876543210", false, "915c53d4-9feb-4da6-a82d-e9bac14ef503", false, null, "MEMBER" });
        }
    }
}
