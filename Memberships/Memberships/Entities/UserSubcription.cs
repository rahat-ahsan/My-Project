﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memberships.Entities
{
    [Table("UserSubscription")]
    public class UserSubscription
    {
        // Composite key: Subscription and AspNetUser tables
        [Key, Column(Order = 1)]
        [Required]
        public int SubscriptionId { get; set; }
        [Key, Column(Order = 2)]
        [MaxLength(128)]
        [Required]
        public string UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}