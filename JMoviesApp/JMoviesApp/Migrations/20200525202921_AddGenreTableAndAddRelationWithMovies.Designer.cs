﻿// <auto-generated />
using System;
using JMoviesApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JMoviesApp.Migrations
{
    [DbContext(typeof(JMoviesAppContext))]
    [Migration("20200525202921_AddGenreTableAndAddRelationWithMovies")]
    partial class AddGenreTableAndAddRelationWithMovies
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("JMoviesApp.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsSuscribedToNewsLetter")
                        .HasColumnType("boolean");

                    b.Property<byte>("MembershipTypeId")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MembershipTypeId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsSuscribedToNewsLetter = true,
                            MembershipTypeId = (byte)1,
                            Name = "Javier"
                        },
                        new
                        {
                            Id = 2,
                            IsSuscribedToNewsLetter = true,
                            MembershipTypeId = (byte)1,
                            Name = "Daniella"
                        },
                        new
                        {
                            Id = 3,
                            IsSuscribedToNewsLetter = false,
                            MembershipTypeId = (byte)2,
                            Name = "Carlos"
                        });
                });

            modelBuilder.Entity("JMoviesApp.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fiction"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Love"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Documental"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Documental"
                        });
                });

            modelBuilder.Entity("JMoviesApp.Models.MembershipType", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("smallint");

                    b.Property<byte>("DiscountRate")
                        .HasColumnType("smallint");

                    b.Property<byte>("DurationInMonths")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<short>("SignUpFee")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("MembershipTypes");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            DiscountRate = (byte)0,
                            DurationInMonths = (byte)0,
                            SignUpFee = (short)0
                        },
                        new
                        {
                            Id = (byte)2,
                            DiscountRate = (byte)10,
                            DurationInMonths = (byte)1,
                            SignUpFee = (short)30
                        },
                        new
                        {
                            Id = (byte)3,
                            DiscountRate = (byte)15,
                            DurationInMonths = (byte)90,
                            SignUpFee = (short)3
                        },
                        new
                        {
                            Id = (byte)4,
                            DiscountRate = (byte)15,
                            DurationInMonths = (byte)12,
                            SignUpFee = (short)300
                        });
                });

            modelBuilder.Entity("JMoviesApp.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("GenreId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Stock")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(1994, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 3,
                            Name = "Star wars",
                            ReleaseDate = new DateTime(1985, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 0
                        },
                        new
                        {
                            Id = 2,
                            DateAdded = new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 3,
                            Name = "SpiderMan",
                            ReleaseDate = new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 0
                        },
                        new
                        {
                            Id = 3,
                            DateAdded = new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 6,
                            Name = "John Wick",
                            ReleaseDate = new DateTime(2019, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 0
                        });
                });

            modelBuilder.Entity("JMoviesApp.Models.Customer", b =>
                {
                    b.HasOne("JMoviesApp.Models.MembershipType", "MembershipType")
                        .WithMany()
                        .HasForeignKey("MembershipTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JMoviesApp.Models.Movie", b =>
                {
                    b.HasOne("JMoviesApp.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}