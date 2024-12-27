using CompositePattern.Abstractions;

namespace CompositePattern.Classes;

public class Waitress(MenuComponent allMenus) 
{
    public void PrintMenu()
    {
        allMenus.Print();
    }
}