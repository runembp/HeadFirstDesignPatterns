using IteratorPattern.Interfaces;

namespace IteratorPattern.Classes;

public class DinerMenu : IMenu
{
    private const int Max_Items = 6;
    private int _numberOfItems;
    private readonly MenuItem?[] _menuItems;

    public DinerMenu()
    {
        _menuItems = new MenuItem[Max_Items];
        
        AddItem("Vegetarian BLT",
            "(Fakin') Bacon with lettuce & tomato on whole wheat", 
            true, 
            2.99);
        AddItem("BLT",
            "Bacon with lettuce & tomato on whole wheat", 
            false, 
            2.99);
        AddItem("Soup of the day",
            "Soup of the day, with a side of potato salad", 
            false, 
            3.29);
        AddItem("Hotdog",
            "A hot dog, with sauerkraut, relish, onions, topped with cheese",
            false, 
            3.05);
    }

    private void AddItem(string name, string description, bool vegetarian, double price)
    {
        var menuItem = new MenuItem(name, description, vegetarian, price);

        if (_numberOfItems >= Max_Items)
        {
            Console.WriteLine("Sorry, menu is full!  Can't add item to menu");
        }
        else
        {
            _menuItems[_numberOfItems] = menuItem;
            _numberOfItems += 1;
        }
    }

    public Iterator<MenuItem> CreateIterator()
    {
        return new DinerMenuIterator(_menuItems);
    }
}