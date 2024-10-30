
using PhotoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace PhotoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PhotoController(ILogger<PhotoController> logger) : ControllerBase
{

    private readonly ILogger<PhotoController> _logger = logger;

    [HttpGet(Name = "Photos")]
    public ActionResult<string> Get()
    {
        return Ok("hola");
    }
}

