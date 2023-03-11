﻿// <auto-generated />
using InnovaDiscs.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InnovaDiscs.Migrations
{
    [DbContext(typeof(InnovaDiscsContext))]
    [Migration("20230216211852_DiscGolfMigration")]
    partial class DiscGolfMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InnovaDiscs.Models.Disc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("FadeInt")
                        .HasColumnType("int");

                    b.Property<int>("GlideInt")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SpeedInt")
                        .HasColumnType("int");

                    b.Property<int>("TurnInt")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Discs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Innova",
                            FadeInt = 3,
                            GlideInt = 5,
                            Name = "Destroyer",
                            SpeedInt = 12,
                            TurnInt = -1,
                            Type = "Distance Driver"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Innova",
                            FadeInt = 2,
                            GlideInt = 5,
                            Name = "Teebird",
                            SpeedInt = 7,
                            TurnInt = 0,
                            Type = "Fairway Driver"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Innova",
                            FadeInt = 3,
                            GlideInt = 2,
                            Name = "Toro",
                            SpeedInt = 4,
                            TurnInt = 1,
                            Type = "Midrange"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Discmania",
                            FadeInt = 1,
                            GlideInt = 3,
                            Name = "Link",
                            SpeedInt = 2,
                            TurnInt = 0,
                            Type = "Putter"
                        });
                });

            modelBuilder.Entity("InnovaDiscs.Models.DiscGolfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("DiscGolfers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Adison",
                            LastName = "Reddy",
                            Team = "Innova"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
