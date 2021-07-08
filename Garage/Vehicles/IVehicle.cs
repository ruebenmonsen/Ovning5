using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public interface IVehicle
    {
        string Color { get; }
        string Identifier { get; }
        string CountryOfOrigin { get; }
        string Manufacturer { get; }
        int ModelYear { get; }
        int ServiceWeight { get; }
    }
}