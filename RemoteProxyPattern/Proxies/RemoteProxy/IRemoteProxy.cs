using RemoteProxyGumballMachineService;

namespace ProxyPattern.Proxies.RemoteProxy;

public interface IRemoteProxy
{
    Task<CountReply> GetCountFromGumballMachine();
}