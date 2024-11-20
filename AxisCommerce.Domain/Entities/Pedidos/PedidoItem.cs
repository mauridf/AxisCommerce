using AxisCommerce.Domain.Entities.Produtos;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pedidos;

public class PedidoItem
{
    public Guid Id { get; set; }
    public Guid PedidoId { get; set; }
    [JsonIgnore]
    public Pedido? Pedido { get; set; }
    public Guid ProdutoId { get; set; }
    [JsonIgnore]
    public Produto? Produto { get; set; }
    public Guid ProdutoCodigoBarraId { get; set; }
    [JsonIgnore]
    public ProdutoCodigoBarra? ProdutoCodigoBarra { get; set; }
    public Guid ProdutoPrecoId { get; set; }
    [JsonIgnore]
    public ProdutoPreco? ProdutoPreco { get; set; }
    public Guid EstoqueId { get; set; }
    [JsonIgnore]
    public Estoque? Estoque { get; set; }
    public int SeqItem { get; set; }
    public bool IndicaEmbrulhaPresente { get; set; } = false;
    public int QtddItem { get; set; } = 0;
    public double PrecoBrutoItem { get; set; } = 0;
    public int DescontoItem { get; set; } = 0;
    public double PrecoLiquidoItem { get; set; } = 0;
    public bool ItemCancelado { get; set; } = false;
    public int SeqKit { get; set; } = 0;
    public Guid MotivoCancelamentoId { get; set; }
    [JsonIgnore]
    public MotivoCancelamento? MotivoCancelamento { get; set; }
    public Guid MotivoDescontoId { get; set; }
    [JsonIgnore]
    public MotivoDesconto? MotivoDesconto { get; set; }
    public Guid MotivoDevolucaoId { get; set; }
    [JsonIgnore]
    public MotivoDevolucao? MotivoDevolucao { get; set; }
    public string? UrlImagem { get; set; }
    public string? URLSite { get; set; }
    public double ValorFrete { get; set; } = 0;
    public double TaxaManuseiro { get; set; } = 0;
    public string? QRCode { get; set; }
    public bool IndicaBrinde { get; set; } = false;

    [JsonIgnore]
    public ICollection<PedidoDesconto>? PedidoDescontos { get; set; }
}
