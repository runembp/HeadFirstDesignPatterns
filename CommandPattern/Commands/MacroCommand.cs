using CommandPattern.Interfaces;

namespace CommandPattern.Commands;

public class MacroCommand(ICommand[] commands) : ICommand
{
    public void Execute()
    {
        foreach (var command in commands)
        {
            command.Execute();
        }
    }

    public void Undo()
    {
        foreach (var command in commands)
        {
            command.Undo();
        }
    }
}