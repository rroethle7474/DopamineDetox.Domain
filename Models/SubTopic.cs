namespace DopamineDetox.Domain.Models
{
    // used for search on Twitter and YouTube
    public class SubTopic : BaseModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string? Term { get; set; }
        public string? UserId { get; set; }
        public int TopicId { get; set; }
        public Topic? Topic { get; set; }
        public User? User { get; set; }
    }
}
