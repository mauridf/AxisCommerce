using AxisCommerce.Application.Interfaces.Caixa;
using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Interfaces.Caixa;
using Microsoft.VisualBasic;

namespace AxisCommerce.Application.Services.Caixa;

public class CaixaFechamentoService : ICaixaFechamentoService
{
    private readonly ICaixaFechamentoRepository _caixaFechamentoRepository;

    public CaixaFechamentoService(ICaixaFechamentoRepository caixaFechamentoRepository)
    {
        _caixaFechamentoRepository = caixaFechamentoRepository;
    }

    public async Task AddCaixaFechamentoAsync(CaixaFechamento caixaFechamento)
    {
        await _caixaFechamentoRepository.AddAsync(caixaFechamento);
    }

    public async Task DeleteCaixaFechamentoAsync(Guid id)
    {
        await _caixaFechamentoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<CaixaFechamento>> GetAllCaixaFechamentoAsync()
    {
        return await _caixaFechamentoRepository.GetAllAsync();
    }

    public async Task<CaixaFechamento?> GetCaixaFechamentoByIdAsync(Guid id)
    {
        return await _caixaFechamentoRepository.GetByIdAsync(id);
    }

    public async Task UpdateCaixaFechamentoAsync(CaixaFechamento caixaFechamento)
    {
        await _caixaFechamentoRepository.UpdateAsync(caixaFechamento);
    }
}
