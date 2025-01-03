using System;
using System.Collections.Generic;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class EmpetzContext : DbContext
{
    public EmpetzContext()
    {
    }

    public EmpetzContext(DbContextOptions<EmpetzContext> options)
        : base(options)
    {
    }







    public virtual DbSet<PetsCategory> PetsCategories { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<User> Users { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     
 
 

        modelBuilder.Entity<PetsCategory>(entity =>
        {
            entity.ToTable("PetsCategory");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Profile");

            entity.Property(e => e.Discription).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Image).HasMaxLength(50);
            entity.Property(e => e.ProfileName).HasMaxLength(50);

            entity.HasOne(d => d.UserNavigation).WithMany()
                .HasForeignKey(d => d.User)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Profile_PublicUser");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

       

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
