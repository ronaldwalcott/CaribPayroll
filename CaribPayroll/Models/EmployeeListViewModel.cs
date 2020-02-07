using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class EmployeeListViewModel
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
        public int? PaymentPeriodId { get; set; }
        public int? EmployeeAddressId { get; set; }
        public int? DepartmentId { get; set; }

    }
}
