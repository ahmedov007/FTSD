using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class CapitalProject
    {
        public Guid Id { get; set; }
        public string? ProjectNo { get; set; }
        public string? ContractNo { get; set; }
        public Guid? BudgetYearId { get; set; }
        public int? RegionId { get; set; }
        public int? CityId { get; set; }
        public int? LandStatusId { get; set; }
        public int? BussinessUnitId { get; set; }
        public int? ProjetTypeId { get; set; }
        public string? ProjectName { get; set; }
        public string? ArabicProjectName { get; set; }
        public int? ProjectStatusId { get; set; }
        public int? PlanPercentage { get; set; }
        public int? ActualPercentage { get; set; }
        public int? ProjectDatesId { get; set; }
        public int? EstimatBudget { get; set; }
        public int? ContractCost { get; set; }
        public int? BudgetSpent { get; set; }
        public string? Description { get; set; }

        public virtual BudgetYear? BudgetYear { get; set; }
        public virtual BussinessUnit? BussinessUnit { get; set; }
        public virtual City? City { get; set; }
        public virtual LandStatus? LandStatus { get; set; }
        public virtual ProjectSatuse? ProjectStatus { get; set; }
        public virtual ProjectType? ProjetType { get; set; }
        public virtual Region? Region { get; set; }
    }
}
