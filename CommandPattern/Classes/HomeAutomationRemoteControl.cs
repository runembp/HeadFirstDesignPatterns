using System.Text;
using CommandPattern.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern.Classes;

public class HomeAutomationRemoteControl
{
    private readonly ICommand[] _onCommands = new ICommand[7];
    private readonly ICommand[] _offCommands = new ICommand[7];
    private ICommand _undoCommand;

    public HomeAutomationRemoteControl()
    {
        var noCommand = new NoCommand();
        _undoCommand = noCommand;
        
        for (var i = 0; i < 7; i++)
        {
            _onCommands[i] = noCommand;
            _offCommands[i] = noCommand;
        }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
        _onCommands[slot].Execute();
        _undoCommand = _onCommands[slot];
    }
    
    public void OffButtonWasPushed(int slot)
    {
        _offCommands[slot].Execute();
        _undoCommand = _onCommands[slot];
    }

    public void UndoButtonWasPushed()
    {
        _undoCommand.Undo();
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        
        stringBuilder.Append("\n------ Remote Control -------\n");

        for (var i = 0; i < _onCommands.Length; i++)
        {
            stringBuilder.Append($"[slot {i}] {_onCommands[i]}    {_offCommands[i]}\n");
        }

        return stringBuilder.ToString();
    }
}