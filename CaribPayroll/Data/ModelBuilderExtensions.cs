using CaribPayroll.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeductionCalculationType>().HasData(
                new DeductionCalculationType { Id = 1, CalculationType = "F", Description = "Fixed", Action = "A", CreatedDate = DateTimeOffset.Now, ModifiedDate = DateTimeOffset.Now },
                new DeductionCalculationType { Id = 2, CalculationType = "P", Description = "Fixed", Action = "A", CreatedDate = DateTimeOffset.Now, ModifiedDate = DateTimeOffset.Now },
                new DeductionCalculationType { Id = 3, CalculationType = "R", Description = "Range", Action = "A", CreatedDate = DateTimeOffset.Now, ModifiedDate = DateTimeOffset.Now },
                new DeductionCalculationType { Id = 4, CalculationType = "S", Description = "Scale", Action = "A", CreatedDate = DateTimeOffset.Now, ModifiedDate = DateTimeOffset.Now },
                new DeductionCalculationType { Id = 5, CalculationType = "B", Description = "Reducing Balance", Action = "A", CreatedDate = DateTimeOffset.Now, ModifiedDate = DateTimeOffset.Now }
            );

            modelBuilder.Entity<PaymentPeriod>().HasData(
                new PaymentPeriod { Id = 1, PaymentCode = "M", Description = "Monthly", Action = "A", CreatedDate = DateTimeOffset.Now, ModifiedDate = DateTimeOffset.Now },
                new PaymentPeriod { Id = 2, PaymentCode = "W", Description = "Weekly", Action = "A", CreatedDate = DateTimeOffset.Now, ModifiedDate = DateTimeOffset.Now }
            );

        }
    }
}
