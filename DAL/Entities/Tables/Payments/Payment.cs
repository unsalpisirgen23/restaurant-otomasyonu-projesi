using DAL.Entities.Plugs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Payments
{
    public class Payment : BaseEntity
    {
        /// <summary>
        /// Masa Fiş ID
        /// </summary>
        public int? PlugID { get; set; } 
        /// <summary>
        /// Çalışan ID
        /// </summary>
        public int? EmployeID { get; set; }
        /// <summary>
        /// Ödeme Tipi
        /// </summary>
        public int PaymentType { get; set; }
        /// <summary>
        /// Tutar
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Toplam Tutar
        /// </summary>
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// Alınan Tutar
        /// </summary>
        public decimal EnterAmount { get; set; }
        /// <summary>
        /// Kalan Tutar
        /// </summary>
        public decimal RemainingAmount { get; set; }
        /// <summary>
        /// Fiş
        /// </summary>
        public virtual Plug Plug { get; set; }

    }
}
