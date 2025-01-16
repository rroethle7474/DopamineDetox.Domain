using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class SearchResultDto
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
        public DateTime PublishedAt { get; set; }
        [JsonPropertyName("term")]
        public string? Term { get; set; }
        [JsonPropertyName("channelName")]
        public string? ChannelName { get; set; }
        [JsonPropertyName("contentTypeId")]
        public int ContentTypeId { get; set; }
        [JsonPropertyName("isHomePage")]
        public bool? IsHomePage { get; set; } = false;
        [JsonPropertyName("isChannelResult")]
        public bool? IsChannelResult { get; set; } = false;
        [JsonPropertyName("topSearchResult")]
        public bool? TopSearchResult { get; set; } = false;
        [JsonPropertyName("embeddedHtml")]
        public string? EmbeddedHtml { get; set; }
        [JsonPropertyName("dateAdded")]
        public DateTime DateAdded { get; set; }
        [JsonPropertyName("isChannel")]
        public bool? IsChannel { get; set; } = false;

        [JsonPropertyName("notes")]
        public IEnumerable<NoteDto> Notes { get; set; } = new List<NoteDto>();
        [JsonPropertyName("topSearchResults")]
        public IEnumerable<TopSearchResultDto> TopSearchResults { get; set; } = new List<TopSearchResultDto>();

    }
}
