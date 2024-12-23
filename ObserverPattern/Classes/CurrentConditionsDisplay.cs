using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private readonly WeatherData _weatherData;
    private float _temperature;
    private float _humidity;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        _temperature = _weatherData.GetTemperature();
        _humidity = _weatherData.GetHumidity();
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
    }
}