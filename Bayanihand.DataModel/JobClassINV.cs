using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class JobClassINV
    {
        [Key]
        public int JobClassID { get; set; }
        public string JobRole { get; set; } = string.Empty;
        public string JobExperience { get; set; } = string.Empty;
        public string JobField { get; set; } = string.Empty;

        // Foreign Keys
        public HandymanINV Handyman {  get; set; }
        public int HandymanID { get; set; }
        public ForumINV ForumPost { get; set; }
        public int ForumPostID { get; set; } 
    }
}
