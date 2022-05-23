using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class NewContractAction
    {
        public NewContractAction()
        {
            NewContracts = new HashSet<NewContract>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ArabicName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<NewContract> NewContracts { get; set; }
    }
}
