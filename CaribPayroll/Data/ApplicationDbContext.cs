using System;
using System.Collections.Generic;
using System.Text;
using CaribPayroll.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CaribPayroll.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<DeductionCalculationType> DeductionCalculationTypes { get; set; }
        public DbSet<DeductionDescription> DeductionDescriptions { get; set; }
        public DbSet<DeductionType> DeductionTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<EarningDescription> EarningDescriptions { get; set; }
        public DbSet<EarningType> EarningTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<EmployeeDeduction> EmployeeDeductions { get; set; }
        public DbSet<EmployeeDeductionReferenceNo> EmployeeDeductionReferenceNos { get; set; }
        public DbSet<EmployeeEarning> EmployeeEarnings { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Parish> Parishes { get; set; }
        public DbSet<PaymentPeriod> PaymentPeriods { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bank>().ToTable("Bank");
            modelBuilder.Entity<DeductionCalculationType>().ToTable("DeductionCalculationType");
            modelBuilder.Entity<DeductionDescription>().ToTable("DeductionDescription");
            modelBuilder.Entity<DeductionType>().ToTable("DeductionType");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<District>().ToTable("District");
            modelBuilder.Entity<EarningDescription>().ToTable("EarningDescription");
            modelBuilder.Entity<EarningType>().ToTable("EarningType");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<EmployeeAddress>().ToTable("EmployeeAddress");
            modelBuilder.Entity<EmployeeDeduction>().ToTable("EmployeeDeduction");
            modelBuilder.Entity<EmployeeDeductionReferenceNo>().ToTable("EmployeeDeductionReferenceNo");
            modelBuilder.Entity<EmployeeEarning>().ToTable("EmployeeEarning");
            modelBuilder.Entity<Job>().ToTable("Job");
            modelBuilder.Entity<Parish>().ToTable("Parish");
            modelBuilder.Entity<PaymentPeriod>().ToTable("PaymentPeriod");

            modelBuilder.Entity<Bank>()
              .HasIndex(t => t.Description)
              .IsUnique();

            modelBuilder.Entity<DeductionCalculationType>()
              .HasIndex(t => t.CalculationType)
              .IsUnique();

            modelBuilder.Entity<Department>()
              .HasIndex(t => t.Description)
              .IsUnique();

            modelBuilder.Entity<DeductionDescription>()
              .HasIndex(t => t.Description)
              .IsUnique();

            modelBuilder.Entity<DeductionType>()
              .HasIndex(t => t.Description)
              .IsUnique();

            modelBuilder.Entity<District>()
              .HasIndex(t => t.Description)
              .IsUnique();

            modelBuilder.Entity<Department>()
              .HasIndex(t => t.Description)
              .IsUnique();

            modelBuilder.Entity<EarningDescription>()
              .HasIndex(t => t.Description)
              .IsUnique();

            modelBuilder.Entity<EarningType>()
              .HasIndex(t => t.Description)
              .IsUnique();

            modelBuilder.Entity<Employee>()
              .HasIndex(t => new { t.Surname, t.FirstName, t.MiddleName})
              .IsUnique();

            modelBuilder.Entity<Employee>()
                .HasOne(a => a.EmployeeAddress)
                .WithOne(e => e.Employee);

            modelBuilder.Entity<Employee>()
                .HasMany(d => d.EmployeeDeductionReferenceNos)
                .WithOne(e => e.Employee);

            modelBuilder.Entity<Employee>()
                .HasMany(d => d.EmployeeEarnings)
                .WithOne(e => e.Employee);

            modelBuilder.Entity<Employee>()
                .HasMany(d => d.EmployeeDeductions)
                .WithOne(e => e.Employee);

            modelBuilder.Entity<Job>()
              .HasIndex(t => t.Description)
              .IsUnique();

            modelBuilder.Entity<Parish>()
              .HasIndex(t => t.Description)
              .IsUnique();

            modelBuilder.Entity<PaymentPeriod>()
              .HasIndex(t => t.Description)
              .IsUnique();

            modelBuilder.Seed();
        }

    }
}
