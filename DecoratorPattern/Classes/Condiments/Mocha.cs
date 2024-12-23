using DecoratorPattern.Abstractions;

namespace DecoratorPattern.Classes.Condiments;

public class Mocha : Condiment
{
    public Mocha(Beverage? beverage)
    {
        Beverage = beverage;
    }
    
    public override string GetDescription()
    {
        return $"{Beverage.GetDescription()}, Mocha";
    }

    public override double Cost()
    {
        return Beverage.Cost() + 0.20;
    }
}