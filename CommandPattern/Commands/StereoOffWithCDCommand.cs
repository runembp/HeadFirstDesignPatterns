using CommandPattern.Classes;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands;

public class StereoOffWithCDCommand(Stereo stereo) : ICommand
{
    public void Execute()
    {
        stereo.SetVolume(0);
        stereo.Off();
    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}