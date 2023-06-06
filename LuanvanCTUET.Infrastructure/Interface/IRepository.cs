using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LuanvanCTUET.Infrastructure.Interface
{
    public interface IRepository<T, K> where T : class
    {
        T FindById(K id, params Expression<Func<T, object>>[] includeProperties);
        T FindSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        void Add(T entity);
        void Updated(T entity);
        void Delete(T entity);
        void Delete(K id);
        void DeleteMultiple(List<T> entities);

    }
}
