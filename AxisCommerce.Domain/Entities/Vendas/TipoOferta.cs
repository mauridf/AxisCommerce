using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Vendas;

public class TipoOferta
{
    public Guid Id { get; set; }
    public string CodTipoOferta { get; set; } = string.Empty;
    public string DescTipoOferta { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<PromocaoTipoOferta>? PromocaoTipoOferta { get; set; }
}
