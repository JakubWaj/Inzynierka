using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteMovies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MovieId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteMovies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    Genre = table.Column<int>(type: "integer", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "date", nullable: false),
                    BoxOffice = table.Column<int>(type: "integer", nullable: false),
                    Duration = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Biography = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserFriends",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    FriendId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFriends", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WatchLaterMovies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MovieId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchLaterMovies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieCountries",
                columns: table => new
                {
                    CountryId = table.Column<Guid>(type: "uuid", nullable: false),
                    MovieId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCountries", x => new { x.MovieId, x.CountryId });
                    table.ForeignKey(
                        name: "FK_MovieCountries_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCountries_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    MovieId = table.Column<Guid>(type: "uuid", nullable: false),
                    MovieProductionRole = table.Column<int>(type: "integer", nullable: false),
                    Character = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Roles_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Comment = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => new { x.MovieId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Reviews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleReviews_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_MovieCountries_CountryId",
                table: "MovieCountries",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleReviews_RoleId",
                table: "RoleReviews",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleReviews_UserId",
                table: "RoleReviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_MovieId",
                table: "Roles",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_PersonId",
                table: "Roles",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteMovies");

            migrationBuilder.DropTable(
                name: "MovieCountries");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "RoleReviews");

            migrationBuilder.DropTable(
                name: "UserFriends");

            migrationBuilder.DropTable(
                name: "WatchLaterMovies");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
