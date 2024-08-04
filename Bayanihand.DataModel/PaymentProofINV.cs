using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class PaymentProofINV
    {
        [Key]
        public int PaymentID { get; set; }
        public DateTime DatePaid { get; set; }
        public string PaymentStatus { get; set; } = string.Empty;
        public decimal AmountPaid { get; set; }

        public bool hasPaid { get; set; }
    }
}
