namespace DopamineDetox.Domain.Models
{
    public class HistorySearchResult : BaseModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? UserName { get; set; }
        public string? Url { get; set; }
        public string? EmbedUrl { get; set; }
        public string? VideoId { get; set; }
        public string? ThumbnailUrl { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string? SubTopicTerm { get; set; }
        public string? ChannelName { get; set; }
        public string? ContentTypeName { get; set; }
    }
}
