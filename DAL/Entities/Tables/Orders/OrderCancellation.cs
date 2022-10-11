using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Orders
{
    public class OrderCancellation : BaseEntity
    {
        /// <summary>
        /// Sipariş ID
        /// </summary>
        public int? OrderID { get; set; }
        /// <summary>
        /// Fiş ID
        /// </summary>
        public int? PlugID { get; set; }
        /// <summary>
        /// Çalışan ID
        /// </summary>
        public int? EmployeID { get; set; }
        /// <summary>
        /// Müşteri ID
        /// </summary>
        public int? CustomerID { get; set; }
    }
}
