﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YourApp.Data;

#nullable disable

namespace fifaAgapov23.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231130085241_AddTestData")]
    partial class AddTestData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("fifaAgapov23.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = 1,
                            DateOfBirth = new DateTime(1990, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "John",
                            Gender = "M",
                            LastName = "Smith",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Country = 2,
                            DateOfBirth = new DateTime(1988, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "James",
                            Gender = "M",
                            LastName = "Williams",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 3,
                            Country = 0,
                            DateOfBirth = new DateTime(1992, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Robert",
                            Gender = "M",
                            LastName = "Johnson",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 4,
                            Country = 1,
                            DateOfBirth = new DateTime(1991, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Michael",
                            Gender = "M",
                            LastName = "Brown",
                            TeamId = 4
                        },
                        new
                        {
                            Id = 5,
                            Country = 2,
                            DateOfBirth = new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "William",
                            Gender = "M",
                            LastName = "Jones",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 6,
                            Country = 0,
                            DateOfBirth = new DateTime(1993, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "David",
                            Gender = "M",
                            LastName = "Miller",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 7,
                            Country = 1,
                            DateOfBirth = new DateTime(1987, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Richard",
                            Gender = "M",
                            LastName = "Davis",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 8,
                            Country = 2,
                            DateOfBirth = new DateTime(1994, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Joseph",
                            Gender = "M",
                            LastName = "Martinez",
                            TeamId = 4
                        });
                });

            modelBuilder.Entity("fifaAgapov23.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Eagles"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sharks"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lions"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Knights"
                        });
                });

            modelBuilder.Entity("fifaAgapov23.Models.Player", b =>
                {
                    b.HasOne("fifaAgapov23.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("fifaAgapov23.Models.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
