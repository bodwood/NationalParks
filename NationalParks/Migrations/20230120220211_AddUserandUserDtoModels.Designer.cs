﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParks.Models;

#nullable disable

namespace NationalParks.Migrations
{
    [DbContext(typeof(NationalParksContext))]
    [Migration("20230120220211_AddUserandUserDtoModels")]
    partial class AddUserandUserDtoModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NationalParks.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ParkName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            ParkName = "Zion",
                            Rating = 5,
                            Region = "Mountain",
                            StateName = "Utah"
                        },
                        new
                        {
                            ParkId = 2,
                            ParkName = "Bryce Canyon",
                            Rating = 4,
                            Region = "Mountain",
                            StateName = "Utah"
                        },
                        new
                        {
                            ParkId = 3,
                            ParkName = "Crater Lake",
                            Rating = 4,
                            Region = "Pacific West",
                            StateName = "Oregon"
                        },
                        new
                        {
                            ParkId = 4,
                            ParkName = "Mount Rainier",
                            Rating = 4,
                            Region = "Pacific West",
                            StateName = "Washington"
                        },
                        new
                        {
                            ParkId = 5,
                            ParkName = "Denali",
                            Rating = 5,
                            Region = "Pacific West",
                            StateName = "Alaska"
                        },
                        new
                        {
                            ParkId = 6,
                            ParkName = "Acadia",
                            Rating = 3,
                            Region = "Northeast",
                            StateName = "Maine"
                        },
                        new
                        {
                            ParkId = 7,
                            ParkName = "Badlands",
                            Rating = 2,
                            Region = "Midwest",
                            StateName = "South Dakota"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
