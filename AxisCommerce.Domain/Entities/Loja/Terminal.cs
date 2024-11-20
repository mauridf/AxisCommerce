using AxisCommerce.Domain.Entities.Caixa;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Loja;

public class Terminal
{
    public Guid Id { get; set; }
    public Guid LojaId { get; set; }
    [JsonIgnore]
    public Lojas? Loja { get; set; }
    public string CodTerminal { get; set; } = string.Empty;
    public string DescTerminal { get; set; } = string.Empty;
    public DateTime DataHoraLogin { get; set; }
    public DateTime? DataHoraLogout { get; set; }

    [JsonIgnore]
    public ICollection<CaixaControle>? CaixasControle { get; set; }
}
