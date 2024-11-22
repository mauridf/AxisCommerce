using AxisCommerce.Application.Interfaces.Vendas;
using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;

namespace AxisCommerce.Application.Services.Vendas;

public class PromocaoService : IPromocaoService
{
    private readonly IPromocaoRepository _promocaoRepository;

    public PromocaoService(IPromocaoRepository promocaoRepository)
    {
        _promocaoRepository = promocaoRepository;
    }

    public async Task AddAsync(Promocao promocao)
    {
        await _promocaoRepository.AddAsync(promocao);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _promocaoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Promocao>> GetAllAsync()
    {
        return await _promocaoRepository.GetAllAsync();
    }

    public async Task<Promocao?> GetByIdAsync(Guid id)
    {
        return await _promocaoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Promocao promocao)
    {
        await _promocaoRepository.UpdateAsync(promocao);
    }
}
