using SpeedAir.Interfaces;
using SpeedAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedAir.Services
{
    public class OrderProcessor : IOrderProcessor
    {
        public OrderProcessor() 
        {
        }
        public List<ProcessedOrder> ProcessOrders(List<Flight> flights, List<Order> orders)
        {
            List<ProcessedOrder> processedOrders = new List<ProcessedOrder>();
            foreach(var flight in flights.OrderBy(o => o.Day))
            {
                var ordersToProcess = orders.Where(w => w.Destination == flight.ArrivalCity && !processedOrders.Select(s=>s.OrderNo).Contains(w.OrderNo)).Take(flight.Capacity);
                if(ordersToProcess.Any())
                   processedOrders.AddRange(ordersToProcess.Select(s => new ProcessedOrder 
                   { 
                       OrderNo = s.OrderNo, 
                       FlightNo = flight.FlightNo,
                       DepartureCity = flight.DepartureCity,
                       ArrivalCity = flight.ArrivalCity,
                       Day = flight.Day,
                       IsScheduled = true,
                   }).ToList());
            }
            var nonScheduledOrders = orders.Where(w => !processedOrders.Select(s => s.OrderNo).Contains(w.OrderNo));
            processedOrders.AddRange(nonScheduledOrders.Select(s => new ProcessedOrder { OrderNo = s.OrderNo, IsScheduled = false }));
            return processedOrders;
        }
    }
}
