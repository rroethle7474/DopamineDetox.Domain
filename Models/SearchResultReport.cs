namespace DopamineDetox.Domain.Models
{
    public class SearchResultReport
    {
        public int Id { get; set; }
        public DateTime ReportDate { get; set; }
        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public int ContentTypeId { get; set; }
        public bool IsDefaultReport { get; set; } = false;
        public bool IsChannelReport { get; set; } = false;
        public ContentType? ContentType { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
