using CommandPattern.Classes;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands;

public class FanHighCommand(Fan fan) : ICommand
{
    private Fan.Speed _previouSpeed;

    public void Execute()
    {
        _previouSpeed = fan.GetSpeed();
        fan.High();
    }

    public void Undo()
    {
        switch (_previouSpeed)
        {
            case Fan.Speed.High:
                fan.High();
                break;
            case Fan.Speed.Medium:
                fan.Medium();
                break;
            case Fan.Speed.Low:
                fan.Low();
                break;
            case Fan.Speed.Off:
                fan.Off();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}