using AxisCommerce.Domain.Entities.Caixa;

namespace AxisCommerce.Application.Interfaces.Caixa;

public interface ITipoLancamentoService
{
    Task<IEnumerable<TipoLancamento>> GetAllTipoLancamentoAsync();
    Task<TipoLancamento?> GetTipoLancamentoByIdAsync(Guid id);
    Task AddTipoLancamentoAsync(TipoLancamento tipoLancamento);
    Task UpdateTipoLancamentoAsync(TipoLancamento tipoLancamento);
    Task DeleteTipoLancamentoAsync(Guid id);
}
