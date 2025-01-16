namespace DopamineDetox.Domain.Models
{
    public class Note : BaseModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Message { get; set; }
        public string? UserId { get; set; }
        public int SearchResultId { get; set; }
        public SearchResult? SearchResult { get; set; }
        public User? User { get; set; }

    }
}
