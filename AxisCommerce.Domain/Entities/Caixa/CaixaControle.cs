using AxisCommerce.Domain.Entities.Loja;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Caixa;

public class CaixaControle
{
    public Guid Id { get; set; }
    public Guid GerenteId { get; set; }
    [JsonIgnore]
    public Vendedor? Gerente { get; set; }
    public Guid OperadorCaixaId { get; set; }
    [JsonIgnore]
    public Vendedor? OperadorCaixa { get; set; }
    public Guid TerminalId { get; set; }
    [JsonIgnore]
    public Terminal? Terminal { get; set; }
    public DateTime DataHoraAbertura { get; set; }
    public DateTime? DataHoraFechamento { get; set; }

    [JsonIgnore]
    public ICollection<CaixaFechamento>? CaixasFechamento { get; set; }
    [JsonIgnore]
    public ICollection<CaixaLancamento>? CaixasLancamento { get; set; }
}
