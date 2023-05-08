using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Prace;

public partial class SystemPracContext : DbContext
{
    public SystemPracContext()
    {
    }

    public SystemPracContext(DbContextOptions<SystemPracContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Konsultacje> Konsultacjes { get; set; }

    public virtual DbSet<PracaStudentum> PracaStudenta { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Temat> Temats { get; set; }

    public virtual DbSet<WersjaPracy> WersjaPracies { get; set; }

    public virtual DbSet<Wykladowca> Wykladowcas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-B8Q5ABQ;Database=System_Prac;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Konsultacje>(entity =>
        {
            entity.HasKey(e => e.IdKonsultacji);

            entity.HasOne(d => d.IdPracystudNavigation).WithMany(p => p.Konsultacjes)
                .HasForeignKey(d => d.IdPracystud);
        });

        modelBuilder.Entity<PracaStudentum>(entity =>
        {
            entity.HasKey(e => e.IdPracystud);


            entity.HasOne(d => d.IdStudentaNavigation).WithMany(p => p.PracaStudenta)
                .HasForeignKey(d => d.IdStudenta);



            entity.HasOne(d => d.IdTematuNavigation).WithMany(p => p.PracaStudenta)
                .HasForeignKey(d => d.IdTematu);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.IdStudenta);

        });

        modelBuilder.Entity<Temat>(entity =>
        {
            entity.HasKey(e => e.IdTematu);

            entity.HasOne(d => d.IdWykladowcyNavigation).WithMany(p => p.Temats)
                .HasForeignKey(d => d.IdWykladowcy);
        });

        modelBuilder.Entity<WersjaPracy>(entity =>
        {
            entity.HasKey(e => e.IdWersji);

            entity.HasOne(d => d.IdTematuNavigation).WithMany(p => p.WersjaPracies)
                .HasForeignKey(d => d.IdTematu);
        });

        modelBuilder.Entity<Wykladowca>(entity =>
        {
            entity.HasKey(e => e.IdWykladowcy)
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
