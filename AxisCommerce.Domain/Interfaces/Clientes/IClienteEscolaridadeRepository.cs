using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Domain.Interfaces.Clientes;

public interface IClienteEscolaridadeRepository
{
    Task AddAsync(ClienteEscolaridade clienteEscolaridade);
    Task<ClienteEscolaridade?> GetByIdAsync(Guid id);
    Task<IEnumerable<ClienteEscolaridade>> GetAllAsync();
    Task UpdateAsync(ClienteEscolaridade clienteEscolaridade);
    Task DeleteAsync(Guid id);
}
