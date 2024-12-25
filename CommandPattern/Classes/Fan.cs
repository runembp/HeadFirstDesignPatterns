namespace CommandPattern.Classes;

public class Fan(string room)
{
    public string Room = room;

    public enum Speed
    {
        High = 3,
        Medium = 2,
        Low = 1,
        Off = 0
    }
    
    private Speed _speed = Speed.Off;

    public void High()
    {
        _speed = Speed.High;
    }

    public void Medium()
    {
        _speed = Speed.Medium;
    }

    public void Low()
    {
        _speed = Speed.Low;
    }

    public void Off()
    {
        _speed = Speed.Off;
    }

    public Speed GetSpeed()
    {
        return _speed;
    }
}