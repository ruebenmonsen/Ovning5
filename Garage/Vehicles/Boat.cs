using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Vehicles
{
    public class Boat : Vehicle
    {
        private int displacement;

        public Boat(string identifier) : base(identifier)
        {
        }

        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }
    }
}
