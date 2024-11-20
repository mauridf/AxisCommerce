using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Interfaces.Loja;

namespace AxisCommerce.Application.Services.Lojas;

public class LojaService : ILojaService
{
    private readonly ILojaRepository _lojaRepository;

    public LojaService(ILojaRepository lojaRepository)
    {
        _lojaRepository = lojaRepository;
    }

    public async Task AddAsync(Domain.Entities.Loja.Lojas loja)
    {
        await _lojaRepository.AddAsync(loja);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _lojaRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Domain.Entities.Loja.Lojas>> GetAllAsync()
    {
        return await _lojaRepository.GetAllAsync();
    }

    public async Task<Domain.Entities.Loja.Lojas?> GetByCodLoja(string codLoja)
    {
        return await _lojaRepository.GetByCodLoja(codLoja);
    }

    public async Task<Domain.Entities.Loja.Lojas?> GetByIdAsync(Guid id)
    {
        return await _lojaRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Domain.Entities.Loja.Lojas loja)
    {
        await _lojaRepository.UpdateAsync(loja);
    }
}
