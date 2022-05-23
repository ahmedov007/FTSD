using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class BudgetPlan
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? Yearbudget { get; set; }
        public int? AnualPlan { get; set; }
        public int? Spentbudget { get; set; }
    }
}
