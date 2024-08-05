using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class CustomerINV
    {
        [Key]
        public int CustomerID { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string ContactNo { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string GovID { get; set; }
        public bool isVerified { get; set; }
        public byte[] ProfilePhoto { get; set; }
        public string CustomerESign { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string BarangayNo { get; set; } = string.Empty;
        public string BarangayName { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZIPCode { get; set; } = string.Empty;

        // 1-to-many Relationships

        public List<ForumINV> ForumPost { get; set; }
        public List<ScheduleINV> Schedule { get; set; }
    }
}
