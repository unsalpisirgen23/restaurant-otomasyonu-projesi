using DAL.Extensions;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbContext con;

        public Repository(DbContext con)
        {
            this.con = con;
        }

        public virtual void Add(TEntity entity)
        {
            con.Entry<TEntity>(entity).State = EntityState.Added;
        }

        public virtual void Add(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                con.Entry<TEntity>(entity).State = EntityState.Added;
            }
        }

        public virtual BindingList<TEntity> BindingList()
        {
            return con.Set<TEntity>().Local.ToBindingList();
        }

        public virtual void Delete(TEntity entity)
        {
            con.Entry<TEntity>(entity).State = EntityState.Deleted;
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> filter)
        {
            con.Set<TEntity>().RemoveRange(con.Set<TEntity>().Where(filter));
        }

        public virtual bool Exist(Expression<Func<TEntity, bool>> filter)
        {
            return con.Set<TEntity>().Any(filter);
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
                return con.Set<TEntity>().SingleOrDefault(filter);
        }

        public virtual TEntity Get2(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return con.Set<TEntity>().Where(filter).FirstOrDefault();
        }


        public virtual IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return filter == null ? con.Set<TEntity>().AsNoTracking().ToList() : con.Set<TEntity>().Where(filter).AsNoTracking().ToList();
        }



        public virtual bool HasChanges()
        {
            return con.ChangeTracker.Entries<TEntity>().Any();
        }

        public virtual IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return filter == null ? con.Set<TEntity>().Select(selector) :
            con.Set<TEntity>().Where(filter).Select(selector);
        }

        public virtual IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return filter == null ? con.Set<TEntity>().Select(selector) :
            con.Set<TEntity>().Where(filter).Select(selector);
        }

        public virtual void Update(TEntity entity)
        {

            con.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Load(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            if (filter == null)
            {
                con.Set<TEntity>().Load();
            }
            else
            {
                con.Set<TEntity>().Where(filter).Load();
            }
        }


        public virtual List<T> Procedure<T>(string tableName,params object[] parameters)
        {
            return con.Database.SqlQuery<T>("exec dbo."+ tableName , parameters).ToList();
        }

         
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
        // ~Repository() {
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
