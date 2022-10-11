using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Procedures
{
    public class OrderStatusOfTableResult
    {

        public int OrderID { get; set; }
        public int OrderPlugID { get; set; }
        public int PlugID { get; set; }
        public int PlugTableID { get; set; }

    }
}
