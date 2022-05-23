using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class Ftsdrole
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? ArabicName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
    }
}
