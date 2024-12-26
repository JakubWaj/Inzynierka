using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("05bd6d76-1486-45d3-a6af-cba2cb9daa78"), "Poland" },
                    { new Guid("529a75e0-2dde-4d6b-a116-18ea72a9b3b1"), "Japan" },
                    { new Guid("df543187-8d33-4f11-9e68-8d79e9455871"), "United States" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BoxOffice", "Description", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("32d9b0b3-c768-46b2-8a8f-b463e848434e"), 829895144, "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into a target's subconscious.", 148, 11, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { new Guid("6321e29a-e363-426a-9c09-3725c9279679"), 361000000, "Two teenagers share a profound connection after discovering they are swapping bodies.", 106, 3, new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Name" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("845eec05-6916-4849-bd5a-46fdb78f3f60"), "A Japanese animator, filmmaker, and manga artist.", new DateTime(1973, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makoto", "Shinkai" },
                    { new Guid("a7c5517f-81a8-474c-9da5-c088be425f46"), "An American actor and film producer.", new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonardo", "DiCaprio" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("11966333-c91a-4d2c-8d13-002dfdf7cbab"), "user1@example.com", "user1", "AQAAAAIAAYagAAAAEAFQE8GLON+mqueUIfgJEnWymBieGh8zIVerizETqJZl2i/mUB25Df+MX57FtICaWQ==" },
                    { new Guid("50d3eeed-72ff-4f73-aa07-bc7963ce8895"), "user2@example.com", "user2", "AQAAAAIAAYagAAAAEFg8gyktZzm8+HSbgBKNwNClefPBXLpcq8jt5FdcqRa0LV99jQjIUfQj4q4sOT7Cfw==" }
                });

            migrationBuilder.InsertData(
                table: "MovieCountries",
                columns: new[] { "CountryId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("df543187-8d33-4f11-9e68-8d79e9455871"), new Guid("32d9b0b3-c768-46b2-8a8f-b463e848434e") },
                    { new Guid("529a75e0-2dde-4d6b-a116-18ea72a9b3b1"), new Guid("6321e29a-e363-426a-9c09-3725c9279679") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "MovieId", "UserId", "Comment", "Id", "Rating" },
                values: new object[,]
                {
                    { new Guid("32d9b0b3-c768-46b2-8a8f-b463e848434e"), new Guid("11966333-c91a-4d2c-8d13-002dfdf7cbab"), "Amazing movie with a mind-blowing plot!", new Guid("5b2acec3-9a84-45e5-9f09-b1c5b0a09db8"), 9 },
                    { new Guid("6321e29a-e363-426a-9c09-3725c9279679"), new Guid("50d3eeed-72ff-4f73-aa07-bc7963ce8895"), "Beautifully animated and emotionally resonant.", new Guid("30177ed8-7be3-4a38-ba05-43cb30988e28"), 10 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Character", "MovieId", "MovieProductionRole", "PersonId" },
                values: new object[,]
                {
                    { new Guid("2e01be26-1f74-4bd6-9795-bcaea55ade77"), null, new Guid("6321e29a-e363-426a-9c09-3725c9279679"), 1, new Guid("845eec05-6916-4849-bd5a-46fdb78f3f60") },
                    { new Guid("5236cb63-caa5-4b79-865b-87a0e8291bb0"), "Dom Cobb", new Guid("32d9b0b3-c768-46b2-8a8f-b463e848434e"), 0, new Guid("a7c5517f-81a8-474c-9da5-c088be425f46") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("05bd6d76-1486-45d3-a6af-cba2cb9daa78"));

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("df543187-8d33-4f11-9e68-8d79e9455871"), new Guid("32d9b0b3-c768-46b2-8a8f-b463e848434e") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("529a75e0-2dde-4d6b-a116-18ea72a9b3b1"), new Guid("6321e29a-e363-426a-9c09-3725c9279679") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("32d9b0b3-c768-46b2-8a8f-b463e848434e"), new Guid("11966333-c91a-4d2c-8d13-002dfdf7cbab") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("6321e29a-e363-426a-9c09-3725c9279679"), new Guid("50d3eeed-72ff-4f73-aa07-bc7963ce8895") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2e01be26-1f74-4bd6-9795-bcaea55ade77"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5236cb63-caa5-4b79-865b-87a0e8291bb0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("529a75e0-2dde-4d6b-a116-18ea72a9b3b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df543187-8d33-4f11-9e68-8d79e9455871"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("32d9b0b3-c768-46b2-8a8f-b463e848434e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6321e29a-e363-426a-9c09-3725c9279679"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("845eec05-6916-4849-bd5a-46fdb78f3f60"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("a7c5517f-81a8-474c-9da5-c088be425f46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11966333-c91a-4d2c-8d13-002dfdf7cbab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50d3eeed-72ff-4f73-aa07-bc7963ce8895"));
        }
    }
}
