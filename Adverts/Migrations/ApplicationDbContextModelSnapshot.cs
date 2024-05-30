﻿// <auto-generated />
using System;
using Adverts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Adverts.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Adverts.Data.Entities.Ads", b =>
                {
                    b.Property<int>("ad_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ad_id"));

                    b.Property<int?>("ad_Advertisersadv_id")
                        .HasColumnType("int");

                    b.Property<int?>("ad_advertisers_id")
                        .HasColumnType("int");

                    b.Property<double>("ad_advertismentPrice")
                        .HasColumnType("float");

                    b.Property<string>("ad_content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ad_headline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ad_productPrice")
                        .HasColumnType("float");

                    b.HasKey("ad_id");

                    b.HasIndex("ad_Advertisersadv_id");

                    b.ToTable("tbl_ads");
                });

            modelBuilder.Entity("Adverts.Data.Entities.Advertisers", b =>
                {
                    b.Property<int>("adv_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("adv_id"));

                    b.Property<string>("adv_City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("adv_PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("adv_billingAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("adv_deliveryAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("adv_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("adv_organisationNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("adv_postalCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("adv_id");

                    b.HasIndex("adv_name")
                        .IsUnique();

                    b.ToTable("tbl_advertisers");
                });

            modelBuilder.Entity("Adverts.Data.Entities.Ads", b =>
                {
                    b.HasOne("Adverts.Data.Entities.Advertisers", "ad_Advertisers")
                        .WithMany()
                        .HasForeignKey("ad_Advertisersadv_id");

                    b.Navigation("ad_Advertisers");
                });
#pragma warning restore 612, 618
        }
    }
}
