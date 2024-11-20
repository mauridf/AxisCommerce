using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Produtos;

public class ProdutoCatalogo
{
    public Guid Id { get; set; }
    public Guid ProdutoAtributoId { get; set; }
    [JsonIgnore]
    public ProdutoAtributo? ProdutoAtributo { get; set; }
    public Guid ProdutoId { get; set; }
    [JsonIgnore]
    public Produto? Produto { get; set; }
    public DateOnly DataInicialCatalogo { get; set; }
    public DateOnly DataFinalCatalogo { get; set; }
    public string Observacao { get; set; } = string.Empty;
    public bool IndicaLook { get; set; } = false;
}
