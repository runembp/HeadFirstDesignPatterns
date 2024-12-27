using IteratorPattern.Interfaces;

namespace IteratorPattern.Classes;

public class CafeMenu : IMenu
{
    private readonly Dictionary<string, MenuItem> _menuItems = new();

    public CafeMenu()
    {
        AddItem("Veggie Burger and Air Fries",
            "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
            true, 
            3.99);
        AddItem("Soup of the day",
            "A cup of the soup of the day, with a side salad",
            false, 
            3.69);
        AddItem("Burrito",
            "A large burrito, with whole pinto beans, salsa, guacamole",
            true, 
            4.29);
    }

    private void AddItem(string name, string description, bool vegetarian, double price)
    {
        var menuItem = new MenuItem(name, description, vegetarian, price);

        _menuItems.Add(name, menuItem);
    }

    public Iterator<MenuItem> CreateIterator()
    {
        var menuItemValues = _menuItems.Values.ToList();

        return new MenuItemIterator(menuItemValues);
    }
}