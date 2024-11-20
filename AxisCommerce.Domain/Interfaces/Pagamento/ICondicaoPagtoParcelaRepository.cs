using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Domain.Interfaces.Pagamento;

public interface ICondicaoPagtoParcelaRepository
{
    Task AddAsync(CondicaoPagtoParcela condicaoPagtoParcela);
    Task<CondicaoPagtoParcela?> GetByIdAsync(Guid id);
    Task<IEnumerable<CondicaoPagtoParcela>> GetAllAsync();
    Task UpdateAsync(CondicaoPagtoParcela condicaoPagtoParcela);
    Task DeleteAsync(Guid id);
}
