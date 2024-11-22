using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Application.Interfaces.Pagamento;

public interface ITipoPagamentoService
{
    Task AddAsync(TipoPagamento tipoPagamento);
    Task<TipoPagamento?> GetByIdAsync(Guid id);
    Task<IEnumerable<TipoPagamento>> GetAllAsync();
    Task UpdateAsync(TipoPagamento tipoPagamento);
    Task DeleteAsync(Guid id);
}
