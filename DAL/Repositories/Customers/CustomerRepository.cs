using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interfaces;
using DAL.Entities.Customers;

namespace DAL.Repositories.Customers
{
    public class CustomerRepository : Repository<Customer>, IRepository<Customer>
    {
        public CustomerRepository(DbContext con) : base(con)
        {
        }
    }
}
