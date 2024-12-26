using AdapterPattern.Interfaces;

namespace AdapterPattern.Classes;

public class WildTurkey : Turkey
{
    public void Gobble()
    {
        Console.WriteLine("Gobble gobble");
    }

    public void Fly()
    {
        Console.WriteLine("I'm flying a short distance");
    }
}