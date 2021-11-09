﻿// <auto-generated />
using GuitarStuff.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GuitarStuff.Migrations
{
    [DbContext(typeof(GuitarStuffContext))]
    [Migration("20211109042151_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GuitarStuff.Models.Guitar", b =>
                {
                    b.Property<int>("GuitarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GuitarPlayersAssociated")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("GuitarType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("GuitarId");

                    b.ToTable("Guitars");

                    b.HasData(
                        new
                        {
                            GuitarId = 1,
                            GuitarPlayersAssociated = "Woolly Mammoth",
                            GuitarType = "Matilda"
                        },
                        new
                        {
                            GuitarId = 2,
                            GuitarPlayersAssociated = "Dinosaur",
                            GuitarType = "Rexie"
                        },
                        new
                        {
                            GuitarId = 3,
                            GuitarPlayersAssociated = "Dinosaur",
                            GuitarType = "Matilda"
                        },
                        new
                        {
                            GuitarId = 4,
                            GuitarPlayersAssociated = "Shark",
                            GuitarType = "Pip"
                        },
                        new
                        {
                            GuitarId = 5,
                            GuitarPlayersAssociated = "Dinosaur",
                            GuitarType = "Bartholomew"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}