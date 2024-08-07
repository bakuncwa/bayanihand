using System.ComponentModel.DataAnnotations;

namespace Bayanihand.App.Models
{
    public class ForumVM
    {
        public int ForumPostID { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
        public string? DateCheckedOut { get; set; } = string.Empty;

        public DateTime DatePosted { get; set; }
        public DateTime? DateEdited { get; set; }

        [Required]
        public string Status { get; set; } = string.Empty;
    }
}
