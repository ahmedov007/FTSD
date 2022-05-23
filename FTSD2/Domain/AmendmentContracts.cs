namespace FTSD2.Domain
{
    public class AmendmentContracts
    {
        public Guid Id { get; set; }
        public string? ContractNo { get; set; }
        public string? ContractName { get; set; }
        public string? ArabicContractName { get; set; }
        public int? RegionId { get; set; }
        public Guid? CompanyId { get; set; }
        public int? ContractTypeId { get; set; }
        public int? AthorityApproval { get; set; }

        public int? NewContractActionId { get; set; }
        public DateTime? AmendmentRequestDate { get; set; }
        public DateTime? AmendmentLetterApprovalDate { get; set; }
        public DateTime? SigntureDate { get; set; }
        public DateTime? ContractorSignutreDate { get; set; }
        public double? AmendmentCost { get; set; }
        public int? OptionalPeriodValue { get; set; }
        public int? AmendmentPercentage { get; set; }
        public int? ModificationDuration { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
    }
}
