using StrategyPattern.Interfaces;

namespace StrategyPattern.Abstractions;

public abstract class Duck
{
    protected IFlyBehavior FlyBehavior;
    protected IQuackBehavior QuackBehavior;

    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }

    public void SetFlyBehavior(IFlyBehavior flyBehavior)
    {
        FlyBehavior = flyBehavior;
    }

    public void SetQuackBehavior(IQuackBehavior quackBehavior)
    {
        QuackBehavior = quackBehavior;
    }

    public void Swim()
    {
        Console.WriteLine("All Ducks swim - even model and decoy ducks");
    }
    
    public abstract void Display();
}