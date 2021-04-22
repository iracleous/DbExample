using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DbExample.Models
{
    public partial class NbgCompanyContext : DbContext
    {
        public NbgCompanyContext()
        {
        }

        public NbgCompanyContext(DbContextOptions<NbgCompanyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectEmployee> ProjectEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=nbgCompany;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => e.Username, "username_unique")
                    .IsUnique();

                entity.Property(e => e.Balance)
                    .HasColumnType("money")
                    .HasColumnName("balance");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.HiringDate)
                    .HasColumnType("date")
                    .HasColumnName("hiringDate");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registrationDate");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Employee__depart__276EDEB3");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("project");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.ProjectTitle)
                    .HasMaxLength(50)
                    .HasColumnName("projectTitle");
            });

            modelBuilder.Entity<ProjectEmployee>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.EmployeeId })
                    .HasName("PK__projectE__1DE201390645C05C");

                entity.ToTable("projectEmployee");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.StartingDate)
                    .HasColumnType("date")
                    .HasColumnName("startingDate");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ProjectEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__projectEm__emplo__398D8EEE");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectEmployees)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__projectEm__proje__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
