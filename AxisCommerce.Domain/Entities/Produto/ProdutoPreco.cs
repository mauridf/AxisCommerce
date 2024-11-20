using AxisCommerce.Domain.Entities.Pedidos;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Produtos;

public class ProdutoPreco
{
    public Guid Id { get; set; }
    public Guid ProdutoId { get; set; }
    [JsonIgnore]
    public Produto? Produto { get; set; }
    public double Preco { get; set; } = 0;
    public double LimiteDesconto { get; set; } = 0;
    public DateOnly DataInicioVigencia { get; set; }
    public DateOnly? DataFimVigencia { get; set; }
    public bool Inativo { get; set; } = false;

    [JsonIgnore]
    public ICollection<PedidoItem>? PedidoItens { get; set; }
}
