﻿// <auto-generated />
using System;
using BlazorworkShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorworkShop.Migrations
{
    [DbContext(typeof(HireMeNowDbContext))]
    [Migration("20240709071339_initials")]
    partial class initials
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorworkShop.Models.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AppliedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("JobId");

                    b.HasIndex("UserId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Mission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Experience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Interview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JobseekerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan?>("Time")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("JobId");

                    b.HasIndex("JobseekerId");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("AppliedCount")
                        .HasColumnType("int");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfWorkPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VacanciesCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Qualification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("University")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("YearOfPassout")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("BlazorworkShop.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Application", b =>
                {
                    b.HasOne("BlazorworkShop.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("BlazorworkShop.Models.Job", "Job")
                        .WithMany("Applications")
                        .HasForeignKey("JobId");

                    b.HasOne("BlazorworkShop.Models.User", "User")
                        .WithMany("Applications")
                        .HasForeignKey("UserId");

                    b.Navigation("Company");

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Experience", b =>
                {
                    b.HasOne("BlazorworkShop.Models.User", "User")
                        .WithMany("Experiences")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Interview", b =>
                {
                    b.HasOne("BlazorworkShop.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("BlazorworkShop.Models.User", "CreatedUser")
                        .WithMany("InterviewCreatedByNavigations")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("BlazorworkShop.Models.Job", "Job")
                        .WithMany("Interviews")
                        .HasForeignKey("JobId");

                    b.HasOne("BlazorworkShop.Models.User", "Jobseeker")
                        .WithMany("InterviewJobseekers")
                        .HasForeignKey("JobseekerId");

                    b.Navigation("Company");

                    b.Navigation("CreatedUser");

                    b.Navigation("Job");

                    b.Navigation("Jobseeker");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Job", b =>
                {
                    b.HasOne("BlazorworkShop.Models.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId");

                    b.HasOne("BlazorworkShop.Models.User", "CreatedUser")
                        .WithMany("Jobs")
                        .HasForeignKey("CreatedBy");

                    b.Navigation("Company");

                    b.Navigation("CreatedUser");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Qualification", b =>
                {
                    b.HasOne("BlazorworkShop.Models.User", "User")
                        .WithMany("Qualifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Skill", b =>
                {
                    b.HasOne("BlazorworkShop.Models.User", "User")
                        .WithMany("Skills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlazorworkShop.Models.User", b =>
                {
                    b.HasOne("BlazorworkShop.Models.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Company", b =>
                {
                    b.Navigation("Jobs");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BlazorworkShop.Models.Job", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("Interviews");
                });

            modelBuilder.Entity("BlazorworkShop.Models.User", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("Experiences");

                    b.Navigation("InterviewCreatedByNavigations");

                    b.Navigation("InterviewJobseekers");

                    b.Navigation("Jobs");

                    b.Navigation("Qualifications");

                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}