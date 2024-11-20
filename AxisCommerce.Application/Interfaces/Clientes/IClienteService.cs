using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Application.Interfaces.Clientes;

public interface IClienteService
{
    Task<IEnumerable<Cliente>> GetAllClientesAsync();
    Task<Cliente?> GetClienteByIdAsync(Guid id);
    Task AddClienteAsync(Cliente cliente);
    Task UpdateClienteAsync(Cliente cliente);
    Task DeleteClienteAsync(Guid id);
}
