using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class ForumINV
    {
        [Key]
        public int ForumPostID { get; set; }
        public string Title { get; set; } = string.Empty;

        public string Description {  get; set; } = string.Empty;
        public string? DateCheckedOut { get; set; } = string.Empty;
        public DateTime DatePosted { get; set; }
        public DateTime? DateEdited { get; set; }
        public string Status { get; set; }

        // Foreign Keys
        public CustomerINV Customer { get; set; }
        public int CustomerID { get; set; }

        // 1-to-many Relationship
        public List<HandymanINV> Handyman { get; set; }
        public List<ApplicationINV> Application { get; set; }
    }
}
