using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class CheckInINV
    {
        [Key]
        public int CheckInID;
        public DateTime DateCheckedIn {  get; set; }
        public DateTime? DateCheckedOut { get; set; }
        public bool hasCheckedIn { get; set; }
        public ScheduleINV Schedule { get; set; }
        public int ScheduleID { get; set; }

        // Foreign Keys
        public PaymentProofINV Payment { get; set; }
        public int PaymentID { get; set; }
    }
}
