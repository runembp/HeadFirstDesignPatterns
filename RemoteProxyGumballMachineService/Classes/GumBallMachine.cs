using RemoteProxyGumballMachineService.Interfaces;

namespace RemoteProxyGumballMachineService.Classes;

[Serializable]
public class GumBallMachine : IGumballMachineRemote
{
    private const long SerialVersionUID = 2L;
    public readonly State SoldOutState;
    public readonly State NoQuarterState;
    public readonly State HasQuarterState;
    public readonly State SoldState;
    public readonly State WinnerState;
    public readonly string Location;
    public State State;
    public int Count;

    public GumBallMachine(int count, string location)
    {
        Count = count;
        Location = location;
        
        SoldOutState = new SoldOutState(this);
        NoQuarterState = new NoQuarterState(this);
        HasQuarterState = new HasQuarterState(this);
        SoldState = new SoldState(this);
        WinnerState = new WinnerState(this);

        State = count > 0
            ? NoQuarterState
            : SoldOutState;
    }

    public void InsertQuarter()
    {
        State.InsertQuarter();
    }

    public void TurnCrank()
    {
        State.TurnCrank();
        State.Dispense();

        if (Count > 0)
        {
            return;
        }
        
        Refill(10);
        State.Refill();
    }

    private void Refill(int refillCount)
    {
        Count += refillCount;
        Console.WriteLine($"The gumball machine has just refilled: the new count is {Count}");
    }

    public void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling out of the slot");

        if (Count > 0)
        {
            Count--;
        }
    }

    public override string ToString()
    {
        return $"Gumball Machine! {Count}";
    }

    public int GetCount()
    {
        return Count;
    }

    public string GetLocation()
    {
        return Location;
    }

    public State GetState()
    {
        return State;
    }
}