﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PartsPortal.API.Data;

#nullable disable

namespace PartsPortal.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240321105015_UpdateRelations3")]
    partial class UpdateRelations3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("PartsPortal.Entites.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("PartsPortal.Entites.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdressId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AdressId");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("PartsPortal.Entites.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MyProperty")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Qty")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StockId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("StockId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("PartsPortal.Entites.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("clientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("clientId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("PartsPortal.Entites.Client", b =>
                {
                    b.HasOne("PartsPortal.Entites.Address", "Adress")
                        .WithMany()
                        .HasForeignKey("AdressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adress");
                });

            modelBuilder.Entity("PartsPortal.Entites.Product", b =>
                {
                    b.HasOne("PartsPortal.Entites.Client", null)
                        .WithMany("Products")
                        .HasForeignKey("ClientId");

                    b.HasOne("PartsPortal.Entites.Stock", null)
                        .WithMany("Products")
                        .HasForeignKey("StockId");
                });

            modelBuilder.Entity("PartsPortal.Entites.Stock", b =>
                {
                    b.HasOne("PartsPortal.Entites.Client", "client")
                        .WithMany()
                        .HasForeignKey("clientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");
                });

            modelBuilder.Entity("PartsPortal.Entites.Client", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("PartsPortal.Entites.Stock", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}