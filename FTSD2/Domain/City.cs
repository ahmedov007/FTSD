using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class City
    {
        public City()
        {
            CapitalProjects = new HashSet<CapitalProject>();
        }

        public int Id { get; set; }
        public int RegionId { get; set; }
        public string? Name { get; set; }
        public string? ArabicName { get; set; }
        public bool? IsActive { get; set; }
        public bool? NoDelete { get; set; }

        public virtual ICollection<CapitalProject> CapitalProjects { get; set; }
    }
}
