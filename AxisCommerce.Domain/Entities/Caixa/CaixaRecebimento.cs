using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Entities.Pagamento;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Caixa;

public class CaixaRecebimento
{
    public Guid Id { get; set; }
    public Guid CaixaLancamentoId { get; set; }
    [JsonIgnore]
    public CaixaLancamento? CaixaLancamento { get; set; }
    public Guid GerenteId { get; set; }
    [JsonIgnore]
    public Vendedor? Gerente { get; set; }
    public double ValorOriginal { get; set; }
    public double ValorEncargo { get; set; } = 0;
    public double ValorDesconto { get; set; } = 0;
    public double ValorTotal { get; set; }
    public Guid MoedaIndicadorId { get; set; }
    [JsonIgnore]
    public MoedaIndicador? MoedaIndicador { get; set; }

    [JsonIgnore]
    public ICollection<CaixaRecebimentoPgto>? CaixasRecebimentoPgto { get; set; }
}
