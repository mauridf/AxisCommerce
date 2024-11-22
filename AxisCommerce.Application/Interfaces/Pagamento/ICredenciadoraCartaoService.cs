using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Application.Interfaces.Pagamento;
public interface ICredenciadoraCartaoService
{
    Task AddAsync(CredenciadoraCartao credenciadoraCartao);
    Task<CredenciadoraCartao?> GetByIdAsync(Guid id);
    Task<IEnumerable<CredenciadoraCartao>> GetAllAsync();
    Task UpdateAsync(CredenciadoraCartao credenciadoraCartao);
    Task DeleteAsync(Guid id);
}
