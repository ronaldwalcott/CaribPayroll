using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class EmployeeEarning : BaseModelClass
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int EarningDescriptionId { get; set; }
        [ForeignKey("EarningDescriptionId")]
        public EarningDescription EarningDescription { get; set; }
        //indicates the regular or overtime hourly rate
        public int JobId { get; set; }
        [ForeignKey("JobId")]
        public Job Job { get; set; }
        public double EarningAmount { get; set; }
        public DateTime? DateStartEffective { get; set; }
        public DateTime? DateEndEffective { get; set; }
        //indicates if this is the active earning record easier to filter on than using date start and end effective
        public bool Active { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
