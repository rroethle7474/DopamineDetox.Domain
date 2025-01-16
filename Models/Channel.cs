namespace DopamineDetox.Domain.Models
{
    public class Channel : BaseModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public string? ChannelName { get; set; }
        public string? Identifier { get; set; }
        public string? Description { get; set; }
        public int ContentTypeId { get; set; }
        public string? UserId { get; set; }

        public ContentType? ContentType { get; set; }
        public User? User { get; set; }
    }
}
