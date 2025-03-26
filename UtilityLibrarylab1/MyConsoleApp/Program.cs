using System;
using UtilityLibraries;
namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship("Poseidon", "Cargo", "New York", 50000, "Captain Smith", 25, new DateTime(2010, 5, 20), 30000, 20);
            Console.WriteLine($"Ship: {ship.Name}, Current Speed: {ship.CurrentSpeed} knots");
            ship.ChangeSpeed(5);
            Console.WriteLine($"New Speed: {ship.CurrentSpeed} knots");

            CargoShip cargoShip = new CargoShip("Titan", "Cargo", "Los Angeles", 75000, "Captain Brown", 30, new DateTime(2015, 8, 15), 40000, 15, "Coal", 200000);
            Console.WriteLine($"Cargo Ship: {cargoShip.Name}, Cargo Type: {cargoShip.CargoType}, Capacity: {cargoShip.CargoCapacity} tons");

            CruiseLiner cruiseLiner = new CruiseLiner("Ocean Queen", "Cruise", "Miami", 100000, "Captain Johnson", 50, new DateTime(2020, 2, 10), 50000, 25, 800, 200);
            Console.WriteLine($"Cruise Liner: {cruiseLiner.Name}, Occupied Seats: {cruiseLiner.OccupiedSeats}, Free Seats: {cruiseLiner.FreeSeats}");
        }
    }
}