using GS_EnergyWise.Domain.Entities;
using GS_EnergyWise.Infraestructure.Data.AppData;

namespace GS_EnergyWise.Infraestructure.Data.Repositories;

public class ComunidadeRepository : IComunidadeRepository
{
    private readonly ApplicationContext _context;

    public ComunidadeRepository(ApplicationContext context)
    {
        _context = context;
    }

    public ComunidadeEntity Add(ComunidadeEntity comunidade)
    {
        _context.Add(comunidade);
        _context.SaveChanges();
        return comunidade;
    }

    public ComunidadeEntity Delete(int id)
    {
        var comunidade = _context.Set<ComunidadeEntity>().Find(id);
        if (comunidade != null)
        {
            _context.Set<ComunidadeEntity>().Remove(comunidade);
            _context.SaveChanges();
        }
        return comunidade;
    }

    public IEnumerable<ComunidadeEntity> GetAll()
    {
        return _context.Set<ComunidadeEntity>().ToList();
    }

    public ComunidadeEntity GetById(int id)
    {
        return _context.Set<ComunidadeEntity>().Find(id);
    }

    public ComunidadeEntity Update(int id, ComunidadeEntity comunidade)
    {
        var entity = _context.Set<ComunidadeEntity>().Find(id);
        if (entity != null)
        {
            entity.Nome = comunidade.Nome;
            entity.TamanhoArea = comunidade.TamanhoArea;
            entity.UnidadeArea = comunidade.UnidadeArea;
            entity.Populacao = comunidade.Populacao;
            _context.SaveChanges();
        }
        return entity;
    }
}
