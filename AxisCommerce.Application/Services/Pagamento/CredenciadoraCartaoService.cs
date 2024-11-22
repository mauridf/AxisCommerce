using AxisCommerce.Application.Interfaces.Pagamento;
using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;

namespace AxisCommerce.Application.Services.Pagamento;

public class CredenciadoraCartaoService : ICredenciadoraCartaoService
{
    private readonly ICredenciadoraCartaoRepository _credenciadoraCartaoRepository;

    public CredenciadoraCartaoService(ICredenciadoraCartaoRepository credenciadoraCartaoRepository)
    {
        _credenciadoraCartaoRepository = credenciadoraCartaoRepository;
    }

    public async Task AddAsync(CredenciadoraCartao credenciadoraCartao)
    {
        await _credenciadoraCartaoRepository.AddAsync(credenciadoraCartao);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _credenciadoraCartaoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<CredenciadoraCartao>> GetAllAsync()
    {
        return await _credenciadoraCartaoRepository.GetAllAsync();
    }

    public async Task<CredenciadoraCartao?> GetByIdAsync(Guid id)
    {
        return await _credenciadoraCartaoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(CredenciadoraCartao credenciadoraCartao)
    {
        await _credenciadoraCartaoRepository.UpdateAsync(credenciadoraCartao);
    }
}
