using AxisCommerce.Domain.Entities.Pagamento;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Vendas;

public class OperacaoVendaCondicaoPgto
{
    public Guid Id { get; set; }
    public Guid CondicaoPgtoId { get; set; }
    [JsonIgnore]
    public CondicaoPagto? CondicaoPgto { get; set; }
    public Guid OperacaoVendaId { get; set; }
    [JsonIgnore]
    public OperacaoVenda? OperacaoVenda { get; set; }
    public bool Inativo { get; set; } = false;
}
