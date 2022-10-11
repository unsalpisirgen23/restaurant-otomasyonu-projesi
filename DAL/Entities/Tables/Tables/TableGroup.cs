using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Masalar
/// </summary>
namespace DAL.Entities.Tables
{
    /// <summary>
    /// Masa Grub
    /// </summary>
    public class TableGroup : BaseEntity
    {
        /// <summary>
        /// Masa Grub Adı
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Masa Grub Durum
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// Masalar
        /// </summary>
        public virtual ICollection<Table> Tables { get; set; }
    }
}