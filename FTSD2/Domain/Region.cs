using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class Region
    {
        public Region()
        {
            ActiveContracts = new HashSet<ActiveContract>();
            CapitalProjects = new HashSet<CapitalProject>();
            NewContracts = new HashSet<NewContract>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ArabicName { get; set; }
        public bool? IsActive { get; set; }
        public bool? NoDelete { get; set; }

        public virtual ICollection<ActiveContract> ActiveContracts { get; set; }
        public virtual ICollection<CapitalProject> CapitalProjects { get; set; }
        public virtual ICollection<NewContract> NewContracts { get; set; }
    }
}
