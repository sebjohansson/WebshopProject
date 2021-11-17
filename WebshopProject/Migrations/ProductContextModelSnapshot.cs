﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebshopProject.Data;

namespace WebshopProject.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebshopProject.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<float?>("ratingrate")
                        .HasColumnType("real");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("ratingrate");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WebshopProject.Models.Rating", b =>
                {
                    b.Property<float>("rate")
                        .HasColumnType("real");

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.HasKey("rate");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("WebshopProject.Models.Product", b =>
                {
                    b.HasOne("WebshopProject.Models.Rating", "rating")
                        .WithMany()
                        .HasForeignKey("ratingrate");

                    b.Navigation("rating");
                });
#pragma warning restore 612, 618
        }
    }
}
