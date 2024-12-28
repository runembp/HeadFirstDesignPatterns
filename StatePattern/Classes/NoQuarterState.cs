using StatePattern.Interfaces;

namespace StatePattern.Classes;

public class NoQuarterState(GumBallMachine gumBallMachine) : State
{
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

    public void Refill()
    {
        throw new NotImplementedException();
    }
}