using AxisCommerce.Domain.Entities.Vendas;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Clientes
{
    public class ClienteTipo
    {
        public Guid Id { get; set; }
        public string? DescTipoCliente { get; set; }

        [JsonIgnore]
        public ICollection<ClienteSubTipo>? ClienteSubTipos { get; set; }
        [JsonIgnore]
        public ICollection<OperacaoVendaTipoCliente>? OperacaoVendaTipoClientes { get; set; }
    }
}
