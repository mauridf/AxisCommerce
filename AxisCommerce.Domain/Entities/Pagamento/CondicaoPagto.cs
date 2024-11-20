using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Entities.Vendas;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pagamento;

public class CondicaoPagto
{
    public Guid Id { get; set; }
    public Guid TipoPagtoId { get; set; }
    [JsonIgnore]
    public TipoPagamento? TipoPagamento { get; set;}
    public Guid AdminCartaoId { get; set; }
    [JsonIgnore]
    public AdminCartao? AdminCartao { get; set; }
    public string CodCondicaoPgto { get; set; } = string.Empty;
    public string DescCondicaoPgto { get; set; } = string.Empty;
    public DateOnly DataAtivar { get; set; }
    public DateOnly? DataDesativar { get; set; }
    public double ValorMinimo { get; set; } = 0;
    public double ValorMaximo { get; set ; } = 0;
    public int PorcentagemDescontoTotal { get; set; } = 0;
    public DateOnly DataCriacao { get; set; }
    public int ParcelasMinimas { get; set; } = 0;
    public int ParcelasMaximas { get; set; } = 0;
    public int ParcelasSugestao { get; set; } = 0;
    public int DiasVencimento { get; set; } = 0;
    public int DiasEntreParcelas { get; set; } = 0;
    public int ToleranciaVencimento { get; set; } = 0;
    public int ToleranciaPorcentagem { get; set; } = 0;
    public int DiaVencimentoFixo { get; set; } = 0;

    [JsonIgnore]
    public ICollection<CondicaoPagtoParcela>? CondicaoPagtoParcelas { get; set; }
    [JsonIgnore]
    public ICollection<PedidoPagto>? PedidoPagos { get; set; }
    [JsonIgnore]
    public ICollection<OperacaoVendaCondicaoPgto>? OperacaoVendaCondicaoPgtos { get; set; }
}
