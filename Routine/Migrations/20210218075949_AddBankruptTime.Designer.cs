﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Routine.Data;

namespace Routine.Migrations
{
    [DbContext(typeof(RoutineDbContext))]
    [Migration("20210218075949_AddBankruptTime")]
    partial class AddBankruptTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Routine.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("BankRuptTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Industry")
                        .HasColumnType("TEXT");

                    b.Property<string>("Introduction")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Product")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d502f792-b007-4262-823e-26abd4666dce"),
                            Country = "USA",
                            Industry = "Software",
                            Introduction = "Great Company",
                            Name = "Microsoft",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("9babffca-c2aa-4ff6-a4ee-0a22682d239e"),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Don't be evil",
                            Name = "Google",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("29e02aef-3144-4f2a-ad19-4499a2732955"),
                            Country = "China",
                            Industry = "Internet",
                            Introduction = "Fubao Company",
                            Name = "Alipapa",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("3b4c5c92-cc8c-905b-3563-fdbe7bd466b2"),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Sells Everything",
                            Name = "Amazon",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("eb94cf6f-e050-4fa0-3cc4-4ad6f2156e04"),
                            Country = "USA",
                            Industry = "Aerospace",
                            Introduction = "High Tech company",
                            Name = "SpaceX",
                            Product = "Aircrafts"
                        });
                });

            modelBuilder.Entity("Routine.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2e996af1-654e-4a07-9d38-0e1b0a1ab8cc"),
                            CompanyId = new Guid("d502f792-b007-4262-823e-26abd4666dce"),
                            DateOfBirth = new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MSFT231",
                            FirstName = "Nick",
                            Gender = 1,
                            LastName = "Carton"
                        },
                        new
                        {
                            Id = new Guid("e0dae939-4275-4df9-95d5-317b72ae4526"),
                            CompanyId = new Guid("d502f792-b007-4262-823e-26abd4666dce"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MSFT235",
                            FirstName = "Vince",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("c83404ff-c8a4-45a9-8f89-ce727a70f080"),
                            CompanyId = new Guid("9babffca-c2aa-4ff6-a4ee-0a22682d239e"),
                            DateOfBirth = new DateTime(1991, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "Gole167",
                            FirstName = "Fred",
                            Gender = 1,
                            LastName = "Huang"
                        },
                        new
                        {
                            Id = new Guid("eedd02c5-46de-9dde-ec34-a44b2be1759a"),
                            CompanyId = new Guid("3b4c5c92-cc8c-905b-3563-fdbe7bd466b2"),
                            DateOfBirth = new DateTime(1982, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "Amazon17",
                            FirstName = "Lyn",
                            Gender = 2,
                            LastName = "Liu"
                        },
                        new
                        {
                            Id = new Guid("18bc9ce1-8a71-64cd-fdd6-4021b4becd0d"),
                            CompanyId = new Guid("eb94cf6f-e050-4fa0-3cc4-4ad6f2156e04"),
                            DateOfBirth = new DateTime(1978, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "SpaceX867",
                            FirstName = "George",
                            Gender = 2,
                            LastName = "Li"
                        });
                });

            modelBuilder.Entity("Routine.Entities.Employee", b =>
                {
                    b.HasOne("Routine.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Routine.Entities.Company", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}