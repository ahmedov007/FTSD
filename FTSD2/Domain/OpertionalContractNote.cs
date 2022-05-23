using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class OpertionalContractNote
    {
        public Guid Id { get; set; }
        public string? Notes { get; set; }
        public DateTime? NoteDate { get; set; }
        public Guid? UserId { get; set; }
        public Guid OperationalContractId { get; set; }
        public bool? IsActive { get; set; }
        public bool? NoDelete { get; set; }
        public Guid? DucomentTypeId { get; set; }

        public virtual DucomentType? DucomentType { get; set; }
        public virtual ActiveContract OperationalContract { get; set; } = null!;
        public virtual NewContract OperationalContractNavigation { get; set; } = null!;
        public virtual Employee? User { get; set; }
    }
}
