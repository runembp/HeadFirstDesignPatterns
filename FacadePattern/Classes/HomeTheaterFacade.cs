namespace FacadePattern.Classes;

public class HomeTheaterFacade(
    Amplifier amp, 
    Tuner tuner, 
    StreamingPlayer player, 
    Projector projector, 
    TheaterLights lights, 
    Screen screen, 
    PopcornPopper popper)
{
    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        popper.On();
        popper.Pop();
        lights.Dim(10);
        screen.Down();
        projector.On();
        projector.WideScreenMode();
        amp.On();
        amp.SetStreamingPlayer(player);
        amp.SetSurroundSound();
        amp.SetVolume(5);
        player.On();
        player.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting movie theater down...");
        popper.off();
        lights.on();
        screen.up();
        projector.off();
        amp.off();
        player.stop();
        player.off();
    }

    public void ListenToRadio()
    {
        
    }

    public void EndRadio()
    {
        
    }
}