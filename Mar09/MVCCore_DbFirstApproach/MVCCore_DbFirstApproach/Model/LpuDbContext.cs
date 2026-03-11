using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVCCore_DbFirstApproach.Model;

public partial class LpuDbContext : DbContext
{
    public LpuDbContext()
    {
    }

    public LpuDbContext(DbContextOptions<LpuDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Person1> People1 { get; set; }

    public virtual DbSet<StudentInfo> StudentInfos { get; set; }

    public virtual DbSet<StudentMark> StudentMarks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;Trusted_Connection=True;Database=Lpu_Db;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Person");

            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Person1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Person__3214EC071971D104");

            entity.ToTable("Person", "PankajBatch");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StudentInfo>(entity =>
        {
            entity.HasKey(e => e.RollNo).HasName("PK__StudentI__7886D5A061618665");

            entity.ToTable("StudentInfo");

            entity.Property(e => e.RollNo).ValueGeneratedNever();
            entity.Property(e => e.LocalAddr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PerAddr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNum)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SchoolName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("RKVM");
        });

        modelBuilder.Entity<StudentMark>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Perc).HasComputedColumnSql("((([Physics]+[Chem])+[Maths])/(3))", false);
            entity.Property(e => e.SrNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("srNo");
            entity.Property(e => e.TotalMarks).HasComputedColumnSql("(([Physics]+[Chem])+[Maths])", false);

            entity.HasOne(d => d.RollNoNavigation).WithMany()
                .HasForeignKey(d => d.RollNo)
                .HasConstraintName("FK_StudentMarks_StudentInfo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
