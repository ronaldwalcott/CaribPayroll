using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class EmployeeEarningListViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? EarningDescriptionId { get; set; }
        public int? JobId { get; set; }
        public double EarningAmount { get; set; }
        public DateTime? DateStartEffective { get; set; }
        public DateTime? DateEndEffective { get; set; }
        public bool Active { get; set; }
        public int? EmployeeId { get; set; }
    }
}
