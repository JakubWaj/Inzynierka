using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class trackingofreviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd9e967e-c0f2-44f3-915d-947e00df9683"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e25a0b55-6bd9-4653-9343-2de43392eb99"));

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("04ed8576-4077-4247-aba7-dd8ba5b4b2ff"), new Guid("0399e505-72b3-41a3-8104-e115aae5efb2") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("04ed8576-4077-4247-aba7-dd8ba5b4b2ff"), new Guid("3c989303-cf7d-4168-8981-1f6f74c6af13") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("8ca7d826-5cb0-4b47-acf4-8c20d1ff4673"), new Guid("4d2b3866-fee2-437f-bb3c-e999db43801e") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("a83f9cab-f057-42c1-901c-61b20aa4d2d4"), new Guid("51a86613-eb6f-4f10-b92b-8cc1c5006c53") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("a83f9cab-f057-42c1-901c-61b20aa4d2d4"), new Guid("a22c15f0-3d5b-4a43-8845-088c19524351") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("0399e505-72b3-41a3-8104-e115aae5efb2"), new Guid("1899382b-8095-4899-8b29-37f4694b423f") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("3c989303-cf7d-4168-8981-1f6f74c6af13"), new Guid("bd2fffcf-26fa-4e96-814b-9807f5483299") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("4d2b3866-fee2-437f-bb3c-e999db43801e"), new Guid("5b753a71-832b-4e3d-8c8f-a6b66a7b5c27") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("51a86613-eb6f-4f10-b92b-8cc1c5006c53"), new Guid("6f4c360b-a68e-47f2-9a68-aa7d555d3ae4") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("a22c15f0-3d5b-4a43-8845-088c19524351"), new Guid("462bae9a-9749-4bc6-b5e3-226b3f69d6b0") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("12e40896-b6f8-4b5b-bb93-bbbc1c4b1503"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3fca32f9-fb30-48ec-8019-fa383613c7b5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("96c0f442-e706-490a-90a8-e6545707265a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("aa3c69b8-a199-4c90-98bf-9dc01ccc074d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c4c4fc25-e500-4c0e-9500-b37a04dba12a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("04ed8576-4077-4247-aba7-dd8ba5b4b2ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ca7d826-5cb0-4b47-acf4-8c20d1ff4673"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a83f9cab-f057-42c1-901c-61b20aa4d2d4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0399e505-72b3-41a3-8104-e115aae5efb2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3c989303-cf7d-4168-8981-1f6f74c6af13"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4d2b3866-fee2-437f-bb3c-e999db43801e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("51a86613-eb6f-4f10-b92b-8cc1c5006c53"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a22c15f0-3d5b-4a43-8845-088c19524351"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("28aa74e3-b1e6-44f9-944f-668866c33b41"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("69caec9b-56dd-4d15-9d0d-d5668370055c"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("9efc04b6-11ca-4a07-a7d8-5cfb4db2de56"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("b191efb9-1058-409b-a329-df65ee74d376"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("db78cd89-0a8b-4fd0-a336-e2bc8043ea76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1899382b-8095-4899-8b29-37f4694b423f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("462bae9a-9749-4bc6-b5e3-226b3f69d6b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b753a71-832b-4e3d-8c8f-a6b66a7b5c27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f4c360b-a68e-47f2-9a68-aa7d555d3ae4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd2fffcf-26fa-4e96-814b-9807f5483299"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleReviews",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "RoleReviews",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Reviews",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Reviews",
                type: "timestamp with time zone",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "RoleReviews");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "RoleReviews");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Reviews");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("04ed8576-4077-4247-aba7-dd8ba5b4b2ff"), "United States" },
                    { new Guid("8ca7d826-5cb0-4b47-acf4-8c20d1ff4673"), "Poland" },
                    { new Guid("a83f9cab-f057-42c1-901c-61b20aa4d2d4"), "Japan" },
                    { new Guid("dd9e967e-c0f2-44f3-915d-947e00df9683"), "United Kingdom" },
                    { new Guid("e25a0b55-6bd9-4653-9343-2de43392eb99"), "Canada" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BoxOffice", "Description", "Duration", "Genre", "Image", "ReleaseDate", "Title", "UserId", "UserId1" },
                values: new object[,]
                {
                    { new Guid("0399e505-72b3-41a3-8104-e115aae5efb2"), 829895144, "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into a target's subconscious.", 148, 11, null, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception", null, null },
                    { new Guid("3c989303-cf7d-4168-8981-1f6f74c6af13"), 466000000, "A hacker discovers the shocking truth about his world and his role in the fight to save humanity.", 136, 11, null, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix", null, null },
                    { new Guid("4d2b3866-fee2-437f-bb3c-e999db43801e"), 701729206, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", 169, 11, null, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar", null, null },
                    { new Guid("51a86613-eb6f-4f10-b92b-8cc1c5006c53"), 361000000, "Two teenagers share a profound connection after discovering they are swapping bodies.", 106, 3, null, new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Name", null, null },
                    { new Guid("a22c15f0-3d5b-4a43-8845-088c19524351"), 395800000, "A young girl becomes trapped in a mysterious world of spirits and must find her way home.", 125, 3, null, new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away", null, null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "BirthDate", "FirstName", "Image", "LastName" },
                values: new object[,]
                {
                    { new Guid("28aa74e3-b1e6-44f9-944f-668866c33b41"), "A British-American film director, producer, and screenwriter.", new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", null, "Nolan" },
                    { new Guid("69caec9b-56dd-4d15-9d0d-d5668370055c"), "An actor known for his roles in The Matrix and John Wick.", new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keanu", null, "Reeves" },
                    { new Guid("9efc04b6-11ca-4a07-a7d8-5cfb4db2de56"), "An American actor and film producer.", new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonardo", null, "DiCaprio" },
                    { new Guid("b191efb9-1058-409b-a329-df65ee74d376"), "A legendary Japanese animator and filmmaker.", new DateTime(1941, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayao", null, "Miyazaki" },
                    { new Guid("db78cd89-0a8b-4fd0-a336-e2bc8043ea76"), "A Japanese animator, filmmaker, and manga artist.", new DateTime(1973, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makoto", null, "Shinkai" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("1899382b-8095-4899-8b29-37f4694b423f"), "user1@example.com", "user1", "AQAAAAIAAYagAAAAEMPEtkT/KQPmQwiWrYeq7spTQc/xNL61fqoUqL+3V7gnyfvkHPT1gQmFxtA15lFHbg==" },
                    { new Guid("462bae9a-9749-4bc6-b5e3-226b3f69d6b0"), "user5@example.com", "user5", "AQAAAAIAAYagAAAAEHSKhBuWlVe+SehB/MKaOzPK7ax/sVI6fWwbhQf5WFd9dOe6GnqSEVNYlRrp8YLC5Q==" },
                    { new Guid("5b753a71-832b-4e3d-8c8f-a6b66a7b5c27"), "user4@example.com", "user4", "AQAAAAIAAYagAAAAEJ8jKynPY8od1O9/E+LRgp8FuJPbAq2XRFcKu1T450dyvB22kt7Y+FgCEO43ydWaPA==" },
                    { new Guid("6f4c360b-a68e-47f2-9a68-aa7d555d3ae4"), "user2@example.com", "user2", "AQAAAAIAAYagAAAAEElON5EGpTKtIEv/krIfBrFnzXKHehlk4Ge8AqBhEQcKR2swZXOdwmNOHfaJHZEl3A==" },
                    { new Guid("bd2fffcf-26fa-4e96-814b-9807f5483299"), "user3@example.com", "user3", "AQAAAAIAAYagAAAAEGpFEpMoF/KH2lpZ4xHQxPMMuRD0a0eX3W0vWfT/N5tX/X7B0DVesHAozd2EPyvecA==" }
                });

            migrationBuilder.InsertData(
                table: "MovieCountries",
                columns: new[] { "CountryId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("04ed8576-4077-4247-aba7-dd8ba5b4b2ff"), new Guid("0399e505-72b3-41a3-8104-e115aae5efb2") },
                    { new Guid("04ed8576-4077-4247-aba7-dd8ba5b4b2ff"), new Guid("3c989303-cf7d-4168-8981-1f6f74c6af13") },
                    { new Guid("8ca7d826-5cb0-4b47-acf4-8c20d1ff4673"), new Guid("4d2b3866-fee2-437f-bb3c-e999db43801e") },
                    { new Guid("a83f9cab-f057-42c1-901c-61b20aa4d2d4"), new Guid("51a86613-eb6f-4f10-b92b-8cc1c5006c53") },
                    { new Guid("a83f9cab-f057-42c1-901c-61b20aa4d2d4"), new Guid("a22c15f0-3d5b-4a43-8845-088c19524351") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "MovieId", "UserId", "Comment", "Id", "Rating" },
                values: new object[,]
                {
                    { new Guid("0399e505-72b3-41a3-8104-e115aae5efb2"), new Guid("1899382b-8095-4899-8b29-37f4694b423f"), "Amazing movie with a mind-blowing plot!", new Guid("3fd8070f-312e-40b1-a5f5-7c00d5c838a5"), 9 },
                    { new Guid("3c989303-cf7d-4168-8981-1f6f74c6af13"), new Guid("bd2fffcf-26fa-4e96-814b-9807f5483299"), "A groundbreaking film with iconic visuals.", new Guid("9dd4d96c-2365-43d4-b64b-3b5593adfee4"), 10 },
                    { new Guid("4d2b3866-fee2-437f-bb3c-e999db43801e"), new Guid("5b753a71-832b-4e3d-8c8f-a6b66a7b5c27"), "A mesmerizing journey through space and time.", new Guid("f63329b5-07da-455c-81e9-b2cd981ee501"), 9 },
                    { new Guid("51a86613-eb6f-4f10-b92b-8cc1c5006c53"), new Guid("6f4c360b-a68e-47f2-9a68-aa7d555d3ae4"), "Beautifully animated and emotionally resonant.", new Guid("58f0a48a-6fa8-40cb-92cc-1811e05ea442"), 10 },
                    { new Guid("a22c15f0-3d5b-4a43-8845-088c19524351"), new Guid("462bae9a-9749-4bc6-b5e3-226b3f69d6b0"), "A masterpiece of animation and storytelling.", new Guid("d5466508-bda6-4371-9202-aec26cb2fa48"), 10 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Character", "MovieId", "MovieProductionRole", "PersonId" },
                values: new object[,]
                {
                    { new Guid("12e40896-b6f8-4b5b-bb93-bbbc1c4b1503"), null, new Guid("a22c15f0-3d5b-4a43-8845-088c19524351"), 1, new Guid("b191efb9-1058-409b-a329-df65ee74d376") },
                    { new Guid("3fca32f9-fb30-48ec-8019-fa383613c7b5"), null, new Guid("4d2b3866-fee2-437f-bb3c-e999db43801e"), 1, new Guid("28aa74e3-b1e6-44f9-944f-668866c33b41") },
                    { new Guid("96c0f442-e706-490a-90a8-e6545707265a"), null, new Guid("51a86613-eb6f-4f10-b92b-8cc1c5006c53"), 1, new Guid("db78cd89-0a8b-4fd0-a336-e2bc8043ea76") },
                    { new Guid("aa3c69b8-a199-4c90-98bf-9dc01ccc074d"), "Dom Cobb", new Guid("0399e505-72b3-41a3-8104-e115aae5efb2"), 0, new Guid("9efc04b6-11ca-4a07-a7d8-5cfb4db2de56") },
                    { new Guid("c4c4fc25-e500-4c0e-9500-b37a04dba12a"), "Neo", new Guid("3c989303-cf7d-4168-8981-1f6f74c6af13"), 0, new Guid("69caec9b-56dd-4d15-9d0d-d5668370055c") }
                });
        }
    }
}
