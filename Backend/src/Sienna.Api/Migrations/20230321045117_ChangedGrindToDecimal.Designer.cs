﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sienna.Data.Contexts;

#nullable disable

namespace Sienna.Api.Migrations
{
    [DbContext(typeof(EspressoShotContext))]
    [Migration("20230321045117_ChangedGrindToDecimal")]
    partial class ChangedGrindToDecimal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sienna.Data.Models.EspressoShot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BeanType")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Beans")
                        .HasColumnType("int");

                    b.Property<int>("BrewTime")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("Flavour")
                        .HasColumnType("int");

                    b.Property<double>("Grind")
                        .HasColumnType("float");

                    b.Property<int>("Pressure")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("Water")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EspressoShots");
                });
#pragma warning restore 612, 618
        }
    }
}
