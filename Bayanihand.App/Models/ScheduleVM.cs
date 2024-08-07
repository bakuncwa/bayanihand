using System.ComponentModel.DataAnnotations;

namespace Bayanihand.App.Models
{
    public class ScheduleVM
    {
        [Key]

        public int ScheduleID { get; set; }

        public string ScheduleName { get; set; } = string.Empty;

        [Required]
        public DateTime DateBooked { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool hasStarted { get; set; }
        public bool hasEnded { get; set; }
        public string Status { get; set; }
    }
}
