namespace DopamineDetox.Domain.Models
{
    public class SearchResult
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? UserName { get; set; }
        public string? Url { get; set; }
        public string? EmbedUrl { get; set; }
        public string? VideoId { get; set; }
        public string? ThumbnailUrl { get; set; }
        public DateTime PublishedAt { get; set; }
        public string? Term { get; set; }
        public string? ChannelName { get; set; }
        public int ContentTypeId { get; set; }
        public string? EmbeddedHtml { get; set; }
        public bool? IsHomePage { get; set; } = false;
        public bool? TopSearchResult { get; set; } = false;
        public bool? IsChannel { get; set; } = false;
        public DateTime DateAdded { get; set; }
        public ContentType? ContentType { get; set; }
        public Channel? Channel { get; set; }
        public SubTopic? SubTopic { get; set; }
        public IEnumerable<Note> Notes { get; set; } = new List<Note>();
        public IEnumerable<TopSearchResult> TopSearchResults { get; set; } = new List<TopSearchResult>();
    }
}
