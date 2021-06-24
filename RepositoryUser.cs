using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    class RepositoryUser<T> : IRepository<T> where T : class
    {
        protected DbSet<T> DbSet;

        public RepositoryUser(DbContext dataContext)
        {
            DbSet = dataContext.Set<T>();
        }
        public void Insert(T entity)
        {
            DbSet.Add(entity);
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }
    }
}