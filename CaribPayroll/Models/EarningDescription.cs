using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class EarningDescription : BaseModelClass
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Description { get; set; }
        [StringLength(25)]
        public string GLCode { get; set; }
        public int EarningTypeId { get; set; }
        [ForeignKey("EarningTypeId")]
        public EarningType EarningType { get; set; }
    }
}
