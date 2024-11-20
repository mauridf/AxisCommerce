using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Domain.Interfaces.Clientes;
public interface IClienteTipoRepository
{
    Task AddAsync(ClienteTipo clienteTipo);
    Task<ClienteTipo?> GetByIdAsync(Guid id);
    Task<IEnumerable<ClienteTipo>> GetAllAsync();
    Task UpdateAsync(ClienteTipo clienteTipo);
    Task DeleteAsync(Guid id);
}
