using System;
using System.ComponentModel.DataAnnotations;

namespace CaribPayroll.Models
{
    public class BaseModelClass
    {
        [StringLength(1)]
        public string Action { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
        [Timestamp]
        public byte[] TimeStamp { get; set; }
    }
}
