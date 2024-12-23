using DecoratorPattern.Abstractions;

namespace DecoratorPattern.Classes.Beverages;

public class Decaf : Beverage
{
    public Decaf()
    {
        Description = "Decaf";
    }

    public override double Cost()
    {
        return 1.05;
    }
}