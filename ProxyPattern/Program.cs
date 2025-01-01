using ProxyPattern.Proxies.RemoteProxy;

namespace ProxyPattern;

internal static class Program
{
    private static async Task Main()
    {
        var remoteProxy = new RemoteProxy();
        var proxyGreeting = await remoteProxy.GetCountFromGumballMachine();
        var proxyLocation = await remoteProxy.GetLocationFromGumballMachine();
        var proxyState = await remoteProxy.GetStateFromGumballMachine();

        Console.WriteLine(proxyGreeting);
        Console.WriteLine(proxyLocation);
        Console.WriteLine(proxyState);
    }
}