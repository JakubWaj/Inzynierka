using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66ef33c5-aa43-40c6-bf35-f1c0532d21e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("97778d24-60b8-4720-a88b-17da14a173bb"));

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("653a251a-f0c7-4383-b5a2-55704602e47b"), new Guid("495135e1-54bf-4e2b-bab7-92608dbddad9") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("aa96bd79-a049-4998-bbdc-735d04c4fa57"), new Guid("65045b08-a195-4fa6-820f-3ea94626a50b") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("210efd8c-e2a9-440f-806d-25cc434bca80"), new Guid("77010ed8-9fc6-42dc-8696-ad97fcb0fe93") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("210efd8c-e2a9-440f-806d-25cc434bca80"), new Guid("929c16a5-36d1-49bd-b458-02fe201c2562") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("aa96bd79-a049-4998-bbdc-735d04c4fa57"), new Guid("a84dcedb-b738-44c2-9aa0-a8814396411d") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("495135e1-54bf-4e2b-bab7-92608dbddad9"), new Guid("a528a64c-4fa3-4f4b-a2e8-1d303004769f") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("65045b08-a195-4fa6-820f-3ea94626a50b"), new Guid("88dab299-6ac5-4088-97bc-821c354c68a9") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("77010ed8-9fc6-42dc-8696-ad97fcb0fe93"), new Guid("e429fd86-95a9-44e0-9105-1547fd370eed") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("929c16a5-36d1-49bd-b458-02fe201c2562"), new Guid("2e20923f-2100-4c44-add9-5cb7f88b1601") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("a84dcedb-b738-44c2-9aa0-a8814396411d"), new Guid("b20469da-48fd-4674-8964-8e66a1babfa9") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("12d8d6f3-26bd-4ecf-8308-aec21fe81254"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a15e7f14-4f15-4867-b077-c57cb502b48e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c4cdb059-85f0-427c-bbc3-8d6569fc5e61"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c83a93ad-5b1c-4266-9297-b579e3a8a58f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ee3550ba-e7ec-405f-abfe-eded81a9ca6f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("210efd8c-e2a9-440f-806d-25cc434bca80"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("653a251a-f0c7-4383-b5a2-55704602e47b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa96bd79-a049-4998-bbdc-735d04c4fa57"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("495135e1-54bf-4e2b-bab7-92608dbddad9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("65045b08-a195-4fa6-820f-3ea94626a50b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("77010ed8-9fc6-42dc-8696-ad97fcb0fe93"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("929c16a5-36d1-49bd-b458-02fe201c2562"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a84dcedb-b738-44c2-9aa0-a8814396411d"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("1e56f7bb-4bbe-4f42-8798-88db2ba93b00"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("21fdad5f-dda3-42da-9c16-6b1f35dac51f"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("923a42eb-e5dc-4c80-806c-90852ff80e30"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("c19b7bea-f533-413d-bea4-a99028dd562c"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("c256e371-9c37-429a-85ca-26e5dbfc6987"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e20923f-2100-4c44-add9-5cb7f88b1601"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88dab299-6ac5-4088-97bc-821c354c68a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a528a64c-4fa3-4f4b-a2e8-1d303004769f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b20469da-48fd-4674-8964-8e66a1babfa9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e429fd86-95a9-44e0-9105-1547fd370eed"));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "People",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Movies",
                type: "text",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Image",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Movies");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("210efd8c-e2a9-440f-806d-25cc434bca80"), "Japan" },
                    { new Guid("653a251a-f0c7-4383-b5a2-55704602e47b"), "Poland" },
                    { new Guid("66ef33c5-aa43-40c6-bf35-f1c0532d21e7"), "United Kingdom" },
                    { new Guid("97778d24-60b8-4720-a88b-17da14a173bb"), "Canada" },
                    { new Guid("aa96bd79-a049-4998-bbdc-735d04c4fa57"), "United States" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BoxOffice", "Description", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("495135e1-54bf-4e2b-bab7-92608dbddad9"), 701729206, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", 169, 11, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" },
                    { new Guid("65045b08-a195-4fa6-820f-3ea94626a50b"), 466000000, "A hacker discovers the shocking truth about his world and his role in the fight to save humanity.", 136, 11, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" },
                    { new Guid("77010ed8-9fc6-42dc-8696-ad97fcb0fe93"), 395800000, "A young girl becomes trapped in a mysterious world of spirits and must find her way home.", 125, 3, new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away" },
                    { new Guid("929c16a5-36d1-49bd-b458-02fe201c2562"), 361000000, "Two teenagers share a profound connection after discovering they are swapping bodies.", 106, 3, new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Name" },
                    { new Guid("a84dcedb-b738-44c2-9aa0-a8814396411d"), 829895144, "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into a target's subconscious.", 148, 11, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("1e56f7bb-4bbe-4f42-8798-88db2ba93b00"), "A Japanese animator, filmmaker, and manga artist.", new DateTime(1973, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makoto", "Shinkai" },
                    { new Guid("21fdad5f-dda3-42da-9c16-6b1f35dac51f"), "A legendary Japanese animator and filmmaker.", new DateTime(1941, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayao", "Miyazaki" },
                    { new Guid("923a42eb-e5dc-4c80-806c-90852ff80e30"), "An American actor and film producer.", new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonardo", "DiCaprio" },
                    { new Guid("c19b7bea-f533-413d-bea4-a99028dd562c"), "An actor known for his roles in The Matrix and John Wick.", new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keanu", "Reeves" },
                    { new Guid("c256e371-9c37-429a-85ca-26e5dbfc6987"), "A British-American film director, producer, and screenwriter.", new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", "Nolan" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("2e20923f-2100-4c44-add9-5cb7f88b1601"), "user2@example.com", "user2", "AQAAAAIAAYagAAAAEI0zoskfxY2wjM0JnkUiiIAoVPA8lEtnyIxlie6Q45zpWD7AVJUjSF5pPH5EcuO23w==" },
                    { new Guid("88dab299-6ac5-4088-97bc-821c354c68a9"), "user3@example.com", "user3", "AQAAAAIAAYagAAAAEPnMtD29jOT/C7+jGgBkj3uoHEoBnL5gw40Bvk6/4XvmrbB5h4CCx/r7G2eh6eM9kg==" },
                    { new Guid("a528a64c-4fa3-4f4b-a2e8-1d303004769f"), "user4@example.com", "user4", "AQAAAAIAAYagAAAAEGtJpR05AwtU9dLXSJ+020c35N5JoYS2vNELF05WEak5mTle9HNkwr8N5XIH4+b2oA==" },
                    { new Guid("b20469da-48fd-4674-8964-8e66a1babfa9"), "user1@example.com", "user1", "AQAAAAIAAYagAAAAELsK/bFPLfXPjX3r4pC7CXtHY4Ahc9282iIw1fLdZqydw+Sxf/pgPt/GSjNNYIJvpg==" },
                    { new Guid("e429fd86-95a9-44e0-9105-1547fd370eed"), "user5@example.com", "user5", "AQAAAAIAAYagAAAAECcuuCeTO3MhD6HFHl/fqUz573591iwaEJWSz9rKQdeGHOVhUD5z66/mqQBDERiQdw==" }
                });

            migrationBuilder.InsertData(
                table: "MovieCountries",
                columns: new[] { "CountryId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("653a251a-f0c7-4383-b5a2-55704602e47b"), new Guid("495135e1-54bf-4e2b-bab7-92608dbddad9") },
                    { new Guid("aa96bd79-a049-4998-bbdc-735d04c4fa57"), new Guid("65045b08-a195-4fa6-820f-3ea94626a50b") },
                    { new Guid("210efd8c-e2a9-440f-806d-25cc434bca80"), new Guid("77010ed8-9fc6-42dc-8696-ad97fcb0fe93") },
                    { new Guid("210efd8c-e2a9-440f-806d-25cc434bca80"), new Guid("929c16a5-36d1-49bd-b458-02fe201c2562") },
                    { new Guid("aa96bd79-a049-4998-bbdc-735d04c4fa57"), new Guid("a84dcedb-b738-44c2-9aa0-a8814396411d") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "MovieId", "UserId", "Comment", "Id", "Rating" },
                values: new object[,]
                {
                    { new Guid("495135e1-54bf-4e2b-bab7-92608dbddad9"), new Guid("a528a64c-4fa3-4f4b-a2e8-1d303004769f"), "A mesmerizing journey through space and time.", new Guid("346f0a83-8322-4370-9ee5-566ab00f469d"), 9 },
                    { new Guid("65045b08-a195-4fa6-820f-3ea94626a50b"), new Guid("88dab299-6ac5-4088-97bc-821c354c68a9"), "A groundbreaking film with iconic visuals.", new Guid("5f528df9-8248-4fc2-82d5-d61ecdeb19a5"), 10 },
                    { new Guid("77010ed8-9fc6-42dc-8696-ad97fcb0fe93"), new Guid("e429fd86-95a9-44e0-9105-1547fd370eed"), "A masterpiece of animation and storytelling.", new Guid("5d7edc5b-2616-4637-b400-ab257fd51861"), 10 },
                    { new Guid("929c16a5-36d1-49bd-b458-02fe201c2562"), new Guid("2e20923f-2100-4c44-add9-5cb7f88b1601"), "Beautifully animated and emotionally resonant.", new Guid("32ce5383-c838-4c56-a04d-6ff207c3d540"), 10 },
                    { new Guid("a84dcedb-b738-44c2-9aa0-a8814396411d"), new Guid("b20469da-48fd-4674-8964-8e66a1babfa9"), "Amazing movie with a mind-blowing plot!", new Guid("e579fc8e-3c34-4830-8963-f84e7b2a387c"), 9 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Character", "MovieId", "MovieProductionRole", "PersonId" },
                values: new object[,]
                {
                    { new Guid("12d8d6f3-26bd-4ecf-8308-aec21fe81254"), null, new Guid("77010ed8-9fc6-42dc-8696-ad97fcb0fe93"), 1, new Guid("21fdad5f-dda3-42da-9c16-6b1f35dac51f") },
                    { new Guid("a15e7f14-4f15-4867-b077-c57cb502b48e"), "Dom Cobb", new Guid("a84dcedb-b738-44c2-9aa0-a8814396411d"), 0, new Guid("923a42eb-e5dc-4c80-806c-90852ff80e30") },
                    { new Guid("c4cdb059-85f0-427c-bbc3-8d6569fc5e61"), "Neo", new Guid("65045b08-a195-4fa6-820f-3ea94626a50b"), 0, new Guid("c19b7bea-f533-413d-bea4-a99028dd562c") },
                    { new Guid("c83a93ad-5b1c-4266-9297-b579e3a8a58f"), null, new Guid("495135e1-54bf-4e2b-bab7-92608dbddad9"), 1, new Guid("c256e371-9c37-429a-85ca-26e5dbfc6987") },
                    { new Guid("ee3550ba-e7ec-405f-abfe-eded81a9ca6f"), null, new Guid("929c16a5-36d1-49bd-b458-02fe201c2562"), 1, new Guid("1e56f7bb-4bbe-4f42-8798-88db2ba93b00") }
                });
        }
    }
}
