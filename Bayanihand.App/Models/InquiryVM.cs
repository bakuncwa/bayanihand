using Bayanihand.DataModel;
using System.ComponentModel.DataAnnotations;

namespace Bayanihand.App.Models
{
    public class InquiryVM
    {
        [Key]
        public int InquiryID { get; set; }

        public DateTime DateInquired { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; } = string.Empty;

        // Foreign Keys
        public HandymanINV? Handyman { get; set; }
        public int HandymanID { get; set; }
        public CustomerINV? Customer { get; set; }
        public int CustomerID { get; set; }
    }
}
