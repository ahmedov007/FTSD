using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class JobTitle
    {
        public JobTitle()
        {
            CompanyContacts = new HashSet<CompanyContact>();
            Employees = new HashSet<Employee>();
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? NameArabic { get; set; }
        public bool? IsActive { get; set; }
        public bool? NoDelete { get; set; }

        public virtual ICollection<CompanyContact> CompanyContacts { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
