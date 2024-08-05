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

        // 1-to-many Relationship
        public List<ScheduleINV> Schedule {  get; set; }
    }
}
