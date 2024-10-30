
namespace PhotoAPI.Models;

public class PhotoModel {
    public Guid Id { get; set; }
    public string Url { get; set; } = String.Empty;
    public uint Size { get; set; } = 0;
    public string Name { get; set; } = String.Empty;
}
