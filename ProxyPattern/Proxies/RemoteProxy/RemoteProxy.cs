using Grpc.Net.Client;
using ProxyGreeterService;

namespace ProxyPattern.Proxies.RemoteProxy;

public class RemoteProxy : IRemoteProxy
{
    public async Task<CountReply> GetCountFromGumballMachine()
    {
        using var channel = GrpcChannel.ForAddress("https://localhost:7083");
        var client = new gumballRemote.gumballRemoteClient(channel);

        return await client.GetCountAsync(new CountRequest());
    }
    
    public async Task<LocationReply> GetLocationFromGumballMachine()
    {
        using var channel = GrpcChannel.ForAddress("https://localhost:7083");
        var client = new gumballRemote.gumballRemoteClient(channel);

        return await client.GetLocationAsync(new LocationRequest());
    }
    
    public async Task<StateReply> GetStateFromGumballMachine()
    {
        using var channel = GrpcChannel.ForAddress("https://localhost:7083");
        var client = new gumballRemote.gumballRemoteClient(channel);

        return await client.GetStateAsync(new StateRequest());
    }
}