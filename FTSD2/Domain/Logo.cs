using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class Logo
    {
        public double SiteNo { get; set; }
        public string? Name { get; set; }
        public string? Ename { get; set; }
        public byte[]? Logo1 { get; set; }
        public byte[]? Background { get; set; }
        public byte[]? Elogo { get; set; }
        public byte[]? Ebackground { get; set; }
        public bool ActiveSite { get; set; }
    }
}
