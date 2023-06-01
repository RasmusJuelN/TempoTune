﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TempoTuneAPI.Data;

#nullable disable

namespace TempoTuneAPI.Migrations
{
    [DbContext(typeof(TempoTuneDbContext))]
    [Migration("20230601071351_add-token")]
    partial class addtoken
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TempoTuneAPI.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists", (string)null);
                });

            modelBuilder.Entity("TempoTuneAPI.Models.Favourite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("TrackId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrackId");

                    b.HasIndex("UserId");

                    b.ToTable("Favourites", (string)null);
                });

            modelBuilder.Entity("TempoTuneAPI.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AlbumName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("SongPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Tracks", (string)null);
                });

            modelBuilder.Entity("TempoTuneAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("TempoTuneAPI.Models.Favourite", b =>
                {
                    b.HasOne("TempoTuneAPI.Models.Track", "Track")
                        .WithMany()
                        .HasForeignKey("TrackId");

                    b.HasOne("TempoTuneAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Track");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TempoTuneAPI.Models.Track", b =>
                {
                    b.HasOne("TempoTuneAPI.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId");

                    b.Navigation("Artist");
                });
#pragma warning restore 612, 618
        }
    }
}