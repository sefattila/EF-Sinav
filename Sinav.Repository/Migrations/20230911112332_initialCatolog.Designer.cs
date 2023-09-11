﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sinav.Repository.Contexts;

#nullable disable

namespace Sinav.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230911112332_initialCatolog")]
    partial class initialCatolog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Sinav.Core.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AlbumAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(10,2)");

                    b.Property<double>("IndirimOrani")
                        .HasColumnType("float");

                    b.Property<int>("SanatciId")
                        .HasColumnType("int");

                    b.Property<bool>("SatisDurum")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SanatciId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumAdi = "Deneme1",
                            CikisTarihi = new DateTime(2025, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6331),
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6318),
                            Fiyat = 150m,
                            IndirimOrani = 15.0,
                            SanatciId = 1,
                            SatisDurum = true,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            AlbumAdi = "Deneme2",
                            CikisTarihi = new DateTime(2024, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6343),
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6342),
                            Fiyat = 150m,
                            IndirimOrani = 15.0,
                            SanatciId = 2,
                            SatisDurum = true,
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            AlbumAdi = "Deneme3",
                            CikisTarihi = new DateTime(2033, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6346),
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6345),
                            Fiyat = 150m,
                            IndirimOrani = 15.0,
                            SanatciId = 3,
                            SatisDurum = true,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            AlbumAdi = "Deneme4",
                            CikisTarihi = new DateTime(2030, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6348),
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6347),
                            Fiyat = 150m,
                            IndirimOrani = 15.0,
                            SanatciId = 4,
                            SatisDurum = true,
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            AlbumAdi = "Deneme5",
                            CikisTarihi = new DateTime(2035, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6351),
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6350),
                            Fiyat = 150m,
                            IndirimOrani = 15.0,
                            SanatciId = 5,
                            SatisDurum = true,
                            Status = 0
                        },
                        new
                        {
                            Id = 6,
                            AlbumAdi = "Deneme6",
                            CikisTarihi = new DateTime(2031, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6353),
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6352),
                            Fiyat = 150m,
                            IndirimOrani = 15.0,
                            SanatciId = 6,
                            SatisDurum = true,
                            Status = 0
                        },
                        new
                        {
                            Id = 7,
                            AlbumAdi = "Deneme7",
                            CikisTarihi = new DateTime(2026, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6355),
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6354),
                            Fiyat = 150m,
                            IndirimOrani = 15.0,
                            SanatciId = 1,
                            SatisDurum = true,
                            Status = 0
                        },
                        new
                        {
                            Id = 8,
                            AlbumAdi = "Deneme8",
                            CikisTarihi = new DateTime(2027, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6357),
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6357),
                            Fiyat = 150m,
                            IndirimOrani = 15.0,
                            SanatciId = 2,
                            SatisDurum = true,
                            Status = 0
                        },
                        new
                        {
                            Id = 9,
                            AlbumAdi = "Deneme9",
                            CikisTarihi = new DateTime(2028, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6360),
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6359),
                            Fiyat = 150m,
                            IndirimOrani = 15.0,
                            SanatciId = 1,
                            SatisDurum = true,
                            Status = 0
                        });
                });

            modelBuilder.Entity("Sinav.Core.Entities.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kullanicis");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8417),
                            FirstName = "Sefa",
                            LastName = "Attila",
                            Password = "sssSSS..",
                            Status = 0,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Sinav.Core.Entities.Sanatci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Sanatcis");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8508),
                            FirstName = "Ali",
                            LastName = "Gündüz",
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8513),
                            FirstName = "Mehmet",
                            LastName = "Uzun",
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8515),
                            FirstName = "Veli",
                            LastName = "Kısa",
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8516),
                            FirstName = "Adnan",
                            LastName = "Ziya",
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8517),
                            FirstName = "Fatih",
                            LastName = "Aslan",
                            Status = 0
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8518),
                            FirstName = "Furkan",
                            LastName = "Kartal",
                            Status = 0
                        });
                });

            modelBuilder.Entity("Sinav.Core.Entities.Album", b =>
                {
                    b.HasOne("Sinav.Core.Entities.Sanatci", "Sanatci")
                        .WithMany("Albums")
                        .HasForeignKey("SanatciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sanatci");
                });

            modelBuilder.Entity("Sinav.Core.Entities.Sanatci", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
