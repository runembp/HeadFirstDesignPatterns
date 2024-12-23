using FactoryPattern.Ingredients;

namespace FactoryPattern.Abstractions;

public abstract class Pizza
{
    public string? Name;
    public Dough? Dough;
    public Sauce? Sauce;
    public Veggies[] Veggies;
    public Cheese Cheese;
    public Pepperoni Pepperoni;
    public Clams Clam; 
    
    protected readonly List<string> Toppings = [];

    public abstract void Prepare(); 

    public void Bake()
    {
        Console.WriteLine("Baking for 25 minutes at 350f");    
    }

    public void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public override string ToString()
    {
        return Name;
    }
}