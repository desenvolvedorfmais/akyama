using Matching_cs.Model;
using System;
using System.Collections.Generic;

namespace Matching_cs.Domain.Interface.Service
{
    public interface IBiometriaService : IDisposable
    {

        IEnumerable<tbBiometria_Akiama> GetAll();

    }
}