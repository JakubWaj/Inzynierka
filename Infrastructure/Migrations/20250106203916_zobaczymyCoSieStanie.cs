using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class zobaczymyCoSieStanie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d137c45-1820-4179-939c-8d3398945d24"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("79b81560-7c0f-4437-ac96-0b79107f8fbf"));

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("049f7282-704f-496d-968d-3fcea78d3210"), new Guid("5f6ec42c-a26f-4319-b657-c04ce97077e5") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("71369f56-81d5-479f-a1f2-715f7bb1c5d8"), new Guid("69b1f1da-a63b-45a5-8e5e-3831194d43fd") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("049f7282-704f-496d-968d-3fcea78d3210"), new Guid("c519b60b-9c7f-4a7c-ab91-bcad634804af") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("7709d604-41bb-4da0-9a97-b6d9ea4e5aa8"), new Guid("e98c57fb-395e-40bb-ac20-0a8a378fb2ab") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("7709d604-41bb-4da0-9a97-b6d9ea4e5aa8"), new Guid("ec33ad72-61e1-4412-8afb-c1de726a2337") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("5f6ec42c-a26f-4319-b657-c04ce97077e5"), new Guid("697a7cc3-bce9-4834-ab85-47b406c19900") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("69b1f1da-a63b-45a5-8e5e-3831194d43fd"), new Guid("1066ad9b-95ac-4163-95b2-121faf9578ce") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("c519b60b-9c7f-4a7c-ab91-bcad634804af"), new Guid("07b05706-888e-4554-bea9-5fdc1c46c4da") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("e98c57fb-395e-40bb-ac20-0a8a378fb2ab"), new Guid("d1826578-75f9-43f2-a0f5-48e19bfa9542") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("ec33ad72-61e1-4412-8afb-c1de726a2337"), new Guid("c2ebb513-3286-4f2e-b5e6-bfc7e9e21ab9") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e8356a4-7e39-43f8-b050-e7e6051e07ba"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9dd3bdb8-0895-4024-8361-1c322a972b91"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9f7fde34-f5c4-4751-af55-16450ca78958"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bf3648ca-22ae-4545-b04c-5d8fb630dfaf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c9ebd325-a5e2-47e2-a6ef-b380a71136e9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("049f7282-704f-496d-968d-3fcea78d3210"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("71369f56-81d5-479f-a1f2-715f7bb1c5d8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7709d604-41bb-4da0-9a97-b6d9ea4e5aa8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5f6ec42c-a26f-4319-b657-c04ce97077e5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("69b1f1da-a63b-45a5-8e5e-3831194d43fd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c519b60b-9c7f-4a7c-ab91-bcad634804af"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e98c57fb-395e-40bb-ac20-0a8a378fb2ab"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ec33ad72-61e1-4412-8afb-c1de726a2337"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("04eb6adb-3fba-4082-8e91-6c7aa5689eaa"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("73368f36-366a-4494-b362-5660117e268a"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("aeba0617-b0ac-4b30-b186-c792be5cd702"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("ded56c9f-e056-463b-abd3-047d19580514"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("ff9cfb8b-0c91-438e-808e-d262df5d7f23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07b05706-888e-4554-bea9-5fdc1c46c4da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1066ad9b-95ac-4163-95b2-121faf9578ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("697a7cc3-bce9-4834-ab85-47b406c19900"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2ebb513-3286-4f2e-b5e6-bfc7e9e21ab9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1826578-75f9-43f2-a0f5-48e19bfa9542"));

            migrationBuilder.AddColumn<decimal>(
                name: "Popularity",
                table: "Movies",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Tmdb_Id",
                table: "Movies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("145805bc-90a5-4a9a-8fa8-7af6ab84b8b1"), "Poland" },
                    { new Guid("61654f41-705a-48a1-a278-3abbd44e2324"), "Japan" },
                    { new Guid("6bed9685-887f-4bd5-8d3f-9840cffa644b"), "United States" },
                    { new Guid("b4285968-661f-46aa-81c1-e88eaafe75db"), "Canada" },
                    { new Guid("c3978434-3ea9-40df-a333-1972d0b319dc"), "United Kingdom" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BoxOffice", "Description", "Duration", "Genre", "Image", "Popularity", "ReleaseDate", "Title", "Tmdb_Id", "UserId", "UserId1" },
                values: new object[,]
                {
                    { new Guid("2ce62ae7-f5ee-479c-9794-8965321c7ae3"), 395800000, "A young girl becomes trapped in a mysterious world of spirits and must find her way home.", 125, 3, null, 0m, new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away", 0, null, null },
                    { new Guid("7d41ddb3-1366-4dbf-8809-f5c3bb6af883"), 701729206, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", 169, 11, null, 0m, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar", 0, null, null },
                    { new Guid("9f360574-4a08-4b1e-87db-d774d4260be5"), 829895144, "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into a target's subconscious.", 148, 11, null, 0m, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception", 0, null, null },
                    { new Guid("de07043b-fdfc-468f-9e3e-f7fcfb10f4c6"), 466000000, "A hacker discovers the shocking truth about his world and his role in the fight to save humanity.", 136, 11, null, 0m, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix", 0, null, null },
                    { new Guid("f0ba6810-2c78-4840-a80d-6d0a2fb78b68"), 361000000, "Two teenagers share a profound connection after discovering they are swapping bodies.", 106, 3, null, 0m, new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Name", 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "BirthDate", "FirstName", "Image", "LastName" },
                values: new object[,]
                {
                    { new Guid("21570144-4bf3-4a71-b50d-a1d03fe6c44b"), "A British-American film director, producer, and screenwriter.", new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", null, "Nolan" },
                    { new Guid("414eab0c-a88f-44b6-9458-8a2f0ee0fc89"), "A Japanese animator, filmmaker, and manga artist.", new DateTime(1973, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makoto", null, "Shinkai" },
                    { new Guid("673bced8-fc8d-473c-900a-316a7fa14cdf"), "A legendary Japanese animator and filmmaker.", new DateTime(1941, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayao", null, "Miyazaki" },
                    { new Guid("6bf1f546-1ca2-4daa-87e7-405e5dfbd7ef"), "An actor known for his roles in The Matrix and John Wick.", new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keanu", null, "Reeves" },
                    { new Guid("f1ac190f-8bd7-4edd-ac99-9ad0b8a1a95d"), "An American actor and film producer.", new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonardo", null, "DiCaprio" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("3526d2b5-96d9-4091-88ca-e22ddcc36022"), "user5@example.com", "user5", "AQAAAAIAAYagAAAAEJYy4dVR5sLCL+MaCY9xanLD5/8JiBVTVqRUV0DubOH+YnikW2GytAu00BgknZQ7Tw==" },
                    { new Guid("439b6788-27b2-444f-b5ac-a79179305db2"), "user3@example.com", "user3", "AQAAAAIAAYagAAAAENDZXc/OT5Fj8CabysBSd45a/zb0cmHsMacsvjg3t1Mg+0y3F3WCbGYYv0k26/L+mQ==" },
                    { new Guid("abe9864a-684a-48ba-8243-26ad20093700"), "user4@example.com", "user4", "AQAAAAIAAYagAAAAEI85CFWZza+QsFzI8ehZRxp2b5BNxIzE9rz83mx7J7Fg0QQqAp6GDrhlCVcMRIK38w==" },
                    { new Guid("b41a1fe6-4693-48f5-b808-c780724e47a8"), "user2@example.com", "user2", "AQAAAAIAAYagAAAAEMzukbb2v1p/80HUm5qfKPDiXolCSf8m88ukoRqQrXBWC0uKQxGSW8Md6cOKnvuymw==" },
                    { new Guid("f87fca60-d4f9-41b5-a008-18224ecfdd23"), "user1@example.com", "user1", "AQAAAAIAAYagAAAAEB/qF65qpvgkgbfQcEhp7uszLOiyYjwI61UPb6Qndv8SHHRaqe6cwiNSI4Rt62adcw==" }
                });

            migrationBuilder.InsertData(
                table: "MovieCountries",
                columns: new[] { "CountryId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("61654f41-705a-48a1-a278-3abbd44e2324"), new Guid("2ce62ae7-f5ee-479c-9794-8965321c7ae3") },
                    { new Guid("145805bc-90a5-4a9a-8fa8-7af6ab84b8b1"), new Guid("7d41ddb3-1366-4dbf-8809-f5c3bb6af883") },
                    { new Guid("6bed9685-887f-4bd5-8d3f-9840cffa644b"), new Guid("9f360574-4a08-4b1e-87db-d774d4260be5") },
                    { new Guid("6bed9685-887f-4bd5-8d3f-9840cffa644b"), new Guid("de07043b-fdfc-468f-9e3e-f7fcfb10f4c6") },
                    { new Guid("61654f41-705a-48a1-a278-3abbd44e2324"), new Guid("f0ba6810-2c78-4840-a80d-6d0a2fb78b68") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "MovieId", "UserId", "Comment", "CreatedAt", "Id", "LastModifiedAt", "Rating" },
                values: new object[,]
                {
                    { new Guid("2ce62ae7-f5ee-479c-9794-8965321c7ae3"), new Guid("3526d2b5-96d9-4091-88ca-e22ddcc36022"), "A masterpiece of animation and storytelling.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e870d114-8b9b-4f24-9b1d-3281c0c5bf98"), null, 10 },
                    { new Guid("7d41ddb3-1366-4dbf-8809-f5c3bb6af883"), new Guid("abe9864a-684a-48ba-8243-26ad20093700"), "A mesmerizing journey through space and time.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d07962ea-5958-48fc-b0c4-18bae0d919ed"), null, 9 },
                    { new Guid("9f360574-4a08-4b1e-87db-d774d4260be5"), new Guid("f87fca60-d4f9-41b5-a008-18224ecfdd23"), "Amazing movie with a mind-blowing plot!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("91e0c611-1545-485f-b614-a29d5ba13b80"), null, 9 },
                    { new Guid("de07043b-fdfc-468f-9e3e-f7fcfb10f4c6"), new Guid("439b6788-27b2-444f-b5ac-a79179305db2"), "A groundbreaking film with iconic visuals.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0c508fd9-8c4b-4fa6-a835-cef505f526fb"), null, 10 },
                    { new Guid("f0ba6810-2c78-4840-a80d-6d0a2fb78b68"), new Guid("b41a1fe6-4693-48f5-b808-c780724e47a8"), "Beautifully animated and emotionally resonant.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("75c7f58b-a265-4d6f-b5d4-70c9c53f364e"), null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Character", "MovieId", "MovieProductionRole", "PersonId" },
                values: new object[,]
                {
                    { new Guid("2ce4c717-d391-41b7-9908-30b046889fc7"), "Neo", new Guid("de07043b-fdfc-468f-9e3e-f7fcfb10f4c6"), 0, new Guid("6bf1f546-1ca2-4daa-87e7-405e5dfbd7ef") },
                    { new Guid("8495dd65-4bb2-442a-8092-91110e9addce"), null, new Guid("2ce62ae7-f5ee-479c-9794-8965321c7ae3"), 1, new Guid("673bced8-fc8d-473c-900a-316a7fa14cdf") },
                    { new Guid("c00df965-15c3-4e27-8643-09bffadcb313"), null, new Guid("f0ba6810-2c78-4840-a80d-6d0a2fb78b68"), 1, new Guid("414eab0c-a88f-44b6-9458-8a2f0ee0fc89") },
                    { new Guid("d1e85235-df9b-4a38-93e5-99eba5a1691a"), null, new Guid("7d41ddb3-1366-4dbf-8809-f5c3bb6af883"), 1, new Guid("21570144-4bf3-4a71-b50d-a1d03fe6c44b") },
                    { new Guid("e0262992-175b-46e6-97df-5d9c72e870fd"), "Dom Cobb", new Guid("9f360574-4a08-4b1e-87db-d774d4260be5"), 0, new Guid("f1ac190f-8bd7-4edd-ac99-9ad0b8a1a95d") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b4285968-661f-46aa-81c1-e88eaafe75db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c3978434-3ea9-40df-a333-1972d0b319dc"));

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("61654f41-705a-48a1-a278-3abbd44e2324"), new Guid("2ce62ae7-f5ee-479c-9794-8965321c7ae3") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("145805bc-90a5-4a9a-8fa8-7af6ab84b8b1"), new Guid("7d41ddb3-1366-4dbf-8809-f5c3bb6af883") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("6bed9685-887f-4bd5-8d3f-9840cffa644b"), new Guid("9f360574-4a08-4b1e-87db-d774d4260be5") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("6bed9685-887f-4bd5-8d3f-9840cffa644b"), new Guid("de07043b-fdfc-468f-9e3e-f7fcfb10f4c6") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("61654f41-705a-48a1-a278-3abbd44e2324"), new Guid("f0ba6810-2c78-4840-a80d-6d0a2fb78b68") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("2ce62ae7-f5ee-479c-9794-8965321c7ae3"), new Guid("3526d2b5-96d9-4091-88ca-e22ddcc36022") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("7d41ddb3-1366-4dbf-8809-f5c3bb6af883"), new Guid("abe9864a-684a-48ba-8243-26ad20093700") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("9f360574-4a08-4b1e-87db-d774d4260be5"), new Guid("f87fca60-d4f9-41b5-a008-18224ecfdd23") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("de07043b-fdfc-468f-9e3e-f7fcfb10f4c6"), new Guid("439b6788-27b2-444f-b5ac-a79179305db2") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("f0ba6810-2c78-4840-a80d-6d0a2fb78b68"), new Guid("b41a1fe6-4693-48f5-b808-c780724e47a8") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2ce4c717-d391-41b7-9908-30b046889fc7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8495dd65-4bb2-442a-8092-91110e9addce"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c00df965-15c3-4e27-8643-09bffadcb313"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d1e85235-df9b-4a38-93e5-99eba5a1691a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e0262992-175b-46e6-97df-5d9c72e870fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("145805bc-90a5-4a9a-8fa8-7af6ab84b8b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61654f41-705a-48a1-a278-3abbd44e2324"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6bed9685-887f-4bd5-8d3f-9840cffa644b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2ce62ae7-f5ee-479c-9794-8965321c7ae3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7d41ddb3-1366-4dbf-8809-f5c3bb6af883"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9f360574-4a08-4b1e-87db-d774d4260be5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("de07043b-fdfc-468f-9e3e-f7fcfb10f4c6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f0ba6810-2c78-4840-a80d-6d0a2fb78b68"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("21570144-4bf3-4a71-b50d-a1d03fe6c44b"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("414eab0c-a88f-44b6-9458-8a2f0ee0fc89"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("673bced8-fc8d-473c-900a-316a7fa14cdf"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("6bf1f546-1ca2-4daa-87e7-405e5dfbd7ef"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("f1ac190f-8bd7-4edd-ac99-9ad0b8a1a95d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3526d2b5-96d9-4091-88ca-e22ddcc36022"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("439b6788-27b2-444f-b5ac-a79179305db2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abe9864a-684a-48ba-8243-26ad20093700"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b41a1fe6-4693-48f5-b808-c780724e47a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f87fca60-d4f9-41b5-a008-18224ecfdd23"));

            migrationBuilder.DropColumn(
                name: "Popularity",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Tmdb_Id",
                table: "Movies");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("049f7282-704f-496d-968d-3fcea78d3210"), "United States" },
                    { new Guid("5d137c45-1820-4179-939c-8d3398945d24"), "Canada" },
                    { new Guid("71369f56-81d5-479f-a1f2-715f7bb1c5d8"), "Poland" },
                    { new Guid("7709d604-41bb-4da0-9a97-b6d9ea4e5aa8"), "Japan" },
                    { new Guid("79b81560-7c0f-4437-ac96-0b79107f8fbf"), "United Kingdom" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BoxOffice", "Description", "Duration", "Genre", "Image", "ReleaseDate", "Title", "UserId", "UserId1" },
                values: new object[,]
                {
                    { new Guid("5f6ec42c-a26f-4319-b657-c04ce97077e5"), 466000000, "A hacker discovers the shocking truth about his world and his role in the fight to save humanity.", 136, 11, null, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix", null, null },
                    { new Guid("69b1f1da-a63b-45a5-8e5e-3831194d43fd"), 701729206, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", 169, 11, null, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar", null, null },
                    { new Guid("c519b60b-9c7f-4a7c-ab91-bcad634804af"), 829895144, "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into a target's subconscious.", 148, 11, null, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception", null, null },
                    { new Guid("e98c57fb-395e-40bb-ac20-0a8a378fb2ab"), 361000000, "Two teenagers share a profound connection after discovering they are swapping bodies.", 106, 3, null, new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Name", null, null },
                    { new Guid("ec33ad72-61e1-4412-8afb-c1de726a2337"), 395800000, "A young girl becomes trapped in a mysterious world of spirits and must find her way home.", 125, 3, null, new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away", null, null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "BirthDate", "FirstName", "Image", "LastName" },
                values: new object[,]
                {
                    { new Guid("04eb6adb-3fba-4082-8e91-6c7aa5689eaa"), "A British-American film director, producer, and screenwriter.", new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", null, "Nolan" },
                    { new Guid("73368f36-366a-4494-b362-5660117e268a"), "A legendary Japanese animator and filmmaker.", new DateTime(1941, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayao", null, "Miyazaki" },
                    { new Guid("aeba0617-b0ac-4b30-b186-c792be5cd702"), "An actor known for his roles in The Matrix and John Wick.", new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keanu", null, "Reeves" },
                    { new Guid("ded56c9f-e056-463b-abd3-047d19580514"), "A Japanese animator, filmmaker, and manga artist.", new DateTime(1973, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makoto", null, "Shinkai" },
                    { new Guid("ff9cfb8b-0c91-438e-808e-d262df5d7f23"), "An American actor and film producer.", new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonardo", null, "DiCaprio" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("07b05706-888e-4554-bea9-5fdc1c46c4da"), "user1@example.com", "user1", "AQAAAAIAAYagAAAAEFApde+LguRu/RDFHLsSCm/34PNoGHflOOIe/YB+ZA7A/Sr3W3syeDs7J1of6J4J/g==" },
                    { new Guid("1066ad9b-95ac-4163-95b2-121faf9578ce"), "user4@example.com", "user4", "AQAAAAIAAYagAAAAED3auLxQQh6locyE/U4vCirET2VQR3qaNI12yBWAyxhcRp9dexFI8daBCHQfI9z3DQ==" },
                    { new Guid("697a7cc3-bce9-4834-ab85-47b406c19900"), "user3@example.com", "user3", "AQAAAAIAAYagAAAAELAuvQESOwzQ9YV6PdnTME0z3wt1wrOhOvuV96p4zPMx13ofixADOi+bjN+5nGW5LQ==" },
                    { new Guid("c2ebb513-3286-4f2e-b5e6-bfc7e9e21ab9"), "user5@example.com", "user5", "AQAAAAIAAYagAAAAEIqF+VYsixsa7cyAsZw/boCqqmzuUYqD6CPDNQXt+ud6tgFzPXoS82sWDs6c/MaNfQ==" },
                    { new Guid("d1826578-75f9-43f2-a0f5-48e19bfa9542"), "user2@example.com", "user2", "AQAAAAIAAYagAAAAEBCsZO629LzOeeJYRvsOPmsJtJeP0BL3n6aXRumFHlwerZ9RQ2fxdonE3OnSgyfgEw==" }
                });

            migrationBuilder.InsertData(
                table: "MovieCountries",
                columns: new[] { "CountryId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("049f7282-704f-496d-968d-3fcea78d3210"), new Guid("5f6ec42c-a26f-4319-b657-c04ce97077e5") },
                    { new Guid("71369f56-81d5-479f-a1f2-715f7bb1c5d8"), new Guid("69b1f1da-a63b-45a5-8e5e-3831194d43fd") },
                    { new Guid("049f7282-704f-496d-968d-3fcea78d3210"), new Guid("c519b60b-9c7f-4a7c-ab91-bcad634804af") },
                    { new Guid("7709d604-41bb-4da0-9a97-b6d9ea4e5aa8"), new Guid("e98c57fb-395e-40bb-ac20-0a8a378fb2ab") },
                    { new Guid("7709d604-41bb-4da0-9a97-b6d9ea4e5aa8"), new Guid("ec33ad72-61e1-4412-8afb-c1de726a2337") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "MovieId", "UserId", "Comment", "CreatedAt", "Id", "LastModifiedAt", "Rating" },
                values: new object[,]
                {
                    { new Guid("5f6ec42c-a26f-4319-b657-c04ce97077e5"), new Guid("697a7cc3-bce9-4834-ab85-47b406c19900"), "A groundbreaking film with iconic visuals.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65f6f442-e3fc-4da1-9bd2-90bfccff657f"), null, 10 },
                    { new Guid("69b1f1da-a63b-45a5-8e5e-3831194d43fd"), new Guid("1066ad9b-95ac-4163-95b2-121faf9578ce"), "A mesmerizing journey through space and time.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3320c0e-e5d5-4fe5-9db1-c817ea421560"), null, 9 },
                    { new Guid("c519b60b-9c7f-4a7c-ab91-bcad634804af"), new Guid("07b05706-888e-4554-bea9-5fdc1c46c4da"), "Amazing movie with a mind-blowing plot!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d9f63c4c-8fce-4ddd-b0af-336a9f536cf1"), null, 9 },
                    { new Guid("e98c57fb-395e-40bb-ac20-0a8a378fb2ab"), new Guid("d1826578-75f9-43f2-a0f5-48e19bfa9542"), "Beautifully animated and emotionally resonant.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e83412cb-637b-43e4-830b-0ada140729ca"), null, 10 },
                    { new Guid("ec33ad72-61e1-4412-8afb-c1de726a2337"), new Guid("c2ebb513-3286-4f2e-b5e6-bfc7e9e21ab9"), "A masterpiece of animation and storytelling.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b553d513-b7cc-441c-aad8-704ffe486934"), null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Character", "MovieId", "MovieProductionRole", "PersonId" },
                values: new object[,]
                {
                    { new Guid("8e8356a4-7e39-43f8-b050-e7e6051e07ba"), null, new Guid("69b1f1da-a63b-45a5-8e5e-3831194d43fd"), 1, new Guid("04eb6adb-3fba-4082-8e91-6c7aa5689eaa") },
                    { new Guid("9dd3bdb8-0895-4024-8361-1c322a972b91"), null, new Guid("ec33ad72-61e1-4412-8afb-c1de726a2337"), 1, new Guid("73368f36-366a-4494-b362-5660117e268a") },
                    { new Guid("9f7fde34-f5c4-4751-af55-16450ca78958"), null, new Guid("e98c57fb-395e-40bb-ac20-0a8a378fb2ab"), 1, new Guid("ded56c9f-e056-463b-abd3-047d19580514") },
                    { new Guid("bf3648ca-22ae-4545-b04c-5d8fb630dfaf"), "Neo", new Guid("5f6ec42c-a26f-4319-b657-c04ce97077e5"), 0, new Guid("aeba0617-b0ac-4b30-b186-c792be5cd702") },
                    { new Guid("c9ebd325-a5e2-47e2-a6ef-b380a71136e9"), "Dom Cobb", new Guid("c519b60b-9c7f-4a7c-ab91-bcad634804af"), 0, new Guid("ff9cfb8b-0c91-438e-808e-d262df5d7f23") }
                });
        }
    }
}
