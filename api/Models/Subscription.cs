using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Subscription
    {
        [Key]
        public string SubscriptionId { get; set; }

        public DateTime ValidTill { get; set; }

        public Transaction Transaction { get; set; }
        
        public Institution Institution { get; set; }
    }
}