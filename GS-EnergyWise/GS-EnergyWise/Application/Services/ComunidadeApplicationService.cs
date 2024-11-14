using AutoMapper;
using GS_EnergyWise.Application.DOTs;
using GS_EnergyWise.Application.Interfaces;
using GS_EnergyWise.Domain.Entities;
using GS_EnergyWise.Infraestructure.Data.Repositories;

namespace GS_EnergyWise.Application.Services;

public class ComunidadeApplicationService : IComunidadeApplicationService
{
    private readonly IComunidadeRepository _comunidadeRepository;
    private readonly IMapper _mapper;
    
    public ComunidadeApplicationService(IComunidadeRepository comunidadeRepository, IMapper mapper)
    {
        _comunidadeRepository = comunidadeRepository;
        _mapper = mapper;
    }
    
    public IEnumerable<ComunidadeEntity> GetAll()
    {
        return _comunidadeRepository.GetAll();
    }

    public ComunidadeEntity GetById(int id)
    {
        return _comunidadeRepository.GetById(id);
    }

    public void Add(ComunidadeDTO comunidadeDTO)
    {
        var comunidade = _mapper.Map<ComunidadeEntity>(comunidadeDTO);
        _comunidadeRepository.Add(comunidade);
    }

    public void Update(int id, ComunidadeDTO comunidadeDTO)
    {
        var comunidade = _mapper.Map<ComunidadeEntity>(comunidadeDTO);
        _comunidadeRepository.Update(id, comunidade);
    }

    public void Delete(int id)
    {
        _comunidadeRepository.Delete(id);
    }
}