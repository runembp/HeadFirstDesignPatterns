using StatePattern.Interfaces;

namespace StatePattern.Classes;

public class HasQuarterState(GumBallMachine gumBallMachine) : State
{

    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert another quarter");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Quarter returned");
        gumBallMachine.State = gumBallMachine.NoQuarterState;
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned...");

        var randomWinnerNumberGenerator = new Random();
        var winnerNumber = randomWinnerNumberGenerator.Next(10);
        var hasWon = winnerNumber == 0 && gumBallMachine.Count > 1;

        if (hasWon)
        {
            gumBallMachine.State = gumBallMachine.WinnerState;
            return;
        }

        gumBallMachine.State = gumBallMachine.SoldState;
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }

    public void Refill()
    {
        throw new NotImplementedException();
    }
}