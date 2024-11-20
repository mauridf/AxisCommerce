using AxisCommerce.Domain.Entities.Clientes;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Vendas;

public class OperacaoVendaTipoCliente
{
    public Guid Id { get; set; }
    public Guid OperacaoVendaId { get; set; }
    [JsonIgnore]
    public OperacaoVenda? OperacaoVenda { get; set; }
    public Guid ClienteTipoId { get; set; }
    [JsonIgnore]
    public ClienteTipo? ClienteTipo { get; set; }
}
