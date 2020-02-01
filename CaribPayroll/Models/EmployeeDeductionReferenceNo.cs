using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class EmployeeDeductionReferenceNo : BaseModelClass
    {
        public int Id { get; set; }
        public int DeductionDescriptionId { get; set; }
        [ForeignKey("DeductionDescriptionId")]
        public DeductionDescription DeductionDescription { get; set; }
        [StringLength(25)]
        [Required]
        public string DeductionReferenceNo { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
