using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "568762d7-5b58-40c4-be99-ae64e4a6181c", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIvTwfriEPWxr7SXxzdGoI1e03q3ygn2fyevfpqBO6Xg9MvnXI1/P/8zFvoX/kblYQ==", null, false, "df1095e1-75fa-416c-836c-998387397805", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(5453), new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(5467), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(5470), new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(5471), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(6540), new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(6542), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(6545), new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(6546), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(6130), new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(6132), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(6135), new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(6136), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(6138), new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(6139), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(6141), new DateTime(2023, 11, 22, 11, 44, 46, 813, DateTimeKind.Local).AddTicks(6142), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
