using SpeedAir.Interfaces;
using SpeedAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedAir.Services
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IDataContext _dataContext;
        public OrderRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Order> GetOrders()
        {
            return _dataContext.Orders.OrderBy(o => o.OrderNo).ToList();
        }
    }
}
