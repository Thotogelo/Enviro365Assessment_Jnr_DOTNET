using Enviro365Assessment_Jnr_DOTNET.Model;

namespace Enviro365Assessment_Jnr_DOTNET.Repository;

public interface IFIleRepository
{
    public EnvFile UploadFile(EnvFile file);
    public EnvFile GetFile(int id);
    public List<EnvFile> GetFiles();
    public void DeleteFile(int id);
    public void UpdateFile(EnvFile file);
}