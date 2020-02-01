using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class DeductionType : BaseModelClass
    {
        public int Id { get; set; }
        //Normally Statutory or Loan
        [StringLength(50)]
        [Required]
        public string Description { get; set; }
        //Statutory deductions are mandatory
        public bool Mandatory { get; set; }
    }
}
