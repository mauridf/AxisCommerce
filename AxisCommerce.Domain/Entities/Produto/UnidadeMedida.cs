using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Produtos;

public class UnidadeMedida
{
    public Guid Id { get; set; }
    public string NomeUnidadeMedida { get; set; } = string.Empty;
    public string NomeUnidadeMedidaPlural { get; set; } = string.Empty;
    public string Simbolo { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<Produto>? Produtos { get; set; }
}
