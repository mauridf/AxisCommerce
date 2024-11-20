using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Clientes;

public class ClienteClassificacao
{
    public Guid Id { get; set; }
    public string? DescClienteClassificacao { get; set; }

    [JsonIgnore]
    public ICollection<Cliente>? Clientes { get; set; }
}
