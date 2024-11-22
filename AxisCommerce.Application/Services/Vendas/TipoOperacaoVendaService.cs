using AxisCommerce.Application.Interfaces.Vendas;
using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;

namespace AxisCommerce.Application.Services.Vendas;

public class TipoOperacaoVendaService : ITipoOperacaoVendaService
{
    private readonly ITipoOperacaoVendaRepository _tipoOperacaoVendaRepository;

    public TipoOperacaoVendaService(ITipoOperacaoVendaRepository tipoOperacaoVendaRepository)
    {
        _tipoOperacaoVendaRepository = tipoOperacaoVendaRepository;
    }

    public async Task AddAsync(TipoOperacaoVenda tipoOperacaoVenda)
    {
        await _tipoOperacaoVendaRepository.AddAsync(tipoOperacaoVenda);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _tipoOperacaoVendaRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<TipoOperacaoVenda>> GetAllAsync()
    {
        return await _tipoOperacaoVendaRepository.GetAllAsync();
    }

    public async Task<TipoOperacaoVenda?> GetByIdAsync(Guid id)
    {
        return await _tipoOperacaoVendaRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(TipoOperacaoVenda tipoOperacaoVenda)
    {
        await _tipoOperacaoVendaRepository.UpdateAsync(tipoOperacaoVenda);
    }
}
