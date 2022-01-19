using System.Text;
using System.Text.Json;
using CodeChamp.Database;
using CodeChamp.Models;
using CodeChamp.RabbitMQ;
using Microsoft.AspNetCore.Mvc;

namespace CodeChamp.Controllers;

[ApiController]
[Route("/api/posts")]
public class PostController : ControllerBase
{
    readonly CodeChampDbContext _context;
    readonly MqProducer _producer;

    public PostController(CodeChampDbContext context, MqProducer producer)
    {
        _context = context;
        _producer = producer;
    }

    [HttpGet]
    public List<Post> GetPosts()
    {
       return _context.Posts.ToList();
    }

    [HttpPost]
    public Post CreatePost([FromBody] Post post)
    {
        _context.Add(post);
        _context.SaveChanges();
        return post;
    }

    [HttpPost("/async")]
    public void CreatePostAsync([FromBody] Post post)
    {
        var jsonText = JsonSerializer.Serialize(post);
        var encodedText = Encoding.UTF8.GetBytes(jsonText);
        _producer.SendMessage(nameof(Post), encodedText);
    }
}