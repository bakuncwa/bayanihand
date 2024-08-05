using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class HandymanINV
    {
        [Key]
        public int HandymanID { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string ContactNo { get; set; } = string.Empty;
        public string Email { get; set;} = string.Empty;
        public string GovID { get; set; }
        public bool isVerified { get; set; }
        public string ProfilePhoto {  get; set; } = string.Empty;
        public string HandymanESign { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string BarangayNo { get; set; } = string.Empty;
        public string BarangayName { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZIPCode { get; set; } = string.Empty;

        public decimal SalaryRange { get; set; }

        // Foreign Keys
        public ForumINV ForumPost { get; set; }
        public int ForumPostID { get; set; }

        // 1-to-many Relationship
        public List<ScheduleINV> Schedule { get; set; }

    }
}
