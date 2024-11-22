using AxisCommerce.Application.Interfaces.Pagamento;
using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;

namespace AxisCommerce.Application.Services.Pagamento;

public class CondicaoPagtoParcelaService : ICondicaoPagtoParcelaService
{
    private readonly ICondicaoPagtoParcelaRepository _condicaoPagtoParcelaRepository;

    public CondicaoPagtoParcelaService(ICondicaoPagtoParcelaRepository condicaoPagtoParcelaRepository)
    {
        _condicaoPagtoParcelaRepository = condicaoPagtoParcelaRepository;
    }

    public async Task AddAsync(CondicaoPagtoParcela condicaoPagtoParcela)
    {
        await _condicaoPagtoParcelaRepository.AddAsync(condicaoPagtoParcela);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _condicaoPagtoParcelaRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<CondicaoPagtoParcela>> GetAllAsync()
    {
        return await _condicaoPagtoParcelaRepository.GetAllAsync();
    }

    public async Task<CondicaoPagtoParcela?> GetByIdAsync(Guid id)
    {
        return await _condicaoPagtoParcelaRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(CondicaoPagtoParcela condicaoPagtoParcela)
    {
        await _condicaoPagtoParcelaRepository.UpdateAsync(condicaoPagtoParcela);
    }
}
