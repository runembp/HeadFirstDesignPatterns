using StatePattern.Interfaces;

namespace StatePattern.Classes;

public class WinnerState(GumBallMachine gumBallMachine) : State
{
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
            gumBallMachine.State = gumBallMachine.SoldState;
            return;
        }
        
        gumBallMachine.ReleaseBall();
        Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");

        if (gumBallMachine.Count == 0)
        {
            Console.WriteLine("Ooops out of gumballs");
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