using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Models
{
    public class EmployeeAddress : BaseModelClass
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string AddressLine1 { get; set; }
        [StringLength(100)]
        [Required]
        public string AddressLine2 { get; set; }
        public int ParishId { get; set; }
        [ForeignKey("ParishId")]
        public Parish Parish { get; set; }
        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public District District { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
