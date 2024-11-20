using System;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Caixa;

public class CaixaFechamento
{
    public Guid Id { get; set; }
    public Guid CaixaControleId { get; set; }
    [JsonIgnore]
    public CaixaControle? CaixaControle { get; set; }
    public double ValorFechamentoCaixa { get; set; }
    public string? Justificativa { get; set; }
}
