﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PhoneBookApp.PersonService.DataAccess.Database.Context.EntityFramework;

namespace PhoneBookApp.PersonService.DataAccess.Migrations
{
    [DbContext(typeof(PhoneBookAppContextEF))]
    [Migration("20210220222542_Update")]
    partial class Update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PhoneBookApp.PersonService.DataAccess.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Mail")
                        .HasColumnType("text");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("PhoneBookApp.PersonService.DataAccess.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CompanyName")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("af5c2744-fe13-4b59-b79a-df9ad25e8d89"),
                            CompanyName = "Bilge Adam",
                            CreatedTime = new DateTime(2021, 2, 21, 1, 25, 40, 700, DateTimeKind.Local).AddTicks(5431),
                            IsDeleted = false,
                            Name = "Mehmet",
                            Surname = "Koyuncu"
                        },
                        new
                        {
                            Id = new Guid("b2dcad91-97b5-4cce-a199-3c2d2bec1e55"),
                            CompanyName = "Setur",
                            CreatedTime = new DateTime(2021, 2, 21, 1, 25, 40, 703, DateTimeKind.Local).AddTicks(2458),
                            IsDeleted = true,
                            Name = "Name 1",
                            Surname = "Name 2"
                        });
                });

            modelBuilder.Entity("PhoneBookApp.PersonService.DataAccess.Entities.Contact", b =>
                {
                    b.HasOne("PhoneBookApp.PersonService.DataAccess.Entities.Person", "Person")
                        .WithMany("Contacts")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}