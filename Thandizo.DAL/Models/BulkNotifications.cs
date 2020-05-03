using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class BulkNotifications
    {
        public BulkNotifications()
        {
            BulkNotificationLog = new HashSet<BulkNotificationLog>();
        }

        public long NotificationId { get; set; }
        public string Message { get; set; }
        public DateTimeOffset SendDate { get; set; }
        public string RowAction { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? DateModified { get; set; }

        public virtual ICollection<BulkNotificationLog> BulkNotificationLog { get; set; }
    }
}
