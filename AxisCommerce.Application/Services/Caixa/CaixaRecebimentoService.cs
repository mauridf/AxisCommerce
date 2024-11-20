using AxisCommerce.Application.Interfaces.Caixa;
using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Interfaces.Caixa;

namespace AxisCommerce.Application.Services.Caixa;

public class CaixaRecebimentoService : ICaixaRecebimentoService
{
    private readonly ICaixaRecebimentoRepository _caixaRecebimentoRepository;

    public CaixaRecebimentoService(ICaixaRecebimentoRepository caixaRecebimentoRepository)
    {
        _caixaRecebimentoRepository = caixaRecebimentoRepository;
    }

    public async Task AddCaixaRecebimentoAsync(CaixaRecebimento caixaRecebimento)
    {
        await _caixaRecebimentoRepository.AddAsync(caixaRecebimento);
    }

    public async Task DeleteCaixaRecebimentoAsync(Guid id)
    {
        await _caixaRecebimentoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<CaixaRecebimento>> GetAllCaixaRecebimentoAsync()
    {
        return await _caixaRecebimentoRepository.GetAllAsync();
    }

    public async Task<CaixaRecebimento?> GetCaixaRecebimentoByIdAsync(Guid id)
    {
        return await _caixaRecebimentoRepository.GetByIdAsync(id);
    }

    public async Task UpdateCaixaRecebimentoAsync(CaixaRecebimento caixaRecebimento)
    {
        await _caixaRecebimentoRepository.UpdateAsync(caixaRecebimento);
    }
}
