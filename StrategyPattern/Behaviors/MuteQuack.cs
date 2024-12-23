using StrategyPattern.Interfaces;

namespace StrategyPattern.Behaviors;

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<<Silence>>");
    }
}