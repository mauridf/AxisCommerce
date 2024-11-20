using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Application.Interfaces.Clientes;

public interface IClienteTipoService
{
    Task<IEnumerable<ClienteTipo>> GetAllClienteTipoAsync();
    Task<ClienteTipo?> GetClienteTipoByIdAsync(Guid id);
    Task AddClienteTipoAsync(ClienteTipo clienteTipo);
    Task UpdateClienteTipoAsync(ClienteTipo clienteTipo);
    Task DeleteClienteTipoAsync(Guid id);
}
