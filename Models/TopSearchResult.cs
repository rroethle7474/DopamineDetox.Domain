namespace DopamineDetox.Domain.Models
{
    public class TopSearchResult
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int SearchResultId { get; set; }
        public SearchResult? SearchResult { get; set; }
    }
}
