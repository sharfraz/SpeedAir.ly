using SpeedAir.Interfaces;
using SpeedAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedAir.Services
{
    public class DataContext : IDataContext
    {
        public List<Flight> Flights { get; set; }
        public List<Order> Orders { get; set; }
        public DataContext()
        {
            Orders = new List<Order>
        {
            new Order { OrderNo = "order-001", Destination = "YYZ" },
            new Order { OrderNo = "order-002", Destination = "YYZ" },
            new Order { OrderNo = "order-003", Destination = "YYZ" },
            new Order { OrderNo = "order-004", Destination = "YYZ" },
            new Order { OrderNo = "order-005", Destination = "YYZ" },
            new Order { OrderNo = "order-006", Destination = "YYZ" },
            new Order { OrderNo = "order-007", Destination = "YYZ" },
            new Order { OrderNo = "order-008", Destination = "YYZ" },
            new Order { OrderNo = "order-009", Destination = "YYZ" },
            new Order { OrderNo = "order-010", Destination = "YYZ" },
            new Order { OrderNo = "order-011", Destination = "YYZ" },
            new Order { OrderNo = "order-012", Destination = "YYZ" },
            new Order { OrderNo = "order-013", Destination = "YYZ" },
            new Order { OrderNo = "order-014", Destination = "YYZ" },
            new Order { OrderNo = "order-015", Destination = "YYZ" },
            new Order { OrderNo = "order-016", Destination = "YYZ" },
            new Order { OrderNo = "order-017", Destination = "YYZ" },
            new Order { OrderNo = "order-018", Destination = "YYZ" },
            new Order { OrderNo = "order-019", Destination = "YYZ" },
            new Order { OrderNo = "order-020", Destination = "YYZ" },
            new Order { OrderNo = "order-021", Destination = "YYZ" },
            new Order { OrderNo = "order-022", Destination = "YYZ" },
            new Order { OrderNo = "order-023", Destination = "YYZ" },
            new Order { OrderNo = "order-024", Destination = "YYZ" },
            new Order { OrderNo = "order-025", Destination = "YYZ" },
            new Order { OrderNo = "order-026", Destination = "YYZ" },
            new Order { OrderNo = "order-027", Destination = "YYZ" },
            new Order { OrderNo = "order-028", Destination = "YYZ" },
            new Order { OrderNo = "order-029", Destination = "YYZ" },
            new Order { OrderNo = "order-030", Destination = "YYZ" },
            new Order { OrderNo = "order-031", Destination = "YYZ" },
            new Order { OrderNo = "order-032", Destination = "YYZ" },
            new Order { OrderNo = "order-033", Destination = "YYZ" },
            new Order { OrderNo = "order-034", Destination = "YYZ" },
            new Order { OrderNo = "order-035", Destination = "YYC" },
            new Order { OrderNo = "order-036", Destination = "YYC" },
            new Order { OrderNo = "order-037", Destination = "YYC" },
            new Order { OrderNo = "order-038", Destination = "YYC" },
            new Order { OrderNo = "order-039", Destination = "YYC" },
            new Order { OrderNo = "order-040", Destination = "YYC" },
            new Order { OrderNo = "order-041", Destination = "YYC" },
            new Order { OrderNo = "order-042", Destination = "YYC" },
            new Order { OrderNo = "order-043", Destination = "YYC" },
            new Order { OrderNo = "order-044", Destination = "YYC" },
            new Order { OrderNo = "order-045", Destination = "YYC" },
            new Order { OrderNo = "order-046", Destination = "YYC" },
            new Order { OrderNo = "order-047", Destination = "YYC" },
            new Order { OrderNo = "order-048", Destination = "YYC" },
            new Order { OrderNo = "order-049", Destination = "YYE" },
            new Order { OrderNo = "order-050", Destination = "YYC" },
            new Order { OrderNo = "order-051", Destination = "YYE" },
            new Order { OrderNo = "order-052", Destination = "YYC" },
            new Order { OrderNo = "order-053", Destination = "YYE" },
            new Order { OrderNo = "order-054", Destination = "YYC" },
            new Order { OrderNo = "order-055", Destination = "YYC" },
            new Order { OrderNo = "order-056", Destination = "YYC" },
            new Order { OrderNo = "order-057", Destination = "YYC" },
            new Order { OrderNo = "order-060", Destination = "YYC" },
            new Order { OrderNo = "order-061", Destination = "YYC" },
            new Order { OrderNo = "order-062", Destination = "YVR" },
            new Order { OrderNo = "order-063", Destination = "YVR" },
            new Order { OrderNo = "order-064", Destination = "YVR" },
            new Order { OrderNo = "order-065", Destination = "YVR" },
            new Order { OrderNo = "order-066", Destination = "YVR" },
            new Order { OrderNo = "order-067", Destination = "YVR" },
            new Order { OrderNo = "order-068", Destination = "YVR" },
            new Order { OrderNo = "order-069", Destination = "YVR" },
            new Order { OrderNo = "order-070", Destination = "YVR" },
            new Order { OrderNo = "order-071", Destination = "YVR" },
            new Order { OrderNo = "order-072", Destination = "YVR" },
            new Order { OrderNo = "order-073", Destination = "YVR" },
            new Order { OrderNo = "order-074", Destination = "YVR" },
            new Order { OrderNo = "order-075", Destination = "YVR" },
            new Order { OrderNo = "order-076", Destination = "YVR" },
            new Order { OrderNo = "order-077", Destination = "YVR" },
            new Order { OrderNo = "order-078", Destination = "YVR" },
            new Order { OrderNo = "order-080", Destination = "YVR" },
            new Order { OrderNo = "order-081", Destination = "YVR" },
            new Order { OrderNo = "order-082", Destination = "YVR" },
            new Order { OrderNo = "order-083", Destination = "YVR" },
            new Order { OrderNo = "order-084", Destination = "YVR" },
            new Order { OrderNo = "order-085", Destination = "YVR" },
            new Order { OrderNo = "order-086", Destination = "YVR" },
            new Order { OrderNo = "order-087", Destination = "YVR" },
            new Order { OrderNo = "order-088", Destination = "YVR" },
            new Order { OrderNo = "order-089", Destination = "YVR" },
            new Order { OrderNo = "order-090", Destination = "YVR" },
            new Order { OrderNo = "order-091", Destination = "YVR" },
            new Order { OrderNo = "order-092", Destination = "YVR" },
            new Order { OrderNo = "order-093", Destination = "YVR" },
            new Order { OrderNo = "order-094", Destination = "YVR" },
            new Order { OrderNo = "order-095", Destination = "YVR" },
            new Order { OrderNo = "order-096", Destination = "YVR" },
            new Order { OrderNo = "order-097", Destination = "YVR" },
            new Order { OrderNo = "order-098", Destination = "YVR" },
            new Order { OrderNo = "order-099", Destination = "YVR" }
        };
            Flights = new List<Flight>
            {
                new Flight{ FlightNo = 1, PlaneNo = 1, Day = 1, DepartureCity = "YUL", ArrivalCity = "YYZ", Capacity = 20 },
            new Flight{ FlightNo = 2, PlaneNo = 2, Day = 1, DepartureCity = "YUL", ArrivalCity = "YYC", Capacity = 20 },
            new Flight{ FlightNo = 3, PlaneNo = 3, Day = 1, DepartureCity = "YUL", ArrivalCity = "YVR", Capacity = 20 },
            new Flight{ FlightNo = 4, PlaneNo = 1, Day = 2, DepartureCity = "YUL", ArrivalCity = "YYZ", Capacity = 20 },
            new Flight{ FlightNo = 5, PlaneNo = 2, Day = 2, DepartureCity = "YUL", ArrivalCity = "YYC", Capacity = 20 },
            new Flight{ FlightNo = 6, PlaneNo = 3, Day = 2, DepartureCity = "YUL", ArrivalCity = "YVR", Capacity = 20 },
            };
        }
    }
}
