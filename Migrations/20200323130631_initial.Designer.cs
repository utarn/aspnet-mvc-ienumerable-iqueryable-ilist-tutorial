﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LinqCollection.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200323130631_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("LinqCollection.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("Genre")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Romantic Comedy",
                            Price = 7.99m,
                            ReleaseDate = new DateTime(1446, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "When Harry Met Sally"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Comedy",
                            Price = 8.99m,
                            ReleaseDate = new DateTime(1441, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Ghostbusters "
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Comedy",
                            Price = 9.99m,
                            ReleaseDate = new DateTime(1443, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Ghostbusters 2"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "Western",
                            Price = 3.99m,
                            ReleaseDate = new DateTime(1416, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Rio Bravo"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
