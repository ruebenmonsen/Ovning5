using MainProject.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class Manager
    {
        private IUI ui;
        private IHandler handler;
        public Manager(IUI ui, IHandler handler)
        {
            this.ui = ui;
            this.handler = handler;
            StartMenuLogic();
        }

        private void StartMenuLogic()
        {
            char choice;
            do
            {
                ui.Print(MainMenu);
                choice = (char)ui.GetKey();
                switch (choice)
                {
                    case '1':
                        // Desierable to only have the methods but created object lacks scope, fix
                        // IGarage desirable
                        // Move the instance of the garage to the handler?
                        var capacity = GarageCreationMenu();
                        var newGarage = (Garage<IVehicle>)handler.CreateGarage(typeof(Garage<IVehicle>), capacity);
                        GarageMenuLogic(newGarage);
                        break;
                    case '2':
                        var capacity2 = GarageCreationMenu();
                        var newGarage2 = (Garage<IVehicle>)handler.CreateGarage(typeof(Garage<IVehicle>), capacity2);
                        GarageMenuLogic(newGarage2);
                        break;
                    case '0':
                        break;
                    default:
                        ui.Print("Please enter valid input.");
                        break;
                }
            } while (choice != '0');

        }

        private int GarageCreationMenu()
        {
            ui.Print("\nChoose how many parking spots your garage has and press ENTER.");
            var strCapacity = ui.GetString();
            int capacity = int.Parse(strCapacity);
            ui.Print($"\nSuccess! A new garage was created with {capacity} parking spots.");
            return capacity;
        }

        private void GarageMenuLogic(Garage<IVehicle> garage)
        {
            char choice;
            do
            {
                ui.Print(GarageMenu);
                choice = (char)ui.GetKey();
                switch (choice)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        VehicleCreationMenu();
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '0':
                        break;
                    default:
                        ui.Print("Please enter valid input.");
                        break;
                }
            } while (choice != '0');
        }

        private void VehicleCreationMenu()
        {
            ui.Print("1. Airplane" +
                "\n2. Boat" +
                "\n3. Bus" +
                "\n4. Car" +
                "\n5. Motorcycle" +
                "\n0. Return to previous menu");
            var choice = (char)ui.GetKey();
            ui.Print("Please specify the identifier of your vehicle");
            var givenVehicleId = ui.GetString();
            switch (choice)
            {
                case '1':
                    var airplane = new Airplane(givenVehicleId);
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                case '5':
                    break;
                case '0':
                    break;
                default:
                    break;
            }

        }

        public string MainMenu =
                   "1. Create an empty garage" +
                 "\n2. Create a garage with vehicles" +
                 "\n0. Exit the program";

        public string GarageMenu =
                 "\n1. List parked vehicles" +
                 "\n2. List vehicle types and amount" +
                 "\n3. Add a new vehicle to the garage" +
                 "\n4. Remove a vehicle from the garage" +
                 "\n5. Find a vehicle in the garage" +
                 "\n6. Search for vehicles by properties" +
                 "\n0. Exit the garage menu";
    }
}
