using GS_EnergyWise.Application.DOTs;
using GS_EnergyWise.Domain.Entities;

namespace GS_EnergyWise.Application.Interfaces;

public interface IComunidadeApplicationService
{
    IEnumerable<ComunidadeEntity> GetAll();
    ComunidadeEntity GetById(int id);
    void Add(ComunidadeDTO comunidadeDTO);
    void Update(int id, ComunidadeDTO comunidadeDTO);
    void Delete(int id);
}