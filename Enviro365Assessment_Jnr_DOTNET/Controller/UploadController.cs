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
    public string UploadFile(IFormFile file)
    {
        return "File uploaded successfully";
    }

    [HttpGet]
    [Route("{id}")]
    public string GetFile(int id)
    {
        return "File retrieved successfully";
    }

    [HttpGet]
    public string GetFiles()
    {
        return "Files retrieved successfully";
    }

    [HttpDelete]
    [Route("{id}")]
    public string DeleteFile(int id)
    {
        return "File deleted successfully";
    }
}