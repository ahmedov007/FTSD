using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class AthorityMatrix
    {
        public AthorityMatrix()
        {
            NewContracts = new HashSet<NewContract>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? ArabicName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<NewContract> NewContracts { get; set; }
    }
}
