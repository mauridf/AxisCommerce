using AxisCommerce.Domain.Entities.Caixa;

namespace AxisCommerce.Domain.Interfaces.Caixa;

public interface ICaixaLancamentoRepository
{
    Task AddAsync(CaixaLancamento caixaLancamento);
    Task<CaixaLancamento?> GetByIdAsync(Guid id);
    Task<IEnumerable<CaixaLancamento>> GetAllAsync();
    Task UpdateAsync(CaixaLancamento caixaLancamento);
    Task DeleteAsync(Guid id);
}
