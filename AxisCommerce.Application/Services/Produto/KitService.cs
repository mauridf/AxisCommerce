using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class KitService : IKitService
{
    private IKitRepository _kitRepository;

    public KitService(IKitRepository kitRepository)
    {
        _kitRepository = kitRepository;
    }

    public async Task AddAsync(Kit kit)
    {
        await _kitRepository.AddAsync(kit);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _kitRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Kit>> GetAllAsync()
    {
        return await _kitRepository.GetAllAsync();
    }

    public async Task<Kit?> GetByIdAsync(Guid id)
    {
        return await _kitRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Kit kit)
    {
        await _kitRepository.UpdateAsync(kit);
    }
}
