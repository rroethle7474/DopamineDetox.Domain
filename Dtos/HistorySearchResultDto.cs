using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class HistorySearchResultDto : BaseDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("userName")]
        public string? UserName { get; set; }
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        [JsonPropertyName("embedUrl")]
        public string? EmbedUrl { get; set; }
        [JsonPropertyName("videoId")]
        public string? VideoId { get; set; }
        [JsonPropertyName("thumbnailUrl")]
        public string? ThumbnailUrl { get; set; }
        [JsonPropertyName("publishedAt")]
        public DateTime? PublishedAt { get; set; }
        [JsonPropertyName("subTopicTerm")]
        public string? SubTopicTerm { get; set; }
        [JsonPropertyName("channelName")]
        public string? ChannelName { get; set; }
        [JsonPropertyName("contentTypeName")]
        public string? ContentTypeName { get; set; }
    }
}
