using ProxyGreeterService.Interfaces;

namespace ProxyGreeterService.Classes;

public class SoldState(GumBallMachine gumBallMachine) : State
{
    private const long SerialVersionUID = 2L;

    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a gumball");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Sorry, you already turned the crank");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Turning twice doesn't get you another gumball.");
    }

    public void Dispense()
    {
        gumBallMachine.ReleaseBall();
        
        if (gumBallMachine.Count == 0)
        {
            Console.WriteLine("Oops, out of gumballs!");
            gumBallMachine.State = gumBallMachine.SoldOutState;
            return;
        }

        gumBallMachine.State = gumBallMachine.NoQuarterState;
    }

    public void Refill()
    {
        throw new NotImplementedException();
    }
}