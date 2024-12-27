using IteratorPattern.Interfaces;

namespace IteratorPattern.Classes;

public class Waitress(List<IMenu> menus)
{
    public void PrintMenu()
    {
        var menuIterator = menus.GetEnumerator();

        while (menuIterator.MoveNext())
        {
            var menu = menuIterator.Current;
            var iterator = menu.CreateIterator();
            PrintMenuContents(iterator);
        }
    }

    private static void PrintMenuContents(Iterator<MenuItem> iterator)
    {
        while (iterator.HasNext())
        {
            var menuItem = iterator.Next();
            
            Console.Write($"{menuItem.Name}, ");
            Console.Write($"{menuItem.Price}, -- ");
            Console.WriteLine(menuItem.Description);
        }
    }
}