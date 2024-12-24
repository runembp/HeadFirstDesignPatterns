namespace SingletonPattern;

public class ChocolateBoiler
{
    public static ChocolateBoiler Instance { get; } = new();

    private bool _empty = true;
    private bool _boiled = false;

    private ChocolateBoiler(){}

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