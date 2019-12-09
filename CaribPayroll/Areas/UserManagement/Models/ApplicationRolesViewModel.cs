using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Areas.UserManagement.Models
{
    public class ApplicationRolesViewModel
    {
        public string Id { get; set; }
        [Display(Name = "Role Name")]
        [Required]
        public string RoleName { get; set; }
    }
}
