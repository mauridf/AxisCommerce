using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Vendas;

public class TipoOperacaoVenda
{
    public Guid Id { get; set; }
    public string DescTipoOperacaoVenda { get; set; } = string.Empty;


    [JsonIgnore]
    public ICollection<Promocao>? Promocao { get; set; }
}
