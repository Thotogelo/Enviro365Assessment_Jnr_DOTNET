using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enviro365Assessment_Jnr_DOTNET.Model;

[Table("EnvironmentData")]
public class EnvironmentData
{
    [Key] [Column("EnvironmentDataId")] public required int Id { get; set; }

    [Column("File_name")] public required string FileName { get; set; }

    [Column("Upload_Date")] public required DateTime UploadDate { get; set; }

    [Column("Processed_Data")] public required string ProcessedData { get; set; }
}