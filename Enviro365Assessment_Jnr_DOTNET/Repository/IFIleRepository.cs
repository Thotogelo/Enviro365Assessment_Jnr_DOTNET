using Enviro365Assessment_Jnr_DOTNET.Model;

namespace Enviro365Assessment_Jnr_DOTNET.Repository;

public interface IFIleRepository
{
    public int UploadFile(EnvFile file);
    public EnvFile GetFile(int id);
    public List<EnvFile> GetFiles();
    public int DeleteFile(int id);
    public int UpdateFile(EnvFile file);
}