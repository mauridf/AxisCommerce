using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Domain.Interfaces.Clientes;

public interface IClienteRepository
{
    Task AddAsync(Cliente cliente);
    Task<Cliente?> GetByIdAsync(Guid id);
    Task<IEnumerable<Cliente>> GetAllAsync();
    Task UpdateAsync(Cliente cliente);
    Task DeleteAsync(Guid id);
}
