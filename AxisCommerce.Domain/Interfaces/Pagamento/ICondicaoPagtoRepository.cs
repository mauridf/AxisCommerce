using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Domain.Interfaces.Pagamento;

public interface ICondicaoPagtoRepository
{
    Task AddAsync(CondicaoPagto condicaoPagto);
    Task<CondicaoPagto?> GetByIdAsync(Guid id);
    Task<IEnumerable<CondicaoPagto>> GetAllAsync();
    Task UpdateAsync(CondicaoPagto condicaoPagto);
    Task DeleteAsync(Guid id);
}
