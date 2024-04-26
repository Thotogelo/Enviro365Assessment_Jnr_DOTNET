using Enviro365Assessment_Jnr_DOTNET.Model;
using Enviro365Assessment_Jnr_DOTNET.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Enviro365Assessment_Jnr_DOTNET.Controller;

[ApiController]
[Route("api/[controller]")]
public class UploadController : ControllerBase
{
    private readonly IFIleRepository _fileRepository;

    public UploadController(IFIleRepository fileRepository)
        => _fileRepository = fileRepository;

    [HttpPost]
    [Route("save")]
    public IActionResult UploadFile(IFormFile file)
    {
        int rowsAffected = _fileRepository.UploadFile(file);
        return rowsAffected > 0 ? Ok() : BadRequest();
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetFile(int id)
    {
        EnvFile? file = _fileRepository.GetFile(id);
        return file != null ? Ok(file) : NotFound();
    }

    [HttpGet]
    [Route("data")]
    public IActionResult GetFiles()
    {
        return Ok(_fileRepository.GetFiles());

    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteFile(int id)
    {
        int rowsAffected = _fileRepository.DeleteFile(id);
        return rowsAffected > 0 ? Ok() : NotFound();
    }

    [HttpPost]
    [Route("update")]
    public IActionResult UpdateFile(IFormFile file)
    {
        int rowsAffected = _fileRepository.UpdateFile(file);
        return rowsAffected > 0 ? Ok() : BadRequest();
    }

}