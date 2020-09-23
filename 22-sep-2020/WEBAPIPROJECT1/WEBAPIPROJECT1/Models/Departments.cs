using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WEBAPIPROJECT1.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Employees = new HashSet<Employees>();
        }

       [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? LocationId { get; set; }

        public virtual Locations Location { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
    }
}
