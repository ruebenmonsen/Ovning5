using MainProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainProject.Vehicles;
using System.Collections.Generic;
using System;

namespace MainProject.Tests
{
    [TestClass()]
    public class GarageTest
    {
        [TestMethod()]
        public void GetParkedVehiclesTest()
        {
            // Arrange
            var myCar = new Car("abc123");
            IVehicle myBoat = new Boat("boatID123");
            IVehicle myCar2 = new Car("abc124");
            var garage = new Garage<IVehicle>(3, myBoat, myCar, myCar2);
            IVehicle[] expected = new IVehicle[3] { myBoat, myCar, myCar2 };

            // Act
            IVehicle[] actual = garage.GetParkedVehicles();

            // Assert
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
        }

        [TestMethod()]
        public void GetVehicleTypesTest()
        {
            // Arrange
            var myCar = new Car("abc123");
            IVehicle myBoat = new Boat("boatID123");
            IVehicle myCar2 = new Car("abc124");
            var garage = new Garage<IVehicle>(3, myBoat, myCar, myCar2);
            Dictionary<string, int> expected = new Dictionary<string, int>(){
                {"Boat", 1},
                {"Car", 2},
            };

            // Act
            var actual = garage.GetVehicleTypes();
            foreach (var item in actual)
            {
                Console.WriteLine(item.Key, item.Value);
            }

            // Assert
            Assert.AreEqual(expected["Car"], actual["Car"]);
            Assert.AreEqual(expected["Boat"], actual["Boat"]);

        }
    }
}