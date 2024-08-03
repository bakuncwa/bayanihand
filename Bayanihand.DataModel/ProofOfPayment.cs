using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class ProofOfPayment
    {
        public int PaymentID { get; set; }
        public DateTime DatePaid { get; set; }
        public string PaymentStatus { get; set; } = string.Empty;
        public decimal AmountPaid { get; set; }
    }
}
