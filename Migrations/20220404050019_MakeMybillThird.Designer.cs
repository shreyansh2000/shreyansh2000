﻿// <auto-generated />
using System;
using MakeMyBill.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MakeMyBill.Migrations
{
    [DbContext(typeof(InvoGenDbContext))]
    [Migration("20220404050019_MakeMybillThird")]
    partial class MakeMybillThird
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MakeMyBill.Models.BranchMaster", b =>
                {
                    b.Property<int>("Branchid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Branchid"), 1L, 1);

                    b.Property<string>("Baddress")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Banswer")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Barea")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Bcity")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Bemail")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Bname")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Bpassword")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Bphone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Bqid")
                        .HasColumnType("int");

                    b.Property<int>("Companyid")
                        .HasColumnType("int");

                    b.HasKey("Branchid");

                    b.ToTable("BranchMasters");
                });

            modelBuilder.Entity("MakeMyBill.Models.CompanyMaster", b =>
                {
                    b.Property<int>("Companyid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Companyid"), 1L, 1);

                    b.Property<string>("Caddress")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Canswer")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ccity")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cemail")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cname")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cpassword")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cphone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Cqid")
                        .HasColumnType("int");

                    b.Property<int>("Crollid")
                        .HasColumnType("int");

                    b.HasKey("Companyid");

                    b.ToTable("CompanyMasters");
                });

            modelBuilder.Entity("MakeMyBill.Models.ComplainMaster", b =>
                {
                    b.Property<int>("Complainid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Complainid"), 1L, 1);

                    b.Property<string>("Cdetails")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Companyid")
                        .HasColumnType("int");

                    b.HasKey("Complainid");

                    b.ToTable("ComplainMasters");
                });

            modelBuilder.Entity("MakeMyBill.Models.CustomerMaster", b =>
                {
                    b.Property<int>("Customerid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Customerid"), 1L, 1);

                    b.Property<int>("Branchid")
                        .HasColumnType("int");

                    b.Property<string>("Customeraddress")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Customeremail")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Customername")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Customerphone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Customerid");

                    b.ToTable("CustomerMasters");
                });

            modelBuilder.Entity("MakeMyBill.Models.FeedbackMaster", b =>
                {
                    b.Property<int>("Fid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Fid"), 1L, 1);

                    b.Property<int>("Companyid")
                        .HasColumnType("int");

                    b.Property<string>("Experiencerate")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("Fdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fdetails")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Fid");

                    b.ToTable("FeedbackMasters");
                });

            modelBuilder.Entity("MakeMyBill.Models.ProductMainCategoryMaster", b =>
                {
                    b.Property<int>("Catid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Catid"), 1L, 1);

                    b.Property<string>("Catimage")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Catname")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Catid");

                    b.ToTable("ProudctMainCategoryMasters");
                });

            modelBuilder.Entity("MakeMyBill.Models.ProductSubCategoryMaster", b =>
                {
                    b.Property<int>("Scid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Scid"), 1L, 1);

                    b.Property<int>("Catid")
                        .HasColumnType("int");

                    b.Property<string>("Scdesc")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Scimage")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Scname")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Scpriceperunit")
                        .HasColumnType("int");

                    b.HasKey("Scid");

                    b.ToTable("ProductSubCategoryMasters");
                });

            modelBuilder.Entity("MakeMyBill.Models.QuestionMaster", b =>
                {
                    b.Property<int>("Qid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Qid"), 1L, 1);

                    b.Property<string>("Questiontext")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Qid");

                    b.ToTable("QuestionMasters");
                });
#pragma warning restore 612, 618
        }
    }
}
