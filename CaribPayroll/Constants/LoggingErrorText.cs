using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Constants
{
    public class LoggingErrorText
    {
        public const string recordAlreadyDefined = "This record is probably already defined, please try again";
        public const string errorWithValues = "There is an error with these values";
        public const string recordChanged = "Record has been changed since it was retrieved for editing, please retrieve the new record for editing";
        public const string newRoleSucceed = "New role created with role name {RoleName} by {username}";
        public const string newRoleFailed = "Errors generated trying to add role name {RoleName} by {username} {generatedErrors}";
        public const string editRoleSucceed = "Role name changed from {OldRoleName} to {NewRoleName} by {username}";
        public const string editRoleFailed = "Errors generated trying to change role name from {OldRoleName} to {NewRoleName} by {username} {generatedErrors}";
        public const string deleteRoleSucceed = "Role name {RoleName} deleted by {username}";
        public const string deleteRoleFailed = "Errors generated trying to delete role name {RoleName} by {username} {generatedErrors}";
    }
}
