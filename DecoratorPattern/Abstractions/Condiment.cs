namespace DecoratorPattern.Abstractions;

public abstract class Condiment : Beverage
{
    protected Beverage? Beverage;
    public abstract override string GetDescription();
}