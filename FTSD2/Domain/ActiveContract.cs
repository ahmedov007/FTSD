using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class ActiveContract
    {
        public ActiveContract()
        {
            OpertionalContractNotes = new HashSet<OpertionalContractNote>();
        }

        public Guid Id { get; set; }
        public string? ContractNo { get; set; }
        public string? Name { get; set; }
        public string? ArabicName { get; set; }
        public int? RegionId { get; set; }
        public Guid? CompanyId { get; set; }
        public int? BaasicDuration { get; set; }
        public int? OptionalDuration { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDat { get; set; }
        public double? BasicPeriodValue { get; set; }
        public double? OptionalPeriodValue { get; set; }
        public double? LumpSum { get; set; }
        public double? Uitrate { get; set; }
        public double? OptionalValue { get; set; }
        public double? CotractTotal { get; set; }
        public int? ContractTypeId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public virtual Company? Company { get; set; }
        public virtual ContractsType? ContractType { get; set; }
        public virtual Region? Region { get; set; }
        public virtual ICollection<OpertionalContractNote> OpertionalContractNotes { get; set; }
    }
}
