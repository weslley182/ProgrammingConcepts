using ObserverPatternExample.Interface;

namespace ObserverPatternExample.Services;

public class TemperatureLogger : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"Logger: Logging temperature = {temperature}");
    }
}
