using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class CompanyContact
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? NameArabic { get; set; }
        public Guid? CompanyId { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? OtherTitle { get; set; }
        public Guid? JobTitleId { get; set; }
        public bool? IsActive { get; set; }
        public bool? NoDelete { get; set; }

        public virtual JobTitle? JobTitle { get; set; }
    }
}
