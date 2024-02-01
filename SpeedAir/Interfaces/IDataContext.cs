using SpeedAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedAir.Interfaces
{
    public interface IDataContext
    {
        public List<Flight> Flights { get; set; }
        public List<Order> Orders { get; set; }
    }
}
