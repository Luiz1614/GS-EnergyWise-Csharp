using System.ComponentModel.DataAnnotations.Schema;

namespace GS_EnergyWise.Domain.Entities;

[Table("GS1_Comunidade")]
public class ComunidadeEntity : BaseEntity
{
    public string Nome { get; set; }
    public double TamanhoArea { get; set; }
    public string UnidadeArea { get; set; }
    public int Populacao { get; set; }
}
