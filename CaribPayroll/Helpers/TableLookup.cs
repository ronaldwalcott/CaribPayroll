using CaribPayroll.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Helpers
{
    public class TableLookup
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger _logger;

        public TableLookup(ApplicationDbContext context, UserManager<ApplicationUser> userManager, ILogger<TableLookup> logger)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
        }

        public class DescriptionLookup
        {
            public int Id { get; set; }
            public string Description { get; set; }
        }

        public List<DescriptionLookup> GetDeductionTypes()
        {
            var genericList = _context.DeductionTypes.Select(c => new DescriptionLookup { Id = c.Id, Description = c.Description }).ToList();
            return genericList;
        }

        public List<DescriptionLookup> GetDeductionCalculationTypes()
        {
            var genericList = _context.DeductionCalculationTypes.Select(c => new DescriptionLookup { Id = c.Id, Description = c.Description }).ToList();
            return genericList;
        }

        public List<DescriptionLookup> GetEarningTypes()
        {
            var genericList = _context.EarningTypes.Select(c => new DescriptionLookup { Id = c.Id, Description = c.Description }).ToList();
            return genericList;
        }

        public List<DescriptionLookup> GetPaymentPeriods()
        {
            var genericList = _context.PaymentPeriods.Select(c => new DescriptionLookup { Id = c.Id, Description = c.Description }).ToList();
            return genericList;
        }

        public List<DescriptionLookup> GetDepartments()
        {
            var genericList = _context.Departments.Select(c => new DescriptionLookup { Id = c.Id, Description = c.Description }).ToList();
            return genericList;
        }

        public List<DescriptionLookup> GetParishes()
        {
            var genericList = _context.Parishes.Select(c => new DescriptionLookup { Id = c.Id, Description = c.Description }).ToList();
            return genericList;
        }

        public List<DescriptionLookup> GetDistricts()
        {
            var genericList = _context.Districts .Select(c => new DescriptionLookup { Id = c.Id, Description = c.Description }).ToList();
            return genericList;
        }


    }
}
