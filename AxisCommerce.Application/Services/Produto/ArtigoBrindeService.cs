using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class ArtigoBrindeService : IArtigoBrindeService
{
    private readonly IArtigoBrindeRepository _artigoBrindeRepository;

    public ArtigoBrindeService(IArtigoBrindeRepository artigoBrindeRepository)
    {
        _artigoBrindeRepository = artigoBrindeRepository;
    }

    public async Task AddAsync(ArtigoBrinde artigoBrinde)
    {
        await _artigoBrindeRepository.AddAsync(artigoBrinde);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _artigoBrindeRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ArtigoBrinde>> GetAllAsync()
    {
        return await _artigoBrindeRepository.GetAllAsync();
    }

    public async Task<ArtigoBrinde?> GetByIdAsync(Guid id)
    {
        return await _artigoBrindeRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(ArtigoBrinde artigoBrinde)
    {
        await _artigoBrindeRepository.UpdateAsync(artigoBrinde);
    }
}
