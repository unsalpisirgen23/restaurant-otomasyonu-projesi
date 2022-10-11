using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    /// <summary>
    /// BaseEntity
    /// Ana Ortak Yapı
    /// </summary>
    public class BaseEntity
    {
        
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Ekleme Tarihi
        /// </summary>
        public DateTime? AddDate { get; set; }
        /// <summary>
        /// Güncelleme Tarihi
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// Silme Tarihi
        /// </summary>
        public DateTime? DeleteDate { get; set; }
        /// <summary>
        ///  Oturum Hareketin den gelen Giriş Yapan ID
        /// </summary>
        public int SessionMovementLoginID { get; set; }  
    }
}
