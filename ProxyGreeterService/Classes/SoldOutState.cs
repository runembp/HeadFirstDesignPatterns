using ProxyGreeterService.Interfaces;

namespace ProxyGreeterService.Classes;

public class SoldOutState(GumBallMachine gumBallMachine) : State
{
    private const long SerialVersionUID = 2L;
    
    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert a quarter, the machine is sold out");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("No quarters have been inserted");
    }

    public void TurnCrank()
    {
        Console.WriteLine("There are no gumballs");
    }

    public void Dispense()
    {
        Console.WriteLine("Nothing dispensed");
    }

    public void Refill()
    {
        gumBallMachine.State = gumBallMachine.NoQuarterState;
    }
}