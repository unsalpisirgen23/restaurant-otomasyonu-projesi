using DAL.Interfaces;
using DAL.Repositories.Addresses;
using DAL.Repositories.Communications;
using DAL.Repositories.Customers;
using DAL.Repositories.Employees;
using DAL.Repositories.Orders;
using DAL.Repositories.Payments;
using DAL.Repositories.Plugs;
using DAL.Repositories.Products;
using DAL.Repositories.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        
        public UnitOfWork(RestaurantContext Db)
        {
            this.Db = Db;

            TableRepositories = new TableRepository(this.Db);

            TableGroupRepositories = new TableGroupRepository(this.Db);

            ProductRepositories = new ProductRepository(this.Db);

            ProductGroupRepositories = new ProductGroupRepository(this.Db);

            PlugRepositories = new PlugRepository(this.Db);

            PaymentRepositories = new PaymentRepository(this.Db);

            OrderRepositories = new OrderRepository(this.Db);

            OrderCancellationRepositories = new OrderCancellationRepository(this.Db);

            EmployeRepositories = new EmployeRepository(this.Db);

            CustomerRepositories = new CustomerRepository(this.Db);

            CommunicationRepositories = new CommunicationRepository(this.Db);

            AddressRepositories = new AddressRepository(this.Db);

        }

        public int Complete()
        {
            return Db.SaveChanges();
        }

        /// <summary>
        /// Restaurant Context Sınıfı
        /// </summary>
        public RestaurantContext Db { get; set; }
        /// <summary>
        /// Masa Depolar
        /// </summary>
        public TableRepository TableRepositories { get; set; }
        /// <summary>
        /// Masa Grup Depoları
        /// </summary>
        public TableGroupRepository TableGroupRepositories { get; set; }
        /// <summary>
        /// Ürün Depoları
        /// </summary>
        public ProductRepository ProductRepositories { get; set; }
        /// <summary>
        /// Ürün Grup Depoları
        /// </summary>
        public ProductGroupRepository ProductGroupRepositories { get; set; }
        /// <summary>
        /// Fiş Depoları
        /// </summary>
        public PlugRepository PlugRepositories { get; set; }
        /// <summary>
        /// Ödeme Depoları
        /// </summary>
        public PaymentRepository PaymentRepositories { get; set; }
        /// <summary>
        /// Sipariş Depoları
        /// </summary>
        public OrderRepository OrderRepositories { get; set; }
        /// <summary>
        /// Sipariş İptal Depoları
        /// </summary>
        public OrderCancellationRepository OrderCancellationRepositories { get; set; }
        /// <summary>
        /// Çalışan Depoları
        /// </summary>
        public EmployeRepository EmployeRepositories { get; set; }
        /// <summary>
        /// Müşteri Depoları
        /// </summary>
        public CustomerRepository CustomerRepositories { get; set; }
        /// <summary>
        /// İletişim Depoları
        /// </summary>
        public CommunicationRepository CommunicationRepositories { get; set; }
        /// <summary>
        /// Adres Depoları
        /// </summary>
        public AddressRepository AddressRepositories { get; set; }


        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
