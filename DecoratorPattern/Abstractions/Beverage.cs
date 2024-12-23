namespace DecoratorPattern.Abstractions;

public abstract class Beverage
{
    protected string Description = "Unknown beverage";
    
    public virtual string GetDescription()
    {
        return Description;
    }

    public abstract double Cost();
}