﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class InquiryINV
    {
        [Key]
        public int InquiryID { get; set; }
        public DateTime DateInquired { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Foreign Keys
        public HandymanINV Handyman {  get; set; }
        public int HandymanID { get; set; }
        public CustomerINV Customer { get; set; }
        public int CustomerID { get; set; }
    }
}
