﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingCart.DbContexts;

#nullable disable

namespace ShoppingCart.Migrations
{
    [DbContext(typeof(ShoppingCartDbContext))]
    [Migration("20211202004021_ForthCreate")]
    partial class ForthCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShoppingCart.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A large phone with one of the best screens",
                            Name = "Phone XL",
                            Price = 799m
                        },
                        new
                        {
                            Id = 2,
                            Description = "A great phone with one of the best cameras",
                            Name = "Phone Mini",
                            Price = 699m
                        },
                        new
                        {
                            Id = 3,
                            Description = "A standard phone that can make and receive calls",
                            Name = "Phone Standard",
                            Price = 299m
                        });
                });

            modelBuilder.Entity("ShoppingCart.Models.ShippingPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShippingPrices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 25.99m,
                            Type = "Overnight"
                        },
                        new
                        {
                            Id = 2,
                            Price = 9.99m,
                            Type = "2-Day"
                        },
                        new
                        {
                            Id = 3,
                            Price = 2.99m,
                            Type = "Postal"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
