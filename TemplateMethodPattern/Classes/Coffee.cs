namespace TemplateMethodPattern.Classes;

public class Coffee : CaffeineBeverage
{
    protected override void Brew()
    {
        Console.WriteLine("Dripping Coffee through filter");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding Sugar and Milk");
    }

    protected override bool CustomerWantsCondiments()
    {
        Console.WriteLine("Would you like milk and sugar with your coffee? (y/n)");
        var answer = Console.ReadLine()?.ToLower();

        return answer switch
        {
            "y" => true,
            "n" => false,
            _ => throw new Exception("Invalid input")
        };
    }
}