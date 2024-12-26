using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2d6fea9a-14b8-4dbb-a9e8-aa5d6d8bc30c"), "Poland" },
                    { new Guid("42e4b138-bb40-4073-9ec0-9fd3e2fffd36"), "United States" },
                    { new Guid("6ec91f5a-e7e0-443d-b437-c26c6ab0a367"), "Japan" },
                    { new Guid("c56f0b8b-b228-4558-b823-8f504ef236d0"), "United Kingdom" },
                    { new Guid("ce52f1cd-3e5b-4abe-8f77-d328334b3257"), "Canada" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BoxOffice", "Description", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("436c1737-55eb-4b31-bc33-6a5c98b424f3"), 361000000, "Two teenagers share a profound connection after discovering they are swapping bodies.", 106, 3, new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Name" },
                    { new Guid("558d0c1b-c9d8-45ca-9dfa-98e42de7153e"), 829895144, "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into a target's subconscious.", 148, 11, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { new Guid("8b78da46-34ea-4d5c-b624-1f6b37244aac"), 466000000, "A hacker discovers the shocking truth about his world and his role in the fight to save humanity.", 136, 11, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" },
                    { new Guid("a70f0951-6e25-4745-ba00-1822b30a76f7"), 395800000, "A young girl becomes trapped in a mysterious world of spirits and must find her way home.", 125, 3, new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away" },
                    { new Guid("dbbe9d3b-fdad-4019-a77d-2aed5990fd5c"), 701729206, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", 169, 11, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("42078b3c-7a7b-4f50-a515-46cd6dd47313"), "An American actor and film producer.", new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonardo", "DiCaprio" },
                    { new Guid("59494ac7-4b2f-48b4-8bde-12154c4b2959"), "A British-American film director, producer, and screenwriter.", new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", "Nolan" },
                    { new Guid("b29678fd-e162-4cfb-80fd-ac5550a1ab48"), "A legendary Japanese animator and filmmaker.", new DateTime(1941, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayao", "Miyazaki" },
                    { new Guid("b70ab35d-850e-42ec-8d0a-bec57910f478"), "A Japanese animator, filmmaker, and manga artist.", new DateTime(1973, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makoto", "Shinkai" },
                    { new Guid("e091878c-3250-4ed1-9065-c078ffbe1720"), "An actor known for his roles in The Matrix and John Wick.", new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keanu", "Reeves" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("23e002be-2e66-4854-a6a5-ac02723aacf8"), "user2@example.com", "user2", "AQAAAAIAAYagAAAAEDUfOB5tmFGFbqon05zoDAXfNDenqOFnslXDZAnMfmYdBwa+kWsl3zBKnR4+u+QWAg==" },
                    { new Guid("26c7dbca-6430-4da1-acb5-a9988be1daad"), "user1@example.com", "user1", "AQAAAAIAAYagAAAAEG3rDf3Y3DK/po6Svlk0BUEzcqlxhobKUo/bTUd9VnbTLQwe0fxNlkvYXyDuANiMSg==" },
                    { new Guid("4324d7b5-7337-4828-b4b5-e0ec79620e1c"), "user5@example.com", "user5", "AQAAAAIAAYagAAAAEODk/0cxdXE1x/YFpBqFDHw0teeManVuhOuF7D4tpoWKekhffOmoO2acW8wZiB0t4g==" },
                    { new Guid("5dfef033-ec42-44ac-9737-720f96e97b8b"), "user4@example.com", "user4", "AQAAAAIAAYagAAAAELNU6eptJ+OeCm7a6jNYBLKpGv1zbSDSwxeICkZWXQZqcnXAV9WQyYIIrfH0GhpCoA==" },
                    { new Guid("d48ac297-1879-4af2-ae79-b262af85e7a1"), "user3@example.com", "user3", "AQAAAAIAAYagAAAAECwuL81BKbQiqze0jm1+3KOIZpGokGzWkL+XSY5liamwID4lWevPnLgkuBTcsJFKoQ==" }
                });

            migrationBuilder.InsertData(
                table: "MovieCountries",
                columns: new[] { "CountryId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("6ec91f5a-e7e0-443d-b437-c26c6ab0a367"), new Guid("436c1737-55eb-4b31-bc33-6a5c98b424f3") },
                    { new Guid("42e4b138-bb40-4073-9ec0-9fd3e2fffd36"), new Guid("558d0c1b-c9d8-45ca-9dfa-98e42de7153e") },
                    { new Guid("42e4b138-bb40-4073-9ec0-9fd3e2fffd36"), new Guid("8b78da46-34ea-4d5c-b624-1f6b37244aac") },
                    { new Guid("6ec91f5a-e7e0-443d-b437-c26c6ab0a367"), new Guid("a70f0951-6e25-4745-ba00-1822b30a76f7") },
                    { new Guid("2d6fea9a-14b8-4dbb-a9e8-aa5d6d8bc30c"), new Guid("dbbe9d3b-fdad-4019-a77d-2aed5990fd5c") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "MovieId", "UserId", "Comment", "Id", "Rating" },
                values: new object[,]
                {
                    { new Guid("436c1737-55eb-4b31-bc33-6a5c98b424f3"), new Guid("23e002be-2e66-4854-a6a5-ac02723aacf8"), "Beautifully animated and emotionally resonant.", new Guid("f304888e-3a12-43d8-9404-a3690f400db9"), 10 },
                    { new Guid("558d0c1b-c9d8-45ca-9dfa-98e42de7153e"), new Guid("26c7dbca-6430-4da1-acb5-a9988be1daad"), "Amazing movie with a mind-blowing plot!", new Guid("26f109f7-2bd2-43b9-a375-c30a980f1539"), 9 },
                    { new Guid("8b78da46-34ea-4d5c-b624-1f6b37244aac"), new Guid("d48ac297-1879-4af2-ae79-b262af85e7a1"), "A groundbreaking film with iconic visuals.", new Guid("829c0a6b-cfad-421c-8e4c-2e0d98c545ca"), 10 },
                    { new Guid("a70f0951-6e25-4745-ba00-1822b30a76f7"), new Guid("4324d7b5-7337-4828-b4b5-e0ec79620e1c"), "A masterpiece of animation and storytelling.", new Guid("e2108b60-beba-47b1-aeba-3a3ae8af8567"), 10 },
                    { new Guid("dbbe9d3b-fdad-4019-a77d-2aed5990fd5c"), new Guid("5dfef033-ec42-44ac-9737-720f96e97b8b"), "A mesmerizing journey through space and time.", new Guid("6da95606-d947-492f-a0b7-f687ca8a4155"), 9 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Character", "MovieId", "MovieProductionRole", "PersonId" },
                values: new object[,]
                {
                    { new Guid("2a10fc8f-51e0-46aa-8e1f-4c2b9db50517"), "Neo", new Guid("8b78da46-34ea-4d5c-b624-1f6b37244aac"), 0, new Guid("e091878c-3250-4ed1-9065-c078ffbe1720") },
                    { new Guid("368e3fa6-4748-4fe8-ae83-e7d3408c22b2"), null, new Guid("dbbe9d3b-fdad-4019-a77d-2aed5990fd5c"), 1, new Guid("59494ac7-4b2f-48b4-8bde-12154c4b2959") },
                    { new Guid("9303d576-8b18-4cec-b7e9-50431485b9ae"), null, new Guid("a70f0951-6e25-4745-ba00-1822b30a76f7"), 1, new Guid("b29678fd-e162-4cfb-80fd-ac5550a1ab48") },
                    { new Guid("a50b9019-3b0f-4866-b0d5-1623bc16d452"), "Dom Cobb", new Guid("558d0c1b-c9d8-45ca-9dfa-98e42de7153e"), 0, new Guid("42078b3c-7a7b-4f50-a515-46cd6dd47313") },
                    { new Guid("d1e3256f-f31f-4024-9601-6eb5a78c0988"), null, new Guid("436c1737-55eb-4b31-bc33-6a5c98b424f3"), 1, new Guid("b70ab35d-850e-42ec-8d0a-bec57910f478") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c56f0b8b-b228-4558-b823-8f504ef236d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce52f1cd-3e5b-4abe-8f77-d328334b3257"));

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("6ec91f5a-e7e0-443d-b437-c26c6ab0a367"), new Guid("436c1737-55eb-4b31-bc33-6a5c98b424f3") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("42e4b138-bb40-4073-9ec0-9fd3e2fffd36"), new Guid("558d0c1b-c9d8-45ca-9dfa-98e42de7153e") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("42e4b138-bb40-4073-9ec0-9fd3e2fffd36"), new Guid("8b78da46-34ea-4d5c-b624-1f6b37244aac") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("6ec91f5a-e7e0-443d-b437-c26c6ab0a367"), new Guid("a70f0951-6e25-4745-ba00-1822b30a76f7") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("2d6fea9a-14b8-4dbb-a9e8-aa5d6d8bc30c"), new Guid("dbbe9d3b-fdad-4019-a77d-2aed5990fd5c") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("436c1737-55eb-4b31-bc33-6a5c98b424f3"), new Guid("23e002be-2e66-4854-a6a5-ac02723aacf8") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("558d0c1b-c9d8-45ca-9dfa-98e42de7153e"), new Guid("26c7dbca-6430-4da1-acb5-a9988be1daad") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("8b78da46-34ea-4d5c-b624-1f6b37244aac"), new Guid("d48ac297-1879-4af2-ae79-b262af85e7a1") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("a70f0951-6e25-4745-ba00-1822b30a76f7"), new Guid("4324d7b5-7337-4828-b4b5-e0ec79620e1c") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("dbbe9d3b-fdad-4019-a77d-2aed5990fd5c"), new Guid("5dfef033-ec42-44ac-9737-720f96e97b8b") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2a10fc8f-51e0-46aa-8e1f-4c2b9db50517"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("368e3fa6-4748-4fe8-ae83-e7d3408c22b2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9303d576-8b18-4cec-b7e9-50431485b9ae"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a50b9019-3b0f-4866-b0d5-1623bc16d452"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d1e3256f-f31f-4024-9601-6eb5a78c0988"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d6fea9a-14b8-4dbb-a9e8-aa5d6d8bc30c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("42e4b138-bb40-4073-9ec0-9fd3e2fffd36"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ec91f5a-e7e0-443d-b437-c26c6ab0a367"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("436c1737-55eb-4b31-bc33-6a5c98b424f3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("558d0c1b-c9d8-45ca-9dfa-98e42de7153e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8b78da46-34ea-4d5c-b624-1f6b37244aac"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a70f0951-6e25-4745-ba00-1822b30a76f7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dbbe9d3b-fdad-4019-a77d-2aed5990fd5c"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("42078b3c-7a7b-4f50-a515-46cd6dd47313"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("59494ac7-4b2f-48b4-8bde-12154c4b2959"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("b29678fd-e162-4cfb-80fd-ac5550a1ab48"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("b70ab35d-850e-42ec-8d0a-bec57910f478"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("e091878c-3250-4ed1-9065-c078ffbe1720"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23e002be-2e66-4854-a6a5-ac02723aacf8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26c7dbca-6430-4da1-acb5-a9988be1daad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4324d7b5-7337-4828-b4b5-e0ec79620e1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5dfef033-ec42-44ac-9737-720f96e97b8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d48ac297-1879-4af2-ae79-b262af85e7a1"));

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
    }
}
