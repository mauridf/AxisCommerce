using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Vendas;

public class PromocaoGrupo
{
    public Guid Id { get; set; }
    public string DescPromocaoGrupo { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<Promocao>? Promocao { get; set; }
}
