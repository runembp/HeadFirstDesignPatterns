namespace TemplateMethodPattern.Classes;

public abstract class CaffeineBeverage
{
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
    }

    protected abstract void Brew();
    protected abstract void AddCondiments();

    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    private void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    protected virtual bool CustomerWantsCondiments()
    {
        return true;
    }
}