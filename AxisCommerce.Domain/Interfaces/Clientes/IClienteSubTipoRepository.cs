using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Domain.Interfaces.Clientes;

public interface IClienteSubTipoRepository
{
    Task AddAsync(ClienteSubTipo clienteSubTipo);
    Task<ClienteSubTipo?> GetByIdAsync(Guid id);
    Task<IEnumerable<ClienteSubTipo>> GetAllAsync();
    Task UpdateAsync(ClienteSubTipo clienteSubTipo);
    Task DeleteAsync(Guid id);
}
