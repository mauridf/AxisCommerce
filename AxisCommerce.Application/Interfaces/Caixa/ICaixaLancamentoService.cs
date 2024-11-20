using AxisCommerce.Domain.Entities.Caixa;

namespace AxisCommerce.Application.Interfaces.Caixa;

public interface ICaixaLancamentoService
{
    Task<IEnumerable<CaixaLancamento>> GetAllCaixaLancamentoAsync();
    Task<CaixaLancamento?> GetCaixaLancamentoByIdAsync(Guid id);
    Task AddCaixaLancamentoAsync(CaixaLancamento caixaLancamento);
    Task UpdateCaixaLancamentoAsync(CaixaLancamento caixaLancamento);
    Task DeleteCaixaLancamentoAsync(Guid id);
}
