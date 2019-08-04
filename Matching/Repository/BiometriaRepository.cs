using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Matching_cs.Model;

namespace Matching_cs.Repository
{
    public class BiometriaRepository : IRepository<tbBiometria>, IDisposable
    {
        private FMContext _context;

        public BiometriaRepository(FMContext context)
        {
            _context = context;
        }

        public tbBiometria GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbBiometria> GetAll()
        {
            return _context.tbBiometria;


        }

        public IQueryable<tbBiometria> Query(Expression<Func<tbBiometria, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Save(tbBiometria entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(tbBiometria entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()

        {

            if (_context != null)

            {

                _context.Dispose();

            }

            GC.SuppressFinalize(this);

        }
    }
}