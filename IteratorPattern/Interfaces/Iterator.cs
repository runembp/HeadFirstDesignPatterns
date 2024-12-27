using IteratorPattern.Classes;

namespace IteratorPattern.Interfaces
{
    public interface Iterator<T>
    {
        bool HasNext();
        T? Next();
        void Remove();
    }
}