using AxisCommerce.Domain.Entities.Pagamento;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Caixa;

public class CaixaRecebimentoPgto
{
    public Guid Id { get; set; }
    public Guid CaixaRecebimentoId { get; set; }
    [JsonIgnore] 
    public CaixaRecebimento? CaixaRecebimento { get; set; }
    public DateOnly DataVencimento { get; set; }
    public string ChequeCartao { get; set; }
    public Guid TipoPagamentoId { get; set; }
    [JsonIgnore]
    public TipoPagamento? TipoPagamento { get; set; }
    public Guid AdmCartaoId { get; set; }
    [JsonIgnore]
    public AdminCartao? AdminCartao { get; set; }
    public Guid MoedaIndicadorId { get; set; }
    [JsonIgnore]
    public MoedaIndicador? MoedaIndicador { get; set; }
    public string? Banco { get; set; }
    public string? Agencia { get; set; }
    public string? ContaCorrente { get; set; }
    public string? NumeroTitulo { get; set; }
    public string? ChequeDigito { get; set; }
    public int ParcelasCartao { get; set; } = 0;
    public double Troco { get; set; } = 0;
    public double Cotacao { get; set; } = 0;
    public double ValorMoeda { get; set; } = 0;
}
