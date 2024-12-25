using CommandPattern.Classes;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands;

public class StereoOnWithCDCommand(Stereo stereo) : ICommand
{
    public void Execute()
    {
        stereo.On();
        stereo.SetCD();
        stereo.SetVolume(11);
    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}