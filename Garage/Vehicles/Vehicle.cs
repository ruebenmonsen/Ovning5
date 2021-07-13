using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(string identifier)
        {
            this.identifier = identifier;
        }
        private string identifier;
        public string Identifier
        {
            get { return identifier; }
            set { identifier = value; }
        }
        public virtual string Color { get; set; }
        public virtual string CountryOfOrigin { get; set; }
        public virtual string Manufacturer { get; set; }
        public virtual int ModelYear { get; set; }
    }
}