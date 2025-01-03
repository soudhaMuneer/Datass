using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RZWorkshop.Models;

public partial class RzworkshopContext : DbContext
{
    public RzworkshopContext()
    {
    }

    public RzworkshopContext(DbContextOptions<RzworkshopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Applicationss> Applicationsses { get; set; }

    public virtual DbSet<Companiess> Companiesses { get; set; }

    public virtual DbSet<Interviewss> Interviewsses { get; set; }

    public virtual DbSet<Jobss> Jobsses { get; set; }

    public virtual DbSet<Qualificationss> Qualificationsses { get; set; }

    public virtual DbSet<Skillss> Skillsses { get; set; }

    public virtual DbSet<Userss> Usersses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-A4LFVAT;Initial Catalog=RZWorkshop;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Applicationss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Applicat__3214EC0705D1711A");

            entity.ToTable("Applicationss");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Company).WithMany(p => p.Applicationsses)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__Applicati__Compa__5535A963");

            entity.HasOne(d => d.Job).WithMany(p => p.Applicationsses)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__Applicati__JobId__5441852A");

            entity.HasOne(d => d.User).WithMany(p => p.Applicationsses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Applicati__UserI__534D60F1");
        });

        modelBuilder.Entity<Companiess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Companie__3214EC07EEE79222");

            entity.ToTable("Companiess");

            entity.HasIndex(e => e.Email, "UQ__Companie__A9D1053414051C5B").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.About)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Logo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mission)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vision)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

       
        modelBuilder.Entity<Interviewss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Intervie__3214EC072343C18C");

            entity.ToTable("Interviewss");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Company).WithMany(p => p.Interviewsses)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__Interview__Compa__5812160E");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.InterviewssCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Interview__Creat__5AEE82B9");

            entity.HasOne(d => d.Job).WithMany(p => p.Interviewsses)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__Interview__JobId__59063A47");

            entity.HasOne(d => d.JobSeeker).WithMany(p => p.InterviewssJobSeekers)
                .HasForeignKey(d => d.JobSeekerId)
                .HasConstraintName("FK__Interview__JobSe__59FA5E80");
        });

        

        modelBuilder.Entity<Jobss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Jobss__3214EC07ABAB8EBC");

            entity.ToTable("Jobss");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Experience)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JobType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Responsibilities)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Salary)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfWorkPlace)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VacanciesCount)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Company).WithMany(p => p.Jobsses)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__Jobss__CompanyId__4F7CD00D");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Jobsses)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Jobss__CreatedBy__5070F446");
        });

        modelBuilder.Entity<Qualificationss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Qualific__3214EC07B75176C5");

            entity.ToTable("Qualificationss");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Mark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.University)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.YearOfPassout)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.Qualificationsses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Qualifica__UserI__5DCAEF64");
        });

        modelBuilder.Entity<Skillss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Skillss__3214EC0771CDC5D8");

            entity.ToTable("Skillss");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.Skillsses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Skillss__UserId__60A75C0F");
        });

        

        

        modelBuilder.Entity<Userss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Userss__3214EC077DA6D951");

            entity.ToTable("Userss");

            entity.HasIndex(e => e.Email, "UQ__Userss__A9D10534B3DA71A3").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.About)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Image)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Company).WithMany(p => p.Usersses)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__Userss__CompanyI__4CA06362");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
