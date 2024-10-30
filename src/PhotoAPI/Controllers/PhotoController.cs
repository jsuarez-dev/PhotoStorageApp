
using PhotoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using PhotoAPI.Data;

namespace PhotoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PhotoController(ILogger<PhotoController> logger, PhotoApiContext context) : ControllerBase
{

    private readonly ILogger<PhotoController> _logger = logger;
    private readonly Guid _uuid = Guid.NewGuid();
    private readonly PhotoApiContext _context = context;

    [HttpGet(Name = "Photos")]
    public ActionResult<string> Get()
    {
        return Ok(this._uuid.ToString());
    }
    
    [HttpGet("{photoId:guid}")]
    public ActionResult<string> GetPhoto(Guid photoId)
    {
        if (photoId == Guid.Empty)
        {
            return BadRequest("empty photoId");
        }
        else if (photoId == this._uuid)
        {
             return Ok("good uuid");
        }
        else
        {
            return BadRequest($"rec: {photoId} / correct uuid {this._uuid}");
        }
    }

    [HttpPut("{size}/resize")]
    public ActionResult<string> PutPhoto(int size)
    {
        return Ok($"this size is {size}KB");
    }

    public struct dataR
    {
        public string name;
        public string URL;

    }
    
    [HttpPost("create")]
    public ActionResult<string> PostPhoto(dataR data)
    {
       var photo = new PhotoModel() { Name = data.name, Url = data.URL };
       _context.Add(photo);
       _context.SaveChanges();
       return Ok(data.name); 
    }
}

