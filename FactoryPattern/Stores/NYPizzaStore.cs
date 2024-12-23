using FactoryPattern.Abstractions;
using FactoryPattern.Factories;
using FactoryPattern.Pizzas;

namespace FactoryPattern.Stores;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string pizzaType)
    {
        var pizzaIngredientFactory = new NYPizzaIngredientFactory();
        Pizza pizza;

        switch (pizzaType)
        {
            case "cheese":
                pizza = new CheesePizza(pizzaIngredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
                break;
            case "clam":
                pizza = new ClamPizza(pizzaIngredientFactory);
                pizza.Name = "New York Style Clam Pizza";
                break;
            default:
                throw new Exception("Unknown pizza");
        }

        return pizza;
    }
}