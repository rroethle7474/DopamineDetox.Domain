using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class TopSearchResultDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        [JsonPropertyName("searchResultId")]
        public int SearchResultId { get; set; }
        [JsonPropertyName("searchResult")]
        public SearchResultDto? SearchResult { get; set; }
    }
}
