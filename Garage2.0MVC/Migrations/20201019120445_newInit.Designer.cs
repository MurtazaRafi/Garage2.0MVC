﻿// <auto-generated />
using System;
using Garage2._0MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Garage2._0MVC.Migrations
{
    [DbContext(typeof(Garage2_0MVCContext))]
    [Migration("20201019120445_newInit")]
    partial class newInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Garage2._0MVC.Models.VehicleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<int>("NumWheels")
                        .HasColumnType("int");

                    b.Property<string>("RegNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VehicleModel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArrivalTime = new DateTime(2020, 10, 19, 14, 4, 44, 710, DateTimeKind.Local).AddTicks(4117),
                            Brand = "Volvo",
                            Color = "Red",
                            Model = "V70",
                            NumWheels = 4,
                            RegNum = "ABC123",
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            ArrivalTime = new DateTime(2020, 10, 19, 14, 4, 44, 714, DateTimeKind.Local).AddTicks(1945),
                            Brand = "Saab",
                            Color = "Blue",
                            Model = "T20",
                            NumWheels = 6,
                            RegNum = "GHT253",
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            ArrivalTime = new DateTime(2020, 10, 19, 14, 4, 44, 714, DateTimeKind.Local).AddTicks(2013),
                            Brand = "BMW",
                            Color = "Black",
                            Model = "800",
                            NumWheels = 0,
                            RegNum = "TYU589",
                            Type = 2
                        },
                        new
                        {
                            Id = 4,
                            ArrivalTime = new DateTime(2020, 10, 19, 14, 4, 44, 714, DateTimeKind.Local).AddTicks(2021),
                            Brand = "SAS",
                            Color = "Silver",
                            Model = "737",
                            NumWheels = 6,
                            RegNum = "SK1420",
                            Type = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}