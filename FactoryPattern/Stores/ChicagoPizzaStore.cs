using FactoryPattern.Abstractions;
using FactoryPattern.Factories;
using FactoryPattern.Interfaces;
using FactoryPattern.Pizzas;

namespace FactoryPattern.Stores;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string pizzaType)
    {
        IPizzaIngredientFactory pizzaIngredientFactory = new ChicagoPizzaIngredientFactory();
        Pizza pizza;

        switch (pizzaType)
        {
            case "cheese":
                pizza = new CheesePizza(pizzaIngredientFactory);
                pizza.Name = "Chicago Style Cheese Pizza";
                break;
            case "clam":
                pizza = new ClamPizza(pizzaIngredientFactory);
                pizza.Name = "Chicago Style Clam Pizza";
                break;
            default:
                throw new Exception("Unknown pizza");
        }

        return pizza;
    }
}