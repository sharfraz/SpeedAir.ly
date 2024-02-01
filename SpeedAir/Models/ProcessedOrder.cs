using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedAir.Models
{
    public class ProcessedOrder
    {
        public string OrderNo { get; set; }
        public int FlightNo { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public int Day { get; set; }
        public bool IsScheduled { get; set; }
    }
}
