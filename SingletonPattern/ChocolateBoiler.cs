namespace SingletonPattern;

public class ChocolateBoiler
{
    private bool _empty = true;
    private bool _boiled = false;

    private static object objectLock = new();
    private static ChocolateBoiler? _uniqueInstance;

    private ChocolateBoiler()
    {
        
    }

    public static ChocolateBoiler GetInstance()
    {
        lock (objectLock)
        {
            _uniqueInstance = new ChocolateBoiler();
            return _uniqueInstance;
        }
    }

    public void Fill()
    {
        if (!_empty)
        {
            return;
        }
        
        _empty = false;
        _boiled = false;
    }

    public void Drain()
    {
        if (!_empty && _boiled)
        {
            _empty = true;
        }
    }

    public void Boil()
    {
        if (!_empty && !_boiled)
        {
            _boiled = true;
        }
    }
}