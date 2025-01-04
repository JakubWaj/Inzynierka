using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class relationshipsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b7e4d095-9c9a-4421-92c0-ab66bc11d7e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee7a433c-11ce-4442-99b7-7b0188c72af9"));

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("251012cb-a39d-46fd-81d9-60cf48a59904"), new Guid("1856aef9-396d-47b7-91e9-27dfbea71d8d") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("150bbb19-1d29-4ba8-aa8a-ba3e76841396"), new Guid("5e609a0c-27bf-4437-9ec7-3836cd5929ef") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("e2cf266b-e0eb-4503-81b5-98a5dcb89889"), new Guid("7a9cb18e-a425-4e43-990b-9be7ad58a46b") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("e2cf266b-e0eb-4503-81b5-98a5dcb89889"), new Guid("b1996f26-5af8-417e-8cd7-0bce4b4111e9") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("150bbb19-1d29-4ba8-aa8a-ba3e76841396"), new Guid("b85bf6f6-31b2-44c4-90be-970e74e84ef3") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("1856aef9-396d-47b7-91e9-27dfbea71d8d"), new Guid("72f63d2a-37c1-4960-a714-900a016c88e5") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("5e609a0c-27bf-4437-9ec7-3836cd5929ef"), new Guid("8bbf9984-3390-48c7-bee6-30f0c56f834a") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("7a9cb18e-a425-4e43-990b-9be7ad58a46b"), new Guid("6a188d1c-d9de-4c06-a9ee-c0dc62ed7701") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("b1996f26-5af8-417e-8cd7-0bce4b4111e9"), new Guid("688a1170-8654-4917-9c4e-dab56e27a87c") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("b85bf6f6-31b2-44c4-90be-970e74e84ef3"), new Guid("f34dc0fa-df2f-402b-a716-6e5263c5fa8d") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("24c076f1-6d18-4d58-adc0-78153c300e98"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4e6c6d8f-0554-48d6-b877-f4b2e8797016"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5a21cdf5-8554-4228-a08e-460f78db0324"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d03f852-eb41-4166-a84d-0514b1a1b5de"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92ea199b-8652-4770-9fd4-7be9eea8a3dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("150bbb19-1d29-4ba8-aa8a-ba3e76841396"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("251012cb-a39d-46fd-81d9-60cf48a59904"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e2cf266b-e0eb-4503-81b5-98a5dcb89889"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1856aef9-396d-47b7-91e9-27dfbea71d8d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5e609a0c-27bf-4437-9ec7-3836cd5929ef"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7a9cb18e-a425-4e43-990b-9be7ad58a46b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b1996f26-5af8-417e-8cd7-0bce4b4111e9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b85bf6f6-31b2-44c4-90be-970e74e84ef3"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("848cddef-20dc-40bf-bcc3-10d969d13659"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("90f93e70-3a2a-4e22-8a03-c9beb9324922"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("92fd249b-7536-4137-8224-220384951e7b"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("d531f225-c193-4226-bb2a-45a8eadc1760"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("e971ee9c-3527-4fc5-8875-176b676b2957"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("688a1170-8654-4917-9c4e-dab56e27a87c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a188d1c-d9de-4c06-a9ee-c0dc62ed7701"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72f63d2a-37c1-4960-a714-900a016c88e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8bbf9984-3390-48c7-bee6-30f0c56f834a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f34dc0fa-df2f-402b-a716-6e5263c5fa8d"));

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

            migrationBuilder.CreateIndex(
                name: "IX_WatchLaterMovies_MovieId",
                table: "WatchLaterMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchLaterMovies_UserId",
                table: "WatchLaterMovies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteMovies_MovieId",
                table: "FavoriteMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteMovies_UserId",
                table: "FavoriteMovies",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteMovies_Movies_MovieId",
                table: "FavoriteMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteMovies_Users_UserId",
                table: "FavoriteMovies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WatchLaterMovies_Movies_MovieId",
                table: "WatchLaterMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WatchLaterMovies_Users_UserId",
                table: "WatchLaterMovies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteMovies_Movies_MovieId",
                table: "FavoriteMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteMovies_Users_UserId",
                table: "FavoriteMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchLaterMovies_Movies_MovieId",
                table: "WatchLaterMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchLaterMovies_Users_UserId",
                table: "WatchLaterMovies");

            migrationBuilder.DropIndex(
                name: "IX_WatchLaterMovies_MovieId",
                table: "WatchLaterMovies");

            migrationBuilder.DropIndex(
                name: "IX_WatchLaterMovies_UserId",
                table: "WatchLaterMovies");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteMovies_MovieId",
                table: "FavoriteMovies");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteMovies_UserId",
                table: "FavoriteMovies");

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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("150bbb19-1d29-4ba8-aa8a-ba3e76841396"), "United States" },
                    { new Guid("251012cb-a39d-46fd-81d9-60cf48a59904"), "Poland" },
                    { new Guid("b7e4d095-9c9a-4421-92c0-ab66bc11d7e5"), "Canada" },
                    { new Guid("e2cf266b-e0eb-4503-81b5-98a5dcb89889"), "Japan" },
                    { new Guid("ee7a433c-11ce-4442-99b7-7b0188c72af9"), "United Kingdom" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BoxOffice", "Description", "Duration", "Genre", "Image", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("1856aef9-396d-47b7-91e9-27dfbea71d8d"), 701729206, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", 169, 11, null, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" },
                    { new Guid("5e609a0c-27bf-4437-9ec7-3836cd5929ef"), 829895144, "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into a target's subconscious.", 148, 11, null, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { new Guid("7a9cb18e-a425-4e43-990b-9be7ad58a46b"), 395800000, "A young girl becomes trapped in a mysterious world of spirits and must find her way home.", 125, 3, null, new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away" },
                    { new Guid("b1996f26-5af8-417e-8cd7-0bce4b4111e9"), 361000000, "Two teenagers share a profound connection after discovering they are swapping bodies.", 106, 3, null, new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Name" },
                    { new Guid("b85bf6f6-31b2-44c4-90be-970e74e84ef3"), 466000000, "A hacker discovers the shocking truth about his world and his role in the fight to save humanity.", 136, 11, null, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "BirthDate", "FirstName", "Image", "LastName" },
                values: new object[,]
                {
                    { new Guid("848cddef-20dc-40bf-bcc3-10d969d13659"), "A legendary Japanese animator and filmmaker.", new DateTime(1941, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayao", null, "Miyazaki" },
                    { new Guid("90f93e70-3a2a-4e22-8a03-c9beb9324922"), "An American actor and film producer.", new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonardo", null, "DiCaprio" },
                    { new Guid("92fd249b-7536-4137-8224-220384951e7b"), "An actor known for his roles in The Matrix and John Wick.", new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keanu", null, "Reeves" },
                    { new Guid("d531f225-c193-4226-bb2a-45a8eadc1760"), "A Japanese animator, filmmaker, and manga artist.", new DateTime(1973, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makoto", null, "Shinkai" },
                    { new Guid("e971ee9c-3527-4fc5-8875-176b676b2957"), "A British-American film director, producer, and screenwriter.", new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", null, "Nolan" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("688a1170-8654-4917-9c4e-dab56e27a87c"), "user2@example.com", "user2", "AQAAAAIAAYagAAAAEOm2CxDaB7ZplBcnVneJEkVrtmYj+ZxAjnFPomOm71QHov6hlyJMEZDMbV1IOcIdPw==" },
                    { new Guid("6a188d1c-d9de-4c06-a9ee-c0dc62ed7701"), "user5@example.com", "user5", "AQAAAAIAAYagAAAAEMKUVtE51I0q7+Lb42i9KyFDGTuEF0AW+mFTWZtsxsExqHPgrw2TX7IRCvVi9wgscg==" },
                    { new Guid("72f63d2a-37c1-4960-a714-900a016c88e5"), "user4@example.com", "user4", "AQAAAAIAAYagAAAAELvjmHpliysx1RBRP9U3gUfhFMOZG88x0MH21R6EBA0zSUvBhM1N4lLHMIlJlhE8YQ==" },
                    { new Guid("8bbf9984-3390-48c7-bee6-30f0c56f834a"), "user1@example.com", "user1", "AQAAAAIAAYagAAAAEETPdvSMv3P1Woex9Ax3BvP/RIDT/j8+1zxbLy+xZ9fPll1rITcJiWuttnegINFNoA==" },
                    { new Guid("f34dc0fa-df2f-402b-a716-6e5263c5fa8d"), "user3@example.com", "user3", "AQAAAAIAAYagAAAAEN26BmXhuKakNCduYPLT0Wtn2u+4rD7mSqbDBcltRVcAAqkAr+Wq9dqK+8kZI+OvDA==" }
                });

            migrationBuilder.InsertData(
                table: "MovieCountries",
                columns: new[] { "CountryId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("251012cb-a39d-46fd-81d9-60cf48a59904"), new Guid("1856aef9-396d-47b7-91e9-27dfbea71d8d") },
                    { new Guid("150bbb19-1d29-4ba8-aa8a-ba3e76841396"), new Guid("5e609a0c-27bf-4437-9ec7-3836cd5929ef") },
                    { new Guid("e2cf266b-e0eb-4503-81b5-98a5dcb89889"), new Guid("7a9cb18e-a425-4e43-990b-9be7ad58a46b") },
                    { new Guid("e2cf266b-e0eb-4503-81b5-98a5dcb89889"), new Guid("b1996f26-5af8-417e-8cd7-0bce4b4111e9") },
                    { new Guid("150bbb19-1d29-4ba8-aa8a-ba3e76841396"), new Guid("b85bf6f6-31b2-44c4-90be-970e74e84ef3") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "MovieId", "UserId", "Comment", "Id", "Rating" },
                values: new object[,]
                {
                    { new Guid("1856aef9-396d-47b7-91e9-27dfbea71d8d"), new Guid("72f63d2a-37c1-4960-a714-900a016c88e5"), "A mesmerizing journey through space and time.", new Guid("4db18e6a-410f-4c04-a577-252a19350f83"), 9 },
                    { new Guid("5e609a0c-27bf-4437-9ec7-3836cd5929ef"), new Guid("8bbf9984-3390-48c7-bee6-30f0c56f834a"), "Amazing movie with a mind-blowing plot!", new Guid("6ec146f9-fb0f-498d-8914-3069318d7a6e"), 9 },
                    { new Guid("7a9cb18e-a425-4e43-990b-9be7ad58a46b"), new Guid("6a188d1c-d9de-4c06-a9ee-c0dc62ed7701"), "A masterpiece of animation and storytelling.", new Guid("2d3b7787-6aff-461e-ba60-d9c440d2f4c3"), 10 },
                    { new Guid("b1996f26-5af8-417e-8cd7-0bce4b4111e9"), new Guid("688a1170-8654-4917-9c4e-dab56e27a87c"), "Beautifully animated and emotionally resonant.", new Guid("fc21dceb-3c5b-41b8-b16d-747d26dbdd3a"), 10 },
                    { new Guid("b85bf6f6-31b2-44c4-90be-970e74e84ef3"), new Guid("f34dc0fa-df2f-402b-a716-6e5263c5fa8d"), "A groundbreaking film with iconic visuals.", new Guid("c0aeca61-c8e0-4919-ae7e-7a95c6eee34b"), 10 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Character", "MovieId", "MovieProductionRole", "PersonId" },
                values: new object[,]
                {
                    { new Guid("24c076f1-6d18-4d58-adc0-78153c300e98"), null, new Guid("b1996f26-5af8-417e-8cd7-0bce4b4111e9"), 1, new Guid("d531f225-c193-4226-bb2a-45a8eadc1760") },
                    { new Guid("4e6c6d8f-0554-48d6-b877-f4b2e8797016"), null, new Guid("7a9cb18e-a425-4e43-990b-9be7ad58a46b"), 1, new Guid("848cddef-20dc-40bf-bcc3-10d969d13659") },
                    { new Guid("5a21cdf5-8554-4228-a08e-460f78db0324"), "Neo", new Guid("b85bf6f6-31b2-44c4-90be-970e74e84ef3"), 0, new Guid("92fd249b-7536-4137-8224-220384951e7b") },
                    { new Guid("8d03f852-eb41-4166-a84d-0514b1a1b5de"), "Dom Cobb", new Guid("5e609a0c-27bf-4437-9ec7-3836cd5929ef"), 0, new Guid("90f93e70-3a2a-4e22-8a03-c9beb9324922") },
                    { new Guid("92ea199b-8652-4770-9fd4-7be9eea8a3dd"), null, new Guid("1856aef9-396d-47b7-91e9-27dfbea71d8d"), 1, new Guid("e971ee9c-3527-4fc5-8875-176b676b2957") }
                });
        }
    }
}
