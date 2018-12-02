namespace Dexter.Server
{
    public class Server
    {

    }

    public interface IServer
    {
        string LogOn(string client);
        string GetAllLiveData();
        string GetLiveDataFor(string item);
    }
}