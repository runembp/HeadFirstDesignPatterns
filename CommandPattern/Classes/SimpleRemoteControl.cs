using CommandPattern.Interfaces;

namespace CommandPattern.Classes;

public class SimpleRemoteControl
{
    private ICommand _slot;

    public void SetCommand(ICommand command)
    {
        _slot = command;
    }

    public void ButtedPressed()
    {
        _slot.Execute();
    }
}