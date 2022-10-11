
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interfaces;
using DAL.Entities.Products;

namespace DAL.Repositories.Products
{
    public class ProductGroupRepository : Repository<ProductGroup>, IRepository<ProductGroup>
    {
        public ProductGroupRepository(DbContext con) : base(con)
        {
        }
    }
}
