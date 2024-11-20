using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pagamento;

public class CondicaoPagtoParcela
{
    public Guid Id { get; set; }
    public Guid CondicaoPgtoId { get; set; }
    [JsonIgnore]
    public CondicaoPagto? CondicaoPgto { get; set; }
    public int Parcela { get; set; } = 0;
    public int DiasDaData { get; set; } = 0;
    public int Porcentagem { get; set; } = 0;
    public Guid TipoPagtoId { get; set; }
    [JsonIgnore]
    public TipoPagamento? TipoPagamento { get; set;}
    public Guid AdminCartaoId { get; set; }
    [JsonIgnore]
    public AdminCartao? AdminCartao { get; set; }
}
