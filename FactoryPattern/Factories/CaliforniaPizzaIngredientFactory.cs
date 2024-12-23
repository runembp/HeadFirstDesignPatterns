using FactoryPattern.Ingredients;
using FactoryPattern.Ingredients.Chicago;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Factories;

public class CaliforniaPizzaIngredientFactory : IPizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThickCrustDough();
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