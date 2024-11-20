using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Application.Interfaces.Clientes;

public interface IClienteEscolaridadeService
{
    Task<IEnumerable<ClienteEscolaridade>> GetAllClienteEscolaridadeAsync();
    Task<ClienteEscolaridade?> GetClienteEscolaridadeByIdAsync(Guid id);
    Task AddClienteEscolaridadeAsync(ClienteEscolaridade clienteEscolaridade);
    Task UpdateClienteEscolaridadeAsync(ClienteEscolaridade clienteEscolaridade);
    Task DeleteClienteEscolaridadeAsync(Guid id);
}
