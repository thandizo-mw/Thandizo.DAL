using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class Subscribers
    {
        public long SubscriberId { get; set; }
        public int ChannelId { get; set; }
        public string PhoneNumber { get; set; }
        public string RecipientAddress { get; set; }
        public DateTime SubscriptionDate { get; set; }

        public virtual NotificationChannels Channel { get; set; }
    }
}
