using AxisCommerce.Domain.Entities.Loja;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pedidos;

public class PedidoVendedor
{
    public Guid Id { get; set; }
    public Guid PedidoId { get; set; }
    [JsonIgnore]
    public Pedido? Pedido { get; set; }
    public Guid VendedorId { get; set; }
    [JsonIgnore]
    public Vendedor? Vendedor { get; set; }
}
