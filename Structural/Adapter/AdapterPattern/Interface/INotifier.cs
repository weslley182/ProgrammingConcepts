namespace AdapterPattern.Interface;

public interface INotifier
{
    void Send(string to, string message);
}
