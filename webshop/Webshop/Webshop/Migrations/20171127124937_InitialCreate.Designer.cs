using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Webshop.Entities;

namespace Webshop.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20171127124937_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
