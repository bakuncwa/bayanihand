using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class ReferralINV
    {
        [Key]
        public int ReferralID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DateReferred { get; set; }
        public DateTime? DateEdited { get; set; }
        public int ReferralVote {  get; set; }

        // Foreign Keys
        public CustomerINV Customer { get; set; }
        public int CustomerID { get; set; }
        public HandymanINV Handyman { get; set; }
        public int HandymanID { get; set; }
        public ForumINV ForumPost { get; set; }
        public int ForumPostID { get; set; }
    }
}
