using ProxyGreeterService.Interfaces;

namespace ProxyGreeterService.Classes;

public class NoQuarterState(GumBallMachine gumBallMachine) : State
{
    private const long SerialVersionUID = 2L;
    
    public void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter");
        gumBallMachine.State = gumBallMachine.HasQuarterState;
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You haven't inserted a quarter.");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned, but there is no quarter");
    }

    public void Dispense()
    {
        Console.WriteLine("You need to pay first");
    }

    public override string ToString()
    {
        return "Waiting for quarter";
    }

    public void Refill()
    {
        throw new NotImplementedException();
    }
}