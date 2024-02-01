using SpeedAir.Interfaces;
using SpeedAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedAir.Services
{
    public class FlightRepository : IFlightRepository
    {
        private readonly IDataContext _dataContext;
        public FlightRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Flight> GetScheduledFlights()
        {
            return _dataContext.Flights.OrderBy(o => o.Day).ThenBy(o => o.ArrivalCity).ToList();
        }
    }
}
