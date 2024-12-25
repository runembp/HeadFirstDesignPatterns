namespace CommandPattern.Classes;

public class Light(string name)
{
    public string Name = name;

    public void On()
    {
        Console.WriteLine("Light turned on!");
    }
    
    public void Off()
    {
        Console.WriteLine("Light turned off!");
    }
}