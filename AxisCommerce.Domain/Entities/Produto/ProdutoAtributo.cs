using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Produtos;

public class ProdutoAtributo
{
    public Guid Id { get; set; }
    public Guid ProdutoAtributoDefinicaoId { get; set; }
    [JsonIgnore]
    public ProdutoAtributoDefinicao? ProdutoAtributoDefinicao { get; set; }
    public string CodAtributo { get; set; } = string.Empty;
    public string DescAtributo { get; set; } = string.Empty;
    public string DescAtributoResumido { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<ProdutoCatalogo>? ProdutoCatalogos { get; set; }
    [JsonIgnore]
    public ICollection<ProdutoLookComposicao>? ProdutoLookComposicoes { get; set; }
    [JsonIgnore]
    public ICollection<ProdutoCorBasica>? ProdutoCorBasica { get; set; }
}
