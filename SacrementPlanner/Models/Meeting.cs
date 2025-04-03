namespace SacrementPlanner.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Conducting { get; set; }
        public string OpeningHymn {  get; set; }
        public string ClosingHymn { get; set; }
        public string SacramentHymn { get; set; }
        public string? IntermediateNumber { get; set; }
        public string OpeningPrayer {  get; set; }
        public string ClosingPrayer { get; set; }
        public ICollection<Speaker> Speakers { get; set; }
    }
}
