using SpeedAir.Interfaces;
using SpeedAir.Models;
using SpeedAir.Services;

namespace SpeedAir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize data context
            IDataContext dataContext = new DataContext();

            //Get flight schedules
            IFlightRepository flightRepository = new FlightRepository(dataContext);
            var flights = flightRepository.GetScheduledFlights();

            //Get orders
            IOrderRepository orderRepository = new OrderRepository(dataContext);
            var orders = orderRepository.GetOrders();

            //process the orders
            var orderProcessor = new OrderProcessor();
            var processedOrders = orderProcessor.ProcessOrders(flights, orders);

            //print status of orders
            var statsPrinter = new StatsPrinter();
            statsPrinter.PrintFlightSchedules(flights);
            statsPrinter.PrintOrderStatus(processedOrders);
        }
    }
}
