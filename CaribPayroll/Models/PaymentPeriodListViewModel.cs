using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class PaymentPeriodListViewModel
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Description { get; set; }
        //one letter codes M-Monthly W-Weekly (hardcoded?)
        [StringLength(1)]
        [Required]
        public string PaymentCode { get; set; }
    }
}
