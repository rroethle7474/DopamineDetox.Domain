namespace DopamineDetox.Domain.Models
{
    public class WeeklySearchResultReport
    {
        public int Id { get; set; }
        public DateTime ReportDate { get; set; }
        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
