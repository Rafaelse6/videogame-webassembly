﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoGameWebAssembly.Data;

#nullable disable

namespace VideoGameWebAssembly.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VideoGameWebAssembly.Shared.Entities.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Publisher = "CD Project Red",
                            ReleaseYear = 2020,
                            Title = "Cyberpunk 2077"
                        },
                        new
                        {
                            Id = 2,
                            Publisher = "From Software",
                            ReleaseYear = 2020,
                            Title = "Elden Ring"
                        },
                        new
                        {
                            Id = 3,
                            Publisher = "Nintendo",
                            ReleaseYear = 1998,
                            Title = "The Legend Of Zelda: Ocarina Of Time"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
