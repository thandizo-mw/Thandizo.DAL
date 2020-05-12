using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class NotificationTemplates
    {
        public NotificationTemplates()
        {
            ScheduledNotifications = new HashSet<ScheduledNotifications>();
        }

        public int TemplateId { get; set; }
        public int Interval { get; set; }
        public int RepeatCount { get; set; }
        public string IntervalUnit { get; set; }
        public string RowAction { get; set; }
        public string TemplateName { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual ICollection<ScheduledNotifications> ScheduledNotifications { get; set; }
    }
}
