using Microsoft.AspNetCore.Mvc;
using BlogService.Models;
using System.Collections.Generic;

namespace BlogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private static List<BlogPost> blogPosts = new List<BlogPost>();

        [HttpGet]
        public ActionResult<IEnumerable<BlogPost>> GetBlogPosts()
        {
            return Ok(blogPosts);
        }

        [HttpGet("{id}")]
        public ActionResult<BlogPost> GetBlogPostById(int id)
        {
            var blogPost = blogPosts.Find(post => post.Id == id);
            if (blogPost == null)
            {
                return NotFound();
            }
            return Ok(blogPost);
        }

        [HttpPost]
        public ActionResult<BlogPost> CreateBlogPost([FromBody] BlogPost blogPost)
        {
            blogPost.Id = blogPosts.Count + 1;
            blogPosts.Add(blogPost);
            return CreatedAtAction(nameof(GetBlogPostById), new { id = blogPost.Id }, blogPost);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateBlogPost(int id, [FromBody] BlogPost updatedBlogPost)
        {
            var blogPost = blogPosts.Find(post => post.Id == id);
            if (blogPost == null)
            {
                return NotFound();
            }
            blogPost.Title = updatedBlogPost.Title;
            blogPost.Content = updatedBlogPost.Content;
            blogPost.AuthorId = updatedBlogPost.AuthorId;
            blogPost.CreatedAt = updatedBlogPost.CreatedAt;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBlogPost(int id)
        {
            var blogPost = blogPosts.Find(post => post.Id == id);
            if (blogPost == null)
            {
                return NotFound();
            }
            blogPosts.Remove(blogPost);
            return NoContent();
        }
    }
}