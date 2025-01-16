using System.Text.Json.Serialization;

namespace DopamineDetox.Domain.Dtos
{
    public class WeeklySearchResultReportDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("reportDate")]
        public DateTime ReportDate { get; set; } = DateTime.Now;
        [JsonPropertyName("isSuccess")]
        public bool IsSuccess { get; set; }
        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }
        [JsonPropertyName("createdOn")]
        public DateTime CreatedOn { get; set; }
    }
}