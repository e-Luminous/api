using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Transaction
    {
        [Key]
        public string TransactionId { get; set; }

        public double BillPaid { get; set; }

        public DateTime DateOfTransaction { get; set; }

        public string TransactionLog { get; set; }

        public PaymentMethod Method { get; set; }
        
        public Subscription Subscription { get; set; }
    }
}