﻿using System;
using System.Collections.Generic;

namespace WEBAPIPROJECT1.Models
{
    public partial class Locations
    {
        public Locations()
        {
            Departments = new HashSet<Departments>();
        }

        public int LocationId { get; set; }
        public string StreetAddress { get; set; }
        public int? PostelCode { get; set; }
        public string City { get; set; }

        public virtual ICollection<Departments> Departments { get; set; }
    }
}
