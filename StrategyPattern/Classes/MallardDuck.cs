using StrategyPattern.Abstractions;
using StrategyPattern.Behaviors;

namespace StrategyPattern.Classes;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        QuackBehavior = new LoudQuack();
        FlyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck!");
    }
}