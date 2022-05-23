using System;
using System.Collections.Generic;

namespace FTSD2.Domain
{
    public partial class Notification
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? NotificationContent { get; set; }
        public Guid? NotificationTypeId { get; set; }
        public string? Sender { get; set; }
        public string? Receiver { get; set; }
        public DateTime? Date { get; set; }
        public string? Url { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public bool? NoDelete { get; set; }

        public virtual NotificationType? NotificationType { get; set; }
    }
}
