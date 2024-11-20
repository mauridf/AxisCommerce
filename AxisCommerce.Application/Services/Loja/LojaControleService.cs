using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Interfaces.Loja;

namespace AxisCommerce.Application.Services.Lojas;

public class LojaControleService : ILojaControleService
{
    private readonly ILojaControleRepository _lojaControleRepository;

    public LojaControleService(ILojaControleRepository lojaControleRepository)
    {
        _lojaControleRepository = lojaControleRepository;
    }

    public async Task AddAsync(LojaControle lojaControle)
    {
        await _lojaControleRepository.AddAsync(lojaControle);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _lojaControleRepository.DeleteAsync(id);
    }

    public Task<IEnumerable<LojaControle>> GetAllAsync()
    {
        return _lojaControleRepository.GetAllAsync();
    }

    public Task<LojaControle?> GetByIdAsync(Guid id)
    {
        return _lojaControleRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(LojaControle lojaControle)
    {
        await _lojaControleRepository.UpdateAsync(lojaControle);
    }
}
