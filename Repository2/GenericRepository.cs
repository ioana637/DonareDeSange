using CentruDeTransfuzie1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository
{
    public class GenericRepository<E> : IRepository<E> where E : class
    {

        public CTContext context;
        public DbSet<E> dbset;

        public GenericRepository(CTContext ctx)
        {
            this.context = ctx;
            dbset = context.Set<E>();
        }
        public void Delete(E entity)
        {
            context.Remove(entity);
        }

        public IQueryable<E> GetAll()
        {
            return dbset;
        }

        public E GetBy(Expression<Func<E, bool>> predicate)
        {
            if (!dbset.Where(predicate).Equals(null))
                return dbset.Where(predicate).FirstOrDefault();
            return null;
        }

        public void Save(E entity)
        {
            context.Add(entity);
        }

        public void Update(E entity)
        {
            context.Update(entity);
        }
    }
}