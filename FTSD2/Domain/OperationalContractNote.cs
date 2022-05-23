using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class OperationalContractNote
    {
        public Guid Id { get; set; }
        public string? Notes { get; set; }
        public string? UserId { get; set; }
        public Guid? ActiveContractId { get; set; }
        public DateTime? NoteDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? NoDelete { get; set; }
    }
}
