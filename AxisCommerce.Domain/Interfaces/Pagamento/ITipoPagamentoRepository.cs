using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Domain.Interfaces.Pagamento;

public interface ITipoPagamentoRepository
{
    Task AddAsync(TipoPagamento tipoPagamento);
    Task<TipoPagamento?> GetByIdAsync(Guid id);
    Task<IEnumerable<TipoPagamento>> GetAllAsync();
    Task UpdateAsync(TipoPagamento tipoPagamento);
    Task DeleteAsync(Guid id);
}
