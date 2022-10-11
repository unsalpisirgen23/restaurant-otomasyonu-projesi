using DAL.Entities.Customers;
using DAL.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Addresses
{
    /// <summary> 
    ///  Adres
    /// </summary>
    public class Address : BaseEntity
    {
        /// <summary> 
        /// Adres Adı
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ülke
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// İl
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// İlçe
        /// </summary>
        public string District { get; set; }
        /// <summary>
        /// Mahalle veya Köy
        /// </summary>
        public string Neighborhood { get; set; }
        /// <summary>
        /// Sokak veya Cadde İsmi
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Kapı Numarası
        /// </summary>
        public string DoorNumber { get; set; }
        /// <summary>
        /// Müşteri ID
        /// </summary>
        public int? CustomerID { get; set; }
        /// <summary>
        /// Çalışan ID
        /// </summary>
        public int? EmployeID { get; set; }
        /// <summary>
        /// Çalışan
        /// </summary>
        public virtual Employe Employe { get; set; }
        /// <summary> 
        /// Müşteri 
        /// </summary>
        public virtual Customer Customer { get; set; }
         

    }
}
