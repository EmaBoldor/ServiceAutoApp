﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceAutoApp.Data;

namespace ServiceAutoApp.Migrations
{
    [DbContext(typeof(ServiceAutoAppContext))]
    [Migration("20210607184320_FirstInit")]
    partial class FirstInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServiceAutoApp.Models.Client", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Locatia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipDefectiune")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipMasina")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            ID = new Guid("551e9dab-b73e-4322-8200-bfab4a214d9f"),
                            Locatia = "Campani",
                            Nume = "Boldor",
                            Prenume = "Ema",
                            TipDefectiune = "pana la roata",
                            TipMasina = "vw"
                        },
                        new
                        {
                            ID = new Guid("551e9dab-b73e-4322-2345-bfab4a214d9a"),
                            Locatia = "Campani",
                            Nume = "Boldor",
                            Prenume = "Sara",
                            TipDefectiune = "oglina rupta",
                            TipMasina = "audi"
                        });
                });

            modelBuilder.Entity("ServiceAutoApp.Models.Masina", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Locatia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipMasina")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Masina");

                    b.HasData(
                        new
                        {
                            ID = new Guid("551e9dab-b73e-1233-2345-bfab4a214d9a"),
                            Locatia = "Oradea",
                            TipMasina = "duba"
                        },
                        new
                        {
                            ID = new Guid("551e9dab-b73e-4567-2345-bfab4a214d9a"),
                            Locatia = "Bistrita",
                            TipMasina = "tir"
                        });
                });

            modelBuilder.Entity("ServiceAutoApp.Models.Serviciu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DenumireServiciu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Pret")
                        .HasColumnType("float");

                    b.Property<string>("TipMasinaNecesara")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Serviciu");

                    b.HasData(
                        new
                        {
                            ID = new Guid("551e9dab-b73e-4567-2345-bfab4a214d9a"),
                            DenumireServiciu = "vulcanizare",
                            Pret = 1234.0,
                            TipMasinaNecesara = "duba"
                        },
                        new
                        {
                            ID = new Guid("551e9dab-b73e-6789-2345-bfab4a214d9a"),
                            DenumireServiciu = "avariere",
                            Pret = 1345.0,
                            TipMasinaNecesara = "tir"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
