using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class SearchResultReportDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("contentTypeId")]
        public int ContentTypeId { get; set; }
        [JsonPropertyName("reportDate")]
        public DateTime ReportDate { get; set; }
        [JsonPropertyName("isSuccess")]
        public bool IsSuccess { get; set; }
        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }
        [JsonPropertyName("isDefaultReport")]
        public bool IsDefaultReport { get; set; }
        [JsonPropertyName("isChannelReport")]
        public bool IsChannelReport { get; set; }
        [JsonPropertyName("createdOn")]
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
