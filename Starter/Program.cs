using CommandPattern.Classes;
using CommandPattern.Commands;
using CommandPattern.Interfaces;
using DecoratorPattern.Abstractions;
using DecoratorPattern.Classes;
using DecoratorPattern.Classes.Beverages;
using DecoratorPattern.Classes.Condiments;
using FactoryPattern.Stores;
using ObserverPattern.Classes;
using StrategyPattern.Behaviors;
using StrategyPattern.Classes;

// StrategyPattern();
// ObserverPattern();
// DecoratorPattern();
// FactoryPattern();
CommandPattern();
return;

void CommandPattern()
{
    var remote = new HomeAutomationRemoteControl();

    var livingRoomLight = new Light("Living Room");
    var kitchenLight = new Light("Living Room");
    var ceilingFan = new Fan("Living Room");
    var garageDoor = new GarageDoor("Garage");
    var stereo = new Stereo("Living Room");
    
    // remote.SetCommand(0, () => livingRoomLight.On(), () => livingRoomLight.Off());

    var lightOnCommand = new LightOnCommand(livingRoomLight);
    var stereoOnCommand = new StereoOnWithCDCommand(stereo);
    var fanHighCommand = new FanHighCommand(ceilingFan);
    
    var lightOffCommand = new LightOffCommand(livingRoomLight);
    var stereoOffCommand = new StereoOffWithCDCommand(stereo);
    var fanOffCommand = new FanOffCommand(ceilingFan);
    var partyOn = new MacroCommand([lightOnCommand, stereoOnCommand, fanHighCommand]);
    var partyOff = new MacroCommand([lightOffCommand, stereoOffCommand, fanOffCommand]);
    
    remote.SetCommand(0, lightOnCommand, lightOffCommand);
    remote.SetCommand(1, partyOn, partyOff);
    
    remote.OnButtonWasPushed(0);
    remote.UndoButtonWasPushed();
}

void FactoryPattern()
{
    var nyStore = new NYPizzaStore();
    var chicagoStore = new ChicagoPizzaStore();

    var newYorkCheesePizza = nyStore.OrderPizza("cheese");
    Console.WriteLine($"Ethan ordered a {newYorkCheesePizza.Name} \n");
    var chicagoCheesePizza = chicagoStore.OrderPizza("cheese");
    Console.WriteLine($"Joel ordered a {chicagoCheesePizza.Name} \n");
}

void DecoratorPattern()
{
    Beverage espresso = new Espresso();
    Console.WriteLine($"{espresso.GetDescription()} {espresso.Cost()}");

    Beverage? beverage2 = new DarkRoast();
    beverage2 = new Mocha(beverage2);
    beverage2 = new Mocha(beverage2);
    beverage2 = new Whip(beverage2);
    Console.WriteLine($"{beverage2.GetDescription()} {beverage2.Cost()}");

    Beverage? beverage3 = new HouseBlend();
    beverage3 = new Soy(beverage3);
    beverage3 = new Mocha(beverage3);
    beverage3 = new Whip(beverage3);
    Console.WriteLine($"{beverage3.GetDescription()} {beverage3.Cost()}");
}

void ObserverPattern()
{
    var weatherData = new WeatherData();
    new CurrentConditionsDisplay(weatherData);
    new StatisticsDisplay(weatherData);
    new ForecastDisplay(weatherData);
    new HeatIndexDisplay(weatherData);

    // Because every display is subscribed to the Weatherdata via their constructor, each of them are updated by the SetMeasurements method.
    weatherData.SetMeasurements(80, 65, 30.4f);
    weatherData.SetMeasurements(82, 70, 29.2f);
    weatherData.SetMeasurements(78, 90, 29.2f);
}

void StrategyPattern()
{
    var mallardDuck = new MallardDuck();
    mallardDuck.Display();
    mallardDuck.PerformFly();
    mallardDuck.PerformQuack();

    var modelDuck = new ModelDuck();
    modelDuck.Display();
    modelDuck.PerformFly();
    modelDuck.SetFlyBehavior(new FlyRocketPowered());
    modelDuck.PerformFly();
}