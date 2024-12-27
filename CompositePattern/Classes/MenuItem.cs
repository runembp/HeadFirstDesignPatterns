using CompositePattern.Abstractions;

namespace CompositePattern.Classes;

public class MenuItem(string name, string description, bool vegetarian, double price) : MenuComponent
{
    public override void Print()
    {
        Console.Write($"   {name}");
        if (vegetarian)
        {
            Console.Write("(v)");
        }

        Console.WriteLine($", {price}");
        Console.WriteLine($"    -- {description}");
    }
}