using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interfaces;
using DAL.Entities.Orders;

namespace DAL.Repositories.Orders
{
    public class OrderRepository : Repository<Order>, IRepository<Order>
    {
        public OrderRepository(DbContext con) : base(con)
        {
        }
    }
}
