using DAL.Entities.Customers;
using DAL.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Communications
{
    /// <summary>
    /// İletişim
    /// </summary>
    public class Communication : BaseEntity
    {
        /// <summary>
        /// Telefon 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// E-Posta
        /// </summary>
        public string EMail { get; set; }
        /// <summary>
        /// Instagram Adresi
        /// </summary>
        public string Instagram { get; set; }
        /// <summary>
        /// Twitter Adresi
        /// </summary>
        public string Twitter { get; set; }
        /// <summary>
        /// Facebook Adrei
        /// </summary>
        public string Facebook { get; set; }
        /// <summary>
        /// Linkedin Adresi
        /// </summary>
        public string Linkedin { get; set; }
        /// <summary>
        /// Müşteri ID
        /// </summary>
        public int? CustomerID { get; set; }
        /// <summary>
        /// Çalışan ID
        /// </summary>
        public int? EmployeID { get; set; }
        /// <summary>
        /// Çalışanlar
        /// </summary>
        public virtual Employe Employe { get; set; }
        /// <summary> 
        /// Müşteri
        /// </summary>
        public virtual Customer Customer { get; set; }
    }
}
