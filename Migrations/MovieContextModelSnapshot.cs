﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission4.Models;

namespace mission4.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("mission4.Models.Application", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 1,
                            Director = "Peter Jackson",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Lord of the Rings: The Fellowship of the Ring",
                            Year = (ushort)2001
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 1,
                            Director = "Peter Jackson",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Lord of the Rings: The Two Towers",
                            Year = (ushort)2002
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 1,
                            Director = "Peter Jackson",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Lord of the Rings: The Return of the King",
                            Year = (ushort)2002
                        },
                        new
                        {
                            MovieID = 4,
                            CategoryID = 3,
                            Director = "Kyle Evert",
                            Edited = true,
                            Lent = "David Evert",
                            Notes = "Just a sample here",
                            Rating = "PG",
                            Title = "test",
                            Year = (ushort)2022
                        });
                });

            modelBuilder.Entity("mission4.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("mission4.Models.Application", b =>
                {
                    b.HasOne("mission4.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
