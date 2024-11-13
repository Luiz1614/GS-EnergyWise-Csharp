using System.ComponentModel.DataAnnotations;

namespace GS_EnergyWise.Application.DOTs;

public class ComunidadeDTO
{
    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [StringLength(150, ErrorMessage = "O campo Nome deve ter no máximo {1} caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo Tamanho da Área é obrigatório.")]
    [Range(1, double.MaxValue, ErrorMessage = "O campo Tamanho da Área deve ser maior que zero.")]
    public double TamanhoArea { get; set; }

    [Required(ErrorMessage = "O campo Unidade de Área é obrigatório.")]
    [RegularExpression("^(m²|hectares)$", ErrorMessage = "A Unidade de Área deve ser 'm²' ou 'hectares'.")]
    public string UnidadeArea { get; set; }

    [Required(ErrorMessage = "O campo População é obrigatório.")]
    [Range(1, int.MaxValue, ErrorMessage = "A População deve ser um número positivo maior que zero.")]
    public int Populacao { get; set; }
}

