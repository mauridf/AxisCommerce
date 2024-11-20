using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Clientes;

public class ClienteFaixaRenda
{
    public Guid Id { get; set; }
    public string? DescClienteFaixaRenda { get; set; }
    public string ValorDe { get; set; } = string.Empty;
    public string ValorAte { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<Cliente>? Clientes { get; set; }
}
