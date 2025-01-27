namespace FrontendJS.Models;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

public class PhotoModel
{
    [Required]
    public List<IFormFile> PhotoFiles { get; set; }
    
}
