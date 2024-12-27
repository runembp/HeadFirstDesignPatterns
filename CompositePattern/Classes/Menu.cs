using CompositePattern.Abstractions;

namespace CompositePattern.Classes;

public class Menu(string name, string description) : MenuComponent
{
    private readonly List<MenuComponent> _menuComponents = [];

    public override void Add(MenuComponent menuComponent)
    {
        _menuComponents.Add(menuComponent);
    }

    public override void Remove(MenuComponent menuComponent)
    {
        _menuComponents.Remove(menuComponent);
    }

    public override MenuComponent GetChild(int i)
    {
        return _menuComponents[i];
    }

    public override void Print()
    {
        Console.Write($"\n{name}");
        Console.WriteLine($", {description}");
        Console.WriteLine("----------------");

        foreach (var menuComponent in _menuComponents)
        {
            menuComponent.Print();
        }
    }
}