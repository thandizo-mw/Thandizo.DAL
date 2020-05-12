using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class ScheduledNotificationEscalationRules
    {
        public ScheduledNotificationEscalationRules()
        {
            ScheduledNotifications = new HashSet<ScheduledNotifications>();
        }

        public int RuleId { get; set; }
        public string Name { get; set; }
        public string EscalateTo { get; set; }
        public string Message { get; set; }
        public string RowAction { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual ICollection<ScheduledNotifications> ScheduledNotifications { get; set; }
    }
}
