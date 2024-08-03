using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class ApplicationINV
    {
        public int ApplicationID { get; set; }
        public DateTime DateApplied { get; set; }
        public string CV { get; set; } = string.Empty;

        public int ApplicationName { get; set; }

    }
}
