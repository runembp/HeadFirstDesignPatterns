using CommandPattern.Classes;
using CommandPattern.Commands;
using CompositePattern.Abstractions;
using CompositePattern.Classes;
using DecoratorPattern.Abstractions;
using DecoratorPattern.Classes;
using DecoratorPattern.Classes.Beverages;
using DecoratorPattern.Classes.Condiments;
using FacadePattern.Classes;
using FactoryPattern.Stores;
using ObserverPattern.Classes;
using StatePattern;
using StatePattern.Classes;
using TemplateMethodPattern.Classes;

// StrategyPattern();
// ObserverPattern();
// DecoratorPattern();
// FactoryPattern();
// CommandPattern();
// AdapterPattern();
// FacadePattern();
// TemplateMethodPattern();
// IteratorPattern();
// CompositePattern();
// StatePattern();
ProxyPattern();
return;

void ProxyPattern()
{
    const int count = 112;
    const string location = "Austin";

    var gumballMachine = new GumBallMachine(112, location);
    var gumballMonitor = new GumballMonitor(gumballMachine);
    
    gumballMonitor.Report();
}


void StatePattern()
{
    var gumballMachine = new GumBallMachine(1, "");
    Console.WriteLine(gumballMachine);
    
    gumballMachine.InsertQuarter();
    gumballMachine.TurnCrank();
    Console.WriteLine(gumballMachine);
    
    gumballMachine.InsertQuarter();
    gumballMachine.TurnCrank();
    Console.WriteLine(gumballMachine);

    gumballMachine.InsertQuarter();
    gumballMachine.TurnCrank();
    Console.WriteLine(gumballMachine);
}

void CompositePattern()
{
    MenuComponent panCakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
    MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
    MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
    MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");
    MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

    dinerMenu.Add(new MenuItem(
        "Pasta",
        "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
        true,
        3.89));

    dessertMenu.Add(new MenuItem(
        "Apple Pie",
        "Apple pie with a flakey crust, topped with vanilla ice cream",
        true,
        1.59));

    allMenus.Add(panCakeHouseMenu);
    allMenus.Add(dinerMenu);
    allMenus.Add(cafeMenu);
    dinerMenu.Add(dessertMenu);

    var waitress = new Waitress(allMenus);
    waitress.PrintMenu();
}

void IteratorPattern()
{
    // var pancakeHouseMenu = new PanCakeHouseMenu();
    // var dinerMenu = new DinerMenu();
    // var cafeMenu = new CafeMenu();
    // var waitress = new Waitress([pancakeHouseMenu, dinerMenu, cafeMenu]);
    // waitress.PrintMenu();
}

void TemplateMethodPattern()
{
    var tea = new Tea();
    tea.PrepareRecipe();

    var coffee = new Coffee();
    coffee.PrepareRecipe();

    var ducks = new List<Duck>
    {
        new("Daffy", 8),
        new("Dewey", 2),
        new("Howard", 7),
        new("Louie", 2),
        new("Donald", 10),
        new("Huey", 2)
    };

    Console.WriteLine("Before sorting");
    Display(ducks);

    ducks.Sort();

    Console.WriteLine("\nAfter sorting");
    Display(ducks);
    return;

    void Display(List<Duck> ducks)
    {
        foreach (var duck in ducks)
        {
            Console.WriteLine(duck);
        }
    }
}

void FacadePattern()
{
    var amp = new Amplifier();
    var popper = new PopcornPopper();
    var projector = new Projector();
    var screen = new Screen();
    var player = new StreamingPlayer();
    var lights = new TheaterLights();
    var tuner = new Tuner();

    var homeTheater = new HomeTheaterFacade(amp, tuner, player, projector, lights, screen, popper);
    homeTheater.WatchMovie("Snoop");
    homeTheater.EndMovie();
}

void AdapterPattern()
{
    // var mallardDuck = new MallardDuck();
    // var turkey = new WildTurkey();
    // var turkeyAdapter = new TurkeyAdapter(turkey);
    //
    // Console.WriteLine("The Turkey says:");
    // turkey.Gobble();
    // turkey.Fly();
    //
    // Console.WriteLine("The duck says:");
    // TestDuck(mallardDuck);
    //
    // Console.WriteLine("The Turkey Adapter says");
    // TestDuck(turkeyAdapter);
    //
    // return;
    //
    // void TestDuck(Duck duck)
    // {
    //     duck.Quack();
    //     duck.Fly();
    // }
}

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
    //     var mallardDuck = new MallardDuck();
    //     mallardDuck.Display();
    //     mallardDuck.PerformFly();
    //     mallardDuck.PerformQuack();
    //
    //     var modelDuck = new ModelDuck();
    //     modelDuck.Display();
    //     modelDuck.PerformFly();
    //     modelDuck.SetFlyBehavior(new FlyRocketPowered());
    //     modelDuck.PerformFly();v
}