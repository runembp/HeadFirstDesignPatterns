using StrategyPattern.Interfaces;

namespace StrategyPattern.Behaviors;

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with Rockets!!");
    }
}