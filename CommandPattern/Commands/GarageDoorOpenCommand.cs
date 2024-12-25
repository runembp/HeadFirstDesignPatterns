using CommandPattern.Classes;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands;

public class GarageDoorClosedCommand(GarageDoor garageDoor) : ICommand
{
    public void Execute()
    {
        garageDoor.Down();
        garageDoor.Stop();
    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}