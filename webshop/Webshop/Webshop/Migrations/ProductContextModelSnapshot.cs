using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Webshop.Entities;

namespace Webshop.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Webshop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category")
                        .HasMaxLength(30);

                    b.Property<string>("ItemName")
                        .HasMaxLength(80);

                    b.Property<string>("Manufacturer")
                        .HasMaxLength(30);

                    b.Property<int>("Price");

                    b.Property<string>("Size")
                        .HasMaxLength(4);

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
        }
    }
}
