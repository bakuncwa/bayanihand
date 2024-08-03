using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class CheckInINV
    {
        public int CheckInID;
        public DateTime DateCheckedIn {  get; set; }
        public DateTime? DateCheckedOut { get; set; }
    }
}
