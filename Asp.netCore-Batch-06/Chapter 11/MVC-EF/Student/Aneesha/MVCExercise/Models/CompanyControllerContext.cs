using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVCExercise.Models;

public partial class CompanyControllerContext : DbContext
{
    public CompanyControllerContext()
    {
    }

    public CompanyControllerContext(DbContextOptions<CompanyControllerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyMember> CompanyMembers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-A4LFVAT;Initial Catalog=CompanyController;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__Company__3E267235353FA0D7");

            entity.ToTable("Company");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedNever()
                .HasColumnName("company_id");
            entity.Property(e => e.About)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("about");
            entity.Property(e => e.CompanyEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("company_email");
            entity.Property(e => e.CompanyLocation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("company_location");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("company_name");
            entity.Property(e => e.CompanyPhoneNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("company_phoneNumber");
            entity.Property(e => e.CompanyWebsite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("company_website");
            entity.Property(e => e.Vision)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vision");
        });

        modelBuilder.Entity<CompanyMember>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__Company___B29B853426BC3319");

            entity.ToTable("Company_Member");

            entity.Property(e => e.MemberId)
                .ValueGeneratedNever()
                .HasColumnName("member_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.ConfirmPassword)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("confirmPassword");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.MemberEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_email");
            entity.Property(e => e.MemberFirstName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_firstName");
            entity.Property(e => e.MemberLastName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_lastName");
            entity.Property(e => e.MemberPassword)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_password");
            entity.Property(e => e.MemberPhoneNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("member_phoneNumber");
            entity.Property(e => e.RegistrationDate).HasColumnName("registration_date");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyMembers)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__Company_M__compa__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
