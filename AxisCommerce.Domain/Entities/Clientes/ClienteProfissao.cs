using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Clientes;

public class ClienteProfissao
{
    public Guid Id { get; set; }
    public string? DescClienteProfissao { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<Cliente>? Clientes { get; set; }
}
