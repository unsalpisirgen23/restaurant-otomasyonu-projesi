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
    /// Ürün Grub
    /// </summary>
    public class ProductGroup : BaseEntity
    {
        /// <summary>
        /// Ürün Grub Adı
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ürün Grub Resmi
        /// </summary>
        public byte[] Picture { get; set; }
        /// <summary>
        /// Ürün Grub Durumu
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// Ürünler
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }

    }
}
