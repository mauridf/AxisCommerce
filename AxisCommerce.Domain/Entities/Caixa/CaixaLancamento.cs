using AxisCommerce.Domain.Entities.Pagamento;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Caixa;

public class CaixaLancamento
{
    public Guid Id { get; set; }
    public Guid CaixaControleId { get; set; }
    [JsonIgnore]
    public CaixaControle? CaixaControle { get; set;}
    public Guid TipoLancamentoId { get; set; }
    [JsonIgnore]
    public TipoLancamento? TipoLancamento { get; set; }
    public Guid TipoPagamentoId { get; set; }
    [JsonIgnore]
    public TipoPagamento? TipoPagamento { get; set; }
    public DateTime DataHoraLancamento { get; set; }
    public double? Valor { get; set; }
    public bool Cancelado { get; set; } = false;
    public DateTime? DataHoraCancelado { get; set; }

    [JsonIgnore]
    public ICollection<CaixaRecebimento>? CaixasRecebimento { get; set; }
}
