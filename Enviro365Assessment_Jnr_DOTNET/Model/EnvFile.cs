using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enviro365Assessment_Jnr_DOTNET.Model;

public class EnvFile
{
    public required int Id { get; set; }

    public required string FileName { get; set; }

    public required DateTime UploadDate { get; set; }

    public required string ProcessedData { get; set; }
}