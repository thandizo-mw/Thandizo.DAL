using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class Subscribers
    {
        public long SubcriberId { get; set; }
        public long? PatientId { get; set; }
        public int ChannelId { get; set; }
        public string RowAction { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? DateModified { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsRegisteredPatient { get; set; }

        public virtual NotificationChannels Channel { get; set; }
        public virtual Patients Patient { get; set; }
    }
}
