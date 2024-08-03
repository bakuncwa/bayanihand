using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class ScheduleINV
    {
        public int ScheduleID { get; set; }
        public string ScheduleName { get; set; } = string.Empty;
        public DateTime DateBooked { get; set; }
        public DateTime StartTime {  get; set; }
        public DateTime EndTime { get; set; }
    }
}
