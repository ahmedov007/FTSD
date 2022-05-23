using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class NotificationType
    {
        public NotificationType()
        {
            Notifications = new HashSet<Notification>();
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? NameArabic { get; set; }
        public string? Criticality { get; set; }
        public string? Icon { get; set; }
        public bool? IsActive { get; set; }
        public bool? NoDelete { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
