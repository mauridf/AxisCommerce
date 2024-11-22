using AxisCommerce.Application.Interfaces.Pagamento;
using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;

namespace AxisCommerce.Application.Services.Pagamento;

public class CondicaoPagtoService : ICondicaoPagtoService
{
    private readonly ICondicaoPagtoRepository _condicaoPagtoRepository;

    public CondicaoPagtoService(ICondicaoPagtoRepository condicaoPagtoRepository)
    {
        _condicaoPagtoRepository = condicaoPagtoRepository;
    }

    public async Task AddAsync(CondicaoPagto condicaoPagto)
    {
        await _condicaoPagtoRepository.AddAsync(condicaoPagto);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _condicaoPagtoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<CondicaoPagto>> GetAllAsync()
    {
        return await _condicaoPagtoRepository.GetAllAsync();
    }

    public async Task<CondicaoPagto?> GetByIdAsync(Guid id)
    {
        return await _condicaoPagtoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(CondicaoPagto condicaoPagto)
    {
        await _condicaoPagtoRepository.UpdateAsync(condicaoPagto);
    }
}
