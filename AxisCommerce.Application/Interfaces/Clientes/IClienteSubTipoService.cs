using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Application.Interfaces.Clientes;

public interface IClienteSubTipoService
{
    Task<IEnumerable<ClienteSubTipo>> GetAllClienteSubTipoAsync();
    Task<ClienteSubTipo?> GetClienteSubTipoByIdAsync(Guid id);
    Task AddClienteSubTipoAsync(ClienteSubTipo clienteSubTipo);
    Task UpdateClienteSubTipoAsync(ClienteSubTipo clienteSubTipo);
    Task DeleteClienteSubTipoAsync(Guid id);
}
