using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;
using System;

namespace ShipLibraryTest
{
    [TestClass]
    public class ShipTests
    {
        [TestMethod]
        public void TestChangeSpeed()
        {
            Ship ship = new Ship("Poseidon", "Cargo", "New York", 50000, "Captain Smith", 25, new DateTime(2010, 5, 20), 30000, 20);
            ship.ChangeSpeed(5);
            double expectedSpeed = 25; // Початкова швидкість 20 + зміна 5
            Assert.AreEqual(expectedSpeed, ship.CurrentSpeed);
        }

        [TestMethod]
        public void TestCargoCapacity()
        {
            CargoShip cargoShip = new CargoShip("Titan", "Cargo", "Los Angeles", 75000, "Captain Brown", 30, new DateTime(2015, 8, 15), 40000, 15, "Coal", 200000);
            int expectedCapacity = 200000;
            Assert.AreEqual(expectedCapacity, cargoShip.CargoCapacity);
        }

        [TestMethod]
        public void TestFreeSeats()
        {
            CruiseLiner cruiseLiner = new CruiseLiner("Ocean Queen", "Cruise", "Miami", 100000, "Captain Johnson", 50, new DateTime(2020, 2, 10), 50000, 25, 800, 200);
            int expectedFreeSeats = 200;
            Assert.AreEqual(expectedFreeSeats, cruiseLiner.FreeSeats);
        }
    }
}

