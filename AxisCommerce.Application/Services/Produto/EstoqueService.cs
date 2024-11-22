using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class EstoqueService : IEstoqueService
{
    private readonly IEstoqueRepository _estoqueRepository;

    public EstoqueService(IEstoqueRepository estoqueRepository)
    {
        _estoqueRepository = estoqueRepository;
    }

    public async Task AddAsync(Estoque estoque)
    {
        await _estoqueRepository.AddAsync(estoque);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _estoqueRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Estoque>> GetAllAsync()
    {
        return await _estoqueRepository.GetAllAsync();
    }

    public async Task<Estoque?> GetByIdAsync(Guid id)
    {
        return await _estoqueRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Estoque estoque)
    {
        await _estoqueRepository.UpdateAsync(estoque);
    }
}
