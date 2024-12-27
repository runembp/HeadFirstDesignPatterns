using IteratorPattern.Interfaces;

namespace IteratorPattern.Classes;

public class MenuItemIterator(List<MenuItem> items) : Iterator<MenuItem>
{
    private int _position;

    public MenuItem Next()
    {
        var menuItem = items[_position];
        _position++;
        return menuItem;
    }

    public bool HasNext()
    {
        return _position < items.Count;
    }
    
    public void Remove()
    {
        throw new NotImplementedException();
    }
}