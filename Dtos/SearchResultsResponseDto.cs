using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class SearchResultsResponseDto
    {
        [JsonPropertyName("successCount")]
        public int SuccessCount { get; set; }
        [JsonPropertyName("duplicateCount")]
        public int DuplicateCount { get; set; }
    }
}
