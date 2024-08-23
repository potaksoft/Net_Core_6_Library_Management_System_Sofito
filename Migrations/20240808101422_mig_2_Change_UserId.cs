using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_Apı_Sysytem.Migrations
{
    public partial class mig_2_Change_UserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_User_UserId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId1",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "02e1100c-fa7b-401f-abd7-7ccf1a74f565");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "7ac8fc76-cd1c-40e9-999a-a2b8c586414a");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "4e538e24-5542-40a9-a37e-17441c53225b", 0, "ACTIVE", "92c4aec9-99d9-466a-a881-ee4f02778bd3", new DateTime(2024, 8, 8, 13, 14, 22, 292, DateTimeKind.Local).AddTicks(7143), "member@gmail.com", false, "Member", "MemberLastName", false, null, null, null, "member1999", null, "9876543210", false, "7a7a6d80-9794-4f2b-93c8-dac0812e625f", false, null, "MEMBER" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "de87b0a2-9f81-46c3-a8fa-ad9209ad2020", 0, "ACTIVE", "e2f6c37d-3fb7-479f-8c58-a6fd65d904b9", new DateTime(2024, 8, 3, 13, 28, 12, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Admin", "Adminlastname", false, null, null, null, "admin1992", null, "1234567890", false, "3d85ad56-45ff-4494-bc8f-9d2d95e0a5f4", false, null, "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_User_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_User_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "4e538e24-5542-40a9-a37e-17441c53225b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "de87b0a2-9f81-46c3-a8fa-ad9209ad2020");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "02e1100c-fa7b-401f-abd7-7ccf1a74f565", 0, "ACTIVE", "79a43553-cb1a-4f58-aceb-4004671719d3", new DateTime(2024, 8, 3, 13, 28, 12, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Admin", "Adminlastname", false, null, null, null, "admin1992", null, "1234567890", false, "c7d3c25a-7749-41af-a4f3-0e11a4116e28", false, null, "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "AccountStatus", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "7ac8fc76-cd1c-40e9-999a-a2b8c586414a", 0, "ACTIVE", "5b26e37b-93a5-41f3-b499-7ffc9098e314", new DateTime(2024, 8, 8, 12, 56, 33, 233, DateTimeKind.Local).AddTicks(6452), "member@gmail.com", false, "Member", "MemberLastName", false, null, null, null, "member1999", null, "9876543210", false, "727fbe08-6d71-4fab-9805-df622d9cdceb", false, null, "MEMBER" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_User_UserId1",
                table: "Orders",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
