using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Matching_cs.Domain.Interface.Repository;
using Matching_cs.Model;

namespace Matching_cs.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly FMContext _dbContext;

        public Repository(FMContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().AsEnumerable();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Save(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }


        public void Dispose()

        {

            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }

            GC.SuppressFinalize(this);

        }

    }
}