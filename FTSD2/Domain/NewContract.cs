using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class NewContract
    {
        public NewContract()
        {
            OpertionalContractNotes = new HashSet<OpertionalContractNote>();
        }

        public Guid Id { get; set; }
        public string ContractName { get; set; } = null!;
        public string? ArabicContractName { get; set; }
        public int RegionId { get; set; }
        public int ContractTypeId { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? WavierDate { get; set; }
        public DateTime? ContractRequestDate { get; set; }
        public DateTime? JobexDate { get; set; }
        public DateTime? OpenBidDate { get; set; }
        public DateTime? BidEvaluationDate { get; set; }
        public DateTime? AwardingApprovalDate { get; set; }
        public int? AthorityApproval { get; set; }
        public Guid? CompanyId { get; set; }
        public DateTime? SigningDate { get; set; }
        public DateTime? ContractorDate { get; set; }
        public int? NewContractActionId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AthorityMatrix? AthorityApprovalNavigation { get; set; }
        public virtual Company? Company { get; set; }
        public virtual ContractsType ContractType { get; set; } = null!;
        public virtual NewContractAction? NewContractAction { get; set; }
        public virtual Region Region { get; set; } = null!;
        public virtual ICollection<OpertionalContractNote> OpertionalContractNotes { get; set; }
    }
}
