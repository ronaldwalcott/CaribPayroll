using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class DeductionCalculationType : BaseModelClass
    {
//Calculation types are predetermined and will be either fixed(F), percent(P), range(R), scale(S) or reducing balance(B)
//calculate pay will use these values to determine which deduction calculation to execute
        public int Id { get; set; }
        [StringLength(1)]
        [Required]
        public string CalculationType { get; set; }
        [StringLength(25)]
        [Required]
        public string Description { get; set; }
    }
}
