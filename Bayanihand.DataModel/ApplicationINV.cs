using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class ApplicationINV
    {
        [Key]
        public int ApplicationID { get; set; }
        public DateTime DateApplied { get; set; }

        public bool hasApplied { get; set; }

        // Foreign Keys
        public ForumINV ForumPost { get; set; }
        public int ForumPostID { get; set; }
        public HandymanINV Handyman { get; set; }
        public int HandymanID { get; set; }

    }
}
