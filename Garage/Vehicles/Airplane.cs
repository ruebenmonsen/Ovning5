using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Vehicles
{
    class Airplane : Vehicle
    {
        private int wingspan;

        public Airplane(string identifier) : base(identifier)
        {
        }

        public int Wingspan
        {
            get { return wingspan; }
            set { wingspan = value; }
        }
    }
}
