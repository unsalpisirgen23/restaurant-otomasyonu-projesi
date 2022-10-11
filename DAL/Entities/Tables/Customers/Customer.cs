using DAL.Entities.Addresses;
using DAL.Entities.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Customers
{
    /// <summary>
    /// Müşteri
    /// </summary>
    public class Customer : BaseEntity
    {
        /// <summary>
        ///  Ad
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///  Soyad
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Tam Adı
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Cinsiyet
        /// </summary>
        public int Gender { get; set; }
        /// <summary>
        /// Durum
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// Müşteri İletişim
        /// </summary>
        public virtual ICollection<Communication> CustomerCommunication { get; set; }
        /// <summary>
        /// Müşteri Adres
        /// </summary>
        public virtual ICollection<Address> CustomerAddress { get; set; }
    }
}