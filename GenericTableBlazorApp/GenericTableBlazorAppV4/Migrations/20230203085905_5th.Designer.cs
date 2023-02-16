﻿// <auto-generated />
using System;
using GenericTableBlazorAppV4.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GenericTableBlazorAppV4.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20230203085905_5th")]
    partial class _5th
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("GenericTableBlazorAppV4.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CashbackCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("GenericTableBlazorAppV4.Models.OrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CloseOrderDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateOrderDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerModelId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FullPrice")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CustomerModelId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("GenericTableBlazorAppV4.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("InStock")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCashback")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductCharacteristicsName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductCharacteristicsValue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("OrderModelProductModel", b =>
                {
                    b.Property<int>("OrderModelsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductModelsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderModelsId", "ProductModelsId");

                    b.HasIndex("ProductModelsId");

                    b.ToTable("OrderModelProductModel");
                });

            modelBuilder.Entity("GenericTableBlazorAppV4.Models.OrderModel", b =>
                {
                    b.HasOne("GenericTableBlazorAppV4.Models.CustomerModel", "CustomerModel")
                        .WithMany("OrderModels")
                        .HasForeignKey("CustomerModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerModel");
                });

            modelBuilder.Entity("OrderModelProductModel", b =>
                {
                    b.HasOne("GenericTableBlazorAppV4.Models.OrderModel", null)
                        .WithMany()
                        .HasForeignKey("OrderModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GenericTableBlazorAppV4.Models.ProductModel", null)
                        .WithMany()
                        .HasForeignKey("ProductModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenericTableBlazorAppV4.Models.CustomerModel", b =>
                {
                    b.Navigation("OrderModels");
                });
#pragma warning restore 612, 618
        }
    }
}
