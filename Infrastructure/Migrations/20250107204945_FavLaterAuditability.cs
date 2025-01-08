using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FavLaterAuditability : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "WatchLaterMovies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "WatchLaterMovies",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "FavoriteMovies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "FavoriteMovies",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6fc6bc50-104f-418a-9295-aeca8ce5ab6a"), "United Kingdom" },
                    { new Guid("800bb8c7-3160-4982-9c0b-7f76d03799cc"), "Japan" },
                    { new Guid("da6d65f0-ff4c-4056-89a0-a734b421828c"), "United States" },
                    { new Guid("dba1e6a6-bf44-4cec-a9c0-05fa5441cf9a"), "Poland" },
                    { new Guid("f21fd4ee-fd3e-4947-81d8-63f1becf0dee"), "Canada" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BoxOffice", "Description", "Duration", "Genre", "Image", "Popularity", "ReleaseDate", "Title", "Tmdb_Id", "UserId", "UserId1" },
                values: new object[,]
                {
                    { new Guid("84269730-4df1-4628-8441-3c2e283799ec"), 395800000, "A young girl becomes trapped in a mysterious world of spirits and must find her way home.", 125, 3, null, 0m, new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away", 0, null, null },
                    { new Guid("9c88ae57-fd1c-4cc1-92d3-8f9da2504fb5"), 466000000, "A hacker discovers the shocking truth about his world and his role in the fight to save humanity.", 136, 11, null, 0m, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix", 0, null, null },
                    { new Guid("bc65dd82-ef0e-49cc-9e08-043a0d87f596"), 701729206, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", 169, 11, null, 0m, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar", 0, null, null },
                    { new Guid("d3e3acc3-fb71-44fa-950d-ffbc7f93fb58"), 361000000, "Two teenagers share a profound connection after discovering they are swapping bodies.", 106, 3, null, 0m, new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your Name", 0, null, null },
                    { new Guid("ee480267-4569-4d91-bc56-49bc9c157491"), 829895144, "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into a target's subconscious.", 148, 11, null, 0m, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception", 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "BirthDate", "FirstName", "Image", "LastName" },
                values: new object[,]
                {
                    { new Guid("139d9b58-a796-4515-9c61-b48c4c0eb942"), "A Japanese animator, filmmaker, and manga artist.", new DateTime(1973, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Makoto", null, "Shinkai" },
                    { new Guid("1ff49701-032a-4405-b26e-3b96d575d4b7"), "An American actor and film producer.", new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonardo", null, "DiCaprio" },
                    { new Guid("940cd656-4178-4810-9166-a5abec8b8712"), "An actor known for his roles in The Matrix and John Wick.", new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keanu", null, "Reeves" },
                    { new Guid("98e935b8-fd17-45b5-a5a5-f7d010e7d0e2"), "A legendary Japanese animator and filmmaker.", new DateTime(1941, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayao", null, "Miyazaki" },
                    { new Guid("dddb188c-5489-476d-9413-f7d8ac08aaa1"), "A British-American film director, producer, and screenwriter.", new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", null, "Nolan" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("010a3aa6-3023-4939-b646-987db03852bb"), "user3@example.com", "user3", "AQAAAAIAAYagAAAAEO92a2iGMb/azqaQrfldAHvmWqgxDEyCdAhlFbwn74nqkxy9ScAzh/LGxCHdIDZVVg==" },
                    { new Guid("96eb1376-2269-43db-83e7-2845357e8673"), "user5@example.com", "user5", "AQAAAAIAAYagAAAAELwFCL9SG+7FjibZGuveD2yCJVONKFzRRxdsGaD5p+kgrgcvbaFNt65zTEVLU4FTPQ==" },
                    { new Guid("ba961562-7765-4931-9f17-ad8c8739467e"), "user4@example.com", "user4", "AQAAAAIAAYagAAAAEDQYcAYcH2y4lnFK8PS2gbn2P71YHm3V3oFdgVNMR3eyUCn+eDBpWNBWoj5FIMeORA==" },
                    { new Guid("c847763c-e90f-479f-9073-5f8574c393c2"), "user1@example.com", "user1", "AQAAAAIAAYagAAAAEDxcZzIxREuWNkzw/cRkWoGn7ie9UFySU/5uNFSde79kqSKek2d90Cgs2Rit2Yt5xQ==" },
                    { new Guid("d195231b-b72b-45b7-b4a3-8baf1e63203f"), "user2@example.com", "user2", "AQAAAAIAAYagAAAAEH7gNaympGqZE4uDj1jsqvFIszvixLJ6PwfE1f/bd8COAl8CnX4W/joKb/dAZ1ql1g==" }
                });

            migrationBuilder.InsertData(
                table: "MovieCountries",
                columns: new[] { "CountryId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("800bb8c7-3160-4982-9c0b-7f76d03799cc"), new Guid("84269730-4df1-4628-8441-3c2e283799ec") },
                    { new Guid("da6d65f0-ff4c-4056-89a0-a734b421828c"), new Guid("9c88ae57-fd1c-4cc1-92d3-8f9da2504fb5") },
                    { new Guid("dba1e6a6-bf44-4cec-a9c0-05fa5441cf9a"), new Guid("bc65dd82-ef0e-49cc-9e08-043a0d87f596") },
                    { new Guid("800bb8c7-3160-4982-9c0b-7f76d03799cc"), new Guid("d3e3acc3-fb71-44fa-950d-ffbc7f93fb58") },
                    { new Guid("da6d65f0-ff4c-4056-89a0-a734b421828c"), new Guid("ee480267-4569-4d91-bc56-49bc9c157491") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "MovieId", "UserId", "Comment", "CreatedAt", "Id", "LastModifiedAt", "Rating" },
                values: new object[,]
                {
                    { new Guid("84269730-4df1-4628-8441-3c2e283799ec"), new Guid("96eb1376-2269-43db-83e7-2845357e8673"), "A masterpiece of animation and storytelling.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0d2498e1-3ba1-4091-96a2-764ede5f6b9f"), null, 10 },
                    { new Guid("9c88ae57-fd1c-4cc1-92d3-8f9da2504fb5"), new Guid("010a3aa6-3023-4939-b646-987db03852bb"), "A groundbreaking film with iconic visuals.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c39dfa0-241e-4fa2-a0e2-f6f5207c005a"), null, 10 },
                    { new Guid("bc65dd82-ef0e-49cc-9e08-043a0d87f596"), new Guid("ba961562-7765-4931-9f17-ad8c8739467e"), "A mesmerizing journey through space and time.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("893c46b4-9913-49cf-870e-b9c45c61b8b9"), null, 9 },
                    { new Guid("d3e3acc3-fb71-44fa-950d-ffbc7f93fb58"), new Guid("d195231b-b72b-45b7-b4a3-8baf1e63203f"), "Beautifully animated and emotionally resonant.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fb3fba02-3e3e-430d-b3ab-0195eef9ea84"), null, 10 },
                    { new Guid("ee480267-4569-4d91-bc56-49bc9c157491"), new Guid("c847763c-e90f-479f-9073-5f8574c393c2"), "Amazing movie with a mind-blowing plot!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("71f439a9-a94d-4d6b-a399-dbc37d02d553"), null, 9 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Character", "MovieId", "MovieProductionRole", "PersonId" },
                values: new object[,]
                {
                    { new Guid("39b44d53-bdd1-411d-a032-a74c8e9bc3bc"), "Dom Cobb", new Guid("ee480267-4569-4d91-bc56-49bc9c157491"), 0, new Guid("1ff49701-032a-4405-b26e-3b96d575d4b7") },
                    { new Guid("47a32198-3b95-4a1b-93d9-c0d1c6ae5586"), null, new Guid("d3e3acc3-fb71-44fa-950d-ffbc7f93fb58"), 1, new Guid("139d9b58-a796-4515-9c61-b48c4c0eb942") },
                    { new Guid("6e865767-481a-4036-885d-ea791a098732"), null, new Guid("bc65dd82-ef0e-49cc-9e08-043a0d87f596"), 1, new Guid("dddb188c-5489-476d-9413-f7d8ac08aaa1") },
                    { new Guid("b056556a-711b-49d2-8307-d85263980e5a"), "Neo", new Guid("9c88ae57-fd1c-4cc1-92d3-8f9da2504fb5"), 0, new Guid("940cd656-4178-4810-9166-a5abec8b8712") },
                    { new Guid("e76da543-8c99-4c2c-94c4-f1fcccc0ba4a"), null, new Guid("84269730-4df1-4628-8441-3c2e283799ec"), 1, new Guid("98e935b8-fd17-45b5-a5a5-f7d010e7d0e2") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6fc6bc50-104f-418a-9295-aeca8ce5ab6a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f21fd4ee-fd3e-4947-81d8-63f1becf0dee"));

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("800bb8c7-3160-4982-9c0b-7f76d03799cc"), new Guid("84269730-4df1-4628-8441-3c2e283799ec") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("da6d65f0-ff4c-4056-89a0-a734b421828c"), new Guid("9c88ae57-fd1c-4cc1-92d3-8f9da2504fb5") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("dba1e6a6-bf44-4cec-a9c0-05fa5441cf9a"), new Guid("bc65dd82-ef0e-49cc-9e08-043a0d87f596") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("800bb8c7-3160-4982-9c0b-7f76d03799cc"), new Guid("d3e3acc3-fb71-44fa-950d-ffbc7f93fb58") });

            migrationBuilder.DeleteData(
                table: "MovieCountries",
                keyColumns: new[] { "CountryId", "MovieId" },
                keyValues: new object[] { new Guid("da6d65f0-ff4c-4056-89a0-a734b421828c"), new Guid("ee480267-4569-4d91-bc56-49bc9c157491") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("84269730-4df1-4628-8441-3c2e283799ec"), new Guid("96eb1376-2269-43db-83e7-2845357e8673") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("9c88ae57-fd1c-4cc1-92d3-8f9da2504fb5"), new Guid("010a3aa6-3023-4939-b646-987db03852bb") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("bc65dd82-ef0e-49cc-9e08-043a0d87f596"), new Guid("ba961562-7765-4931-9f17-ad8c8739467e") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("d3e3acc3-fb71-44fa-950d-ffbc7f93fb58"), new Guid("d195231b-b72b-45b7-b4a3-8baf1e63203f") });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { new Guid("ee480267-4569-4d91-bc56-49bc9c157491"), new Guid("c847763c-e90f-479f-9073-5f8574c393c2") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("39b44d53-bdd1-411d-a032-a74c8e9bc3bc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("47a32198-3b95-4a1b-93d9-c0d1c6ae5586"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6e865767-481a-4036-885d-ea791a098732"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b056556a-711b-49d2-8307-d85263980e5a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e76da543-8c99-4c2c-94c4-f1fcccc0ba4a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("800bb8c7-3160-4982-9c0b-7f76d03799cc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("da6d65f0-ff4c-4056-89a0-a734b421828c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dba1e6a6-bf44-4cec-a9c0-05fa5441cf9a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("84269730-4df1-4628-8441-3c2e283799ec"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9c88ae57-fd1c-4cc1-92d3-8f9da2504fb5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bc65dd82-ef0e-49cc-9e08-043a0d87f596"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d3e3acc3-fb71-44fa-950d-ffbc7f93fb58"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ee480267-4569-4d91-bc56-49bc9c157491"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("139d9b58-a796-4515-9c61-b48c4c0eb942"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("1ff49701-032a-4405-b26e-3b96d575d4b7"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("940cd656-4178-4810-9166-a5abec8b8712"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("98e935b8-fd17-45b5-a5a5-f7d010e7d0e2"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("dddb188c-5489-476d-9413-f7d8ac08aaa1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("010a3aa6-3023-4939-b646-987db03852bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96eb1376-2269-43db-83e7-2845357e8673"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba961562-7765-4931-9f17-ad8c8739467e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c847763c-e90f-479f-9073-5f8574c393c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d195231b-b72b-45b7-b4a3-8baf1e63203f"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "WatchLaterMovies");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "WatchLaterMovies");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "FavoriteMovies");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "FavoriteMovies");

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
    }
}
