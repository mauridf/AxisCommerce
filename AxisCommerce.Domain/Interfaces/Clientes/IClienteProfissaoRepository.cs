using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Domain.Interfaces.Clientes;

public interface IClienteProfissaoRepository
{
    Task AddAsync(ClienteProfissao clienteProfissao);
    Task<ClienteProfissao?> GetByIdAsync(Guid id);
    Task<IEnumerable<ClienteProfissao>> GetAllAsync();
    Task UpdateAsync(ClienteProfissao clienteProfissao);
    Task DeleteAsync(Guid id);
}
