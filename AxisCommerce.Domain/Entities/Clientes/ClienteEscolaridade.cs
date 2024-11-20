using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Clientes;

public class ClienteEscolaridade
{
    public Guid Id { get; set; }
    public string? DescEscolaridade { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<Cliente>? Clientes { get; set; }
}
