using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class ProjectDate
    {
        public int Id { get; set; }
        public DateTime? RecevReq { get; set; }
        public DateTime? PlannigDate { get; set; }
        public DateTime? DesigningDate { get; set; }
        public DateTime? BiddingDate { get; set; }
        public DateTime? AwardingDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? Closing { get; set; }
    }
}
