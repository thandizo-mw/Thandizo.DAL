using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class ScheduledNotificationLog
    {
        public long NotificationLogId { get; set; }
        public long NotificationId { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual ScheduledNotifications Notification { get; set; }
    }
}
