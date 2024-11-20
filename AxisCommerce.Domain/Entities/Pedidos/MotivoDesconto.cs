using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pedidos;

public class MotivoDesconto
{
    public Guid Id { get; set; }
    public string DescMotivoDesconto { get; set; } = string.Empty;
    public bool Inativo { get; set; } = false;

    [JsonIgnore]
    public ICollection<Pedido>? Pedidos { get; set; }
    [JsonIgnore]
    public ICollection<PedidoItem>? PedidoItens { get; set; }
    [JsonIgnore]
    public ICollection<PedidoDesconto>? PedidoDescontos { get; set; }
}
