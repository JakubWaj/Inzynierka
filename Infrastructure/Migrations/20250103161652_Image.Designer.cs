﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MoviesDbContext))]
    [Migration("20250103161652_Image")]
    partial class Image
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("150bbb19-1d29-4ba8-aa8a-ba3e76841396"),
                            Name = "United States"
                        },
                        new
                        {
                            Id = new Guid("251012cb-a39d-46fd-81d9-60cf48a59904"),
                            Name = "Poland"
                        },
                        new
                        {
                            Id = new Guid("e2cf266b-e0eb-4503-81b5-98a5dcb89889"),
                            Name = "Japan"
                        },
                        new
                        {
                            Id = new Guid("ee7a433c-11ce-4442-99b7-7b0188c72af9"),
                            Name = "United Kingdom"
                        },
                        new
                        {
                            Id = new Guid("b7e4d095-9c9a-4421-92c0-ab66bc11d7e5"),
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

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5e609a0c-27bf-4437-9ec7-3836cd5929ef"),
                            BoxOffice = 829895144,
                            Description = "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into a target's subconscious.",
                            Duration = 148,
                            Genre = 11,
                            ReleaseDate = new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Inception"
                        },
                        new
                        {
                            Id = new Guid("b1996f26-5af8-417e-8cd7-0bce4b4111e9"),
                            BoxOffice = 361000000,
                            Description = "Two teenagers share a profound connection after discovering they are swapping bodies.",
                            Duration = 106,
                            Genre = 3,
                            ReleaseDate = new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Your Name"
                        },
                        new
                        {
                            Id = new Guid("b85bf6f6-31b2-44c4-90be-970e74e84ef3"),
                            BoxOffice = 466000000,
                            Description = "A hacker discovers the shocking truth about his world and his role in the fight to save humanity.",
                            Duration = 136,
                            Genre = 11,
                            ReleaseDate = new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = new Guid("1856aef9-396d-47b7-91e9-27dfbea71d8d"),
                            BoxOffice = 701729206,
                            Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                            Duration = 169,
                            Genre = 11,
                            ReleaseDate = new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Interstellar"
                        },
                        new
                        {
                            Id = new Guid("7a9cb18e-a425-4e43-990b-9be7ad58a46b"),
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
                            MovieId = new Guid("5e609a0c-27bf-4437-9ec7-3836cd5929ef"),
                            CountryId = new Guid("150bbb19-1d29-4ba8-aa8a-ba3e76841396")
                        },
                        new
                        {
                            MovieId = new Guid("b1996f26-5af8-417e-8cd7-0bce4b4111e9"),
                            CountryId = new Guid("e2cf266b-e0eb-4503-81b5-98a5dcb89889")
                        },
                        new
                        {
                            MovieId = new Guid("b85bf6f6-31b2-44c4-90be-970e74e84ef3"),
                            CountryId = new Guid("150bbb19-1d29-4ba8-aa8a-ba3e76841396")
                        },
                        new
                        {
                            MovieId = new Guid("1856aef9-396d-47b7-91e9-27dfbea71d8d"),
                            CountryId = new Guid("251012cb-a39d-46fd-81d9-60cf48a59904")
                        },
                        new
                        {
                            MovieId = new Guid("7a9cb18e-a425-4e43-990b-9be7ad58a46b"),
                            CountryId = new Guid("e2cf266b-e0eb-4503-81b5-98a5dcb89889")
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
                            Id = new Guid("90f93e70-3a2a-4e22-8a03-c9beb9324922"),
                            Biography = "An American actor and film producer.",
                            BirthDate = new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Leonardo",
                            LastName = "DiCaprio"
                        },
                        new
                        {
                            Id = new Guid("d531f225-c193-4226-bb2a-45a8eadc1760"),
                            Biography = "A Japanese animator, filmmaker, and manga artist.",
                            BirthDate = new DateTime(1973, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Makoto",
                            LastName = "Shinkai"
                        },
                        new
                        {
                            Id = new Guid("92fd249b-7536-4137-8224-220384951e7b"),
                            Biography = "An actor known for his roles in The Matrix and John Wick.",
                            BirthDate = new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Keanu",
                            LastName = "Reeves"
                        },
                        new
                        {
                            Id = new Guid("e971ee9c-3527-4fc5-8875-176b676b2957"),
                            Biography = "A British-American film director, producer, and screenwriter.",
                            BirthDate = new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Christopher",
                            LastName = "Nolan"
                        },
                        new
                        {
                            Id = new Guid("848cddef-20dc-40bf-bcc3-10d969d13659"),
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
                            MovieId = new Guid("5e609a0c-27bf-4437-9ec7-3836cd5929ef"),
                            UserId = new Guid("8bbf9984-3390-48c7-bee6-30f0c56f834a"),
                            Comment = "Amazing movie with a mind-blowing plot!",
                            Id = new Guid("6ec146f9-fb0f-498d-8914-3069318d7a6e"),
                            Rating = 9
                        },
                        new
                        {
                            MovieId = new Guid("b1996f26-5af8-417e-8cd7-0bce4b4111e9"),
                            UserId = new Guid("688a1170-8654-4917-9c4e-dab56e27a87c"),
                            Comment = "Beautifully animated and emotionally resonant.",
                            Id = new Guid("fc21dceb-3c5b-41b8-b16d-747d26dbdd3a"),
                            Rating = 10
                        },
                        new
                        {
                            MovieId = new Guid("b85bf6f6-31b2-44c4-90be-970e74e84ef3"),
                            UserId = new Guid("f34dc0fa-df2f-402b-a716-6e5263c5fa8d"),
                            Comment = "A groundbreaking film with iconic visuals.",
                            Id = new Guid("c0aeca61-c8e0-4919-ae7e-7a95c6eee34b"),
                            Rating = 10
                        },
                        new
                        {
                            MovieId = new Guid("1856aef9-396d-47b7-91e9-27dfbea71d8d"),
                            UserId = new Guid("72f63d2a-37c1-4960-a714-900a016c88e5"),
                            Comment = "A mesmerizing journey through space and time.",
                            Id = new Guid("4db18e6a-410f-4c04-a577-252a19350f83"),
                            Rating = 9
                        },
                        new
                        {
                            MovieId = new Guid("7a9cb18e-a425-4e43-990b-9be7ad58a46b"),
                            UserId = new Guid("6a188d1c-d9de-4c06-a9ee-c0dc62ed7701"),
                            Comment = "A masterpiece of animation and storytelling.",
                            Id = new Guid("2d3b7787-6aff-461e-ba60-d9c440d2f4c3"),
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
                            Id = new Guid("8d03f852-eb41-4166-a84d-0514b1a1b5de"),
                            Character = "Dom Cobb",
                            MovieId = new Guid("5e609a0c-27bf-4437-9ec7-3836cd5929ef"),
                            MovieProductionRole = 0,
                            PersonId = new Guid("90f93e70-3a2a-4e22-8a03-c9beb9324922")
                        },
                        new
                        {
                            Id = new Guid("24c076f1-6d18-4d58-adc0-78153c300e98"),
                            MovieId = new Guid("b1996f26-5af8-417e-8cd7-0bce4b4111e9"),
                            MovieProductionRole = 1,
                            PersonId = new Guid("d531f225-c193-4226-bb2a-45a8eadc1760")
                        },
                        new
                        {
                            Id = new Guid("5a21cdf5-8554-4228-a08e-460f78db0324"),
                            Character = "Neo",
                            MovieId = new Guid("b85bf6f6-31b2-44c4-90be-970e74e84ef3"),
                            MovieProductionRole = 0,
                            PersonId = new Guid("92fd249b-7536-4137-8224-220384951e7b")
                        },
                        new
                        {
                            Id = new Guid("92ea199b-8652-4770-9fd4-7be9eea8a3dd"),
                            MovieId = new Guid("1856aef9-396d-47b7-91e9-27dfbea71d8d"),
                            MovieProductionRole = 1,
                            PersonId = new Guid("e971ee9c-3527-4fc5-8875-176b676b2957")
                        },
                        new
                        {
                            Id = new Guid("4e6c6d8f-0554-48d6-b877-f4b2e8797016"),
                            MovieId = new Guid("7a9cb18e-a425-4e43-990b-9be7ad58a46b"),
                            MovieProductionRole = 1,
                            PersonId = new Guid("848cddef-20dc-40bf-bcc3-10d969d13659")
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
                            Id = new Guid("8bbf9984-3390-48c7-bee6-30f0c56f834a"),
                            Email = "user1@example.com",
                            Login = "user1",
                            Password = "AQAAAAIAAYagAAAAEETPdvSMv3P1Woex9Ax3BvP/RIDT/j8+1zxbLy+xZ9fPll1rITcJiWuttnegINFNoA=="
                        },
                        new
                        {
                            Id = new Guid("688a1170-8654-4917-9c4e-dab56e27a87c"),
                            Email = "user2@example.com",
                            Login = "user2",
                            Password = "AQAAAAIAAYagAAAAEOm2CxDaB7ZplBcnVneJEkVrtmYj+ZxAjnFPomOm71QHov6hlyJMEZDMbV1IOcIdPw=="
                        },
                        new
                        {
                            Id = new Guid("f34dc0fa-df2f-402b-a716-6e5263c5fa8d"),
                            Email = "user3@example.com",
                            Login = "user3",
                            Password = "AQAAAAIAAYagAAAAEN26BmXhuKakNCduYPLT0Wtn2u+4rD7mSqbDBcltRVcAAqkAr+Wq9dqK+8kZI+OvDA=="
                        },
                        new
                        {
                            Id = new Guid("72f63d2a-37c1-4960-a714-900a016c88e5"),
                            Email = "user4@example.com",
                            Login = "user4",
                            Password = "AQAAAAIAAYagAAAAELvjmHpliysx1RBRP9U3gUfhFMOZG88x0MH21R6EBA0zSUvBhM1N4lLHMIlJlhE8YQ=="
                        },
                        new
                        {
                            Id = new Guid("6a188d1c-d9de-4c06-a9ee-c0dc62ed7701"),
                            Email = "user5@example.com",
                            Login = "user5",
                            Password = "AQAAAAIAAYagAAAAEMKUVtE51I0q7+Lb42i9KyFDGTuEF0AW+mFTWZtsxsExqHPgrw2TX7IRCvVi9wgscg=="
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

                    b.ToTable("WatchLaterMovies");
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
                    b.Navigation("Reviews");

                    b.Navigation("RoleReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
