
using PhotoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace PhotoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController(ILogger<UsersController> logger) : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<UsersController> _logger = logger;

    [HttpGet(Name = "Users")]
    public List<UserModel> Get()
    {
        List<UserModel> result = new List<UserModel>(){
            new UserModel() {
                Name = "johan"
            }
        };
        return result;
    }
}

