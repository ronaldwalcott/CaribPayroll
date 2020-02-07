using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class DeductionDescription : BaseModelClass
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Description { get; set; }
        [StringLength(25)]
        public string GLCode { get; set; }
        public int? DeductionTypeId { get; set; }
        [ForeignKey("DeductionTypeId")]
        public DeductionType DeductionType { get; set; }
        public int? DeductionCalculationTypeId { get; set; }
        [ForeignKey("DeductionCalculationTypeId")]
        public DeductionCalculationType DeductionCalculationType { get; set; }
        public bool SubCategoriesExist { get; set; }
    }
}
