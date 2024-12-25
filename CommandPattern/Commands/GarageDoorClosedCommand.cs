using CommandPattern.Classes;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands;

public class GarageDoorOpenCommand(GarageDoor garageDoor) : ICommand
{
    public void Execute()
    {
        garageDoor.Up();
        garageDoor.Stop();
    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}