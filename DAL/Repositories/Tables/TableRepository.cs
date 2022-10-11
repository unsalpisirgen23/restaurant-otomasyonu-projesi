using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Entities.Tables;
using DAL.Interfaces;

namespace DAL.Repositories.Tables
{
    public class TableRepository : Repository<Table>, IRepository<Table>
    {
        public TableRepository(DbContext con) : base(con)
        {
        }
    }
}
