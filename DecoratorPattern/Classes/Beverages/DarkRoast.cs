using DecoratorPattern.Abstractions;

namespace DecoratorPattern.Classes;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Dark Roast coffee";
    }
    
    public override double Cost()
    {
        return 0.99;
    }
}