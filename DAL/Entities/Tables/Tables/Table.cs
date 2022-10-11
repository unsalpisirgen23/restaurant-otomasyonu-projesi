using DAL.Entities.Plugs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Masalar
/// </summary>
namespace DAL.Entities.Tables
{
    /// <summary>
    /// Masa
    /// </summary>
    public class Table : BaseEntity
    {    
        /// <summary>
        /// Masa Numarası
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// Masa Kapasitesi
        /// </summary>
        public int? Capacity { get; set; }
        /// <summary>
        /// Masa Durumu
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// Masa Grub ID 
        /// </summary>
        public int? TableGroupID { get; set; }
        /// <summary>
        /// Masa Grub
        /// </summary>
        public virtual TableGroup TableGroup { get; set; }
        /// <summary>
        /// Fişler
        /// </summary>
        public virtual ICollection<Plug> Plugs { get; set; }
         
    }
}
