using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WEBAPIPROJECT1.Models
{
    public partial class Jobs
    {
        public Jobs()
        {
            Employees = new HashSet<Employees>();
        }

        [Key]
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public int? MinSalary { get; set; }
        public int? MaxSalary { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
