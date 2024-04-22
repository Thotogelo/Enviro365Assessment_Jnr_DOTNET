using Enviro365Assessment_Jnr_DOTNET.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Enviro365Assessment_Jnr_DOTNET.Controller;

[ApiController]
[Route("api/[controller]")]
public class UploadController
{
    private readonly IFIleRepository _fileRepository;

    public UploadController(IFIleRepository fileRepository)
        => _fileRepository = fileRepository;


    [HttpGet]
    public string Test() => "Hello World!";

    [HttpPost]
    public string UploadFile(IFormFile file)
    {
        return "File uploaded successfully";
    }
}