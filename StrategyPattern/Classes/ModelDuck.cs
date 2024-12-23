using StrategyPattern.Abstractions;
using StrategyPattern.Behaviors;

namespace StrategyPattern.Classes;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new MuteQuack();
    }
    
    public override void Display()
    {
        Console.WriteLine("I'm a Model duck");
    }
}