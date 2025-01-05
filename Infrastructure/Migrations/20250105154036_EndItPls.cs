using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EndItPls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("230826b8-e6bf-447d-ad0a-247d912fe606"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b956822e-7c58-4c19-938e-9784842b7b12"));

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("cf49ec18-c626-447e-945a-0ed9c4bafaad"), new Guid("3789dac6-1502-4ccd-9547-aa2d00f41541") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("a7c19289-70ec-40a4-95c6-0986a487089d"), new Guid("6b95fd0a-970c-4bd7-89b0-b7c42d2320aa") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("cf49ec18-c626-447e-945a-0ed9c4bafaad"), new Guid("a096e6eb-6c1c-4c7a-bebb-352499887384") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("a7c19289-70ec-40a4-95c6-0986a487089d"), new Guid("dcd57444-0ae3-4f8c-9a2e-5a9017fceebf") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("47a38d74-2dad-48f8-8726-d7e64fb59cda"), new Guid("f86c645d-66aa-4edb-b9aa-347120356f0c") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("3789dac6-1502-4ccd-9547-aa2d00f41541"), new Guid("82ae5918-6800-46ed-9f07-a99e9e153b82") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("6b95fd0a-970c-4bd7-89b0-b7c42d2320aa"), new Guid("f485e707-2c84-4351-9b43-747284208abe") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("a096e6eb-6c1c-4c7a-bebb-352499887384"), new Guid("2fb78001-03a5-48af-8424-961af5d3c2f7") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("dcd57444-0ae3-4f8c-9a2e-5a9017fceebf"), new Guid("31d07396-1077-4b24-97c9-4869f9697375") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("f86c645d-66aa-4edb-b9aa-347120356f0c"), new Guid("ac9217a1-10d3-4584-af68-6af4fe3241a0") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("21848865-c1b0-4a7f-a42c-a43a80c84767"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2a1d0001-09cb-4263-8cdf-bbccfd26e41d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b8761716-44fa-4344-b004-e9797f097dbd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3eb0997-32bf-44ae-9634-1cc37f6d459b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d8c038fd-f498-4e51-8b78-dc976c494144"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("47a38d74-2dad-48f8-8726-d7e64fb59cda"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a7c19289-70ec-40a4-95c6-0986a487089d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cf49ec18-c626-447e-945a-0ed9c4bafaad"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3789dac6-1502-4ccd-9547-aa2d00f41541"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6b95fd0a-970c-4bd7-89b0-b7c42d2320aa"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a096e6eb-6c1c-4c7a-bebb-352499887384"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dcd57444-0ae3-4f8c-9a2e-5a9017fceebf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f86c645d-66aa-4edb-b9aa-347120356f0c"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("0d74da9a-8e31-4306-8155-b1104ac2e828"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("7c3877b7-e5e3-427b-a5b3-d53f439ee0fd"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("a1b0848b-d263-4a13-99d1-c52fd877a767"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("d58c9197-5a68-4ed3-a0fe-beb9919b7011"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("f5c59a60-a5ac-48a8-bebd-b47dd6e9cb44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2fb78001-03a5-48af-8424-961af5d3c2f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31d07396-1077-4b24-97c9-4869f9697375"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82ae5918-6800-46ed-9f07-a99e9e153b82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac9217a1-10d3-4584-af68-6af4fe3241a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f485e707-2c84-4351-9b43-747284208abe"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Movies",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "Movies",
                type: "uuid",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Movies_UserId",
                table: "Movies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_UserId1",
                table: "Movies",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Users_UserId",
                table: "Movies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Users_UserId1",
                table: "Movies",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Users_UserId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Users_UserId1",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_UserId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_UserId1",
                table: "Movies");

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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Movies");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("230826b8-e6bf-447d-ad0a-247d912fe606"), "Canada" },
                    { new Guid("47a38d74-2dad-48f8-8726-d7e64fb59cda"), "Poland" },
                    { new Guid("a7c19289-70ec-40a4-95c6-0986a487089d"), "Japan" },
                    { new Guid("b956822e-7c58-4c19-938e-9784842b7b12"), "United Kingdom" },
                    { new Guid("cf49ec18-c626-447e-945a-0ed9c4bafaad"), "United States" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BoxOffice", "Description", "Duration", "Genre", "Image", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("3789dac6-1502-4ccd-9547-aa2d00f41541"), 829895144, "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into a target's subconscious.", 148, 11, null, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { new Guid("6b95fd0a-970c-4bd7-89b0-b7c42d2320aa"), 361000000, "Two teenagers share a profound connection after discovering they are swapping bodies.", 106, 3, null, new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Name" },
                    { new Guid("a096e6eb-6c1c-4c7a-bebb-352499887384"), 466000000, "A hacker discovers the shocking truth about his world and his role in the fight to save humanity.", 136, 11, null, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" },
                    { new Guid("dcd57444-0ae3-4f8c-9a2e-5a9017fceebf"), 395800000, "A young girl becomes trapped in a mysterious world of spirits and must find her way home.", 125, 3, null, new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away" },
                    { new Guid("f86c645d-66aa-4edb-b9aa-347120356f0c"), 701729206, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", 169, 11, null, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "BirthDate", "FirstName", "Image", "LastName" },
                values: new object[,]
                {
                    { new Guid("0d74da9a-8e31-4306-8155-b1104ac2e828"), "A Japanese animator, filmmaker, and manga artist.", new DateTime(1973, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makoto", null, "Shinkai" },
                    { new Guid("7c3877b7-e5e3-427b-a5b3-d53f439ee0fd"), "An actor known for his roles in The Matrix and John Wick.", new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keanu", null, "Reeves" },
                    { new Guid("a1b0848b-d263-4a13-99d1-c52fd877a767"), "A British-American film director, producer, and screenwriter.", new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", null, "Nolan" },
                    { new Guid("d58c9197-5a68-4ed3-a0fe-beb9919b7011"), "A legendary Japanese animator and filmmaker.", new DateTime(1941, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayao", null, "Miyazaki" },
                    { new Guid("f5c59a60-a5ac-48a8-bebd-b47dd6e9cb44"), "An American actor and film producer.", new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonardo", null, "DiCaprio" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("2fb78001-03a5-48af-8424-961af5d3c2f7"), "user3@example.com", "user3", "AQAAAAIAAYagAAAAEFBcGyJ9cRG1zO8o82iwa2X97rByG0vzryewmEvsdpQl6bo+Df2n+hGHoLGJn8bJPw==" },
                    { new Guid("31d07396-1077-4b24-97c9-4869f9697375"), "user5@example.com", "user5", "AQAAAAIAAYagAAAAEHm5n1vdT4MpLcCVKqdI8wJ3NySWlcgA6KE1pA4ghYnEvzYv6c8+Az2FnZFbtW5XOg==" },
                    { new Guid("82ae5918-6800-46ed-9f07-a99e9e153b82"), "user1@example.com", "user1", "AQAAAAIAAYagAAAAEGW7XXyIoWJMX+Hr0uBHPqgIwY1MLHZ9GUvXTdN2CyBdU/WAS/jHTFm5NJqsTzrh0A==" },
                    { new Guid("ac9217a1-10d3-4584-af68-6af4fe3241a0"), "user4@example.com", "user4", "AQAAAAIAAYagAAAAECEtZqEBF2uxzKC1jy/oxKo/lVcnpQbQ+FQuTGfsIQppSDPla4nM4XfOCiDYp9iC2A==" },
                    { new Guid("f485e707-2c84-4351-9b43-747284208abe"), "user2@example.com", "user2", "AQAAAAIAAYagAAAAEMXCdB32W46kK99jmcUNjweDfsxX1ryRD7Ux2amLra2NfKfx7yFA1uZfWri7zMhTqA==" }
                });

            migrationBuilder.InsertData(
                table: "MovieCountries",
                columns: new[] { "CountryId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("cf49ec18-c626-447e-945a-0ed9c4bafaad"), new Guid("3789dac6-1502-4ccd-9547-aa2d00f41541") },
                    { new Guid("a7c19289-70ec-40a4-95c6-0986a487089d"), new Guid("6b95fd0a-970c-4bd7-89b0-b7c42d2320aa") },
                    { new Guid("cf49ec18-c626-447e-945a-0ed9c4bafaad"), new Guid("a096e6eb-6c1c-4c7a-bebb-352499887384") },
                    { new Guid("a7c19289-70ec-40a4-95c6-0986a487089d"), new Guid("dcd57444-0ae3-4f8c-9a2e-5a9017fceebf") },
                    { new Guid("47a38d74-2dad-48f8-8726-d7e64fb59cda"), new Guid("f86c645d-66aa-4edb-b9aa-347120356f0c") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "MovieId", "UserId", "Comment", "Id", "Rating" },
                values: new object[,]
                {
                    { new Guid("3789dac6-1502-4ccd-9547-aa2d00f41541"), new Guid("82ae5918-6800-46ed-9f07-a99e9e153b82"), "Amazing movie with a mind-blowing plot!", new Guid("1fcda9f3-1d72-49e8-ad32-764c9bc1e882"), 9 },
                    { new Guid("6b95fd0a-970c-4bd7-89b0-b7c42d2320aa"), new Guid("f485e707-2c84-4351-9b43-747284208abe"), "Beautifully animated and emotionally resonant.", new Guid("24aaaa88-6ca7-4455-8b7a-e76750aeab22"), 10 },
                    { new Guid("a096e6eb-6c1c-4c7a-bebb-352499887384"), new Guid("2fb78001-03a5-48af-8424-961af5d3c2f7"), "A groundbreaking film with iconic visuals.", new Guid("0d8b8b69-bb92-4264-8323-0f359229b05e"), 10 },
                    { new Guid("dcd57444-0ae3-4f8c-9a2e-5a9017fceebf"), new Guid("31d07396-1077-4b24-97c9-4869f9697375"), "A masterpiece of animation and storytelling.", new Guid("7ef5bb6f-e94d-4f80-ac49-6cd4b60d94c4"), 10 },
                    { new Guid("f86c645d-66aa-4edb-b9aa-347120356f0c"), new Guid("ac9217a1-10d3-4584-af68-6af4fe3241a0"), "A mesmerizing journey through space and time.", new Guid("4a8a8e1a-d371-498b-a22d-3b7679ece9ce"), 9 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Character", "MovieId", "MovieProductionRole", "PersonId" },
                values: new object[,]
                {
                    { new Guid("21848865-c1b0-4a7f-a42c-a43a80c84767"), null, new Guid("6b95fd0a-970c-4bd7-89b0-b7c42d2320aa"), 1, new Guid("0d74da9a-8e31-4306-8155-b1104ac2e828") },
                    { new Guid("2a1d0001-09cb-4263-8cdf-bbccfd26e41d"), null, new Guid("f86c645d-66aa-4edb-b9aa-347120356f0c"), 1, new Guid("a1b0848b-d263-4a13-99d1-c52fd877a767") },
                    { new Guid("b8761716-44fa-4344-b004-e9797f097dbd"), null, new Guid("dcd57444-0ae3-4f8c-9a2e-5a9017fceebf"), 1, new Guid("d58c9197-5a68-4ed3-a0fe-beb9919b7011") },
                    { new Guid("c3eb0997-32bf-44ae-9634-1cc37f6d459b"), "Neo", new Guid("a096e6eb-6c1c-4c7a-bebb-352499887384"), 0, new Guid("7c3877b7-e5e3-427b-a5b3-d53f439ee0fd") },
                    { new Guid("d8c038fd-f498-4e51-8b78-dc976c494144"), "Dom Cobb", new Guid("3789dac6-1502-4ccd-9547-aa2d00f41541"), 0, new Guid("f5c59a60-a5ac-48a8-bebd-b47dd6e9cb44") }
                });
        }
    }
}
