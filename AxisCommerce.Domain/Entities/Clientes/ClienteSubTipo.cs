using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Clientes;

public class ClienteSubTipo
{
    public Guid Id { get; set; }
    public Guid ClienteTipoId { get; set; }
    [JsonIgnore]
    public ClienteTipo? ClienteTipo { get; set;}
    public string? DescClienteSubTipo { get; set; }

    [JsonIgnore]
    public ICollection<Cliente>? Clientes { get; set; }
}
