using AxisCommerce.Domain.Entities.Pedidos;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Produtos;

public class Estoque
{
    public Guid Id { get; set; }
    public Guid DepositoId { get; set; }
    [JsonIgnore]
    public Deposito? Deposito { get; set; }
    public Guid ProdutoId { get; set; }
    [JsonIgnore]
    public Produto? Produto { get; set; }
    public int QtddEstoque { get; set; } = 0;
    public DateOnly DataAtualizacaoEstoque { get; set; }
    public int QttdEstoqueLimiteMinino { get; set; } = -1;

    [JsonIgnore]
    public ICollection<PedidoItem>? PedidoItens { get; set; }
}
