using AxisCommerce.Application.Interfaces.Caixa;
using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Interfaces.Caixa;

namespace AxisCommerce.Application.Services.Caixa;

public class CaixaLancamentoService : ICaixaLancamentoService
{
    private readonly ICaixaLancamentoRepository _caixaLancamentoRepository;

    public CaixaLancamentoService(ICaixaLancamentoRepository caixaLancamentoRepository)
    {
        _caixaLancamentoRepository = caixaLancamentoRepository;
    }

    public async Task AddCaixaLancamentoAsync(CaixaLancamento caixaLancamento)
    {
        await _caixaLancamentoRepository.AddAsync(caixaLancamento);
    }

    public async Task DeleteCaixaLancamentoAsync(Guid id)
    {
        await _caixaLancamentoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<CaixaLancamento>> GetAllCaixaLancamentoAsync()
    {
        return await _caixaLancamentoRepository.GetAllAsync();
    }

    public async Task<CaixaLancamento?> GetCaixaLancamentoByIdAsync(Guid id)
    {
        return await _caixaLancamentoRepository.GetByIdAsync(id);
    }

    public async Task UpdateCaixaLancamentoAsync(CaixaLancamento caixaLancamento)
    {
        await _caixaLancamentoRepository.UpdateAsync(caixaLancamento);
    }
}
