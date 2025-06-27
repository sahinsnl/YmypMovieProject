using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MovieSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("b8d9b759-0d67-4b2d-ac87-2f8e116e29de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd3241d0-448a-47c0-9fd2-31b5946aa5df"));

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "IMDB",
                table: "Movies",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b0aa4963-a87a-4d68-90cf-40a64a4aa00a"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("08b15177-0a99-4fef-b8c9-f2b60a78b990"), new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4729), null, true, false, "Komedi", null },
                    { new Guid("9219b023-558b-4646-a09c-7e7454cc5c6d"), new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4731), null, true, false, "Bilim Kurgu", null },
                    { new Guid("9667a4ff-a431-4ef4-bf1e-f274dafd80dc"), new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4738), null, true, false, "Korku", null },
                    { new Guid("978adb51-6f78-4f4a-92b3-dd7b9e597cee"), new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4733), null, true, false, "Belgesel", null },
                    { new Guid("c6250467-f059-49de-9445-16c0e599275c"), new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4735), null, true, false, "Fantastik", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("24be6d8c-69c5-4254-a67b-27fbffd35bad"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4901));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("5755ecfe-95bf-45ea-b95f-d801461c14d2"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4919), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null },
                    { new Guid("c19f3acf-57b0-4f55-a092-e8033e693e69"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4911), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("c512226b-b68a-4699-818e-933960b6f6e3"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4917), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null },
                    { new Guid("f3660c9a-7ef8-417e-8de5-c7a89d30c69d"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4913), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "DirectorId", "IMDB", "ImageUrl", "IsActive", "IsDeleted", "Name", "PublishDate", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("6359386c-cb5f-4bda-a367-7c3ca848725a"), new Guid("b0aa4963-a87a-4d68-90cf-40a64a4aa00a"), new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4966), "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new Guid("24be6d8c-69c5-4254-a67b-27fbffd35bad"), 9.0m, null, true, false, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("88dbcdda-b576-41b0-bcda-2bddd7f08217"), new Guid("b0aa4963-a87a-4d68-90cf-40a64a4aa00a"), new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4971), "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", new Guid("24be6d8c-69c5-4254-a67b-27fbffd35bad"), 8.6m, null, true, false, "Interstellar", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c62a5ab2-4d0c-48b1-a5b1-e911e9283d19"), new Guid("b0aa4963-a87a-4d68-90cf-40a64a4aa00a"), new DateTime(2025, 6, 19, 18, 53, 57, 770, DateTimeKind.Utc).AddTicks(4956), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", new Guid("24be6d8c-69c5-4254-a67b-27fbffd35bad"), 8.8m, null, true, false, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08b15177-0a99-4fef-b8c9-f2b60a78b990"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9219b023-558b-4646-a09c-7e7454cc5c6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9667a4ff-a431-4ef4-bf1e-f274dafd80dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("978adb51-6f78-4f4a-92b3-dd7b9e597cee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6250467-f059-49de-9445-16c0e599275c"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("5755ecfe-95bf-45ea-b95f-d801461c14d2"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("c19f3acf-57b0-4f55-a092-e8033e693e69"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("c512226b-b68a-4699-818e-933960b6f6e3"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("f3660c9a-7ef8-417e-8de5-c7a89d30c69d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6359386c-cb5f-4bda-a367-7c3ca848725a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("88dbcdda-b576-41b0-bcda-2bddd7f08217"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c62a5ab2-4d0c-48b1-a5b1-e911e9283d19"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "IMDB",
                table: "Movies",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b0aa4963-a87a-4d68-90cf-40a64a4aa00a"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("21551b2d-56c5-48a8-b9c7-e18b6c0b70ff"), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3381), null, true, false, "Belgesel", null },
                    { new Guid("a8c2b86d-c99d-47e0-8d79-94daf24dcc6a"), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3386), null, true, false, "Korku", null },
                    { new Guid("ab856c83-0582-4564-a34d-a8722a6fe7d8"), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3384), null, true, false, "Fantastik", null },
                    { new Guid("b8d9b759-0d67-4b2d-ac87-2f8e116e29de"), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3377), null, true, false, "Komedi", null },
                    { new Guid("bd3241d0-448a-47c0-9fd2-31b5946aa5df"), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3380), null, true, false, "Bilim Kurgu", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("24be6d8c-69c5-4254-a67b-27fbffd35bad"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("4d90e54d-ff67-4799-9942-4da1f29094a3"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3567), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("6e855d3f-b1c6-4533-acbd-12fcbfe2cbd2"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3573), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null },
                    { new Guid("79fd1078-69f7-4057-97f1-4b843427424e"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3571), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("a55cf894-220d-4252-a690-dcd12e6a9a43"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 55, 55, 480, DateTimeKind.Utc).AddTicks(3575), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null }
                });
        }
    }
}
