using Matching_cs.Model;

namespace Matching_cs.Repository
{
    public interface IBiometriaInterface
    {
        tbBiometria GetByID(int produtoID);
        tbBiometria Load(int produtoID);
        void Save(tbBiometria produto);
        void Delete(tbBiometria produto);
    }
}