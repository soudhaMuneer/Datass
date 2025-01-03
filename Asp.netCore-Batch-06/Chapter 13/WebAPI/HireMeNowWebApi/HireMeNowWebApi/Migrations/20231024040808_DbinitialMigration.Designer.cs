﻿// <auto-generated />
using System;
using HireMeNowWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HireMeNowWebApi.Migrations
{
    [DbContext(typeof(HireMeNowDbContext))]
    [Migration("20231024040808_DbinitialMigration")]
    partial class DbinitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HireMeNowWebApi.Models.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("JobId");

                    b.HasIndex("UserId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.Company", b =>
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

            modelBuilder.Entity("HireMeNowWebApi.Models.Experience", b =>
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

            modelBuilder.Entity("HireMeNowWebApi.Models.Interview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ApplicationId")
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

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("JobId");

                    b.HasIndex("JobseekerId");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.Job", b =>
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

            modelBuilder.Entity("HireMeNowWebApi.Models.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FromUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MessageGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("To")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ToUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MessageGroupId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.MessageGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsNewMessages")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("newCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MessageGroups");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.Qualification", b =>
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

            modelBuilder.Entity("HireMeNowWebApi.Models.Skill", b =>
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

            modelBuilder.Entity("HireMeNowWebApi.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConnectionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("OnlineStatus")
                        .HasColumnType("bit");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MessageGroupUser", b =>
                {
                    b.Property<Guid>("MessageGroupsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MessageGroupsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("MessageGroupUser");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.Application", b =>
                {
                    b.HasOne("HireMeNowWebApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("HireMeNowWebApi.Models.Job", "Job")
                        .WithMany("Applications")
                        .HasForeignKey("JobId")
                        .HasConstraintName("FK__Applicati__JobId__33D4B598");

                    b.HasOne("HireMeNowWebApi.Models.User", "User")
                        .WithMany("Applications")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Applicati__UserI__32E0915F");

                    b.Navigation("Company");

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.Experience", b =>
                {
                    b.HasOne("HireMeNowWebApi.Models.User", "User")
                        .WithMany("Experiences")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.Interview", b =>
                {
                    b.HasOne("HireMeNowWebApi.Models.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId");

                    b.HasOne("HireMeNowWebApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("HireMeNowWebApi.Models.User", "CreatedUser")
                        .WithMany("InterviewCreatedByNavigations")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK__Interview__Creat__3D5E1FD2");

                    b.HasOne("HireMeNowWebApi.Models.Job", "Job")
                        .WithMany("Interviews")
                        .HasForeignKey("JobId")
                        .HasConstraintName("FK__Interview__JobId__3B75D760");

                    b.HasOne("HireMeNowWebApi.Models.User", "Jobseeker")
                        .WithMany("InterviewJobseekers")
                        .HasForeignKey("JobseekerId")
                        .HasConstraintName("FK__Interview__Jobse__3C69FB99");

                    b.Navigation("Application");

                    b.Navigation("Company");

                    b.Navigation("CreatedUser");

                    b.Navigation("Job");

                    b.Navigation("Jobseeker");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.Job", b =>
                {
                    b.HasOne("HireMeNowWebApi.Models.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK__Jobs__CompanyId__2E1BDC42");

                    b.HasOne("HireMeNowWebApi.Models.User", "CreatedUser")
                        .WithMany("Jobs")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK__Jobs__CreatedBy__2F10007B");

                    b.Navigation("Company");

                    b.Navigation("CreatedUser");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.Message", b =>
                {
                    b.HasOne("HireMeNowWebApi.Models.MessageGroup", "MessageGroup")
                        .WithMany("Messages")
                        .HasForeignKey("MessageGroupId");

                    b.Navigation("MessageGroup");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.Qualification", b =>
                {
                    b.HasOne("HireMeNowWebApi.Models.User", "User")
                        .WithMany("Qualifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Qualifica__UserI__412EB0B6");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.Skill", b =>
                {
                    b.HasOne("HireMeNowWebApi.Models.User", "User")
                        .WithMany("Skills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Skills__UserId__44FF419A");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.User", b =>
                {
                    b.HasOne("HireMeNowWebApi.Models.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK__Users__CreatedDa__2A4B4B5E");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("MessageGroupUser", b =>
                {
                    b.HasOne("HireMeNowWebApi.Models.MessageGroup", null)
                        .WithMany()
                        .HasForeignKey("MessageGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HireMeNowWebApi.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.Company", b =>
                {
                    b.Navigation("Jobs");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.Job", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("Interviews");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.MessageGroup", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("HireMeNowWebApi.Models.User", b =>
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
