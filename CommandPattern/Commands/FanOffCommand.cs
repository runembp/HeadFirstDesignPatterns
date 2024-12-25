using CommandPattern.Classes;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands;

public class FanOffCommand(Fan fan) : ICommand
{
    public void Execute()
    {
        fan.Off();
    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}