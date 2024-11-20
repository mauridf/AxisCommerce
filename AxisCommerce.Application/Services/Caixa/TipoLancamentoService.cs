using AxisCommerce.Application.Interfaces.Caixa;
using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Interfaces.Caixa;

namespace AxisCommerce.Application.Services.Caixa;

public class TipoLancamentoService : ITipoLancamentoService
{
    private readonly ITipoLancamentoRepository _tipoLancamentoRepository;

    public TipoLancamentoService(ITipoLancamentoRepository tipoLancamentoRepository)
    {
        _tipoLancamentoRepository = tipoLancamentoRepository;
    }

    public async Task AddTipoLancamentoAsync(TipoLancamento tipoLancamento)
    {
        await _tipoLancamentoRepository.AddAsync(tipoLancamento);
    }

    public async Task DeleteTipoLancamentoAsync(Guid id)
    {
        await _tipoLancamentoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<TipoLancamento>> GetAllTipoLancamentoAsync()
    {
        return await _tipoLancamentoRepository.GetAllAsync();
    }

    public async Task<TipoLancamento?> GetTipoLancamentoByIdAsync(Guid id)
    {
        return await _tipoLancamentoRepository.GetByIdAsync(id);
    }

    public async Task UpdateTipoLancamentoAsync(TipoLancamento tipoLancamento)
    {
        await _tipoLancamentoRepository.UpdateAsync(tipoLancamento);
    }
}
