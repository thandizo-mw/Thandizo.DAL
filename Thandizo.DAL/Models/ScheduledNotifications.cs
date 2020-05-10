using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class ScheduledNotifications
    {
        public ScheduledNotifications()
        {
            ScheduledNotificationLog = new HashSet<ScheduledNotificationLog>();
        }

        public long NotificationId { get; set; }
        public string Message { get; set; }
        public long PatientId { get; set; }
        public int ChannelId { get; set; }
        public int TemplateId { get; set; }
        public bool IsActive { get; set; }
        public string Interval { get; set; }
        public DateTime StartDate { get; set; }
        public int RuleId { get; set; }
        public string RowAction { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual NotificationChannels Channel { get; set; }
        public virtual Patients Patient { get; set; }
        public virtual ScheduledNotificationEscalationRules Rule { get; set; }
        public virtual NotificationTemplates Template { get; set; }
        public virtual ICollection<ScheduledNotificationLog> ScheduledNotificationLog { get; set; }
    }
}
