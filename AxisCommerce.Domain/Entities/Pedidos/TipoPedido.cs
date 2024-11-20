using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pedidos;

public class TipoPedido
{
    public Guid Id { get; set; }
    public string DescTipoPedido { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<Pedido>? Pedidos { get; set; }
}
