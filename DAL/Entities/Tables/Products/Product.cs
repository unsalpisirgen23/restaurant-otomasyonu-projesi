using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Ürünler
/// </summary>
namespace DAL.Entities.Products
{
    /// <summary>
    /// Ürün
    /// </summary>
    public class Product : BaseEntity
    {
        /// <summary>
        /// Ürün Adı
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ürün Fiyatı
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Ürün Resmi
        /// </summary>
        public byte[] Picture { get; set; }
        /// <summary>
        /// Ürün Durumu
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// Ürün Grub ID
        /// </summary>
        public int? ProductGroupID { get; set; }
        /// <summary>
        /// Ürün Grubu
        /// </summary>
        public virtual ProductGroup ProductGroup { get; set; }
    }
}
