namespace ProxyGreeterService.Interfaces;

public interface IGumballMachineRemote
{
    public int GetCount();
    public string GetLocation();
    public State GetState();
}