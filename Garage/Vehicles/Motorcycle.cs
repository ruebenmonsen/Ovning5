using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Vehicles
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string identifier) : base(identifier)
        {
        }
        public bool SideCar { get; set; }
    }
}