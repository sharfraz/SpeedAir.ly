using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedAir.Models
{
    public class Flight
    {
        public int FlightNo { get; set; }
        public int PlaneNo { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public int Day { get; set; }
        public int Capacity { get; set; }
    }
}
