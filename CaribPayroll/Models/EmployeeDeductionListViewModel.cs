using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class EmployeeDeductionListViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int DeductionDescriptionId { get; set; }
        public double DeductionAmount { get; set; }
        public double DeductionBalance { get; set; }
        public DateTime? DateStartEffective { get; set; }
        public DateTime? DateEndEffective { get; set; }
        public int? BankId { get; set; }
        public string BranchCode { get; set; }
        public string BankAccountNo { get; set; }
        //indicates if this is the active deduction record easier to filter on than using date start and end effective
        public bool Active { get; set; }
        public int? EmployeeId { get; set; }
    }
}
