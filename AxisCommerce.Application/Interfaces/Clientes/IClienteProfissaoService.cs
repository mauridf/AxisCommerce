using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Application.Interfaces.Clientes;

public interface IClienteProfissaoService
{
    Task<IEnumerable<ClienteProfissao>> GetAllClienteProfissaoAsync();
    Task<ClienteProfissao?> GetClienteProfissaoByIdAsync(Guid id);
    Task AddClienteProfissaoAsync(ClienteProfissao clienteProfissao);
    Task UpdateClienteProfissaoAsync(ClienteProfissao clienteProfissao);
    Task DeleteClienteProfissaoAsync(Guid id);
}
