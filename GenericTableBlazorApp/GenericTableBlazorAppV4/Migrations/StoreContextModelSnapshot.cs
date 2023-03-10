// <auto-generated />
using System;
using GenericTableBlazorAppV4.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GenericTableBlazorAppV4.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

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

                    b.Property<int?>("ProductModelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CustomerModelId")
                        .IsUnique();

                    b.HasIndex("ProductModelId");

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

            modelBuilder.Entity("GenericTableBlazorAppV4.Models.OrderModel", b =>
                {
                    b.HasOne("GenericTableBlazorAppV4.Models.CustomerModel", "CustomerModel")
                        .WithOne("OrderModel")
                        .HasForeignKey("GenericTableBlazorAppV4.Models.OrderModel", "CustomerModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GenericTableBlazorAppV4.Models.ProductModel", null)
                        .WithMany("OrderModels")
                        .HasForeignKey("ProductModelId");

                    b.Navigation("CustomerModel");
                });

            modelBuilder.Entity("GenericTableBlazorAppV4.Models.CustomerModel", b =>
                {
                    b.Navigation("OrderModel")
                        .IsRequired();
                });

            modelBuilder.Entity("GenericTableBlazorAppV4.Models.ProductModel", b =>
                {
                    b.Navigation("OrderModels");
                });
#pragma warning restore 612, 618
        }
    }
}
