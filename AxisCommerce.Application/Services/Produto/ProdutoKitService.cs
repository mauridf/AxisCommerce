using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class ProdutoKitService : IProdutoKitService
{
    private readonly IProdutoKitRepository _produtoKitRepository;

    public ProdutoKitService(IProdutoKitRepository produtoKitRepository)
    {
        _produtoKitRepository = produtoKitRepository;
    }

    public async Task AddAsync(ProdutoKit produtoKit)
    {
        await _produtoKitRepository.AddAsync(produtoKit);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _produtoKitRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ProdutoKit>> GetAllAsync()
    {
        return await _produtoKitRepository.GetAllAsync();
    }

    public async Task<ProdutoKit?> GetByIdAsync(Guid id)
    {
        return await _produtoKitRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(ProdutoKit produtoKit)
    {
        await _produtoKitRepository.UpdateAsync(produtoKit);
    }
}
