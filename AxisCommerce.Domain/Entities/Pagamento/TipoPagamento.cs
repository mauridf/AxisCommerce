using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Entities.Vendas;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pagamento;

public class TipoPagamento
{
    public Guid Id { get; set; }
    public string SiglaTipoPagto { get; set; } = string.Empty;
    public string DescTipoPagto { get; set; } = string.Empty;
    public bool TipoAVista { get; set; } = false;
    public bool PossuiTEF { get; set; } = false;
    public bool PermiteDevolucao { get; set; } = false;
    public double ValorMinimo { get; set; } = 0;
    public double ValorMaximo { get; set; } = 0;
    public int ParcelasMinimo { get; set; } = 0;
    public int ParcelasSugestao { get; set; } = 0;
    public int ParcelasMaximo { get; set; } = 0;
    public int DiasVencimento { get; set; } = 0;
    public int DiasEntreParcelas { get; set; } = 0;
    public int ToleranciaVencimento { get; set;} = 0;
    public int ToleranciaPorcentagem { get; set; } = 0;
    public bool Inativo { get; set; } = false;

    [JsonIgnore]
    public ICollection<CaixaLancamento>? CaixasLancamento { get; set; }
    [JsonIgnore]
    public ICollection<CaixaRecebimentoPgto>? CaixasRecebimentoPgto { get; set; }
    [JsonIgnore]
    public ICollection<CondicaoPagto>? CondicaoPagtos { get; set; }
    [JsonIgnore]
    public ICollection<CondicaoPagtoParcela>? CondicaoPagtoParcelas { get; set; }
    [JsonIgnore]
    public ICollection<Promocao>? Promocoes { get; set; }
    [JsonIgnore]
    public ICollection<PedidoPagto>? PedidoPagos { get; set; }
}
