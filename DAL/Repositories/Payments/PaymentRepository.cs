using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interfaces;
using DAL.Entities.Payments;

namespace DAL.Repositories.Payments
{
    public class PaymentRepository : Repository<Payment>, IRepository<Payment>
    {
        public PaymentRepository(DbContext con) : base(con)
        {
        }
    }
}
