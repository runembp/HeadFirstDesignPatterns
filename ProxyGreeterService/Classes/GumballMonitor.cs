namespace ProxyGreeterService.Classes;

public class GumballMonitor(GumBallMachine gumBallMachine)
{
    public void Report()
    {
        Console.WriteLine($"Gumball Machine: {gumBallMachine.Location}");
        Console.WriteLine($"Current inventory: {gumBallMachine.Count} gumballs");
        Console.WriteLine($"Current state: {gumBallMachine.State}");
    }    
}