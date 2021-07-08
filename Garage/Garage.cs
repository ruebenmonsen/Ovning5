using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class Garage<T> : IGarage<T> where T : IVehicle
    {
        public Garage(int capacity)
        {
            this.capacity = capacity;
            vehicles = new IVehicle[this.capacity];
        }
        public Garage(int capacity, params IVehicle[] vehicles)
        {
            this.capacity = capacity;
            this.vehicles = new IVehicle[this.capacity];
            for (int i = 0; i < vehicles.Length; i++)
            {
                this.vehicles[i] = vehicles[i];
            }
        }

        private int capacity;
        private IVehicle[] vehicles;
        public IVehicle[] Vehicles
        {
            get { return vehicles; }
            set { vehicles = value; }
        }


        public IEnumerator<T> GetEnumerator()
        {
            yield return (T)Vehicles.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator() // explicit interface implementation
        {
            foreach (var item in Vehicles)
            {
                yield return item;
            }
        }
        public IVehicle[] GetParkedVehicles()
        {
            return Vehicles;
        }
        public Dictionary<string, int> GetVehicleTypes()
        {
            var dict = new Dictionary<string, int>();
            foreach (var vehicle in Vehicles)
            {
                // fix this
                if (dict.ContainsKey(TypeToString(vehicle))) dict[TypeToString(vehicle)]++;
                else dict.Add(TypeToString(vehicle), 1);
            };
            return dict;
        }
        public string TypeToString(IVehicle vehicle)
        {
            return vehicle.GetType().Name.ToString();
        }
        public bool ParkCar(IVehicle vehicle)
        {
            var success = false;
            for (int i = 0; i < Vehicles.Length; i++)
            {
                if (Vehicles[i] == null)
                {
                    success = true;
                    Vehicles[i] = vehicle;
                }
            }
            return success;
            
        }
        public bool RemoveCar(IVehicle vehicle)
        {
            var success = false;
            for (int i = 0; i < Vehicles.Length; i++)
            {
                if (Vehicles[i] == vehicle)
                {
                    success = true;
                    Vehicles[i] = null;
                }
            }
            return success;
        }
        /// <summary>
        /// Returns the vehicle corresponding to the given identifier, or null if no vehicle was found.
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public IVehicle FindVehicle(string identifier)
        {
            foreach (var vehicle in Vehicles)
            {
                if (vehicle.Identifier.ToLower() == identifier.ToLower()) return vehicle;
            }
            return null;
        }
        public List<IVehicle> SearchVehicles(params string[] criteria)
        {
            var list = new List<IVehicle>();
            foreach (var vehicle in Vehicles)
            {
                foreach (var criterion in criteria)
                {
                }
            }
            return list;
            
        }

    }
}