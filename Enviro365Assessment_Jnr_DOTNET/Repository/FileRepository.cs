using Enviro365Assessment_Jnr_DOTNET.Data;
using Enviro365Assessment_Jnr_DOTNET.Model;

namespace Enviro365Assessment_Jnr_DOTNET.Repository;

public class FileRepository : IFIleRepository
{
    private readonly DataContext _dataContext;

    public FileRepository(DataContext dataContext)
        => _dataContext = dataContext;

    public int UploadFile(EnvFile file)
    {
        _dataContext.EnvFiles.Add(file);
        return _dataContext.SaveChanges();
    }

    public EnvFile GetFile(int id)
    {
        throw new NotImplementedException();
    }

    public List<EnvFile> GetFiles()
    {
        throw new NotImplementedException();
    }

    public void DeleteFile(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateFile(EnvFile file)
    {
        throw new NotImplementedException();
    }
}