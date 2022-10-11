using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interfaces;
using DAL.Entities.Plugs;
using System.Data.SqlClient;
using DAL.Procedures;

namespace DAL.Repositories.Plugs
{
    public class PlugRepository : Repository<Plug>, IRepository<Plug>
    {

        private DbContext con;

        public PlugRepository(DbContext con) : base(con)
        {
            this.con = con;
        }

        public virtual List<OrderStatusOfTableResult> SpOrderStatusOfTable(Nullable<int> TableID)
        {
           return  this.Procedure<OrderStatusOfTableResult>("SpOrderStatusOfTable @TableID", new object[] { new SqlParameter("@TableID", TableID) }).ToList();
        }

    }
}
