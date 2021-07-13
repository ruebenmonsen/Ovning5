using MainProject.Vehicles;
using System;

namespace MainProject
{
    public interface IHandler
    {
        IGarage<IVehicle> CreateGarage(Type type, int capacity);
        IVehicle CreateVehicle(Type type, string identifier);
        void SetArticulated(Bus bus, bool articulated);
        void SetColor(IVehicle vehicle, string color);
        void SetCountryOfOrigin(IVehicle vehicle, string country);
        void SetDisplacement(Boat boat, int displacement);
        void SetManufacturer(IVehicle vehicle, string manufacturer);
        void SetModelyear(IVehicle vehicle, int year);
        void SetProperties(IVehicle vehicle, string color, string country, string manufacturer, int year);
        void SetSideCar(Motorcycle mc, bool sidecar);
        void SetWheelDriveType(Car car, WheelDriveType wdtype);
        void SetWingspan(Airplane airplane, int wingspan);
    }
}