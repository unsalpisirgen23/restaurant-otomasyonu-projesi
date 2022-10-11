namespace DAL
{
    using DAL.Entities.Addresses;
    using DAL.Entities.Communications;
    using DAL.Entities.Customers;
    using DAL.Entities.Employees;
    using DAL.Entities.Orders;
    using DAL.Entities.Payments;
    using DAL.Entities.Plugs;
    using DAL.Entities.Products;
    using DAL.Entities.Tables;
    using DAL.Procedures;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using System.Data.SqlClient;
    using System.Linq;

    public class RestaurantContext : DbContext
    {
        private static string ConnectionString = "name=DbConnectionString";

        public RestaurantContext()
            : base(ConnectionString)
        {
        
        }


        public RestaurantContext(string connectionString):base(connectionString)
        {
            ConnectionString = connectionString;
        }
         
        /// <summary>
        /// Masalar
        /// </summary>
        public virtual DbSet<Table> Tables { get; set; }
        /// <summary>
        /// Masa Grublar�
        /// </summary>
        public virtual DbSet<TableGroup> TableGroups { get; set; }
        /// <summary>
        /// �r�nler
        /// </summary>
        public virtual DbSet<Product> Products { get; set; }
        /// <summary>
        /// �r�n Gruplar�
        /// </summary>
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }
        /// <summary>
        /// Fi�ler
        /// </summary>
        public virtual DbSet<Plug> Plugs { get; set; }
        /// <summary>
        /// �demeler
        /// </summary>
        public virtual DbSet<Payment> Payments { get; set; }
        /// <summary>
        /// Sipari�ler
        /// </summary>
        public virtual DbSet<Order> Orders { get; set; }
        /// <summary>
        /// Sipari� �ptaller
        /// </summary>
        public virtual DbSet<OrderCancellation> OrderCancellations { get; set; }
        /// <summary>
        /// �al��anlar
        /// </summary>
        public virtual DbSet<Employe> Employees { get; set; }
        /// <summary>
        /// M��teriler
        /// </summary>
        public virtual DbSet<Customer> Customers { get; set; }
        /// <summary>
        /// �leti�im Bilgileri
        /// </summary>
        public virtual DbSet<Communication> Communications { get; set; }
        /// <summary>
        /// Adresler
        /// </summary>
        public virtual DbSet<Address> Addresses { get; set; }
     



    }
}