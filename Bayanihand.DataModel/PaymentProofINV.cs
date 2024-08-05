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

        // Foreign Keys
        public HandymanINV Handyman { get; set; }
        public int HandymanID { get; set; }
        public CustomerINV Customer { get; set; }
        public int CustomerID { get; set; }

        public ForumINV ForumPost { get; set; }
        public int ForumPostID { get; set; }

        // 1-to-many Relationships
        public List<CheckInINV> CheckIn { get; set; }
    }
}
