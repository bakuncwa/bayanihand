using Bayanihand.DataModel;
using System.ComponentModel.DataAnnotations;

namespace Bayanihand.App.Models
{
    public class PaymentVM
    {
        [Key]
        public int PaymentID { get; set; }
        public DateTime DatePaid { get; set; }
        public string PaymentStatus { get; set; } = string.Empty;
        public decimal AmountPaid { get; set; }
        public bool hasPaid { get; set; }

        //public HandymanINV Handyman { get; set; }
        //public int HandymanID { get; set; }
        //public CustomerINV Customer { get; set; }
        //public int CustomerID { get; set; }
    }
}
