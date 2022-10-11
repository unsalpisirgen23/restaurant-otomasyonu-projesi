using DAL.Entities.Customers;
using DAL.Entities.Employees;
using DAL.Entities.Plugs;
using DAL.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Orders
{
    public class Order : BaseEntity
    {
        public decimal? Price { get; set; }
        /// <summary>
        /// Adet
        /// </summary>
        public int? Piece { get; set; }
        /// <summary>
        /// Ürün ID
        /// </summary>
        public int? ProductID { get; set; }
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
        /// <summary>
        /// Ürün
        /// </summary>
        public virtual Product Product { get; set; }
        /// <summary>
        /// Fiş
        /// </summary>
        public virtual Plug Plug { get; set; }
        /// <summary>
        /// Kullanıcı
        /// </summary>
        public virtual Employe Employe { get; set; }
        /// <summary>
        /// Müşteri
        /// </summary>
        public virtual Customer Customer { get; set; }

    }
}
