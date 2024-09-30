﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OutpostBackend.Data;

#nullable disable

namespace OutpostBackend.Data.Migrations
{
    [DbContext(typeof(OutpostDbContext))]
    [Migration("20240930125051_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OutpostBackend.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Movies"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Programming"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cities"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Plants"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Games"
                        });
                });

            modelBuilder.Entity("OutpostBackend.Core.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Published")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Post");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.",
                            CategoryId = 3,
                            Published = new DateTime(2024, 9, 30, 14, 50, 51, 615, DateTimeKind.Local).AddTicks(5559),
                            Title = "City Post Title"
                        },
                        new
                        {
                            Id = 2,
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.",
                            CategoryId = 1,
                            Published = new DateTime(2024, 9, 30, 14, 50, 51, 615, DateTimeKind.Local).AddTicks(5624),
                            Title = "Movie Post Title"
                        },
                        new
                        {
                            Id = 3,
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.",
                            CategoryId = 5,
                            Published = new DateTime(2024, 9, 30, 14, 50, 51, 615, DateTimeKind.Local).AddTicks(5627),
                            Title = "Game Post Title"
                        },
                        new
                        {
                            Id = 4,
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.",
                            CategoryId = 5,
                            Published = new DateTime(2024, 9, 30, 14, 50, 51, 615, DateTimeKind.Local).AddTicks(5629),
                            Title = "Game Post Title"
                        },
                        new
                        {
                            Id = 5,
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.",
                            CategoryId = 4,
                            Published = new DateTime(2024, 9, 30, 14, 50, 51, 615, DateTimeKind.Local).AddTicks(5632),
                            Title = "Plant Post Title"
                        });
                });

            modelBuilder.Entity("OutpostBackend.Core.Entities.Post", b =>
                {
                    b.HasOne("OutpostBackend.Core.Entities.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OutpostBackend.Core.Entities.Category", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
