using AxisCommerce.Domain.Entities.Caixa;

namespace AxisCommerce.Domain.Interfaces.Caixa;

public interface ITipoLancamentoRepository
{
    Task AddAsync(TipoLancamento tipoLancamento);
    Task<TipoLancamento?> GetByIdAsync(Guid id);
    Task<IEnumerable<TipoLancamento>> GetAllAsync();
    Task UpdateAsync(TipoLancamento tipoLancamento);
    Task DeleteAsync(Guid id);
}
