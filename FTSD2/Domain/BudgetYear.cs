using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class BudgetYear
    {
        public BudgetYear()
        {
            CapitalProjects = new HashSet<CapitalProject>();
        }

        public Guid Id { get; set; }
        public int? YearName { get; set; }

        public virtual ICollection<CapitalProject> CapitalProjects { get; set; }
    }
}
