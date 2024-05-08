using Enviro365Assessment_Jnr_DOTNET.Model;
using Enviro365Assessment_Jnr_DOTNET.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Enviro365Assessment_Jnr_DOTNET.Controller;

[ApiController]
[Route("api/v1/[controller]")]
public class UploadController : ControllerBase
{
    private readonly FileRepository _fileRepository;

    public UploadController(FileRepository fileRepository)
        => _fileRepository = fileRepository;

    [HttpPost]
    [Route("save")]
    public IActionResult UploadFile([FromForm] IFormFile file)
    {
        var dbfile = _fileRepository.UploadFile(file);
        return CreatedAtAction(nameof(GetFile), new { id = dbfile.Id }, dbfile);
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