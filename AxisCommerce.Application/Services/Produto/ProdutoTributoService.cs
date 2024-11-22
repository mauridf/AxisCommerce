using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class ProdutoTributoService : IProdutoTributoService
{
    private readonly IProdutoTributoRepository _produtoTributoRepository;   

    public ProdutoTributoService(IProdutoTributoRepository produtoTributoRepository)
    {
        _produtoTributoRepository = produtoTributoRepository;
    }

    public async Task AddAsync(ProdutoTributo produtoTributo)
    {
        await _produtoTributoRepository.AddAsync(produtoTributo);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _produtoTributoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ProdutoTributo>> GetAllAsync()
    {
        return await _produtoTributoRepository.GetAllAsync();
    }

    public async Task<ProdutoTributo?> GetByIdAsync(Guid id)
    {
        return await _produtoTributoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(ProdutoTributo produtoTributo)
    {
        await _produtoTributoRepository.UpdateAsync(produtoTributo);
    }
}
