using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject
{
    public class Booking
    {
        public int Id { get; set; }
        public string BookingReference { get; set; }
        public DateTime BookingDate { get; set; } 
        public int SeatNumber { get; set; }
        public int PassengerId { get; set; }
        public virtual Passenger Passenger { get; set; }      
        public int FlightId { get; set; }
        public virtual Flight Flight { get; set; }

    }
}
