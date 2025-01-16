namespace DopamineDetox.Domain.Models
{
    public class ContentType : BaseModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
