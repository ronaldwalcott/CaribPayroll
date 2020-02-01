using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class EarningType : BaseModelClass
    {
        public int Id { get; set; }
        //Adhoc, Overtime, Salary, Wages
        [StringLength(25)]
        [Required]
        public string Description { get; set; }
        //Fixed, Activity – Only these two types can exist
        [StringLength(15)]
        [Required]
        public string ActivityType { get; set; }
    }
}
