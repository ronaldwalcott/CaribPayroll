﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Areas.UserManagement.Models
{
    public class UserRolesViewModel
    {
        public string Id { get; set; }
        public string RoleName { get; set; }
        public Boolean HasRole { get; set; }
        
    }
}
