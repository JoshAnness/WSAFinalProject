// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WSAFinalProject.Models;

namespace WSAFinalProject.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20211203232754_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WSAFinalProject.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Name = "Horror"
                        },
                        new
                        {
                            GenreId = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            GenreId = 3,
                            Name = "Drama"
                        },
                        new
                        {
                            GenreId = 4,
                            Name = "Comedy"
                        },
                        new
                        {
                            GenreId = 5,
                            Name = "RomCom"
                        },
                        new
                        {
                            GenreId = 6,
                            Name = "Action"
                        },
                        new
                        {
                            GenreId = 7,
                            Name = "SuperHero"
                        },
                        new
                        {
                            GenreId = 8,
                            Name = "Musical"
                        },
                        new
                        {
                            GenreId = 9,
                            Name = "Documentary"
                        });
                });

            modelBuilder.Entity("WSAFinalProject.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Description = "A rescue crew investigates a spaceship that disappeared into a black hole and has now returned...with someone or something new on-board.",
                            Duration = 96,
                            GenreId = 2,
                            Name = "Event Horizon",
                            Year = 1997
                        },
                        new
                        {
                            MovieId = 2,
                            Description = "A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose.",
                            Duration = 127,
                            GenreId = 2,
                            Name = "Jurassic Park",
                            Year = 1993
                        });
                });

            modelBuilder.Entity("WSAFinalProject.Models.Movie", b =>
                {
                    b.HasOne("WSAFinalProject.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
