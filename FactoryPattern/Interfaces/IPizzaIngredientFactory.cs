using FactoryPattern.Ingredients;

namespace FactoryPattern.Interfaces;

public interface IPizzaIngredientFactory
{
    public Dough CreateDough();
    public Sauce CreateSauce();
    public Cheese CreateCheese();
    public Veggies[] CreateVeggies();
    public Pepperoni CreatePepperoni();
    public Clams CreateClam();
}