
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
    public class ProductRepository : Repository<Product>, IRepository<Product>
    {
        public ProductRepository(DbContext con) : base(con)
        {
        }
    }
}
