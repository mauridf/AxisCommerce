using AxisCommerce.Application.Interfaces.Caixa;
using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Interfaces.Caixa;

namespace AxisCommerce.Application.Services.Caixa;

public class CaixaRecebimentoPgtoService : ICaixaRecebimentoPgtoService
{
    private readonly ICaixaRecebimentoPgtoRepository _caixaRecebimentoPgtoRepository;

    public CaixaRecebimentoPgtoService(ICaixaRecebimentoPgtoRepository caixaRecebimentoPgtoRepository)
    {
        _caixaRecebimentoPgtoRepository = caixaRecebimentoPgtoRepository;
    }

    public async Task AddCaixaRecebimentoPgtoAsync(CaixaRecebimentoPgto caixaRecebimentoPgto)
    {
        await _caixaRecebimentoPgtoRepository.AddAsync(caixaRecebimentoPgto);
    }

    public async Task DeleteCaixaRecebimentoPgtoAsync(Guid id)
    {
        await _caixaRecebimentoPgtoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<CaixaRecebimentoPgto>> GetAllCaixaRecebimentoPgtoAsync()
    {
        return await _caixaRecebimentoPgtoRepository.GetAllAsync();
    }

    public async Task<CaixaRecebimentoPgto?> GetCaixaRecebimentoPgtoByIdAsync(Guid id)
    {
        return await _caixaRecebimentoPgtoRepository.GetByIdAsync(id);
    }

    public async Task UpdateCaixaRecebimentoPgtoAsync(CaixaRecebimentoPgto caixaRecebimentoPgto)
    {
        await _caixaRecebimentoPgtoRepository.UpdateAsync(caixaRecebimentoPgto);
    }
}
