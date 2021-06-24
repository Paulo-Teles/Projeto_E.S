using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
    }
}