using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes;

public class WeatherData : ISubject
{
    private readonly List<IObserver> _observers = [];
    
    private float _temperature;
    private float _humidity;
    private float _pressure;

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        
        MeasurementsChanged();
    }

    private void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public float GetTemperature()
    {
        return _temperature;
    }

    public float GetHumidity()
    {
        return _humidity;
    }

    public float GetPressure()
    {
        return _pressure;
    }
    
    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}