﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace April2020.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220124142701_V1")]
    partial class V1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Models.Polica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MaxDiskova")
                        .HasColumnType("int");

                    b.Property<string>("Oznaka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrenutnoDiskova")
                        .HasColumnType("int");

                    b.Property<int?>("VideoKlubID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("VideoKlubID");

                    b.ToTable("Police");
                });

            modelBuilder.Entity("Models.VideoKlub", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Klubovi");
                });

            modelBuilder.Entity("Models.Polica", b =>
                {
                    b.HasOne("Models.VideoKlub", "VideoKlub")
                        .WithMany("Police")
                        .HasForeignKey("VideoKlubID");

                    b.Navigation("VideoKlub");
                });

            modelBuilder.Entity("Models.VideoKlub", b =>
                {
                    b.Navigation("Police");
                });
#pragma warning restore 612, 618
        }
    }
}
