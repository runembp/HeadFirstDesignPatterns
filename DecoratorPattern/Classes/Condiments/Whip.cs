using DecoratorPattern.Abstractions;

namespace DecoratorPattern.Classes.Condiments;

public class Whip : Condiment
{
    public Whip(Beverage? beverage)
    {
        Beverage = beverage;
    }
    
    public override string GetDescription()
    {
        return $"{Beverage.GetDescription()}, Whip";
    }

    public override double Cost()
    {
        return Beverage.Cost() + 0.10;
    }
}