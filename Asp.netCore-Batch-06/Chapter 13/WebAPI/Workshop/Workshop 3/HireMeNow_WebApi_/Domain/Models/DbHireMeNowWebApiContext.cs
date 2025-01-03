﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public partial class DbHireMeNowWebApiContext : DbContext
{
    public DbHireMeNowWebApiContext()
    {
    }

    public DbHireMeNowWebApiContext(DbContextOptions<DbHireMeNowWebApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuthUser> AuthUsers { get; set; }
    public virtual DbSet<SignUpRequest> SignUpRequests { get; set; }

    public virtual DbSet<CompanyUser> CompanyUsers { get; set; }

    public virtual DbSet<Industry> Industries { get; set; }

    public virtual DbSet<JobCategory> JobCategories { get; set; }

    public virtual DbSet<JobPost> JobPosts { get; set; }

    public virtual DbSet<JobProviderCompany> JobProviderCompanies { get; set; }

    public virtual DbSet<JobResponsibility> JobResponsibilities { get; set; }

    public virtual DbSet<JobSeeker> JobSeekers { get; set; }

    public virtual DbSet<JobSeekerProfile> JobSeekerProfiles { get; set; }

    public virtual DbSet<Location> Locations { get; set; }


    public virtual DbSet<JobApplication> JobApplications { get; set; }

    public virtual DbSet<Qualification> Qualifications { get; set; }

    public virtual DbSet<Resume> Resumes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }
	public virtual DbSet<SavedJob> SavedJobs { get; set; }
	public virtual DbSet<Interview> Interviews { get; set; }


	//public virtual DbSet<SystemUser> SystemUsers { get; set; }

	public virtual DbSet<WorkExperience> WorkExperiences { get; set; }

    public virtual DbSet<Message> Messages { get; set; }
    public virtual DbSet<MessageGroup> MessageGroups { get; set; }
    public virtual DbSet<GroupMember> GroupMember { get; set; }
   


    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<AuthUser>(entity =>
        //{
        //    entity.ToTable("AuthUser");

        //    entity.Property(e => e.Id).ValueGeneratedNever();

        //    entity.HasOne(d => d.IdNavigation).WithOne(p => p.AuthUserIdNavigation).HasForeignKey<AuthUser>(d => d.Id);

        //    entity.HasOne(d => d.SystemUser).WithMany(p => p.AuthUserSystemUsers)
        //        .HasForeignKey(d => d.SystemUserId)
        //        .OnDelete(DeleteBehavior.ClientSetNull);
        //});

        modelBuilder.Entity<CompanyUser>(entity =>
        {
            entity.ToTable("CompanyUser");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CompanyNavigation).WithMany(p => p.CompanyUsers)
                .HasForeignKey(d => d.Company)
                .HasConstraintName("FK_CompanyUser_JobProviderCompany");
        });

        modelBuilder.Entity<Industry>(entity =>
        {
            entity.ToTable("Industry");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JobCategory>(entity =>
        {
            entity
               
                .ToTable("JobCategory");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JobPost>(entity =>
        {
            entity.ToTable("JobPost");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.JobSummary).HasMaxLength(50);
            entity.Property(e => e.JobTitle)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PostedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Location).WithMany(p => p.JobPosts)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobPost_Location");

            entity.HasOne(d => d.PostedByNavigation).WithMany(p => p.JobPosts)
                .HasForeignKey(d => d.PostedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobPost_Industry");
        });

        modelBuilder.Entity<JobProviderCompany>(entity =>
        {
            entity.ToTable("JobProviderCompany");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LegalName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Summary)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.LocationNavigation).WithMany(p => p.JobProviderCompanies)
                .HasForeignKey(d => d.Location)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobProviderCompany_Location");
        });

        modelBuilder.Entity<JobResponsibility>(entity =>
        {
            entity.ToTable("JobResponsibility");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.JobPostNavigation).WithMany(p => p.JobResponsibilities)
                .HasForeignKey(d => d.JobPost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobResponsibility_JobPost");
        });

        //modelBuilder.Entity<JobSeeker>(entity =>
        //{
        //    entity.ToTable("JobSeeker");

        //    entity.Property(e => e.Id).ValueGeneratedNever();
        //    entity.Property(e => e.Email).HasMaxLength(450);

        //    entity.HasOne(d => d.IdNavigation).WithOne(p => p.JobSeeker).HasForeignKey<JobSeeker>(d => d.Id);
        //});

        modelBuilder.Entity<JobSeekerProfile>(entity =>
        {
            entity.ToTable("JobSeekerProfile");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Resume).WithMany(p => p.JobSeekerProfiles).HasForeignKey(d => d.ResumeId);

            //entity.HasMany(s=>s.Skills).WithMany(p => p.jo).HasForeignKey(d => d.ResumeId);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("Location");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Discription)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Qualification>(entity =>
        {
            entity.ToTable("Qualification");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.JobPost).WithMany()
                .HasForeignKey(d => d.JobPostId)
                .HasConstraintName("FK_Qualification_JobSeekerProfile");
        });

        modelBuilder.Entity<Resume>(entity =>
        {
            entity.ToTable("Resume");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Role");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.ToTable("Skill");

            entity.Property(e => e.Id);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            //entity.HasOne(d => d.JobPostNavigation).WithMany(p => p.Skills)
            //    .HasForeignKey(d => d.JobPost)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_Skill_JobSeekerProfile1");
        });

        //modelBuilder.Entity<SystemUser>(entity =>
        //{
        //    entity.ToTable("SystemUser");

        //    entity.Property(e => e.Id).ValueGeneratedNever();
        //    entity.Property(e => e.Email).HasMaxLength(450);
        //});

        modelBuilder.Entity<WorkExperience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Experiences");

            entity.ToTable("WorkExperience");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.JobSeekerProfile).WithMany(p => p.WorkExperiences)
                .HasForeignKey(d => d.JobSeekerProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkExperience_JobSeekerProfile");
        });


        modelBuilder.Entity<JobSeekerProfileSkill>()
       .HasKey(jps => new { jps.JobSeekerProfileId, jps.SkillId });

        modelBuilder.Entity<JobSeekerProfileSkill>()
            .HasOne(jps => jps.JobSeekerProfile)
            .WithMany(jp => jp.JobSeekerProfileSkills)
            .HasForeignKey(jps => jps.JobSeekerProfileId);

        //modelBuilder.Entity<JobSeekerProfileSkill>()
        //    .HasOne(jps => jps.Skill)
        //    .WithMany(s => s.JobSeekerProfileSkills)
        //    .HasForeignKey(jps => jps.SkillId);
   
        OnModelCreatingPartial(modelBuilder);

    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
