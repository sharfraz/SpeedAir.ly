using SpeedAir.Interfaces;
using SpeedAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedAir.Services
{
    public class StatsPrinter : IStatsPrinter
    {
        public StatsPrinter() 
        {
        }
        public void PrintFlightSchedules(List<Flight> flights)
        {
            Console.WriteLine("USER STORY #1");
            Console.WriteLine("Flight Schedule");
            foreach (Flight flight in flights)
            {
                Console.WriteLine($"Flight: {flight.FlightNo} departure: {flight.DepartureCity}, arrival: {flight.ArrivalCity}, day: {flight.Day}");
            }
        }
        public void PrintOrderStatus(List<ProcessedOrder> orders)
        {
            Console.WriteLine("");
            Console.WriteLine("USER STORY #2");
            Console.WriteLine("Order Status");
            foreach (ProcessedOrder order in orders)
            {
                if (order.IsScheduled)
                    Console.WriteLine($"order: {order.OrderNo}, flightNumber: {order.FlightNo}, departure: {order.DepartureCity}, arrival: {order.ArrivalCity}, day: {order.Day}");
                else
                    Console.WriteLine($"order: {order.OrderNo}, flightNumber: not scheduled");
            }
            
        }
    }
}
