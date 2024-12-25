using CommandPattern.Classes;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands;

public class LightOffCommand(Light light) : ICommand
{
    public void Execute()
    {
        light.Off();
    }

    public void Undo()
    {
        light.On();
    }
}