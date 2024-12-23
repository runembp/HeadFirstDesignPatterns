using StrategyPattern.Interfaces;

namespace StrategyPattern.Behaviors;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying!!");
    }
}