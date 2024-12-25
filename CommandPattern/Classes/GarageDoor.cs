namespace CommandPattern.Classes;

public class GarageDoor(string garage)
{
    public string Room = garage;
    
    public void Up()
    {
        Console.WriteLine("Going up!");
    }

    public void Down()
    {
        
    }

    public void Stop()
    {
        Console.WriteLine("Garage Door is open");
    }

    public void LightOn()
    {
        Console.WriteLine("Lights are on!");
    }

    public void LightOff()
    {
        
    }
}