﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanlyKho1;

#nullable disable

namespace QuanlyKho1.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231118050257_m2")]
    partial class m2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanlyKho1.Models.Category", b =>
                {
                    b.Property<long>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CategoryID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1L,
                            Name = "Soft Drink"
                        },
                        new
                        {
                            CategoryID = 2L,
                            Name = "Beer"
                        },
                        new
                        {
                            CategoryID = 3L,
                            Name = "Wine"
                        },
                        new
                        {
                            CategoryID = 4L,
                            Name = "Mineral Water"
                        });
                });

            modelBuilder.Entity("QuanlyKho1.Models.DcDetail", b =>
                {
                    b.Property<long>("DcDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("DcDetailID"));

                    b.Property<long>("DocumentID")
                        .HasColumnType("bigint");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<long>("ProductDetailID")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("DcDetailID");

                    b.HasIndex("DocumentID");

                    b.HasIndex("ProductDetailID");

                    b.ToTable("DcDetail");
                });

            modelBuilder.Entity("QuanlyKho1.Models.Document", b =>
                {
                    b.Property<long>("DocumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("DocumentID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte>("Classify")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("Date");

                    b.Property<long>("PersonID")
                        .HasColumnType("bigint");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("DocumentID");

                    b.HasIndex("PersonID");

                    b.HasIndex("UserID");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("QuanlyKho1.Models.Inventory", b =>
                {
                    b.Property<long>("InventoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("InventoryID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InventoryID");

                    b.ToTable("Inventory");

                    b.HasData(
                        new
                        {
                            InventoryID = 1L,
                            Address = "Cộng Hòa",
                            Name = "Kho 1"
                        });
                });

            modelBuilder.Entity("QuanlyKho1.Models.Person", b =>
                {
                    b.Property<long>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PersonID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("char(10)");

                    b.HasKey("PersonID");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonID = 1L,
                            Address = "103/16C Trần Qang Diệu,P14,Q3",
                            Email = "ttathu0907@gmail.com",
                            Name = "Trần Thị Anh Thư",
                            Phone = "0945449058"
                        });
                });

            modelBuilder.Entity("QuanlyKho1.Models.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductID"));

                    b.Property<long>("CategoryID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1L,
                            CategoryID = 3L,
                            Name = "Soju",
                            Origin = "Korea",
                            Price = 60000
                        },
                        new
                        {
                            ProductID = 2L,
                            CategoryID = 2L,
                            Name = "Tiger",
                            Origin = "Korea",
                            Price = 15000
                        },
                        new
                        {
                            ProductID = 3L,
                            CategoryID = 2L,
                            Name = "SaiGon",
                            Origin = "Korea",
                            Price = 12000
                        });
                });

            modelBuilder.Entity("QuanlyKho1.Models.ProductDetail", b =>
                {
                    b.Property<long>("ProductDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductDetailID"));

                    b.Property<long>("InventoryID")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductDetailID");

                    b.HasIndex("InventoryID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductsDetail");
                });

            modelBuilder.Entity("QuanlyKho1.Models.User", b =>
                {
                    b.Property<long>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserID"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("char(50)");

                    b.Property<byte>("RoleID")
                        .HasColumnType("tinyint");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("char(20)");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1L,
                            Email = "ahihi@gmail.com",
                            Name = "Nguyễn Công Giới",
                            Password = "admin",
                            RoleID = (byte)1,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("QuanlyKho1.Models.DcDetail", b =>
                {
                    b.HasOne("QuanlyKho1.Models.Document", "Document")
                        .WithMany("DcDetails")
                        .HasForeignKey("DocumentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanlyKho1.Models.ProductDetail", "ProductDetail")
                        .WithMany("DcDetails")
                        .HasForeignKey("ProductDetailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("QuanlyKho1.Models.Document", b =>
                {
                    b.HasOne("QuanlyKho1.Models.Person", "Person")
                        .WithMany("Documents")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanlyKho1.Models.User", "User")
                        .WithMany("Documents")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuanlyKho1.Models.Product", b =>
                {
                    b.HasOne("QuanlyKho1.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("QuanlyKho1.Models.ProductDetail", b =>
                {
                    b.HasOne("QuanlyKho1.Models.Inventory", "Inventory")
                        .WithMany("ProductDetails")
                        .HasForeignKey("InventoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanlyKho1.Models.Product", "Product")
                        .WithMany("Details")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("QuanlyKho1.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("QuanlyKho1.Models.Document", b =>
                {
                    b.Navigation("DcDetails");
                });

            modelBuilder.Entity("QuanlyKho1.Models.Inventory", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("QuanlyKho1.Models.Person", b =>
                {
                    b.Navigation("Documents");
                });

            modelBuilder.Entity("QuanlyKho1.Models.Product", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("QuanlyKho1.Models.ProductDetail", b =>
                {
                    b.Navigation("DcDetails");
                });

            modelBuilder.Entity("QuanlyKho1.Models.User", b =>
                {
                    b.Navigation("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}
