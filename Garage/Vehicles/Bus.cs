using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Vehicles
{
    public class Bus : Vehicle
    {
        private bool articulated;

        public Bus(string identifier) : base(identifier)
        {
        }

        public bool Articulated
        {
            get { return articulated; }
            set { articulated = value; }
        }
    }
}
