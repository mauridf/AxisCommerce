using AxisCommerce.Domain.Entities.Caixa;

namespace AxisCommerce.Domain.Interfaces.Caixa;

public interface ICaixaFechamentoRepository
{
    Task AddAsync(CaixaFechamento caixaFechamento);
    Task<CaixaFechamento?> GetByIdAsync(Guid id);
    Task<IEnumerable<CaixaFechamento>> GetAllAsync();
    Task UpdateAsync(CaixaFechamento caixaFechamento);
    Task DeleteAsync(Guid id);
}
