using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_Apı_Sysytem.Migrations
{
    public partial class mig_3_Seed_Data_Part2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "38a2fa8e-8c7c-41df-8ae4-abb185d5937b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "4e49754e-c375-4b3f-95ae-2f478578e0ca");

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
                    { "06c157ca-50f9-4002-a7dc-c97c0b722f04", 0, "ACTIVE", "3e736fe3-334f-4986-a157-81c6e2a42bb3", new DateTime(2024, 8, 3, 13, 28, 12, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Admin", "Adminlastname", false, null, null, null, "admin1992", null, "1234567890", false, "fc87017b-7ab6-4586-b841-432e779486c7", false, null, "EMPLOYEE" },
                    { "62b7d818-9d24-4117-aff7-42934b43d806", 0, "ACTIVE", "6429f5c9-5c2e-4277-9adc-0aba45528fe3", new DateTime(2024, 8, 3, 15, 26, 9, 246, DateTimeKind.Local).AddTicks(1464), "member@gmail.com", false, "Member", "MemberLastName", false, null, null, null, "member1999", null, "9876543210", false, "915c53d4-9feb-4da6-a82d-e9bac14ef503", false, null, "MEMBER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "06c157ca-50f9-4002-a7dc-c97c0b722f04");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "62b7d818-9d24-4117-aff7-42934b43d806");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "38a2fa8e-8c7c-41df-8ae4-abb185d5937b", 0, "ACTIVE", "c52aa66d-1bfc-4a1e-83dd-97ea0feb5bb3", new DateTime(2024, 8, 3, 15, 13, 2, 603, DateTimeKind.Local).AddTicks(3918), "member@gmail.com", false, "Member", "", false, null, null, null, "member1999", null, "9876543210", false, "4278ebff-7893-4050-b522-aca6639f947b", false, null, "MEMBER" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "4e49754e-c375-4b3f-95ae-2f478578e0ca", 0, "ACTIVE", "94057a68-e72b-4707-b90d-5f38923f2040", new DateTime(2023, 11, 1, 13, 28, 12, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "admin", "lastname", false, null, null, null, "admin1992", null, "1234567890", false, "34722498-d431-45db-8866-c283a2fde4da", false, null, "EMPLOYEE" });
        }
    }
}
