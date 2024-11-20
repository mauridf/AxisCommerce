using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pedidos;

public class PedidoPromocao
{
    public Guid Id { get; set; }
    public Guid PedidoId { get; set; }
    [JsonIgnore]
    public Pedido? Pedido { get; set; }
    public double ValorDescontoEfetivo { get; set; } = 0;

    [JsonIgnore]
    public ICollection<PedidoDesconto>? PedidoDescontos { get; set; }
}
