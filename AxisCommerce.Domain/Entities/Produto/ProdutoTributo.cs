using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Produtos;

public class ProdutoTributo
{
    public Guid Id { get; set; }
    public Guid ProdutoId { get; set; }
    [JsonIgnore]
    public Produto? Produto { get; set; }
    public DateOnly DataInicioVigencia { get; set; }
    public double TaxaFederal { get; set; } = 0;
    public double TaxaEstadual { get; set; } = 0;
    public double TaxaMunicipal { get; set; } = 0;
}
