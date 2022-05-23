using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class DucomentType
    {
        public DucomentType()
        {
            OpertionalContractNotes = new HashSet<OpertionalContractNote>();
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? ArabiceName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<OpertionalContractNote> OpertionalContractNotes { get; set; }
    }
}
