using AdapterPattern.Interfaces;

namespace AdapterPattern.Adapters;

public class DuckAdapter(Duck duck) : Turkey
{
    public void Gobble()
    {
        duck.Quack();
    }

    public void Fly()
    {
        duck.Fly();
    }
}