using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class LearnMoreDetailDto
    {
        [JsonPropertyName("introduction")]
        public string? Introduction { get; set; }
        [JsonPropertyName("items")]
        public string? Items { get; set; }
        [JsonPropertyName("quoteDateFetched")]
        public DateTime? QuoteDateFetched { get; set; }
    }
}
