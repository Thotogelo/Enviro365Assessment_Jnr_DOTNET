namespace Enviro365Assessment_Jnr_DOTNET.Model;

public class EnvFile
{
    public required int Id { get; set; }

    public required string FileName { get; set; }

    public DateTime UploadDate { get; }

    public required string ProcessedData { get; set; }

    public EnvFile()
    => UploadDate = DateTime.Now;
}