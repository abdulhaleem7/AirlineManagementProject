using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject
{
    public class Passenger
    {
        public int Id { get; set; }
        public string PassengerFirstName { get; set; }
        public string PassengerLastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string PassengerPersonalId { get; set; }
        List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
