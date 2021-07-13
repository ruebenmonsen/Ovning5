using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public interface IVehicle
    {
        string Color { get; set; }
        string Identifier { get; set; }
        string CountryOfOrigin { get; set; }
        string Manufacturer { get; set; }
        int ModelYear { get; set; }
    }
}