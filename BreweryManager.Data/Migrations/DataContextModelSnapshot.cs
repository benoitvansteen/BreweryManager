﻿// <auto-generated />
using BreweryManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BreweryManager.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BreweryManager.EntityModels.Beer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("AlcoolDegree")
                        .HasColumnType("float");

                    b.Property<int>("BreweryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BreweryId");

                    b.ToTable("Beers");
                });

            modelBuilder.Entity("BreweryManager.EntityModels.Brewery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Breweries");
                });

            modelBuilder.Entity("BreweryManager.EntityModels.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("WholesalerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WholesalerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BreweryManager.EntityModels.OrderBeerProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BeerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BeerId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderBeerProducts");
                });

            modelBuilder.Entity("BreweryManager.EntityModels.Wholesaler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Wholesalers");
                });

            modelBuilder.Entity("BreweryManager.EntityModels.WholesalerBeerProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BeerId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("WholesalerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BeerId");

                    b.HasIndex("WholesalerId");

                    b.ToTable("wholesalerBeerProducts");
                });

            modelBuilder.Entity("BreweryManager.EntityModels.Beer", b =>
                {
                    b.HasOne("BreweryManager.EntityModels.Brewery", "Brewery")
                        .WithMany("Beers")
                        .HasForeignKey("BreweryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brewery");
                });

            modelBuilder.Entity("BreweryManager.EntityModels.Order", b =>
                {
                    b.HasOne("BreweryManager.EntityModels.Wholesaler", "Wholesaler")
                        .WithMany("Orders")
                        .HasForeignKey("WholesalerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wholesaler");
                });

            modelBuilder.Entity("BreweryManager.EntityModels.OrderBeerProduct", b =>
                {
                    b.HasOne("BreweryManager.EntityModels.Beer", "Beer")
                        .WithMany()
                        .HasForeignKey("BeerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BreweryManager.EntityModels.Order", "Order")
                        .WithMany("OrderBeerProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beer");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BreweryManager.EntityModels.WholesalerBeerProduct", b =>
                {
                    b.HasOne("BreweryManager.EntityModels.Beer", "Beer")
                        .WithMany()
                        .HasForeignKey("BeerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BreweryManager.EntityModels.Wholesaler", "Wholesaler")
                        .WithMany("WholesalerBeerProducts")
                        .HasForeignKey("WholesalerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beer");

                    b.Navigation("Wholesaler");
                });

            modelBuilder.Entity("BreweryManager.EntityModels.Brewery", b =>
                {
                    b.Navigation("Beers");
                });

            modelBuilder.Entity("BreweryManager.EntityModels.Order", b =>
                {
                    b.Navigation("OrderBeerProducts");
                });

            modelBuilder.Entity("BreweryManager.EntityModels.Wholesaler", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("WholesalerBeerProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
