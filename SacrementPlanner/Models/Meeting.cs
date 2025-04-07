using System.ComponentModel.DataAnnotations;
using SacrementPlanner.ValidationAttributes;

namespace SacrementPlanner.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Meeting Date")]
        
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Conducting cannot exceed 100 characters.")]
        [RegularExpression(@"^[^\d]+$", ErrorMessage = "Conducting cannot contain numbers.")]
        public string Conducting { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Opening Prayer cannot exceed 100 characters.")]
        [RegularExpression(@"^[^\d]+$", ErrorMessage = "Opening Prayer cannot contain numbers.")]
        public string OpeningPrayer { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Closing Prayer cannot exceed 100 characters.")]
        [RegularExpression(@"^[^\d]+$", ErrorMessage = "Closing Prayer cannot contain numbers.")]
        public string ClosingPrayer { get; set; }

        [Required]
        [RegularExpression(@"^.+\s?#\d+$", ErrorMessage = "Opening Hymn must follow the format 'Hymn name #number' (e.g., 'Come Unto Jesus #42').")]
        public string OpeningHymn { get; set; }

        [Required]
        [RegularExpression(@"^.+\s?#\d+$", ErrorMessage = "Closing Hymn must follow the format 'Hymn name #number' (e.g., 'Come Unto Jesus #42').")]
        public string ClosingHymn { get; set; }

        [Required]
        [RegularExpression(@"^.+\s?#\d+$", ErrorMessage = "Sacrament Hymn must follow the format 'Hymn name #number' (e.g., 'Come Unto Jesus #42').")]
        public string SacramentHymn { get; set; }

        [RegularExpression(@"^.+\s?#\d+$", ErrorMessage = "Intermediate Hymn must follow the format 'Hymn name #number' (e.g., 'Come Unto Jesus #42').")]
        public string? IntermediateNumber { get; set; }

        public ICollection<Speaker> Speakers { get; set; } = new List<Speaker>();
    }
}

