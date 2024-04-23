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
    [Route("upload")]
    public IActionResult UploadFile(IFormFile file)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetFile(int id)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    public IActionResult GetFiles()
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteFile(int id)
    {
        throw new NotImplementedException();
    }
}