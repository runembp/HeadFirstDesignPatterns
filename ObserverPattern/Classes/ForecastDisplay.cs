using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes;

public class ForecastDisplay : IObserver, IDisplayElement
{
    private readonly WeatherData _weatherData;
    private float _currentPressure = 29.92f;
    private float _lastPressure;

    public ForecastDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        _lastPressure = _weatherData.GetPressure();
        _currentPressure = _weatherData.GetPressure();
        Display();
    }

    public void Display()
    {
        Console.Write("Forecast: ");
        
        if (_currentPressure > _lastPressure)
        {
            Console.WriteLine("Improving weather on the way!");
        }
        else if (_currentPressure == _lastPressure)
        {
            Console.WriteLine("More of the same");
        }
        else if (_currentPressure < _lastPressure)
        {
            Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}