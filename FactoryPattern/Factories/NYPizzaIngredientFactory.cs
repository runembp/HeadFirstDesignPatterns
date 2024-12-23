using FactoryPattern.Ingredients;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Factories;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public Dough CreateDough()
    {
        throw new NotImplementedException();
    }

    public Sauce CreateSauce()
    {
        throw new NotImplementedException();
    }

    public Cheese CreateCheese()
    {
        throw new NotImplementedException();
    }

    public Veggies[] CreateVeggies()
    {
        throw new NotImplementedException();
    }

    public Pepperoni CreatePepperoni()
    {
        throw new NotImplementedException();
    }

    public Clams CreateClam()
    {
        throw new NotImplementedException();
    }
}