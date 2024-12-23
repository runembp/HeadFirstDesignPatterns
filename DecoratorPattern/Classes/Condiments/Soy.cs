using DecoratorPattern.Abstractions;

namespace DecoratorPattern.Classes.Condiments;

public class Soy : Condiment
{
    public Soy(Beverage? beverage)
    {
        Beverage = beverage;
    }
    
    public override string GetDescription()
    {
        return $"{Beverage.GetDescription()}, Soy";
    }

    public override double Cost()
    {
        return Beverage.Cost() + 0.15;
    }
}