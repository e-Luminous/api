using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class PaymentMethod
    {
        [Key]
        public int MethodId { get; set; }

        public string MethodName { get; set; }

        public string EndPoint { get; set; }

        public string OTPUrl { get; set; }
        
        public string TransactionUrl { get; set; }

        public ICollection<Transaction> Transcs { get; set; }
    }
}