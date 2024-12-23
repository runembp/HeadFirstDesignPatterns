using StrategyPattern.Interfaces;

namespace StrategyPattern.Behaviors;

public class Squak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak!");
    }
}