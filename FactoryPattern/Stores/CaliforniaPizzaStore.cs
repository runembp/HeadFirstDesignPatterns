using FactoryPattern.Abstractions;
using FactoryPattern.Factories;
using FactoryPattern.Pizzas;

namespace FactoryPattern.Stores;

public class CaliforniaPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string pizzaType)
    {
        var pizzaIngredientFactory = new CaliforniaPizzaIngredientFactory();
        Pizza pizza;

        switch (pizzaType)
        {
            case "cheese":
                pizza = new CheesePizza(pizzaIngredientFactory);
                pizza.Name = "California Style Cheese Pizza";
                break;
            case "clam":
                pizza = new ClamPizza(pizzaIngredientFactory);
                pizza.Name = "California Style Clam Pizza";
                break;
            default:
                throw new Exception("Unknown pizza");
        }

        return pizza;
    }
}