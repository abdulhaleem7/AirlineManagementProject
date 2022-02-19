using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject
{
    public class Flight
    {
        public int Id { get; set; }
        public Location TakeOfPoint { get; set; }
        public Location LandingPoint { get; set; }
        public DateTime TakeOffTime { get; set; }
        public DateTime LandingTime { get; set; }
        public Decimal Price { get; set; }
        public int AvailableSit { get; set; }
        public FlightType FlightTypes { get; set; }
        public int AirCraftId { get; set; }
        public virtual AirCraft AirCraft { get; set; }
        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
