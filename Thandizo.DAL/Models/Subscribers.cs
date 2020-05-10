using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class Subscribers
    {
        public long SubscriberId { get; set; }
        public int ChannelId { get; set; }
        public string RowAction { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsRegisteredPatient { get; set; }

        public virtual NotificationChannels Channel { get; set; }
    }
}
