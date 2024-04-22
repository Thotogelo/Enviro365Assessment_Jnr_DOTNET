using Microsoft.AspNetCore.Mvc;

namespace Enviro365Assessment_Jnr_DOTNET.Controller;

[ApiController]
[Route("api/[controller]")]
public class UploadController
{
    [HttpGet]
    public string test() => "Hello World!";
    
    [HttpPost]
    public string UploadFile(IFormFile file)
    {
        return "File uploaded successfully";
    }
}