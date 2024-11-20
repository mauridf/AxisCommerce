using AxisCommerce.Domain.Entities.Pedidos;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Produtos;

public class Produto
{
    public Guid Id { get; set; }
    public string DescProduto { get; set; } = string.Empty;
    public string CodProduto { get; set; } = string.Empty;
    public Guid UnidadeMedidaId { get; set; }
    [JsonIgnore]
    public UnidadeMedida? UnidadeMedida { get; set; }
    public double PesoProduto { get; set; } = 0;
    public int EstoqueLocalProduto { get; set; } = 0;
    public int EstoqueLocalProdutoLimiteMinimo { get; set; } = -1;

    [JsonIgnore]
    public ICollection<ProdutoKit>? ProdutoKits { get; set; }
    [JsonIgnore]
    public ICollection<ProdutoCodigoBarra>? ProdutoCodigoBarra { get; set; }
    [JsonIgnore]
    public ICollection<ProdutoPreco>? ProdutoPreco { get; set; }
    [JsonIgnore]
    public ICollection<ProdutoTributo>? ProdutoTributo { get; set; }
    [JsonIgnore]
    public ICollection<ProdutoCatalogo>? ProdutoCatalogos { get; set; }
    [JsonIgnore]
    public ICollection<ProdutoLookComposicao>? ProdutoLookComposicoes { get; set; }
    [JsonIgnore]
    public ICollection<ProdutoCorBasica>? ProdutoCorBasica { get; set; }
    [JsonIgnore]
    public ICollection<Estoque>? Estoques { get; set; }
    [JsonIgnore]
    public ICollection<ArtigoBrinde>? ArtigoBrinde { get; set; }
    [JsonIgnore]
    public ICollection<PedidoItem>? PedidoItens { get; set; }
}
