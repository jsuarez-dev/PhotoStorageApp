namespace FrontendJS.Controllers;

using Microsoft.AspNetCore.Mvc;

public class UploadController : Controller{

    public IActionResult Index(){

        return View();
    }

    [HttpPost]
    public IActionResult Index(List<IFormFile> PhotoFiles){

        foreach (IFormFile File in PhotoFiles) {

            Console.WriteLine(File.FileName);

        }
        return View();
    }



}
