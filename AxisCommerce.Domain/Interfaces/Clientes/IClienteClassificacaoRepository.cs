using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Domain.Interfaces.Clientes;

public interface IClienteClassificacaoRepository
{
    Task AddAsync(ClienteClassificacao clienteClassificacao);
    Task<ClienteClassificacao?> GetByIdAsync(Guid id);
    Task<IEnumerable<ClienteClassificacao>> GetAllAsync();
    Task UpdateAsync(ClienteClassificacao clienteClassificacao);
    Task DeleteAsync(Guid id);
}
