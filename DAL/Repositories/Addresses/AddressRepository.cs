using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interfaces;
using DAL.Entities.Addresses;

namespace DAL.Repositories.Addresses
{
    public class AddressRepository : Repository<Address>, IRepository<Address>
    {
        public AddressRepository(DbContext con) : base(con)
        {
        }
    }
}
