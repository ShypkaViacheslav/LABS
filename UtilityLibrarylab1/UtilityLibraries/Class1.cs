namespace UtilityLibraries;

public class Ship
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string HomePort { get; set; }
    public double Displacement { get; set; }
    public string Captain { get; set; }
    public int CrewCount { get; set; }
    public DateTime LaunchDate { get; set; }
    public double EnginePower { get; set; }
    public double CurrentSpeed { get; private set; }

    public Ship(string name, string type, string homePort, double displacement, string captain, int crewCount, DateTime launchDate, double enginePower, double currentSpeed)
    {
        Name = name;
        Type = type;
        HomePort = homePort;
        Displacement = displacement;
        Captain = captain;
        CrewCount = crewCount;
        LaunchDate = launchDate;
        EnginePower = enginePower;
        CurrentSpeed = currentSpeed;
    }

    public void ChangeSpeed(double delta)
    {
        CurrentSpeed += delta;
        if (CurrentSpeed < 0) CurrentSpeed = 0;
    }
}

public class CargoShip : Ship
{
    public string CargoType { get; set; }
    public double CargoCapacity { get; set; }

    public CargoShip(string name, string type, string homePort, double displacement, string captain, int crewCount, DateTime launchDate, double enginePower, double currentSpeed, string cargoType, double cargoCapacity)
        : base(name, type, homePort, displacement, captain, crewCount, launchDate, enginePower, currentSpeed)
    {
        CargoType = cargoType;
        CargoCapacity = cargoCapacity;
    }
}

public class CruiseLiner : Ship
{
    public int OccupiedSeats { get; set; }
    public int FreeSeats { get; set; }

    public CruiseLiner(string name, string type, string homePort, double displacement, string captain, int crewCount, DateTime launchDate, double enginePower, double currentSpeed, int occupiedSeats, int freeSeats)
        : base(name, type, homePort, displacement, captain, crewCount, launchDate, enginePower, currentSpeed)
    {
        OccupiedSeats = occupiedSeats;
        FreeSeats = freeSeats;
    }
}

