using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    class Manager
    {
        public Garage<IVehicle> CreateGarage(int capacity)
        {
            
            return new Garage<IVehicle>(capacity);
        }
    }
}
