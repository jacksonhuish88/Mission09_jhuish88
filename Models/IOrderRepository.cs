using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jhuish88.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }

        public void SaveOrder(Order order);

    }
}
