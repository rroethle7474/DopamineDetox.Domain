using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class QuoteDto
    {
        [JsonPropertyName("quoteText")]
        public string? QuoteText { get; set; }
        [JsonPropertyName("quoteDateFetched")]
        public DateTime? QuoteDateFetched { get; set; }
        [JsonPropertyName("quoteImage")]
        public byte[]? QuoteImage { get; set; }
    }
}
