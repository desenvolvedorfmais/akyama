using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Matching_cs.Domain.Interface.Repository
{
    public interface IRepository<T> : IDisposable
    {
        T GetById(int id);

        IEnumerable<T> GetAll();


        IQueryable<T> Query(Expression<Func<T, bool>> filter);

        void Save(T entity);

        void Delete(T entity);
    }

}