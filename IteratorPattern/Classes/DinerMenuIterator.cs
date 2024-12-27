using IteratorPattern.Interfaces;

namespace IteratorPattern.Classes;

public class DinerMenuIterator(MenuItem?[] items) : Iterator<MenuItem>
{
    private int _position;
    
    public MenuItem? Next()
    {
        var menuItem = items[_position];
        _position++;

        return menuItem;
    }

    public bool HasNext()
    {
        return _position < items.Length && items[_position] != null;
    }
    
    public void Remove()
    {
        throw new NotSupportedException("You shouldn't be trying to remove menu items");
    }
}