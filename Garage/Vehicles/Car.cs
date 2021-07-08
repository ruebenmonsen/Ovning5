using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Vehicles
{
    public class Car : Vehicle
    {
        private WheelDriveType wheelDrive;

        public Car(string identifier) : base(identifier)
        {
        }

        public WheelDriveType WheelDrive
        {
            get { return wheelDrive; }
            set { wheelDrive = value; }
        }
    }
}