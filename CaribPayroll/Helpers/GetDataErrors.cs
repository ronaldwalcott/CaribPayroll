using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Helpers
{
    public static class GetDataErrors
    {
        public static string GetErrors(IdentityResult result)
        {
            string errorDescription = "";
            foreach (var error in result.Errors)
            {
                errorDescription = errorDescription + " " + error.Description;
            }
            return errorDescription;
        }
    }
}
