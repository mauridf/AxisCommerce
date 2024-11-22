using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Application.Interfaces.Pagamento;

public  interface ICondicaoPagtoService
{
    Task AddAsync(CondicaoPagto condicaoPagto);
    Task<CondicaoPagto?> GetByIdAsync(Guid id);
    Task<IEnumerable<CondicaoPagto>> GetAllAsync();
    Task UpdateAsync(CondicaoPagto condicaoPagto);
    Task DeleteAsync(Guid id);
}
