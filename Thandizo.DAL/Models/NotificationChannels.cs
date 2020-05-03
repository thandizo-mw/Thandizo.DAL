﻿using System;
using System.Collections.Generic;

namespace Thandizo.DAL.Models
{
    public partial class NotificationChannels
    {
        public NotificationChannels()
        {
            ScheduledNotifications = new HashSet<ScheduledNotifications>();
            Subscribers = new HashSet<Subscribers>();
        }

        public int ChannelId { get; set; }
        public string ChannelName { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? DateModified { get; set; }

        public virtual ICollection<ScheduledNotifications> ScheduledNotifications { get; set; }
        public virtual ICollection<Subscribers> Subscribers { get; set; }
    }
}
