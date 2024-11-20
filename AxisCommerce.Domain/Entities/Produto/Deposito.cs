using AxisCommerce.Domain.Entities.Loja;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Produtos;

public class Deposito
{
    public Guid Id { get; set; }
    public Guid LojaId { get; set; }
    [JsonIgnore]
    public Lojas? Loja { get; set; }
    public string CodDeposito { get; set; } = string.Empty;
    public string DesDeposito { get; set; } = string.Empty;
}
