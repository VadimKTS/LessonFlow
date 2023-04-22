﻿// <auto-generated />
using Lesson15main_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lesson15main_2.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230421074413_Add_Card_Table_1_3")]
    partial class Add_Card_Table_1_3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lesson15main_2.Models.EFDto.Manufacture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountOfMembers")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufactures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountOfMembers = 540,
                            Name = "Google"
                        },
                        new
                        {
                            Id = 2,
                            CountOfMembers = 400,
                            Name = "Microsoft"
                        },
                        new
                        {
                            Id = 3,
                            CountOfMembers = 250,
                            Name = "Intel"
                        });
                });

            modelBuilder.Entity("Lesson15main_2.Models.EFDto.PayCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufactureId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManufactureId");

                    b.ToTable("PayCard");
                });

            modelBuilder.Entity("Lesson15main_2.Models.EFDto.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufactureId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManufactureId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Lesson15main_2.Models.EFDto.PayCard", b =>
                {
                    b.HasOne("Lesson15main_2.Models.EFDto.Manufacture", "Manufacture")
                        .WithMany()
                        .HasForeignKey("ManufactureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacture");
                });

            modelBuilder.Entity("Lesson15main_2.Models.EFDto.User", b =>
                {
                    b.HasOne("Lesson15main_2.Models.EFDto.Manufacture", "Manufacture")
                        .WithMany()
                        .HasForeignKey("ManufactureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacture");
                });
#pragma warning restore 612, 618
        }
    }
}
