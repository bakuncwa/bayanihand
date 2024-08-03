using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class JobClassINV
    {
        public int JobClassID { get; set; }
        public string JobRole { get; set; } = string.Empty;
        public string JobExperience { get; set; } = string.Empty;
        public string JobField { get; set; } = string.Empty;
    }
}
