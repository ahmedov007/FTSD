using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class Employee
    {
        public Employee()
        {
            OpertionalContractNotes = new HashSet<OpertionalContractNote>();
        }

        public Guid Id { get; set; }
        public string? Username { get; set; }
        public string? Name { get; set; }
        public string? ArabicName { get; set; }
        public string? Email { get; set; }
        public Guid? JobTitleId { get; set; }

        public virtual JobTitle? JobTitle { get; set; }
        public virtual ICollection<OpertionalContractNote> OpertionalContractNotes { get; set; }
    }
}
