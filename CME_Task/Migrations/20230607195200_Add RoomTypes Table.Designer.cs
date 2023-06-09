﻿// <auto-generated />
using System;
using CME_Task.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CME_Task.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20230607195200_Add RoomTypes Table")]
    partial class AddRoomTypesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CME_Task.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CME_Task.Models.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NightsNum")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("CME_Task.Models.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BedsNum")
                        .HasColumnType("int");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<int>("RoomType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bbc76288-130d-48c0-8e35-8505a7860317"),
                            BedsNum = 1,
                            Floor = 1,
                            Price = 100f,
                            RoomNumber = 1,
                            RoomType = 1
                        },
                        new
                        {
                            Id = new Guid("58795f8a-4703-4e32-a636-d558b2fcf81f"),
                            BedsNum = 1,
                            Floor = 1,
                            Price = 150f,
                            RoomNumber = 2,
                            RoomType = 3
                        },
                        new
                        {
                            Id = new Guid("9f6dc4c3-1f34-4827-9520-72e66ee202a1"),
                            BedsNum = 2,
                            Floor = 2,
                            Price = 200f,
                            RoomNumber = 3,
                            RoomType = 2
                        },
                        new
                        {
                            Id = new Guid("227fe832-6364-48ac-af13-321f937fd1f0"),
                            BedsNum = 2,
                            Floor = 2,
                            Price = 250f,
                            RoomNumber = 4,
                            RoomType = 2
                        });
                });

            modelBuilder.Entity("CME_Task.Models.RoomTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoomType = "Standard"
                        },
                        new
                        {
                            Id = 2,
                            RoomType = "Suite"
                        },
                        new
                        {
                            Id = 3,
                            RoomType = "Deluxe"
                        });
                });

            modelBuilder.Entity("CME_Task.Models.Reservation", b =>
                {
                    b.HasOne("CME_Task.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("CME_Task.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.Navigation("Customer");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("CME_Task.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
