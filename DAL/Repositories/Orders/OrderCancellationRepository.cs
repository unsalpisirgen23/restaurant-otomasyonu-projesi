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
    public class OrderCancellationRepository : Repository<OrderCancellation>, IRepository<OrderCancellation>
    {
        public OrderCancellationRepository(DbContext con) : base(con)
        {
        }
    }
}
