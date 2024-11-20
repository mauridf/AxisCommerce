using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Domain.Interfaces.Pagamento;

public interface ICredenciadoraCartaoRepository
{
    Task AddAsync(CredenciadoraCartao credenciadoraCartao);
    Task<CredenciadoraCartao?> GetByIdAsync(Guid id);
    Task<IEnumerable<CredenciadoraCartao>> GetAllAsync();
    Task UpdateAsync(CredenciadoraCartao credenciadoraCartao);
    Task DeleteAsync(Guid id);
}
