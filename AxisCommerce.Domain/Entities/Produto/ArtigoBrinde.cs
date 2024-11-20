using AxisCommerce.Domain.Entities.Vendas;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Produtos;

public class ArtigoBrinde
{
    public Guid Id { get; set; }
    public Guid PromocaoTipoOfertaId { get; set; }
    [JsonIgnore]
    public PromocaoTipoOferta? PromocaoTipoOferta { get; set; }
    public Guid ProdutoId { get; set; }
    [JsonIgnore]
    public Produto? Produto { get; set; }
    public int QtdPecas { get; set; } = 0;
}
