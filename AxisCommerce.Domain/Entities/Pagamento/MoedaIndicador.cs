using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Entities.Pedidos;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pagamento;

public class MoedaIndicador
{
    public Guid Id { get; set; }
    public string SiglaMoedaIndicador { get; set; } = string.Empty;
    public string NomeMoeda { get; set; } = string.Empty;
    public string NomeMoedaFracao { get; set; } = string.Empty;
    public string NomeMoedaPlural { get; set; } = string.Empty;
    public string NomeMoedaFracaoPlural { get; set; } = string.Empty;
    public double ValorConversao { get; set; } = 0;

    [JsonIgnore]
    public ICollection<CaixaRecebimento>? CaixasRecebimento { get; set; }
    [JsonIgnore]
    public ICollection<CaixaRecebimentoPgto>? CaixasRecebimentoPgto { get; set; }
    [JsonIgnore]
    public ICollection<PedidoPagto>? PedidoPagos { get; set; }
}
