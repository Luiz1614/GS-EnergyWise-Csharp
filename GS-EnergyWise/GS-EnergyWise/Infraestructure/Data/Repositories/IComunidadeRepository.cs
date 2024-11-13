using GS_EnergyWise.Domain.Entities;

namespace GS_EnergyWise.Infraestructure.Data.Repositories;

public interface IComunidadeRepository
{
    IEnumerable<ComunidadeEntity> GetAll();
    ComunidadeEntity GetById(int id);
    ComunidadeEntity Add(ComunidadeEntity comunidade);
    ComunidadeEntity Update(int id, ComunidadeEntity comunidade);
    ComunidadeEntity Delete(int id);
}
