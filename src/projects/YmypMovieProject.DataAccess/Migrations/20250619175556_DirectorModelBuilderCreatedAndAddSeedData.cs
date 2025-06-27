using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DirectorModelBuilderCreatedAndAddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "LastName",
                table: "Directors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Directors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Directors",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Directors",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("21551b2d-56c5-48a8-b9c7-e18b6c0b70ff"), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3381), null, true, false, "Belgesel", null },
                    { new Guid("a8c2b86d-c99d-47e0-8d79-94daf24dcc6a"), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3386), null, true, false, "Korku", null },
                    { new Guid("ab856c83-0582-4564-a34d-a8722a6fe7d8"), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3384), null, true, false, "Fantastik", null },
                    { new Guid("b0aa4963-a87a-4d68-90cf-40a64a4aa00a"), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3373), null, true, false, "Aksiyon", null },
                    { new Guid("b8d9b759-0d67-4b2d-ac87-2f8e116e29de"), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3377), null, true, false, "Komedi", null },
                    { new Guid("bd3241d0-448a-47c0-9fd2-31b5946aa5df"), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3380), null, true, false, "Bilim Kurgu", null }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("24be6d8c-69c5-4254-a67b-27fbffd35bad"), new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3557), "British-American film director, producer, and screenwriter.", "Christopher", null, true, false, "Nolan", null },
                    { new Guid("4d90e54d-ff67-4799-9942-4da1f29094a3"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3567), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("6e855d3f-b1c6-4533-acbd-12fcbfe2cbd2"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3573), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null },
                    { new Guid("79fd1078-69f7-4057-97f1-4b843427424e"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3571), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("a55cf894-220d-4252-a690-dcd12e6a9a43"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3575), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21551b2d-56c5-48a8-b9c7-e18b6c0b70ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a8c2b86d-c99d-47e0-8d79-94daf24dcc6a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ab856c83-0582-4564-a34d-a8722a6fe7d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b0aa4963-a87a-4d68-90cf-40a64a4aa00a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8d9b759-0d67-4b2d-ac87-2f8e116e29de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd3241d0-448a-47c0-9fd2-31b5946aa5df"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("24be6d8c-69c5-4254-a67b-27fbffd35bad"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("4d90e54d-ff67-4799-9942-4da1f29094a3"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("6e855d3f-b1c6-4533-acbd-12fcbfe2cbd2"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("79fd1078-69f7-4057-97f1-4b843427424e"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("a55cf894-220d-4252-a690-dcd12e6a9a43"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Directors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
