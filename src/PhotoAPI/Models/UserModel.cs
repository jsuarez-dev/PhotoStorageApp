
namespace PhotoAPI.Models;

public class UserModel {
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
}
