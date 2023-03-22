﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sienna.Infrastructure.Repositories;

#nullable disable

namespace Sienna.Api.Migrations
{
    [DbContext(typeof(EspressoShotRepository))]
    [Migration("20230321222355_UpdatedTheModelWithMoreDoubles")]
    partial class UpdatedTheModelWithMoreDoubles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sienna.Infrastructure.Models.EspressoShot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BeanType")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<double>("Beans")
                        .HasColumnType("float");

                    b.Property<double>("BrewTime")
                        .HasColumnType("float");

                    b.Property<string>("Comments")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("Flavour")
                        .HasColumnType("int");

                    b.Property<double>("Grind")
                        .HasColumnType("float");

                    b.Property<double>("Pressure")
                        .HasColumnType("float");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<double>("Water")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("EspressoShots");
                });
#pragma warning restore 612, 618
        }
    }
}