﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Constants
{
    public static class ClaimNames
    {
        public static List<string> ClaimName = new List<string>() {
            PolicyNames.ManageUsersPolicy,
            PolicyNames.ManageRolesPolicy
        };
    }
}
