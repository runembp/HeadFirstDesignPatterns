using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private readonly WeatherData _weatherData;
    private float _minTemp = 200;
    private float _maxTemp;
    private float _tempSum;
    private int _numReadings;

    public StatisticsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        var weatherDataTemperature = _weatherData.GetTemperature();
        _tempSum += weatherDataTemperature;
        _numReadings++;

        if (weatherDataTemperature > _maxTemp)
        {
            _maxTemp = weatherDataTemperature;
        }
        
        if (weatherDataTemperature < _minTemp)
        {
            _minTemp = weatherDataTemperature;
        }

        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Avg/Max/Min temperature = {_tempSum / _numReadings}/{_maxTemp}/{_minTemp}");
    }
}