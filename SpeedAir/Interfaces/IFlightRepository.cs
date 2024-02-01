using SpeedAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedAir.Interfaces
{
    public interface IFlightRepository
    {
        public List<Flight> GetScheduledFlights();
    }
}
