using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Produtos;

public class ProdutoLookComposicao
{
    public Guid Id { get; set; }
    public Guid ProdutoId { get; set; }
    [JsonIgnore]
    public Produto? Produto { get; set; }
    public Guid ProdutoAtributoId { get; set; }
    [JsonIgnore]
    public ProdutoAtributo? ProdutoAtributo { get; set; }
}
