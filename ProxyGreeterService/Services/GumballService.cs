using Grpc.Core;
using ProxyGreeterService.Classes;

namespace ProxyGreeterService.Services;

public class GumballService(ILogger<GumballService> logger) : gumballRemote.gumballRemoteBase
{
    private const int GumballCount = 32;
    private const string Location = "Copenhagen";
    
    public override Task<CountReply> GetCount(CountRequest request, ServerCallContext context)
    {
        logger.Log(LogLevel.Information, "Retrieving count from Gumball Machine");

        var gumballMachine = new GumBallMachine(GumballCount, Location);
        
        return Task.FromResult(new CountReply
        {
            Message = gumballMachine.GetCount()
        });
    }

    public override Task<LocationReply> GetLocation(LocationRequest request, ServerCallContext context)
    {
        logger.Log(LogLevel.Information, "Retrieving location from Gumball Machine");

        var gumballMachine = new GumBallMachine(GumballCount, Location);
        
        return Task.FromResult(new LocationReply
        {
            Message = gumballMachine.GetLocation()
        });
    }
    
    public override Task<StateReply> GetState(StateRequest request, ServerCallContext context)
    {
        logger.Log(LogLevel.Information, "Retrieving state from Gumball Machine");

        var gumballMachine = new GumBallMachine(GumballCount, Location);
        
        return Task.FromResult(new StateReply
        {
            Message = gumballMachine.GetState().ToString()
        });
    }
}