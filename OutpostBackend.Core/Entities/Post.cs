namespace OutpostBackend.Core.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Body { get; set; } = default!;
        public DateTime Published { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
