using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class UnidadeMedidaService : IUnidadeMedidaService
{
    private readonly IUnidadeMedidaRepository _unidadeMedidaRepository;

    public UnidadeMedidaService(IUnidadeMedidaRepository unidadeMedidaRepository)
    {
        _unidadeMedidaRepository = unidadeMedidaRepository;
    }

    public async Task AddAsync(UnidadeMedida unidadeMedida)
    {
        await _unidadeMedidaRepository.AddAsync(unidadeMedida);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _unidadeMedidaRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<UnidadeMedida>> GetAllAsync()
    {
        return await _unidadeMedidaRepository.GetAllAsync();
    }

    public async Task<UnidadeMedida?> GetByIdAsync(Guid id)
    {
        return await _unidadeMedidaRepository.GetByIdAsync(id);
    }

    public async Task<UnidadeMedida?> GetBySimbolo(string simbolo)
    {
        return await _unidadeMedidaRepository.GetBySimbolo(simbolo);
    }

    public async Task UpdateAsync(UnidadeMedida unidadeMedida)
    {
        await _unidadeMedidaRepository.UpdateAsync(unidadeMedida);
    }
}
