using System;
using System.Collections.Generic;
using Matching_cs.Domain.Interface.Repository;
using Matching_cs.Domain.Interface.Service;
using Matching_cs.Model;

namespace Matching_cs.Domain.Service
{
    public class BiometriaService : IBiometriaService
    {
        private readonly IBiometriaRepository _biometriaRepository;
        public BiometriaService(IBiometriaRepository biometriaRepository)
        {
            _biometriaRepository = biometriaRepository;
        }
        public void Dispose()
        {
            _biometriaRepository?.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<tbBiometria> GetAll()
        {
            return _biometriaRepository.GetAll();
        }
    }
}