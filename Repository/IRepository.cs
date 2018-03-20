using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository
{
    public interface IRepository<E> where E : class
    {
        void Save(E entity);
        E GetBy(Expression<Func<E, bool>> predicate);
        void Delete(E entity);
        void Update(E entity);
        IQueryable<E> GetAll();
    }
}
