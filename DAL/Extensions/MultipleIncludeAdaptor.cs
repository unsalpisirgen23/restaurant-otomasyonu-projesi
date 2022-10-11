using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Extensions
{
    public static class MultipleIncludeAdaptor
    {
         /// <summary>
         ///  Bu Tabloları Birşeltirmek için
         /// </summary>
         /// <typeparam name="TEntity"></typeparam>
         /// <param name="query"></param>
         /// <param name="includes"></param>
         /// <returns></returns>
        public static IQueryable<TEntity> Inner<TEntity>(this IQueryable<TEntity> query, params Expression<Func<TEntity, object>>[] includes) where TEntity : class
        {
            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }
            return query;
        }

    }
}
