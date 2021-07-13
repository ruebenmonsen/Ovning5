using MainProject.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class Handler : IHandler
    {
        public IGarage<IVehicle> CreateGarage(Type type, int capacity)
        {
            return (IGarage<IVehicle>)Activator.CreateInstance(type, capacity);
        }


        // Vehicle handler class?
        public IVehicle CreateVehicle(Type type, string identifier)
        {
            return (IVehicle)Activator.CreateInstance(type, identifier);
        }

        public void SetProperties(IVehicle vehicle, string color, string country, string manufacturer, int year)
        {
            vehicle.Color = color;
            vehicle.CountryOfOrigin = country;
            vehicle.Manufacturer = manufacturer;
            vehicle.ModelYear = year;
        }
        // One method to change any property?
        public void SetColor(IVehicle vehicle, string color) => vehicle.Color = color;
        public void SetCountryOfOrigin(IVehicle vehicle, string country) => vehicle.CountryOfOrigin = country;
        public void SetManufacturer(IVehicle vehicle, string manufacturer) => vehicle.Manufacturer = manufacturer;
        public void SetModelyear(IVehicle vehicle, int year) => vehicle.ModelYear = year;

        // Specific vehicle properties
        public void SetWingspan(Airplane airplane, int wingspan) => airplane.Wingspan = wingspan;
        public void SetDisplacement(Boat boat, int displacement) => boat.Displacement = displacement;
        public void SetArticulated(Bus bus, bool articulated) => bus.Articulated = articulated;
        public void SetWheelDriveType(Car car, WheelDriveType wdtype) => car.WheelDrive = wdtype;
        public void SetSideCar(Motorcycle mc, bool sidecar) => mc.SideCar = sidecar;
    }
}