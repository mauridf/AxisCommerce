using AxisCommerce.Domain.Entities.Loja;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pedidos;

public class PedidoDesconto
{
    public Guid Id { get; set; }
    public Guid PedidoId { get; set; }
    [JsonIgnore]
    public Pedido? Pedido { get; set; }
    public Guid PedidoItemId { get; set; }
    [JsonIgnore]
    public PedidoItem? PedidoItem { get; set; }
    public Guid PedidoPgtoId { get; set; }
    [JsonIgnore]
    public PedidoPagto? PedidoPgto { get; set; }
    public Guid MotivoDescontoId { get; set; }
    [JsonIgnore]
    public MotivoDesconto? MotivoDesconto { get; set; }
    public Guid VendedorId { get; set; }
    [JsonIgnore]
    public Vendedor? Vendedor { get; set; }
    public Guid PedidoPromocaoId { get; set; }
    [JsonIgnore]
    public PedidoPromocao? PedidoPromocao { get; set; }
    public double ValorDesconto { get; set; } = 0;
    public double ValorAcrescimo { get; set; } = 0;
    public string CupomDesconto { get; set; } = string.Empty;
    public string Mensagem { get; set; } = string.Empty;
}
