using IteratorPattern.Classes;

namespace IteratorPattern.Interfaces;

public interface IMenu
{
    Iterator<MenuItem> CreateIterator();
}