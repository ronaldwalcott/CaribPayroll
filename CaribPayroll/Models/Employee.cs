using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class Employee : BaseModelClass
    {
        public int Id { get; set; }
        [StringLength(25)]
        [Required]
        public string EmployeeNo { get; set; }
        [StringLength(100)]
        [Required]
        public string Surname { get; set; }
        [StringLength(100)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(100)]
        [Required]
        public string MiddleName { get; set; }
        [StringLength(25)]
        [Required]
        public string NationalRegistrationNo { get; set; }
        public int PaymentPeriodId { get; set; }
        [ForeignKey("PaymentPeriodId")]
        public PaymentPeriod PaymentPeriod { get; set; }
        public int EmployeeAddressId { get; set; }
        [ForeignKey("EmployeeAddressId")]
        public EmployeeAddress EmployeeAddress { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public ICollection<EmployeeDeductionReferenceNo> EmployeeDeductionReferenceNos { get; set; }
        public ICollection<EmployeeEarning> EmployeeEarnings { get; set; }
        public ICollection<EmployeeDeduction> EmployeeDeductions { get; set; }
    }
}
