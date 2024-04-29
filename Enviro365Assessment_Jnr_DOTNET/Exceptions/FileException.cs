
namespace Enviro365Assessment_Jnr_DOTNET.Exceptions;

public class FileException : Exception
{
    public FileException(string message) : base(message)
    {
    }

    public FileException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public FileException()
    {
    }

}