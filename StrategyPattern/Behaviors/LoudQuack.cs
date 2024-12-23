using StrategyPattern.Interfaces;

namespace StrategyPattern.Behaviors;

public class LoudQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack!!");
    }
}