using System;

namespace BlogService.Models
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid AuthorId { get; set; }
        public DateTime CreatedAt { get; set; }

        public BlogPost()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}