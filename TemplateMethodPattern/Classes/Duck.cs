namespace TemplateMethodPattern.Classes;

public class Duck(string name, int weight) : IComparable<Duck>
{
    private readonly int _weight = weight;
    
    public int CompareTo(Duck? otherDuck)
    {
        if (_weight < otherDuck._weight)
        {
            return -1;
        }

        if(_weight == otherDuck._weight)
        {
            return 0;
        }

        return 1;
    }

    public override string ToString()
    {
        return $"{name} weighs {_weight}";
    }
}