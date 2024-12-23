using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes;

public class HeatIndexDisplay : IObserver, IDisplayElement
{
    private readonly WeatherData _weatherData;
    private float _temperature;
    private float _humidity;

    public HeatIndexDisplay(WeatherData weatherData)
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
        Console.WriteLine($"Heat index is {ComputeHeatIndex()}");
    }

    private float ComputeHeatIndex()
    {
        var heatIndex = (float)((16.923 + (0.185212 * _temperature) + (5.37941 * _humidity) - (0.100254 * _temperature * _humidity)
                                 + (0.00941695 * (_temperature * _temperature)) + (0.00728898 * (_humidity * _humidity))
                                 + (0.000345372 * (_temperature * _temperature * _humidity)) - (0.000814971 * (_temperature * _humidity * _humidity)) +
                                 (0.0000102102 * (_temperature * _temperature * _humidity * _humidity)) - (0.000038646 * (_temperature * _temperature * _temperature)) + (0.0000291583 *
                                                                                                                                                                          (_humidity * _humidity * _humidity)) + (0.00000142721 * (_temperature * _temperature * _temperature * _humidity)) +
                                 (0.000000197483 * (_temperature * _humidity * _humidity * _humidity)) - (0.0000000218429 * (_temperature * _temperature * _temperature * _humidity * _humidity)) +
                                 0.000000000843296 * (_temperature * _temperature * _humidity * _humidity * _humidity)) -
                                (0.0000000000481975 * (_temperature * _temperature * _temperature * _humidity * _humidity * _humidity)));

        return heatIndex;
    }
}