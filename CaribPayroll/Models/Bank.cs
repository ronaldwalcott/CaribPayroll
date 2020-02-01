using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class Bank : BaseModelClass
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Description { get; set; }
    }
}
