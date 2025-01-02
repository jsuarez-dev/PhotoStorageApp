
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

    public class dataR
    {
        public string name { get; set; }
        public string URL { get; set; }
    }
    
    [HttpPost("create")]
    public ActionResult<string> PostPhoto(dataR data)
    {
        if (String.IsNullOrEmpty(data.name) || String.IsNullOrEmpty(data.URL))
        {
            return BadRequest($"data is null: {data.name}, {data.URL}");
        }
       var photo = new PhotoModel() { Name = data.name, Url = data.URL };
       _context.Add(photo);
       _context.SaveChanges();
       return Ok(data.name); 
    }

    [HttpPost("upload")]
    public async Task<IActionResult> OnPostUploadAsync(List<IFormFile> files)
    {
        long size = files.Sum(f => f.Length);

        foreach (var formFile in files)
        {
            if (formFile.Length > 0)
            {
                var filePath = Path.GetTempFileName();

                using (var stream = System.IO.File.Create(filePath))
                {
                    await formFile.CopyToAsync(stream);
                }
            }
        }

        // Process uploaded files
        // Don't rely on or trust the FileName property without validation.

        return Ok(new { count = files.Count, size });
    }
}

