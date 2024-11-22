using AxisCommerce.Application.Interfaces.Pagamento;
using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;

namespace AxisCommerce.Application.Services.Pagamento;

public class TipoPagamentoService : ITipoPagamentoService
{
    private readonly ITipoPagamentoRepository _tipoPagamentoRepository;

    public TipoPagamentoService(ITipoPagamentoRepository tipoPagamentoRepository)
    {
        _tipoPagamentoRepository = tipoPagamentoRepository;
    }

    public async Task AddAsync(TipoPagamento tipoPagamento)
    {
        await _tipoPagamentoRepository.AddAsync(tipoPagamento);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _tipoPagamentoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<TipoPagamento>> GetAllAsync()
    {
        return await _tipoPagamentoRepository.GetAllAsync();
    }

    public async Task<TipoPagamento?> GetByIdAsync(Guid id)
    {
        return await _tipoPagamentoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(TipoPagamento tipoPagamento)
    {
        await _tipoPagamentoRepository.UpdateAsync(tipoPagamento);
    }
}
