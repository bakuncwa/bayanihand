using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class ScheduleINV
    {
        [Key]
        public int ScheduleID { get; set; }
        public string ScheduleName { get; set; } = string.Empty;
        public DateTime DateBooked { get; set; }
        public DateTime? StartTime {  get; set; }
        public DateTime? EndTime { get; set; }
        public bool hasStarted { get; set; }
        public bool hasEnded { get; set; }

        // Foreign Keys
        public ForumINV ForumPost { get; set; }
        public int ForumPostID { get; set; }
        public CustomerINV Customer { get; set; }
        public int CustomerID { get; set; }
        public HandymanINV Handyman { get; set; }
        public int HandymanID { get; set; }

        // 1-to-many Relationship
        public List<CheckInINV> CheckIn { get; set; }

    }
}
