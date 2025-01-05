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
                            Id = new Guid("04ed8576-4077-4247-aba7-dd8ba5b4b2ff"),
                            Name = "United States"
                        },
                        new
                        {
                            Id = new Guid("8ca7d826-5cb0-4b47-acf4-8c20d1ff4673"),
                            Name = "Poland"
                        },
                        new
                        {
                            Id = new Guid("a83f9cab-f057-42c1-901c-61b20aa4d2d4"),
                            Name = "Japan"
                        },
                        new
                        {
                            Id = new Guid("dd9e967e-c0f2-44f3-915d-947e00df9683"),
                            Name = "United Kingdom"
                        },
                        new
                        {
                            Id = new Guid("e25a0b55-6bd9-4653-9343-2de43392eb99"),
                            Name = "Canada"
                        });
                });

            modelBuilder.Entity("Domain.Entities.FavoriteMovies", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

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

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

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
                            Id = new Guid("0399e505-72b3-41a3-8104-e115aae5efb2"),
                            BoxOffice = 829895144,
                            Description = "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into a target's subconscious.",
                            Duration = 148,
                            Genre = 11,
                            ReleaseDate = new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Inception"
                        },
                        new
                        {
                            Id = new Guid("51a86613-eb6f-4f10-b92b-8cc1c5006c53"),
                            BoxOffice = 361000000,
                            Description = "Two teenagers share a profound connection after discovering they are swapping bodies.",
                            Duration = 106,
                            Genre = 3,
                            ReleaseDate = new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Your Name"
                        },
                        new
                        {
                            Id = new Guid("3c989303-cf7d-4168-8981-1f6f74c6af13"),
                            BoxOffice = 466000000,
                            Description = "A hacker discovers the shocking truth about his world and his role in the fight to save humanity.",
                            Duration = 136,
                            Genre = 11,
                            ReleaseDate = new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = new Guid("4d2b3866-fee2-437f-bb3c-e999db43801e"),
                            BoxOffice = 701729206,
                            Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                            Duration = 169,
                            Genre = 11,
                            ReleaseDate = new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Interstellar"
                        },
                        new
                        {
                            Id = new Guid("a22c15f0-3d5b-4a43-8845-088c19524351"),
                            BoxOffice = 395800000,
                            Description = "A young girl becomes trapped in a mysterious world of spirits and must find her way home.",
                            Duration = 125,
                            Genre = 3,
                            ReleaseDate = new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Spirited Away"
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
                            MovieId = new Guid("0399e505-72b3-41a3-8104-e115aae5efb2"),
                            CountryId = new Guid("04ed8576-4077-4247-aba7-dd8ba5b4b2ff")
                        },
                        new
                        {
                            MovieId = new Guid("51a86613-eb6f-4f10-b92b-8cc1c5006c53"),
                            CountryId = new Guid("a83f9cab-f057-42c1-901c-61b20aa4d2d4")
                        },
                        new
                        {
                            MovieId = new Guid("3c989303-cf7d-4168-8981-1f6f74c6af13"),
                            CountryId = new Guid("04ed8576-4077-4247-aba7-dd8ba5b4b2ff")
                        },
                        new
                        {
                            MovieId = new Guid("4d2b3866-fee2-437f-bb3c-e999db43801e"),
                            CountryId = new Guid("8ca7d826-5cb0-4b47-acf4-8c20d1ff4673")
                        },
                        new
                        {
                            MovieId = new Guid("a22c15f0-3d5b-4a43-8845-088c19524351"),
                            CountryId = new Guid("a83f9cab-f057-42c1-901c-61b20aa4d2d4")
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
                            Id = new Guid("9efc04b6-11ca-4a07-a7d8-5cfb4db2de56"),
                            Biography = "An American actor and film producer.",
                            BirthDate = new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Leonardo",
                            LastName = "DiCaprio"
                        },
                        new
                        {
                            Id = new Guid("db78cd89-0a8b-4fd0-a336-e2bc8043ea76"),
                            Biography = "A Japanese animator, filmmaker, and manga artist.",
                            BirthDate = new DateTime(1973, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Makoto",
                            LastName = "Shinkai"
                        },
                        new
                        {
                            Id = new Guid("69caec9b-56dd-4d15-9d0d-d5668370055c"),
                            Biography = "An actor known for his roles in The Matrix and John Wick.",
                            BirthDate = new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Keanu",
                            LastName = "Reeves"
                        },
                        new
                        {
                            Id = new Guid("28aa74e3-b1e6-44f9-944f-668866c33b41"),
                            Biography = "A British-American film director, producer, and screenwriter.",
                            BirthDate = new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Christopher",
                            LastName = "Nolan"
                        },
                        new
                        {
                            Id = new Guid("b191efb9-1058-409b-a329-df65ee74d376"),
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

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.HasKey("MovieId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            MovieId = new Guid("0399e505-72b3-41a3-8104-e115aae5efb2"),
                            UserId = new Guid("1899382b-8095-4899-8b29-37f4694b423f"),
                            Comment = "Amazing movie with a mind-blowing plot!",
                            Id = new Guid("3fd8070f-312e-40b1-a5f5-7c00d5c838a5"),
                            Rating = 9
                        },
                        new
                        {
                            MovieId = new Guid("51a86613-eb6f-4f10-b92b-8cc1c5006c53"),
                            UserId = new Guid("6f4c360b-a68e-47f2-9a68-aa7d555d3ae4"),
                            Comment = "Beautifully animated and emotionally resonant.",
                            Id = new Guid("58f0a48a-6fa8-40cb-92cc-1811e05ea442"),
                            Rating = 10
                        },
                        new
                        {
                            MovieId = new Guid("3c989303-cf7d-4168-8981-1f6f74c6af13"),
                            UserId = new Guid("bd2fffcf-26fa-4e96-814b-9807f5483299"),
                            Comment = "A groundbreaking film with iconic visuals.",
                            Id = new Guid("9dd4d96c-2365-43d4-b64b-3b5593adfee4"),
                            Rating = 10
                        },
                        new
                        {
                            MovieId = new Guid("4d2b3866-fee2-437f-bb3c-e999db43801e"),
                            UserId = new Guid("5b753a71-832b-4e3d-8c8f-a6b66a7b5c27"),
                            Comment = "A mesmerizing journey through space and time.",
                            Id = new Guid("f63329b5-07da-455c-81e9-b2cd981ee501"),
                            Rating = 9
                        },
                        new
                        {
                            MovieId = new Guid("a22c15f0-3d5b-4a43-8845-088c19524351"),
                            UserId = new Guid("462bae9a-9749-4bc6-b5e3-226b3f69d6b0"),
                            Comment = "A masterpiece of animation and storytelling.",
                            Id = new Guid("d5466508-bda6-4371-9202-aec26cb2fa48"),
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
                            Id = new Guid("aa3c69b8-a199-4c90-98bf-9dc01ccc074d"),
                            Character = "Dom Cobb",
                            MovieId = new Guid("0399e505-72b3-41a3-8104-e115aae5efb2"),
                            MovieProductionRole = 0,
                            PersonId = new Guid("9efc04b6-11ca-4a07-a7d8-5cfb4db2de56")
                        },
                        new
                        {
                            Id = new Guid("96c0f442-e706-490a-90a8-e6545707265a"),
                            MovieId = new Guid("51a86613-eb6f-4f10-b92b-8cc1c5006c53"),
                            MovieProductionRole = 1,
                            PersonId = new Guid("db78cd89-0a8b-4fd0-a336-e2bc8043ea76")
                        },
                        new
                        {
                            Id = new Guid("c4c4fc25-e500-4c0e-9500-b37a04dba12a"),
                            Character = "Neo",
                            MovieId = new Guid("3c989303-cf7d-4168-8981-1f6f74c6af13"),
                            MovieProductionRole = 0,
                            PersonId = new Guid("69caec9b-56dd-4d15-9d0d-d5668370055c")
                        },
                        new
                        {
                            Id = new Guid("3fca32f9-fb30-48ec-8019-fa383613c7b5"),
                            MovieId = new Guid("4d2b3866-fee2-437f-bb3c-e999db43801e"),
                            MovieProductionRole = 1,
                            PersonId = new Guid("28aa74e3-b1e6-44f9-944f-668866c33b41")
                        },
                        new
                        {
                            Id = new Guid("12e40896-b6f8-4b5b-bb93-bbbc1c4b1503"),
                            MovieId = new Guid("a22c15f0-3d5b-4a43-8845-088c19524351"),
                            MovieProductionRole = 1,
                            PersonId = new Guid("b191efb9-1058-409b-a329-df65ee74d376")
                        });
                });

            modelBuilder.Entity("Domain.Entities.RoleReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

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
                            Id = new Guid("1899382b-8095-4899-8b29-37f4694b423f"),
                            Email = "user1@example.com",
                            Login = "user1",
                            Password = "AQAAAAIAAYagAAAAEMPEtkT/KQPmQwiWrYeq7spTQc/xNL61fqoUqL+3V7gnyfvkHPT1gQmFxtA15lFHbg=="
                        },
                        new
                        {
                            Id = new Guid("6f4c360b-a68e-47f2-9a68-aa7d555d3ae4"),
                            Email = "user2@example.com",
                            Login = "user2",
                            Password = "AQAAAAIAAYagAAAAEElON5EGpTKtIEv/krIfBrFnzXKHehlk4Ge8AqBhEQcKR2swZXOdwmNOHfaJHZEl3A=="
                        },
                        new
                        {
                            Id = new Guid("bd2fffcf-26fa-4e96-814b-9807f5483299"),
                            Email = "user3@example.com",
                            Login = "user3",
                            Password = "AQAAAAIAAYagAAAAEGpFEpMoF/KH2lpZ4xHQxPMMuRD0a0eX3W0vWfT/N5tX/X7B0DVesHAozd2EPyvecA=="
                        },
                        new
                        {
                            Id = new Guid("5b753a71-832b-4e3d-8c8f-a6b66a7b5c27"),
                            Email = "user4@example.com",
                            Login = "user4",
                            Password = "AQAAAAIAAYagAAAAEJ8jKynPY8od1O9/E+LRgp8FuJPbAq2XRFcKu1T450dyvB22kt7Y+FgCEO43ydWaPA=="
                        },
                        new
                        {
                            Id = new Guid("462bae9a-9749-4bc6-b5e3-226b3f69d6b0"),
                            Email = "user5@example.com",
                            Login = "user5",
                            Password = "AQAAAAIAAYagAAAAEHSKhBuWlVe+SehB/MKaOzPK7ax/sVI6fWwbhQf5WFd9dOe6GnqSEVNYlRrp8YLC5Q=="
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
