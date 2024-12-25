using CommandPattern.Interfaces;

namespace CommandPattern.Classes;

public class Command(Action execute) : ICommand
{
    public void Execute()
    {
        execute();
    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}