using Enviro365Assessment_Jnr_DOTNET.Data;
using Enviro365Assessment_Jnr_DOTNET.Model;

namespace Enviro365Assessment_Jnr_DOTNET.Repository;

public class FileRepository : IFIleRepository
{
    private readonly DataContext _dataContext;

    public FileRepository(DataContext dataContext)
        => _dataContext = dataContext;


    public EnvFile CovertToEnvFile(IFormFile file)
    {
        using var reader = new StreamReader(file.OpenReadStream());
        string contents = reader.ReadToEnd();
        reader.Close();
        return new EnvFile
        {
            Id = 0, // Id is auto-generated
            FileName = file.FileName,
            ProcessedData = contents
        };

    }

    public int UploadFile(IFormFile file)
    {
        if (file == null)
            return 0;

        try
        {
            EnvFile FileToStore = CovertToEnvFile(file);
            _dataContext.EnvFiles.Add(FileToStore);
            return _dataContext.SaveChanges();
        }
        catch (Exception e)
        {
            throw new Exception("An error occurred while uploading the file: " + e.Message);
        }
    }

    public EnvFile? GetFile(int id)
    {
        return _dataContext.EnvFiles.Find(id);
    }

    public List<EnvFile> GetFiles()
    {
        return _dataContext.EnvFiles.ToList();
    }

    public int DeleteFile(int id)
    {
        EnvFile? file = GetFile(id);
        if (file == null)
            return 0;
        try
        {
            _dataContext.EnvFiles.Remove(file);
            return _dataContext.SaveChanges();
        }
        catch (Exception e)
        {
            throw new Exception("An error occurred while removing the file: " + e.Message);
        }
    }

    public int UpdateFile(IFormFile file)
    {
        EnvFile FileToUpdate = CovertToEnvFile(file);
        _dataContext.EnvFiles.Update(FileToUpdate);
        return _dataContext.SaveChanges();
    }
}