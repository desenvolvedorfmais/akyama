using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Matching_cs.Domain.Interface.Repository;
using Matching_cs.Model;

namespace Matching_cs.Data.Repository
{
    public class BiometriaRepository : Repository<tbBiometria>, IBiometriaRepository
    {
        public BiometriaRepository(FMContext dbContext) : base(dbContext)
        {
        }
    }
}