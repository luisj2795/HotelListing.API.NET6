﻿// <auto-generated />
using HotelListingAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelListingAPI.Migrations
{
    [DbContext(typeof(HotelListingDbContext))]
    partial class HotelListingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HotelListingAPI.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaisId")
                        .HasColumnType("int");

                    b.Property<double>("Reseña")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("Hoteles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Direccion = "Negril",
                            Nombre = "Sandals Resort an Spa",
                            PaisId = 1,
                            Reseña = 4.5
                        },
                        new
                        {
                            Id = 2,
                            Direccion = "George Town",
                            Nombre = "Comfort Suites",
                            PaisId = 2,
                            Reseña = 4.2999999999999998
                        },
                        new
                        {
                            Id = 3,
                            Direccion = "Av Vitacura 130",
                            Nombre = "AC Hotel",
                            PaisId = 3,
                            Reseña = 4.2000000000000002
                        },
                        new
                        {
                            Id = 4,
                            Direccion = "Cerro el Avila",
                            Nombre = "Hotel Humbolt",
                            PaisId = 4,
                            Reseña = 4.7000000000000002
                        });
                });

            modelBuilder.Entity("HotelListingAPI.Data.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCorto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Paises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Jamaica",
                            NombreCorto = "JM"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Bahamas",
                            NombreCorto = "BS"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Chile",
                            NombreCorto = "CL"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Venezuela",
                            NombreCorto = "VE"
                        });
                });

            modelBuilder.Entity("HotelListingAPI.Data.Hotel", b =>
                {
                    b.HasOne("HotelListingAPI.Data.Pais", null)
                        .WithMany("Hoteles")
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelListingAPI.Data.Pais", b =>
                {
                    b.Navigation("Hoteles");
                });
#pragma warning restore 612, 618
        }
    }
}