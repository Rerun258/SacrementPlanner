using System.ComponentModel.DataAnnotations;

namespace SacrementPlanner.Models
{
    public class Speaker
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Speaker name cannot exceed 100 characters.")]
        [RegularExpression(@"^[^\d]+$", ErrorMessage = "Speaker name cannot contain numbers.")]
        public string Name { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Subject cannot exceed 200 characters.")]
        public string Subject { get; set; }

        [Required]
        public int MeetingId { get; set; }
    }
}
