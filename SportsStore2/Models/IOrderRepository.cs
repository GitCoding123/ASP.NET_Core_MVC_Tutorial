using SportsStore2.Models;
using System.Collections.Generic;

namespace SportsStore2.Models
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
