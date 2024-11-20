using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Loja;

public class LojaControle
{
    public Guid Id { get; set; }
    public Guid LojaId { get; set; }
    [JsonIgnore]
    public Lojas? Loja { get; set; }
    public Guid GerenteLojaId { get; set; }
    [JsonIgnore]
    public Vendedor? Vendedor { get; set; }
    public DateOnly LojaDataControle { get; set; }
}
