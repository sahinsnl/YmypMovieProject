using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2774cec5-bbb0-40c2-bc9a-cdf9cd84ac75"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40bad1dd-df17-4d2d-a378-667e9eaa4eb8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7951981b-a241-4a51-936d-40b424426182"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9100fc8a-9b45-4308-8b63-e36925744054"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c2f89e11-b6f8-4c4e-9e69-82d3b60a2993"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f90f5433-dfd5-4869-bfe1-018dc997fd0e"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("3371424d-0e33-4e3a-a61b-e32b64dc9bc3"), new DateTime(2025, 6, 17, 20, 8, 30, 523, DateTimeKind.Utc).AddTicks(7348), null, true, false, "Fantastik", null },
                    { new Guid("3f4393c5-bdf6-4147-828c-35801802fca6"), new DateTime(2025, 6, 17, 20, 8, 30, 523, DateTimeKind.Utc).AddTicks(7336), null, true, false, "Komedi", null },
                    { new Guid("4c062732-9e4f-422b-baca-05b5f8967db7"), new DateTime(2025, 6, 17, 20, 8, 30, 523, DateTimeKind.Utc).AddTicks(7331), null, true, false, "Aksiyon", null },
                    { new Guid("81c271c5-fb26-4d8a-9035-b66b80ea6cc4"), new DateTime(2025, 6, 17, 20, 8, 30, 523, DateTimeKind.Utc).AddTicks(7345), null, true, false, "Bilim Kurgu", null },
                    { new Guid("a6076c7d-2331-4fe5-8667-ae2536aa5f30"), new DateTime(2025, 6, 17, 20, 8, 30, 523, DateTimeKind.Utc).AddTicks(7346), null, true, false, "Belgesel", null },
                    { new Guid("e5c82904-34a3-4adf-aebd-701e848cdb52"), new DateTime(2025, 6, 17, 20, 8, 30, 523, DateTimeKind.Utc).AddTicks(7350), null, true, false, "Korku", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3371424d-0e33-4e3a-a61b-e32b64dc9bc3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f4393c5-bdf6-4147-828c-35801802fca6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c062732-9e4f-422b-baca-05b5f8967db7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81c271c5-fb26-4d8a-9035-b66b80ea6cc4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6076c7d-2331-4fe5-8667-ae2536aa5f30"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5c82904-34a3-4adf-aebd-701e848cdb52"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2774cec5-bbb0-40c2-bc9a-cdf9cd84ac75"), new DateTime(2025, 6, 15, 12, 23, 33, 350, DateTimeKind.Utc).AddTicks(4532), "", true, false, "Komedi", null },
                    { new Guid("40bad1dd-df17-4d2d-a378-667e9eaa4eb8"), new DateTime(2025, 6, 15, 12, 23, 33, 350, DateTimeKind.Utc).AddTicks(4520), "", true, false, "Aksiyon", null },
                    { new Guid("7951981b-a241-4a51-936d-40b424426182"), new DateTime(2025, 6, 15, 12, 23, 33, 350, DateTimeKind.Utc).AddTicks(4536), "", true, false, "Belgesel", null },
                    { new Guid("9100fc8a-9b45-4308-8b63-e36925744054"), new DateTime(2025, 6, 15, 12, 23, 33, 350, DateTimeKind.Utc).AddTicks(4538), "", true, false, "Fantastik", null },
                    { new Guid("c2f89e11-b6f8-4c4e-9e69-82d3b60a2993"), new DateTime(2025, 6, 15, 12, 23, 33, 350, DateTimeKind.Utc).AddTicks(4534), "", true, false, "Bilim Kurgu", null },
                    { new Guid("f90f5433-dfd5-4869-bfe1-018dc997fd0e"), new DateTime(2025, 6, 15, 12, 23, 33, 350, DateTimeKind.Utc).AddTicks(4541), "", true, false, "Korku", null }
                });
        }
    }
}
