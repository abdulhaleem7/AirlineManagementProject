using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject
{
    public class AirCraft
    {
        public int Id { get; set; }
        public string AircraftName { get; set; }
        public int Capacity { get; set; }
        public string RegistrationNumber { get; set; }
        public string IdentificationNumber { get; set; }
        public virtual List<Flight> flight { get; set; } = new List<Flight>();

    }

}
