using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ORMActivityDatabasefirst2.Models;

public partial class SchoolDb2Context : DbContext
{
    public SchoolDb2Context()
    {
    }

    public SchoolDb2Context(DbContextOptions<SchoolDb2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=PAVILIONGAMING;Initial Catalog=SchoolDB2;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.Gradeid).HasName("PK__Grades__54E15E7F66A3E2FF");

            entity.Property(e => e.Gradeid).ValueGeneratedNever();
            entity.Property(e => e.Gradename)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Studentid).HasName("PK__Student__32CE55B10E8F7A58");

            entity.ToTable("Student");

            entity.Property(e => e.Studentid).ValueGeneratedNever();
            entity.Property(e => e.Firstname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Lastname)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Grade).WithMany(p => p.Students)
                .HasForeignKey(d => d.Gradeid)
                .HasConstraintName("FK__Student__Gradeid__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
