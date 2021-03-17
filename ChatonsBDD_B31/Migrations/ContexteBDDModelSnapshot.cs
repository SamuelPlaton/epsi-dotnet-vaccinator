﻿// <auto-generated />
using System;
using ChatonsBDD_B31.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChatonsBDD_B31.Migrations
{
    [DbContext(typeof(ContexteBDD))]
    partial class ContexteBDDModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("ChatonsBDD_B31.Models.Injection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("lot")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("recall")
                        .HasColumnType("TEXT");

                    b.Property<int?>("userId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("vaccineId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.HasIndex("vaccineId");

                    b.ToTable("Injection");
                });

            modelBuilder.Entity("ChatonsBDD_B31.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("category")
                        .HasColumnType("INTEGER");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ChatonsBDD_B31.Models.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("periodicity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Vaccine");
                });

            modelBuilder.Entity("ChatonsBDD_B31.Models.Injection", b =>
                {
                    b.HasOne("ChatonsBDD_B31.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");

                    b.HasOne("ChatonsBDD_B31.Models.Vaccine", "vaccine")
                        .WithMany()
                        .HasForeignKey("vaccineId");

                    b.Navigation("user");

                    b.Navigation("vaccine");
                });
#pragma warning restore 612, 618
        }
    }
}
