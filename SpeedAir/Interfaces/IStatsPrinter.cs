using SpeedAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedAir.Interfaces
{
    public interface IStatsPrinter
    {
        public void PrintFlightSchedules(List<Flight> flights);
        public void PrintOrderStatus(List<ProcessedOrder> scheduled);
    }
}
