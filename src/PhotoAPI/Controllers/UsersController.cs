
using PhotoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace PhotoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController(ILogger<UsersController> logger) : ControllerBase
{

    private readonly ILogger<UsersController> _logger = logger;

    [HttpGet]
    public List<UserModel> GetAllUsers()
    {
        List<UserModel> result = new List<UserModel>(){
            new UserModel() {
                Name = "johan"
            }
        };
        return result;
    }
    [HttpGet("User/{id:int}")]
    public UserModel GetUser(int id)
    {
        UserModel result = new UserModel()
        {
            Name = "johan"
        };
        return result;
    }
}

