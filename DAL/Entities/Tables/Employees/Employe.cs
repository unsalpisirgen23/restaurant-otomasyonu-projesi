using DAL.Entities.Addresses;
using DAL.Entities.Communications;
using DAL.Entities.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Employees
{
    /// <summary>
    /// Çalışan
    /// </summary>
    public class Employe : BaseEntity
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
        public int? Gender { get; set; }
        /// <summary>
        /// Vatandaşlık Numarası  
        /// </summary>
        public string CitizenshipNumber { get; set; }
        /// <summary>
        ///  Fotoraf
        /// </summary>
        public byte[] Avatar { get; set; }
        /// <summary>
        ///  doğum Tarihi
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// Medeni Durumu yani Evlimi Bekarmı gibisinden
        /// </summary>
        public int? MaritalStatus { get; set; }
        /// <summary>
        /// Kullanıcı Adı
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Şifre
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Durum
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// Çalışan Adresleri
        /// </summary>
        public virtual ICollection<Address> EmployeAddresses { get; set; } 
        /// <summary> 
        /// Çalışan İletişimleri 
        /// </summary>
        public virtual ICollection<Communication> EmployeCommunication { get; set; }

    }
}
