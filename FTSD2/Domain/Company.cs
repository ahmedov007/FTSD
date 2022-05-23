using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class Company
    {
        public Company()
        {
            ActiveContracts = new HashSet<ActiveContract>();
            NewContracts = new HashSet<NewContract>();
        }

        public Guid Id { get; set; }
        public string? Sapno { get; set; }
        public string? Name { get; set; }
        public string? NameArabic { get; set; }
        public int? CityId { get; set; }
        public string? Logo { get; set; }
        public string? Phone { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? NoDelete { get; set; }

        public virtual ICollection<ActiveContract> ActiveContracts { get; set; }
        public virtual ICollection<NewContract> NewContracts { get; set; }
    }
}
