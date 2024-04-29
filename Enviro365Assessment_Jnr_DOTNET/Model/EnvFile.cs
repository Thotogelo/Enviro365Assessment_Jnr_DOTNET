using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enviro365Assessment_Jnr_DOTNET.Model;

public class EnvFile
{
    public required int Id { get; set; }

    public required string FileName { get; set; }

    private DateTime _uploadDate;
    public DateTime UploadDate
    {
        get { return _uploadDate; }
        set { _uploadDate = value; }
    }

    public required string ProcessedData { get; set; }
}