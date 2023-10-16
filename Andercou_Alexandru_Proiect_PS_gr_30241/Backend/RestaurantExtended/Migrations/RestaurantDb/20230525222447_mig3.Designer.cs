﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantExtended.Data;

#nullable disable

namespace RestaurantExtended.Migrations.RestaurantDb
{
    [DbContext(typeof(RestaurantDbContext))]
    [Migration("20230525222447_mig3")]
    partial class mig3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RestaurantExtended.Models.Comanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("pretTotal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Comanda");
                });

            modelBuilder.Entity("RestaurantExtended.Models.ComandaProdus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ComandaId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComandaId");

                    b.HasIndex("ProductId");

                    b.ToTable("comandaProdus");
                });

            modelBuilder.Entity("RestaurantExtended.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ProdusId")
                        .HasColumnType("int");

                    b.Property<byte[]>("data")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProdusId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("RestaurantExtended.Models.Produs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("pret")
                        .HasColumnType("float");

                    b.Property<int>("stoc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("RestaurantExtended.Models.ComandaProdus", b =>
                {
                    b.HasOne("RestaurantExtended.Models.Comanda", null)
                        .WithMany("produseComanda")
                        .HasForeignKey("ComandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantExtended.Models.Produs", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantExtended.Models.Image", b =>
                {
                    b.HasOne("RestaurantExtended.Models.Produs", null)
                        .WithMany("images")
                        .HasForeignKey("ProdusId");
                });

            modelBuilder.Entity("RestaurantExtended.Models.Comanda", b =>
                {
                    b.Navigation("produseComanda");
                });

            modelBuilder.Entity("RestaurantExtended.Models.Produs", b =>
                {
                    b.Navigation("images");
                });
#pragma warning restore 612, 618
        }
    }
}
