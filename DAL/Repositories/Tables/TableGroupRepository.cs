using DAL.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interfaces;

namespace DAL.Repositories.Tables
{
    public class TableGroupRepository : Repository<TableGroup>, IRepository<TableGroup>
    {
        public TableGroupRepository(DbContext con) : base(con)
        {
        }
    }
}
