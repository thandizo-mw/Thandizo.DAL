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
        public string RowAction { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime SendDate { get; set; }
        public int ChannelId { get; set; }

        public virtual NotificationChannels Channel { get; set; }
        public virtual ICollection<BulkNotificationLog> BulkNotificationLog { get; set; }
    }
}
