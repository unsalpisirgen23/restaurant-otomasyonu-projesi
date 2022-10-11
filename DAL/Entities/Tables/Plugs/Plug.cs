using DAL.Entities.Orders;
using DAL.Entities.Payments;
using DAL.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Plugs
{
    public class Plug : BaseEntity
    {
        /// <summary>
        /// Masa ID
        /// </summary>
        public int? TableID { get; set; }
        /// <summary>
        /// Masa
        /// </summary>
        public virtual Table Table { get; set; }
        /// <summary>
        /// Ödemeler
        /// </summary>
        public virtual ICollection<Payment> Payments { get; set; }
        /// <summary>
        /// Siparişler
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }

    }
}
