using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class ForumINV
    {
        public int ForumPostID { get; set; }
        public string Title { get; set; }
        public string? DateCheckedOut { get; set; } = string.Empty;
        public DateTime DatePosted { get; set; }
        public DateTime DateEdited { get; set; }

        public string Status { get; set; }
    }
}
