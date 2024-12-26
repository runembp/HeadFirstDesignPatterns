using AdapterPattern.Interfaces;

namespace AdapterPattern.Adapters;

public class TurkeyAdapter(Turkey turkey) : Duck
{
    public void Quack()
    {
        turkey.Gobble();
    }

    public void Fly()
    {
        for (var i = 0; i < 5; i++)
        {
            turkey.Fly();
        }
    }
}