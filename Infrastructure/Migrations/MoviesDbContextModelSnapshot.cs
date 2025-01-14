﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MoviesDbContext))]
    partial class MoviesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("da6d65f0-ff4c-4056-89a0-a734b421828c"),
                            Name = "United States"
                        },
                        new
                        {
                            Id = new Guid("dba1e6a6-bf44-4cec-a9c0-05fa5441cf9a"),
                            Name = "Poland"
                        },
                        new
                        {
                            Id = new Guid("800bb8c7-3160-4982-9c0b-7f76d03799cc"),
                            Name = "Japan"
                        },
                        new
                        {
                            Id = new Guid("6fc6bc50-104f-418a-9295-aeca8ce5ab6a"),
                            Name = "United Kingdom"
                        },
                        new
                        {
                            Id = new Guid("f21fd4ee-fd3e-4947-81d8-63f1becf0dee"),
                            Name = "Canada"
                        });
                });

            modelBuilder.Entity("Domain.Entities.FavoriteMovies", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("FavoriteMovies");
                });

            modelBuilder.Entity("Domain.Entities.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("BoxOffice")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<int>("Genre")
                        .HasColumnType("integer");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<decimal>("Popularity")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("Tmdb_Id")
                        .HasColumnType("integer");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserId1")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ee480267-4569-4d91-bc56-49bc9c157491"),
                            BoxOffice = 829895144,
                            Description = "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into a target's subconscious.",
                            Duration = 148,
                            Genre = 11,
                            Popularity = 0m,
                            ReleaseDate = new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Inception",
                            Tmdb_Id = 0
                        },
                        new
                        {
                            Id = new Guid("d3e3acc3-fb71-44fa-950d-ffbc7f93fb58"),
                            BoxOffice = 361000000,
                            Description = "Two teenagers share a profound connection after discovering they are swapping bodies.",
                            Duration = 106,
                            Genre = 3,
                            Popularity = 0m,
                            ReleaseDate = new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Your Name",
                            Tmdb_Id = 0
                        },
                        new
                        {
                            Id = new Guid("9c88ae57-fd1c-4cc1-92d3-8f9da2504fb5"),
                            BoxOffice = 466000000,
                            Description = "A hacker discovers the shocking truth about his world and his role in the fight to save humanity.",
                            Duration = 136,
                            Genre = 11,
                            Popularity = 0m,
                            ReleaseDate = new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Matrix",
                            Tmdb_Id = 0
                        },
                        new
                        {
                            Id = new Guid("bc65dd82-ef0e-49cc-9e08-043a0d87f596"),
                            BoxOffice = 701729206,
                            Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                            Duration = 169,
                            Genre = 11,
                            Popularity = 0m,
                            ReleaseDate = new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Interstellar",
                            Tmdb_Id = 0
                        },
                        new
                        {
                            Id = new Guid("84269730-4df1-4628-8441-3c2e283799ec"),
                            BoxOffice = 395800000,
                            Description = "A young girl becomes trapped in a mysterious world of spirits and must find her way home.",
                            Duration = 125,
                            Genre = 3,
                            Popularity = 0m,
                            ReleaseDate = new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Spirited Away",
                            Tmdb_Id = 0
                        });
                });

            modelBuilder.Entity("Domain.Entities.MovieCountry", b =>
                {
                    b.Property<Guid>("MovieId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uuid");

                    b.HasKey("MovieId", "CountryId");

                    b.HasIndex("CountryId");

                    b.ToTable("MovieCountries");

                    b.HasData(
                        new
                        {
                            MovieId = new Guid("ee480267-4569-4d91-bc56-49bc9c157491"),
                            CountryId = new Guid("da6d65f0-ff4c-4056-89a0-a734b421828c")
                        },
                        new
                        {
                            MovieId = new Guid("d3e3acc3-fb71-44fa-950d-ffbc7f93fb58"),
                            CountryId = new Guid("800bb8c7-3160-4982-9c0b-7f76d03799cc")
                        },
                        new
                        {
                            MovieId = new Guid("9c88ae57-fd1c-4cc1-92d3-8f9da2504fb5"),
                            CountryId = new Guid("da6d65f0-ff4c-4056-89a0-a734b421828c")
                        },
                        new
                        {
                            MovieId = new Guid("bc65dd82-ef0e-49cc-9e08-043a0d87f596"),
                            CountryId = new Guid("dba1e6a6-bf44-4cec-a9c0-05fa5441cf9a")
                        },
                        new
                        {
                            MovieId = new Guid("84269730-4df1-4628-8441-3c2e283799ec"),
                            CountryId = new Guid("800bb8c7-3160-4982-9c0b-7f76d03799cc")
                        });
                });

            modelBuilder.Entity("Domain.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1ff49701-032a-4405-b26e-3b96d575d4b7"),
                            Biography = "An American actor and film producer.",
                            BirthDate = new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Leonardo",
                            LastName = "DiCaprio"
                        },
                        new
                        {
                            Id = new Guid("139d9b58-a796-4515-9c61-b48c4c0eb942"),
                            Biography = "A Japanese animator, filmmaker, and manga artist.",
                            BirthDate = new DateTime(1973, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Makoto",
                            LastName = "Shinkai"
                        },
                        new
                        {
                            Id = new Guid("940cd656-4178-4810-9166-a5abec8b8712"),
                            Biography = "An actor known for his roles in The Matrix and John Wick.",
                            BirthDate = new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Keanu",
                            LastName = "Reeves"
                        },
                        new
                        {
                            Id = new Guid("dddb188c-5489-476d-9413-f7d8ac08aaa1"),
                            Biography = "A British-American film director, producer, and screenwriter.",
                            BirthDate = new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Christopher",
                            LastName = "Nolan"
                        },
                        new
                        {
                            Id = new Guid("98e935b8-fd17-45b5-a5a5-f7d010e7d0e2"),
                            Biography = "A legendary Japanese animator and filmmaker.",
                            BirthDate = new DateTime(1941, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Hayao",
                            LastName = "Miyazaki"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Review", b =>
                {
                    b.Property<Guid>("MovieId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.HasKey("MovieId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            MovieId = new Guid("ee480267-4569-4d91-bc56-49bc9c157491"),
                            UserId = new Guid("c847763c-e90f-479f-9073-5f8574c393c2"),
                            Comment = "Amazing movie with a mind-blowing plot!",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("71f439a9-a94d-4d6b-a399-dbc37d02d553"),
                            Rating = 9
                        },
                        new
                        {
                            MovieId = new Guid("d3e3acc3-fb71-44fa-950d-ffbc7f93fb58"),
                            UserId = new Guid("d195231b-b72b-45b7-b4a3-8baf1e63203f"),
                            Comment = "Beautifully animated and emotionally resonant.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("fb3fba02-3e3e-430d-b3ab-0195eef9ea84"),
                            Rating = 10
                        },
                        new
                        {
                            MovieId = new Guid("9c88ae57-fd1c-4cc1-92d3-8f9da2504fb5"),
                            UserId = new Guid("010a3aa6-3023-4939-b646-987db03852bb"),
                            Comment = "A groundbreaking film with iconic visuals.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("1c39dfa0-241e-4fa2-a0e2-f6f5207c005a"),
                            Rating = 10
                        },
                        new
                        {
                            MovieId = new Guid("bc65dd82-ef0e-49cc-9e08-043a0d87f596"),
                            UserId = new Guid("ba961562-7765-4931-9f17-ad8c8739467e"),
                            Comment = "A mesmerizing journey through space and time.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("893c46b4-9913-49cf-870e-b9c45c61b8b9"),
                            Rating = 9
                        },
                        new
                        {
                            MovieId = new Guid("84269730-4df1-4628-8441-3c2e283799ec"),
                            UserId = new Guid("96eb1376-2269-43db-83e7-2845357e8673"),
                            Comment = "A masterpiece of animation and storytelling.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("0d2498e1-3ba1-4091-96a2-764ede5f6b9f"),
                            Rating = 10
                        });
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Character")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uuid");

                    b.Property<int>("MovieProductionRole")
                        .HasColumnType("integer");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("PersonId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("39b44d53-bdd1-411d-a032-a74c8e9bc3bc"),
                            Character = "Dom Cobb",
                            MovieId = new Guid("ee480267-4569-4d91-bc56-49bc9c157491"),
                            MovieProductionRole = 0,
                            PersonId = new Guid("1ff49701-032a-4405-b26e-3b96d575d4b7")
                        },
                        new
                        {
                            Id = new Guid("47a32198-3b95-4a1b-93d9-c0d1c6ae5586"),
                            MovieId = new Guid("d3e3acc3-fb71-44fa-950d-ffbc7f93fb58"),
                            MovieProductionRole = 1,
                            PersonId = new Guid("139d9b58-a796-4515-9c61-b48c4c0eb942")
                        },
                        new
                        {
                            Id = new Guid("b056556a-711b-49d2-8307-d85263980e5a"),
                            Character = "Neo",
                            MovieId = new Guid("9c88ae57-fd1c-4cc1-92d3-8f9da2504fb5"),
                            MovieProductionRole = 0,
                            PersonId = new Guid("940cd656-4178-4810-9166-a5abec8b8712")
                        },
                        new
                        {
                            Id = new Guid("6e865767-481a-4036-885d-ea791a098732"),
                            MovieId = new Guid("bc65dd82-ef0e-49cc-9e08-043a0d87f596"),
                            MovieProductionRole = 1,
                            PersonId = new Guid("dddb188c-5489-476d-9413-f7d8ac08aaa1")
                        },
                        new
                        {
                            Id = new Guid("e76da543-8c99-4c2c-94c4-f1fcccc0ba4a"),
                            MovieId = new Guid("84269730-4df1-4628-8441-3c2e283799ec"),
                            MovieProductionRole = 1,
                            PersonId = new Guid("98e935b8-fd17-45b5-a5a5-f7d010e7d0e2")
                        });
                });

            modelBuilder.Entity("Domain.Entities.RoleReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("RoleReviews");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c847763c-e90f-479f-9073-5f8574c393c2"),
                            Email = "user1@example.com",
                            Login = "user1",
                            Password = "AQAAAAIAAYagAAAAEDxcZzIxREuWNkzw/cRkWoGn7ie9UFySU/5uNFSde79kqSKek2d90Cgs2Rit2Yt5xQ=="
                        },
                        new
                        {
                            Id = new Guid("d195231b-b72b-45b7-b4a3-8baf1e63203f"),
                            Email = "user2@example.com",
                            Login = "user2",
                            Password = "AQAAAAIAAYagAAAAEH7gNaympGqZE4uDj1jsqvFIszvixLJ6PwfE1f/bd8COAl8CnX4W/joKb/dAZ1ql1g=="
                        },
                        new
                        {
                            Id = new Guid("010a3aa6-3023-4939-b646-987db03852bb"),
                            Email = "user3@example.com",
                            Login = "user3",
                            Password = "AQAAAAIAAYagAAAAEO92a2iGMb/azqaQrfldAHvmWqgxDEyCdAhlFbwn74nqkxy9ScAzh/LGxCHdIDZVVg=="
                        },
                        new
                        {
                            Id = new Guid("ba961562-7765-4931-9f17-ad8c8739467e"),
                            Email = "user4@example.com",
                            Login = "user4",
                            Password = "AQAAAAIAAYagAAAAEDQYcAYcH2y4lnFK8PS2gbn2P71YHm3V3oFdgVNMR3eyUCn+eDBpWNBWoj5FIMeORA=="
                        },
                        new
                        {
                            Id = new Guid("96eb1376-2269-43db-83e7-2845357e8673"),
                            Email = "user5@example.com",
                            Login = "user5",
                            Password = "AQAAAAIAAYagAAAAELwFCL9SG+7FjibZGuveD2yCJVONKFzRRxdsGaD5p+kgrgcvbaFNt65zTEVLU4FTPQ=="
                        });
                });

            modelBuilder.Entity("Domain.Entities.UserFriends", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("FriendId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("UserFriends");
                });

            modelBuilder.Entity("Domain.Entities.WatchLaterMovies", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("WatchLaterMovies");
                });

            modelBuilder.Entity("Domain.Entities.FavoriteMovies", b =>
                {
                    b.HasOne("Domain.Entities.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Movie", b =>
                {
                    b.HasOne("Domain.Entities.User", null)
                        .WithMany("FavoriteMovies")
                        .HasForeignKey("UserId");

                    b.HasOne("Domain.Entities.User", null)
                        .WithMany("WatchedMovies")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("Domain.Entities.MovieCountry", b =>
                {
                    b.HasOne("Domain.Entities.Country", "Country")
                        .WithMany("Productions")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Movie", "Movie")
                        .WithMany("CountryOfMovie")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Domain.Entities.Review", b =>
                {
                    b.HasOne("Domain.Entities.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.HasOne("Domain.Entities.Movie", "Movie")
                        .WithMany("Cast")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Person", "Person")
                        .WithMany("Roles")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Domain.Entities.RoleReview", b =>
                {
                    b.HasOne("Domain.Entities.Role", "Role")
                        .WithMany("Reviews")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("RoleReviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.WatchLaterMovies", b =>
                {
                    b.HasOne("Domain.Entities.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.Navigation("Productions");
                });

            modelBuilder.Entity("Domain.Entities.Movie", b =>
                {
                    b.Navigation("Cast");

                    b.Navigation("CountryOfMovie");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Domain.Entities.Person", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("FavoriteMovies");

                    b.Navigation("Reviews");

                    b.Navigation("RoleReviews");

                    b.Navigation("WatchedMovies");
                });
#pragma warning restore 612, 618
        }
    }
}
