using FactoryPattern.Abstractions;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Pizzas;

public class ClamPizza(IPizzaIngredientFactory ingredientFactory) : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
        Clam = ingredientFactory.CreateClam();
    }
}