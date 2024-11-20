using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Produtos;

public class ProdutoKit
{
    public Guid Id { get; set; }
    public Guid ProdutoId { get; set; }
    [JsonIgnore]
    public Produto? Produto { get; set; }
    public Guid KitId { get; set; }
    [JsonIgnore]
    public Kit? Kit { get; set; }
}
