using System;
using System.Collections.Generic;

namespace WEBAPIPROJECT1.Models
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? PhoneNumber { get; set; }
        public DateTime? HireDate { get; set; }
        public int? Salary { get; set; }
        public int? JobId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Departments Department { get; set; }
        public virtual Jobs Job { get; set; }
    }
}
