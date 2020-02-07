using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class EmployeeDeduction
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Description { get; set; }
        public int DeductionDescriptionId { get; set; }
        [ForeignKey("DeductionDescriptionId")]
        public DeductionDescription DeductionDescription { get; set; }
        public double DeductionAmount { get; set; }
        public double DeductionBalance { get; set; }
        public DateTime? DateStartEffective { get; set; }
        public DateTime? DateEndEffective { get; set; }
        public int? BankId { get; set; }
        [ForeignKey("BankId")]
        public Bank Bank { get; set; }
        [StringLength(25)]
        [Required]
        public string BranchCode { get; set; }
        [StringLength(25)]
        [Required]
        public string BankAccountNo { get; set; }
        //indicates if this is the active deduction record easier to filter on than using date start and end effective
        public bool Active { get; set; }
        public int? EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
