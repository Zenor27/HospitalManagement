﻿// <auto-generated />
using System;
using HospitalServer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalServer.Migrations
{
    [DbContext(typeof(ApplicationDatabaseContext))]
    [Migration("20200501120334_RenamePasswordToPasswordHash")]
    partial class RenamePasswordToPasswordHash
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalEntities.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.HasIndex("StaffId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 584, DateTimeKind.Local).AddTicks(1365),
                            Date = new DateTime(2020, 5, 1, 14, 3, 33, 584, DateTimeKind.Local).AddTicks(1365),
                            Description = "Rendez-Vous classique",
                            PatientId = 1,
                            StaffId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 584, DateTimeKind.Local).AddTicks(1365),
                            Date = new DateTime(2020, 5, 1, 14, 3, 33, 584, DateTimeKind.Local).AddTicks(1365),
                            Description = "Rendez-Vous classique",
                            PatientId = 1,
                            StaffId = 1,
                            Status = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 584, DateTimeKind.Local).AddTicks(1365),
                            Date = new DateTime(2020, 5, 1, 14, 3, 33, 584, DateTimeKind.Local).AddTicks(1365),
                            Description = "Rendez-Vous classique",
                            PatientId = 2,
                            StaffId = 1,
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 584, DateTimeKind.Local).AddTicks(1365),
                            Date = new DateTime(2020, 5, 1, 14, 3, 33, 584, DateTimeKind.Local).AddTicks(1365),
                            Description = "Rendez-Vous classique",
                            PatientId = 2,
                            StaffId = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 584, DateTimeKind.Local).AddTicks(1365),
                            Date = new DateTime(2020, 5, 1, 14, 3, 33, 584, DateTimeKind.Local).AddTicks(1365),
                            Description = "Rendez-Vous classique",
                            PatientId = 3,
                            StaffId = 2,
                            Status = 2
                        });
                });

            modelBuilder.Entity("HospitalEntities.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 581, DateTimeKind.Local).AddTicks(1228),
                            Description = "Alerte COVID-19. Restez prudent."
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 582, DateTimeKind.Local).AddTicks(1232),
                            Description = "Portez des masques. Restez prudent."
                        });
                });

            modelBuilder.Entity("HospitalEntities.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Background")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "EPITA",
                            Background = "Troubles psychologiques",
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 582, DateTimeKind.Local).AddTicks(1232),
                            Email = "denis@fail.com",
                            FirstName = "Denis",
                            LastName = "Lastname",
                            PasswordHash = "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK",
                            PhoneNumber = "0000000000"
                        },
                        new
                        {
                            Id = 2,
                            Address = "EPITA",
                            Background = "Troubles psychologiques",
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 582, DateTimeKind.Local).AddTicks(1232),
                            Email = "sylvie@fail.com",
                            FirstName = "Sylvie",
                            LastName = "Lastname",
                            PasswordHash = "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK",
                            PhoneNumber = "0000000000"
                        },
                        new
                        {
                            Id = 3,
                            Address = "EPITA",
                            Background = "Troubles psychologiques",
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 582, DateTimeKind.Local).AddTicks(1232),
                            Email = "dumeige@fail.com",
                            FirstName = "Antoine",
                            LastName = "Login",
                            PasswordHash = "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK",
                            PhoneNumber = "0000000000"
                        },
                        new
                        {
                            Id = 4,
                            Address = "EPITA",
                            Background = "Troubles psychologiques",
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 582, DateTimeKind.Local).AddTicks(1232),
                            Email = "xavier@fail.com",
                            FirstName = "Xavier",
                            LastName = "Login",
                            PasswordHash = "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK",
                            PhoneNumber = "0000000000"
                        });
                });

            modelBuilder.Entity("HospitalEntities.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "14 Rue de Villejuif, 94800 Villejuif",
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 583, DateTimeKind.Local).AddTicks(1388),
                            Email = "antoine@fail.com",
                            FirstName = "Antoine",
                            LastName = "Lastname",
                            PasswordHash = "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK",
                            PhoneNumber = "0707070707",
                            StaffType = 0
                        },
                        new
                        {
                            Id = 2,
                            Address = "14 Rue de Villejuif, 94800 Villejuif",
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 583, DateTimeKind.Local).AddTicks(1388),
                            Email = "gauthier@fail.com",
                            FirstName = "Gauthier",
                            LastName = "Lastname",
                            PasswordHash = "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK",
                            PhoneNumber = "0707070707",
                            StaffType = 0
                        },
                        new
                        {
                            Id = 3,
                            Address = "14 Rue de Villejuif, 94800 Villejuif",
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 583, DateTimeKind.Local).AddTicks(1388),
                            Email = "julien@fail.com",
                            FirstName = "Julien",
                            LastName = "Lastname",
                            PasswordHash = "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK",
                            PhoneNumber = "0707070707",
                            StaffType = 1
                        },
                        new
                        {
                            Id = 4,
                            Address = "14 Rue de Villejuif, 94800 Villejuif",
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 583, DateTimeKind.Local).AddTicks(1388),
                            Email = "louis@fail.com",
                            FirstName = "Louis",
                            LastName = "Lastname",
                            PasswordHash = "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK",
                            PhoneNumber = "0707070707",
                            StaffType = 2
                        },
                        new
                        {
                            Id = 5,
                            Address = "14 Rue de Villejuif, 94800 Villejuif",
                            CreatedAt = new DateTime(2020, 5, 1, 14, 3, 33, 583, DateTimeKind.Local).AddTicks(1388),
                            Email = "albert@fail.com",
                            FirstName = "Albert",
                            LastName = "Login",
                            PasswordHash = "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK",
                            PhoneNumber = "0707070707",
                            StaffType = 3
                        });
                });

            modelBuilder.Entity("HospitalEntities.Models.Appointment", b =>
                {
                    b.HasOne("HospitalEntities.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalEntities.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
