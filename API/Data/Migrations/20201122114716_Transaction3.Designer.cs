﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201122114716_Transaction3")]
    partial class Transaction3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("API.Entities.AppQLTC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CardType")
                        .HasColumnType("TEXT");

                    b.Property<double>("InitialLoad")
                        .HasColumnType("REAL");

                    b.Property<int>("Validity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("QLTC");
                });

            modelBuilder.Entity("API.Entities.AppTransactions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date_In")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date_Out")
                        .HasColumnType("TEXT");

                    b.Property<int>("StationFrom")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StationTo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("API.Entities.MRTLine1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("F1")
                        .HasColumnType("REAL");

                    b.Property<double>("F10")
                        .HasColumnType("REAL");

                    b.Property<double>("F11")
                        .HasColumnType("REAL");

                    b.Property<double>("F12")
                        .HasColumnType("REAL");

                    b.Property<double>("F13")
                        .HasColumnType("REAL");

                    b.Property<double>("F14")
                        .HasColumnType("REAL");

                    b.Property<double>("F15")
                        .HasColumnType("REAL");

                    b.Property<double>("F16")
                        .HasColumnType("REAL");

                    b.Property<double>("F17")
                        .HasColumnType("REAL");

                    b.Property<double>("F18")
                        .HasColumnType("REAL");

                    b.Property<double>("F19")
                        .HasColumnType("REAL");

                    b.Property<double>("F2")
                        .HasColumnType("REAL");

                    b.Property<double>("F20")
                        .HasColumnType("REAL");

                    b.Property<double>("F3")
                        .HasColumnType("REAL");

                    b.Property<double>("F4")
                        .HasColumnType("REAL");

                    b.Property<double>("F5")
                        .HasColumnType("REAL");

                    b.Property<double>("F6")
                        .HasColumnType("REAL");

                    b.Property<double>("F7")
                        .HasColumnType("REAL");

                    b.Property<double>("F8")
                        .HasColumnType("REAL");

                    b.Property<double>("F9")
                        .HasColumnType("REAL");

                    b.Property<int>("Station")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MRTLine1");
                });

            modelBuilder.Entity("API.Entities.MRTLine2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("F1")
                        .HasColumnType("REAL");

                    b.Property<double>("F10")
                        .HasColumnType("REAL");

                    b.Property<double>("F11")
                        .HasColumnType("REAL");

                    b.Property<double>("F2")
                        .HasColumnType("REAL");

                    b.Property<double>("F3")
                        .HasColumnType("REAL");

                    b.Property<double>("F4")
                        .HasColumnType("REAL");

                    b.Property<double>("F5")
                        .HasColumnType("REAL");

                    b.Property<double>("F6")
                        .HasColumnType("REAL");

                    b.Property<double>("F7")
                        .HasColumnType("REAL");

                    b.Property<double>("F8")
                        .HasColumnType("REAL");

                    b.Property<double>("F9")
                        .HasColumnType("REAL");

                    b.Property<int>("Station")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MRTLine2");
                });
#pragma warning restore 612, 618
        }
    }
}
