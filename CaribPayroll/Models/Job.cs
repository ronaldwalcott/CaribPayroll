using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class Job : BaseModelClass
    {
        public int Id { get; set; }
        //normally regular or overtime
        [StringLength(1)]
        [Required]
        public string JobType { get; set; }
        [StringLength(25)]
        [Required]
        public string Description { get; set; }
    }
}
