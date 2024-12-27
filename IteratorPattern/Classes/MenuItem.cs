namespace IteratorPattern.Classes;

public class MenuItem(string name, string description, bool vegetarian, double price)
{
    public readonly string Name = name;
    public readonly string Description = description;
    public readonly bool Vegetarian = vegetarian;
    public readonly double Price = price;
}