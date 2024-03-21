﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PartsPortal.API.Data;

#nullable disable

namespace PartsPortal.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240321135537_UpdateRelations7")]
    partial class UpdateRelations7
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

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("PartsPortal.Entites.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("PartsPortal.Entites.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

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

                    b.HasKey("Id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("PartsPortal.Entites.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("clientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("productId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("clientId");

                    b.HasIndex("productId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("PartsPortal.Entites.Address", b =>
                {
                    b.HasOne("PartsPortal.Entites.Client", "Client")
                        .WithMany("Addresses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("PartsPortal.Entites.Stock", b =>
                {
                    b.HasOne("PartsPortal.Entites.Client", "client")
                        .WithMany()
                        .HasForeignKey("clientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PartsPortal.Entites.Product", "product")
                        .WithMany()
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");

                    b.Navigation("product");
                });

            modelBuilder.Entity("PartsPortal.Entites.Client", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}