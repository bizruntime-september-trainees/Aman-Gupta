using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVCPROJECTDEMO4.Models
{
    public partial class BizRunTimeEmployeeContext : DbContext //     Initializes a new instance of the Microsoft.EntityFrameworkCore.DbContext class
                                                               //     using the specified options. The Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)
                                                               //     method will still be called to allow further configuration of the options.
    {
        public BizRunTimeEmployeeContext()
        {
        }

        public BizRunTimeEmployeeContext(DbContextOptions<BizRunTimeEmployeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeeTable> EmployeeTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=BizRunTimeEmployee;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeTable>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeProfile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Employeelevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
