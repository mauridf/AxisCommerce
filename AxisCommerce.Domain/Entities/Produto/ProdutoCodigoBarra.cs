using AxisCommerce.Domain.Entities.Pedidos;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Produtos;

public class ProdutoCodigoBarra
{
    public Guid Id { get; set; }
    public Guid ProdutoId { get; set; }
    [JsonIgnore]
    public Produto? Produto { get; set; }
    public string CodigoBarra { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<PedidoItem>? PedidoItens { get; set; }
}
